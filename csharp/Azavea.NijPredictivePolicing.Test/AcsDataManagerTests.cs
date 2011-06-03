﻿using NUnit.Framework;
using log4net;
using System.IO;
using System.Collections.Generic;
using Azavea.NijPredictivePolicing.Test.Helpers;
using Azavea.NijPredictivePolicing.AcsImporterLibrary.Transfer;
using SharpMap.CoordinateSystems;
using GeoAPI.Geometries;
using Azavea.NijPredictivePolicing.AcsImporterLibrary;
using Azavea.NijPredictivePolicing.Common;
using Azavea.NijPredictivePolicing.Common.DB;

namespace Azavea.NijPredictivePolicing.Test.AcsImporterLibrary
{
    [TestFixture]
    public class AcsDataManagerTests
    {
        /// <summary>
        /// Place to dump files generated by tests
        /// </summary>
        protected const string OutputDir = "output\\";

        private static ILog _log = null;

        private static AcsDataManager man;

        private static void AcsDataManagerInit()
        {
            man.WorkingPath = Path.Combine(@"E:\projects\Temple_Univ_NIJ_Predictive_Policing\csharp\Azavea.NijPredictivePolicing.Test", "TestData");
            
            FileUtilities.PathEnsure(man.WorkingPath, "database");
            man.DBFilename = FileUtilities.PathCombine(man.WorkingPath, "database", Settings.CurrentAcsDirectory + ".sqlite");

            man.ShapePath = FileUtilities.PathEnsure(man.WorkingPath, "shapes");
            man.CurrentDataPath = man.WorkingPath;


            //man.DataPath = FileLocator.GetStateBlockGroupDataDir(man.State);
            //man.ShpPath = FileLocator.GetStateBlockGroupDataDir(man.State);            
            //man.DBPath = FileUtilities.PathCombine(man.DataPath, man.State.ToString() + ".sqlite");

            man.DbClient = DataClient.GetDefaultClient(man.DBFilename);            
        }

        private static string GetShapePath(string filename)
        {
            return Path.Combine(man.ShapePath, Path.GetFileName(filename));
        }

        [TestFixtureSetUp]
        public void Init()
        {
            _log = LogHelpers.ResetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            if (!Directory.Exists(OutputDir))
                Directory.CreateDirectory(OutputDir);

            man = new AcsDataManager();
            AcsDataManagerInit();
        }

        [Test]
        public void GetShapefileFeatures()
        {
            var features = new List<IGeometry>();
            var features2 = new List<IGeometry>();

            features = man.GetFilteringGeometries(GetShapePath("DoesNotExist.shp"), 
                GeographicCoordinateSystem.WGS84);
            Assert.AreEqual(features, null);

            features = man.GetFilteringGeometries(GetShapePath("bg42_d00.shp"), GeographicCoordinateSystem.WGS84);
            Assert.AreEqual(features, null);

            features = man.GetFilteringGeometries(GetShapePath("bg42_d00_nosrid.shp"), 
                GeographicCoordinateSystem.WGS84);
            Assert.IsTrue(features.Count > 0);

            features = man.GetFilteringGeometries(GetShapePath("bg42_d00_srid.shp"), 
                GeographicCoordinateSystem.WGS84);
            Assert.IsTrue(features.Count > 0);

            features2 = man.GetFilteringGeometries(GetShapePath("bg42_d00_srid.shp"),
                GeographicCoordinateSystem.WGS84);
        }

        [Test]
        public void ImportVariablesFile()
        {

        }
    }
}
