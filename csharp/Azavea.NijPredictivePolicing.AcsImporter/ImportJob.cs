﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Azavea.NijPredictivePolicing.AcsImporterLibrary;
using Azavea.NijPredictivePolicing.Common;
using log4net;
using Azavea.NijPredictivePolicing.AcsImporterLibrary.Transfer;
using Azavea.NijPredictivePolicing.Common.DB;
using Azavea.NijPredictivePolicing.AcsImporterLibrary.FileFormats;
using Azavea.NijPredictivePolicing.Common.Data;
using System.IO;

namespace Azavea.NijPredictivePolicing.AcsDataImporter
{
    public class ImportJob
    {
        private static ILog _log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #region Command Line Stuff

        public static CmdLineArg[] Arguments = new CmdLineArg[] {
            new CmdLineArg() { Flag = "s", Description = "State Code", DataType=typeof(AcsState), PropertyName="State"},
            new CmdLineArg() { Flag = "e", Description = "Filter Spatially by Census Summary Level", DataType=typeof(string), PropertyName="SummaryLevel"},            
            new CmdLineArg() { Flag = "v", Description = "Filter data by variable name file", DataType=typeof(string), PropertyName="IncludedVariableFile"},                        
            new CmdLineArg() { Flag = "f", Description = "Filter Spatially by optional shapefile", DataType=typeof(string), PropertyName="ExportFilterShapefile"},
            
            //new CmdLineArg() { Flag = "ExportFilterSRID", Description = "SRID to use for shapefile filter if none is provided in the shapefile", DataType=typeof(string), PropertyName="ExportFilterSRID"},

            new CmdLineArg() { Flag = "j", Display=false, DataType=typeof(string), PropertyName="JobName"},
            new CmdLineArg() { Flag = "jobName", Description = "Specify a name for this job / shapefile", DataType=typeof(string), PropertyName="JobName"},
            new CmdLineArg() { Flag = "r", Display=false,  DataType=typeof(string), PropertyName="ReplaceTable"},
            new CmdLineArg() { Flag = "replaceJob", Description = "Replace an existing job / shapefile", DataType=typeof(string), PropertyName="ReplaceTable"},
            
            new CmdLineArg() { Flag = "outputProjection", Description = "Provide the .prj file of a desired projection to operate in", DataType=typeof(string), PropertyName="OutputProjection"},

            new CmdLineArg() { Flag = "exportToShape", Description = "Export results to shapefile", DataType=typeof(string), PropertyName="ExportToShapefile"},
            new CmdLineArg() { Flag = "exportToGrid", Description = "Export results to fishnetted shapefile where value = # feet", DataType=typeof(string), PropertyName="ExportToGrid"},

            new CmdLineArg() { Flag = "gridEnvelope", Description = "Align the grid cells to an envelope in a file", DataType=typeof(string), PropertyName="GridEnvelope"},            
            new CmdLineArg() { Flag = "includeEmptyGridCells", Display=false,   DataType=typeof(string), PropertyName="IncludeEmptyGridCells"},
            new CmdLineArg() { Flag = "includeEmptyGeometries", Description = "Keeps empty grid cells during export", DataType=typeof(string), PropertyName="IncludeEmptyGridCells"},

            new CmdLineArg() { Flag = "outputFolder", Description = "Specify where you'd like the results saved", DataType=typeof(string), PropertyName = "OutputFolder"},
            new CmdLineArg() { Flag = "preserveJam", Description = "Optional flag to preserve non-numeric margin of error values", DataType=typeof(string), PropertyName="PreserveJam"},
            
            new CmdLineArg() { Flag = "listStateCodes", Description = "Displays a list of available state codes", DataType=typeof(string), PropertyName="DisplayStateCodes"},
            new CmdLineArg() { Flag = "listSummaryLevels", Description = "Displays a list of available census summary levels", DataType=typeof(string), PropertyName="DisplaySummaryLevels"},
            new CmdLineArg() { Flag = "stripGEOIDColumn", Description = "Adds an extra column to the shapefile output named GEOID_STRP that contains the same data as the GEOID column but without the \"15000US\" prefix", DataType=typeof(string), PropertyName = "AddStrippedGEOIDcolumn" }
            //This command is now kind of useless now that we discovered how mangled these variable names actually are
            //new CmdLineArg() { Flag = "exportVariables", Description = "Exports a CSV of all variables to allVariables.csv", DataType=typeof(string), PropertyName="ExportVariables"}
        };

        public string ArgumentLine;

        public AcsState State { get; set; }

        public string ExportFilterShapefile { get; set; }
        //public string ExportFilterSRID { get; set; }
        public string ExportVariables { get; set; }
        public string IncludedVariableFile { get; set; }
        public string JobName { get; set; }
        public string SummaryLevel { get; set; }
        public string ReplaceTable { get; set; }
        public string ExportToShapefile { get; set; }
        public string ExportToGrid { get; set; }
        
        public string DisplaySummaryLevels { get; set; }
        public string DisplayStateCodes { get; set; }
        public string GridEnvelope { get; set; }
        public string OutputProjection { get; set; }
        public string IncludeEmptyGridCells { get; set; }
        public string OutputFolder { get; set; }
        public string PreserveJam { get; set; }
        public string AddStrippedGEOIDcolumn { get; set; }
        
        

        


        public ImportJob()
        {
            this.State = AcsState.None;
        }

        public int IndexOf(string str, int idx, params char[] delims)
        {
            foreach (char d in delims)
            {
                int next = str.IndexOf(d, idx);
                if (next >= 0)
                    return next;
            }
            return -1;
        }


        public bool Load(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < args.Length; i++)
            {
                sb.Append(args[i]).Append(' ');
            }            
            string line = sb.ToString();
            this.ArgumentLine = line;
            //char delim = '-';
            char[] delims = new char[] { (char)45, (char)8211 }; //'-', '–';
            int idx = IndexOf(line, 0, delims);     //int idx = line.IndexOf(delim);

            if (idx == -1)
            {
                //if we have arguments, but they didn't include flags, it's probably a file,
                //look for the file.
                if (File.Exists(args[0]))
                {
                    var lines = File.ReadAllLines(args[0]);
                    sb = new StringBuilder();
                    foreach (string chunk in lines)
                    {
                        if (chunk.StartsWith("#") || chunk.StartsWith("/"))
                            continue;
                        sb.Append(chunk).Append(" ");
                    }
                    line = sb.ToString();
                }
                else
                {
                    _log.ErrorFormat("The arguments file you provided could not be read: {0}", args[0]);
                    return false;
                }
            }

            


            var thisType = typeof(ImportJob);
            //int idx = IndexOf(line, 0, delims);     //int idx = line.IndexOf(delim);
            while (idx >= 0)
            {
                int nextSpace = line.IndexOf(' ', idx + 1);

                string flag = line.Substring(idx + 1, nextSpace - (idx + 1));
                string contents = string.Empty;

                idx += 1 + flag.Length;
                int end = IndexOf(line, idx, delims);   //int end = line.IndexOf(delim, idx);
                if (end == -1)
                {
                    end = line.Length;
                }
                if (end > idx)
                {
                    contents = line.Substring(idx, end - idx).Trim();
                    if (string.IsNullOrEmpty(contents))
                    {
                        contents = true.ToString();
                    }

                    idx = end;
                }
                idx = IndexOf(line, idx, delims);       //idx = line.IndexOf(delim, idx);


                for (int p = 0; p < Arguments.Length; p++)
                {
                    var arg = Arguments[p];
                    if (arg.Flag == flag)
                    {
                        var prop = thisType.GetProperty(arg.PropertyName);
                        prop.SetValue(this, Utilities.GetAsType(prop.PropertyType, contents, null), null);
                        break;
                    }
                }
            }
            return true;
        }

        #endregion Command Line Stuff


        public bool ExecuteJob()
        {
            DateTime startTime = DateTime.Now;
            try
            {
                if (!string.IsNullOrEmpty(DisplaySummaryLevels))
                {
                    Utilities.DisplayEnum("Summary Levels:", typeof(BoundaryLevels));
                    return true;
                }
                if (!string.IsNullOrEmpty(DisplayStateCodes))
                {
                    Utilities.DisplayEnumKeysOnly("State Codes:", typeof(AcsState));
                    return true;
                }

                if (this.State == AcsState.None)
                {
                    _log.Error("Invalid State selected, please select a state from the list and try again.");
                    return false;
                }
                else if (this.State == AcsState.UnitedStates)
                {
                    //if it can't be parsed, it'll get assigned to value '0', which in this case is 'UnitedStates'

                    var isOkay = "-s UnitedStates".ToLower();
                    if (!this.ArgumentLine.Contains(isOkay))
                    {
                        _log.Fatal("I couldn't understand which state you wanted, please check the spelling and try again.  Exiting...");
                        return false;
                    }
                }




                if ((string.IsNullOrEmpty(this.JobName)) || (this.JobName == true.ToString()))
                {
                    this.JobName = string.Format("{0}_{1}", this.State, DateTime.Now.ToShortDateString().Replace('/', '_'));
                    _log.DebugFormat("Jobname was empty, using {0}", this.JobName);
                }

                var manager = new AcsDataManager(this.State);
                //TODO: check for bad combinations of inputs
                manager.SummaryLevel = this.SummaryLevel;
                manager.ExportFilterFilename = this.ExportFilterShapefile;
                manager.DesiredVariablesFilename = IncludedVariableFile;
                manager.ReplaceTable = (!string.IsNullOrEmpty(this.ReplaceTable));
                manager.OutputProjectionFilename = this.OutputProjection;
                manager.PreserveJam = (!string.IsNullOrEmpty(this.PreserveJam));
                manager.AddStrippedGEOIDcolumn = (!string.IsNullOrEmpty(this.AddStrippedGEOIDcolumn));
                manager.OutputFolder = this.OutputFolder;
                manager.IncludeEmptyGridCells = (!string.IsNullOrEmpty(this.IncludeEmptyGridCells));
                //manager.SRID = Utilities.GetAs<int>(this.ExportFilterSRID, -1);

                if (FileUtilities.SafePathEnsure(OutputFolder) != OutputFolder)
                {
                    _log.FatalFormat("Unable to set or create output folder, ( {0} ) exiting", OutputFolder);
                    return false;
                }

                if (string.IsNullOrEmpty(this.OutputProjection))
                {
                    _log.Warn(Constants.Warning_MissingProjection);
                }



                _log.Debug("\r\nLoading Prerequisites...");
                if (!manager.CheckColumnMappingsFile()
                    || !manager.CheckBlockGroupFile()
                    || !manager.CheckDatabase()
                    || !manager.CheckShapefiles())
                {
                    _log.Debug("Loading Prerequisites... Failed!");
                    _log.Error("Import cannot continue, one or more prerequisites failed!");
                    return false;
                }
                _log.Debug("Loading Prerequisites... Done!\r\n");



                if (!string.IsNullOrEmpty(IncludedVariableFile) && !string.IsNullOrEmpty(this.JobName))
                {
                    _log.Info("Importing requested variables...");
                    if (!manager.CheckBuildVariableTable(this.JobName))
                    {
                        _log.Error("Importing requested variables... Failed! A problem was detected, exiting.");
                        return false;
                    }
                    _log.Debug("mporting requested variables... Done!");
                }

                if (!string.IsNullOrEmpty(ExportToShapefile))
                {
                    _log.Info("Exporting to shapefile...");
                    if (!manager.ExportShapefile(this.JobName))
                    {
                        _log.Error("There was an error while exporting the shapefile");
                    }

                    _log.Debug("Exporting to shapefile... Done!");
                }

                if (!string.IsNullOrEmpty(ExportToGrid))
                {
                    _log.Info("Exporting to gridded shapefile...");
                    manager.GridEnvelopeFilename = GridEnvelope;
                    manager.SetGridParam(ExportToGrid);

                    _log.DebugFormat("Exporting all requested variables to fishnet shapefile with grid cell size {0} ", ExportToGrid);
                    manager.ExportGriddedShapefile(this.JobName);

                    _log.Debug("Exporting to gridded shapefile... Done!");
                }


                return true;
            }
            catch (Exception ex)
            {
                _log.Error("Error thrown during import job ", ex);
            }
            finally
            {
                TimeSpan elapsed = DateTime.Now - startTime;
                _log.DebugFormat("Job completed in {0} seconds", elapsed.TotalSeconds);
            }

            return false;
        }


    }
}
