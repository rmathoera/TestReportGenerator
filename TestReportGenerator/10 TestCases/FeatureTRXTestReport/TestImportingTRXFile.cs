﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestReportGenerator._03_Importers.CommandLine;

namespace TestReportGenerator._10_TestCases
{
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class TestImportingTRXFile
    {
        [TestMethod]
        public void Read_Trx_File()
        {
            // Assign fullpath with trx filename
            string? trxfile = @"C:\Repos\TestReportGenerator\TestReportGenerator\10 TestCases\TestData\trxfile_v1.trx";
            // Assert 
            Assert.IsNotNull(TRX_TestReport.Import_TRX_File(trxfile));
            // Assert
            Assert.IsTrue(TRX_TestReport.Result);
        }
        [TestMethod]
        public void ReadTRX_XSLT_File()
        {
            // Assign class where methods are 
            TRX_TestReport get_TRX_Testreport = new TRX_TestReport();

            // Assign fullpath with trx xslt filename
            string? trxxsltfile = @"C:\Repos\TestReportGenerator\TestReportGenerator\10 TestCases\TestData\trxxsltfile_v1.xslt";

            // Act
            TRX_TestReport.Import_TRX_XSLT_File(trxxsltfile);

            // Assert
            Assert.IsTrue(TRX_TestReport.Result);
        }
        [TestMethod]
        public void Validate_TRX_File_Format()
        {
            // Assign class where methods are 
            TRX_TestReport get_TRX_Testreport = new TRX_TestReport();
            // Assign fullpath with trx filename
            string? trxfile = @"C:\Repos\TestReportGenerator\TestReportGenerator\10 TestCases\TestData\trxfile_v1.trx";
            // Assign fullpath with trx xslt filename
            string? trxxsltfile = @"C:\Repos\TestReportGenerator\TestReportGenerator\10 TestCases\TestData\trxxsltfile_v1.xslt";

            // Act/Assert
            Assert.IsNotNull(TRX_TestReport.ValidateTRX(trxfile, trxxsltfile));

        }
        [TestMethod]
        public void Transform_TRX_To_BaseJSON()
        {
            // Assign class where methods are 
            TRX_TestReport get_TRX_Testreport = new TRX_TestReport();

            // Assign fullpath with trx filename
            string? trxfile = @"C:\Repos\TestReportGenerator\TestReportGenerator\10 TestCases\TestData\trxfile_v1.trx";

            // Assign fullpath with xlts filename
            string? trxxsltfile = @"C:\Repos\TestReportGenerator\TestReportGenerator\10 TestCases\TestData\trxxsltfile_v1.xslt";

            // Act
            TRX_TestReport.Import_TRX_XSLT_File(trxxsltfile);

            // Act
            string? FullPathToFile = TRX_TestReport.Import_TRX_File(trxfile);

            // Act/Assert
            Assert.IsNotNull(TRX_TestReport.ToBaseJSON(FullPathToFile));
        }
        [TestMethod]
        public void Transform_TRX_To_XML()
        {
            // Assign class where methods are 
            TRX_TestReport get_TRX_Testreport = new TRX_TestReport();

            // Assign fullpath with trx filename
            string? trxfile = @"C:\Repos\TestReportGenerator\TestReportGenerator\10 TestCases\TestData\trxfile_v1.trx";

            // Assign fullpath with xlts filename
            string? trxxsltfile = @"C:\Repos\TestReportGenerator\TestReportGenerator\10 TestCases\TestData\trxxsltfile_v1.xslt";

            // Act
            TRX_TestReport.Import_TRX_XSLT_File(trxxsltfile);

            // Act
            string? FullPathToFile = TRX_TestReport.Import_TRX_File(trxfile);

            // Act/Assert
            Assert.IsNotNull(TRX_TestReport.ToBaseXML(FullPathToFile));
        }
    }
}
