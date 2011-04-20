﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using log4net;

namespace Azavea.NijPredictivePolicing.Common.Data
{
    public static class FileWriterHelpers
    {
        private static ILog _log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static bool WriteDataTable(IDataFileWriter writer, DataTable dt)
        {
            try
            {
                int colCount = dt.Columns.Count;
                List<string> colNames = new List<string>(colCount);
                foreach (DataColumn col in dt.Columns)
                {
                    colNames.Add(col.ColumnName);
                }

                writer.CreateTable(string.Empty, colNames);

                string[] rowValues = new string[colCount];
                foreach (DataRow row in dt.Rows)
                {
                    for (int i = 0; i < colCount; i++)
                    {
                        rowValues[i] = row[i] + string.Empty;
                    }

                    writer.WriteLine(rowValues);
                }
                writer.Flush();

                return true;
            }
            catch (Exception ex)
            {
                _log.Error("Error writing table to writer", ex);
            }
            return false;
        }

    }
}