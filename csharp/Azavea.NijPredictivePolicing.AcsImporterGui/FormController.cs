﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using System.IO;
using Azavea.NijPredictivePolicing.Common;
using log4net.Appender;
using log4net.Layout;
using Azavea.NijPredictivePolicing.ACSAlchemist;
using Azavea.NijPredictivePolicing.ACSAlchemistLibrary;
using Azavea.NijPredictivePolicing.ACSAlchemistLibrary.FileFormats;

namespace Azavea.NijPredictivePolicing.AcsAlchemistGui
{
    /// <summary>
    /// This class is meant to act as our interface between the GUI and the rest of the importer logic
    /// </summary>
    public class FormController
    {
        static FormController()
        {
            _instance = new FormController();
        }

        private static FormController _instance;
        public static FormController Instance
        {
            get { return _instance; }
        }


        #region FormController Properties

        /// <summary>
        /// Our resident instance of the current 'job', typically holds 
        /// command line params, runs an import, does exports, etc.
        /// </summary>
        public ImportJob JobInstance { get; set; }


        /// <summary>
        /// Returns a modifiable list of years that correspond to ACS data that
        /// can be used as a live binding source for a form
        /// </summary>
        public List<string> AvailableYears
        {
            get
            {
                if (_availableYears != null) { return _availableYears; }

                //a quick initialization
                _availableYears = new List<string>(Settings.LoadYearConfigs().Keys);
                return _availableYears;
            }
            set { _availableYears = value; }
        }
        protected List<string> _availableYears;


        /// <summary>
        /// Returns a modifiable list of states that correspond to ACS data that
        /// can be used as a live binding source for a form
        /// </summary>
        public List<AcsState> AvailableStates
        {
            get
            {
                if (_availableStates != null) { return _availableStates; }

                //a quick initialization
                _availableStates = Utilities.GetEnumAsList<AcsState>(
                    new HashSet<AcsState>(new AcsState[] { AcsState.None })
                    );

                return _availableStates;
            }
            set { _availableStates = value; }
        }
        protected List<AcsState> _availableStates;

        /// <summary>
        /// Returns a modifiable list of summary levels that correspond to ACS data that
        /// can be used as a live binding source for a form
        /// </summary>
        public List<BoundaryLevels> AvailableLevels
        {
            get
            {
                if (_availableLevels != null) { return _availableLevels; }

                //a quick initialization
                _availableLevels = Utilities.GetEnumAsList<BoundaryLevels>(null);

                return _availableLevels;
            }
            set { _availableLevels = value; }
        }
        protected List<BoundaryLevels> _availableLevels;

        /// <summary>
        /// Returns a modifiable list of projections that correspond to SRID.csv
        /// </summary>
        public List<string> AvailableProjections
        {
            get
            {
                if (_availableProjections != null) { return _availableProjections; }

                //a quick initialization
                _availableProjections = Utilities.ListAllCoordinateSystemIDs();

                return _availableProjections;
            }
            set { _availableProjections = value; }
        }
        protected List<string> _availableProjections;




        #endregion FormController Properties









        #region Initialization Boilerplate


        private static ILog _log = null;
        internal void InitLogging(IAppender appenderObj)
        {
            if (_log != null)
            {
                _log.Debug("Logging already initialized");
                return;
            }

            try
            {
                //attempt to load logging configuration
                System.IO.FileInfo configFile = new System.IO.FileInfo(Path.Combine(Settings.ApplicationPath, "Logging.config"));
                log4net.Config.XmlConfigurator.ConfigureAndWatch(configFile);
                _log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            }
            catch
            {
                ConsoleAppender con = new ConsoleAppender();
                con.Layout = new PatternLayout("%message%newline");
                //con.Threshold = log4net.Core.Level.Info;
                log4net.Config.BasicConfigurator.Configure(con);
                _log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            }

            if (appenderObj != null)
            {
                ((log4net.Repository.Hierarchy.Hierarchy)log4net.LogManager.GetLoggerRepository()).Root.AddAppender(appenderObj);
            }
        }


        protected void ShowWelcomeScreen()
        {
            _log.Debug("+--------------------------------------------+");
            _log.Debug("|   Welcome to ACS Alchemist                 |");
            _log.Debug("+--------------------------------------------+");
            _log.Debug("");
            _log.Debug(" This tool was developed by Azavea in collaboration with");
            _log.Debug(" Jerry Ratcliffe and Ralph Taylor of Temple University and partially funded by ");
            _log.Debug(" a Predictive Policing grant from the National Institute of Justice ");
            _log.Debug(" (Award # 2010-DE-BX-K004). ");

            _log.Debug(" The source code is released under a GPLv3 license.");
            _log.Debug(" available here: https://github.com/azavea/acs-alchemist ");
            _log.Debug("");
        }

        protected void ShowCopyrightAndLicense()
        {
            _log.Info("+-------------------------------------------------------------+");
            _log.Info(" ACS Alchemist  Copyright (C) 2012 Azavea, Inc.");
            _log.Info(" This program comes with ABSOLUTELY NO WARRANTY;");
            _log.Info(" This is free software, and you are welcome to redistribute it");
            _log.Info(" under the terms of the GNU General Public License");

            //TODO: are we obligated to list other libraries here?

            _log.Info("+-------------------------------------------------------------+");
        }

        protected void LoadConfigFile()
        {
            Settings.ConfigFile = new Config(Path.Combine(Settings.ApplicationPath, "AcsAlchemist.json.config"));
            if (Settings.ConfigFile.IsEmpty())
            {
                Settings.RestoreDefaults();
            }

            Settings.LoadYearConfigs();
        }


        /// <summary>
        /// Run initialization sequence (logging, load config, welcome, copyright, license, create job instance)
        /// </summary>
        internal void Initialize()
        {
            //InitLogging();

            LoadConfigFile();
            ShowWelcomeScreen();
            ShowCopyrightAndLicense();
            this.JobInstance = new ImportJob();
        }


        #endregion Initialization Boilerplate









        /// <summary>
        /// TODO: Validate variables file:
        /// (does it exist, can I read it, does it have at least one variable, etc.)
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        internal bool ValidateVariablesFile(string filename, out string errorMessage)
        {
            if (!File.Exists(filename))
            {
                errorMessage = "File does not exist";
                return false;
            }

            //TODO: read in the file, make sure it is valid.



            errorMessage = string.Empty;
            return true;
        }


    }
}