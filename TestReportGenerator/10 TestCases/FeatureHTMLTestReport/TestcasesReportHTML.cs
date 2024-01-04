/*
This Testclass has all test described for the HTML Testreport generation.

User Story
As a Developer/QA 
I want a test report genreated in single HTML File 
So that it can be localy distributed and saved on websites, using there own style sheet 
*/
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using TestReportGenerator._04_Exporters.HTML;

namespace TestReportGenerator._10_TestCases.FeatureHTMLTestReport
{
    [TestClass]
    public class TestcasesReportHTML
    {
        /*
         Scenario: Create an TestReport in HTML using the ISTQB prefered 
         */
        [TestMethod]
        public void CreateAnTestReportInHTMLInISTQB()
        {
            TestReportHTML testReportHTML = new TestReportHTML();

            // Assign
            // Given output ReportJSON.xml file exists
            Assert.IsTrue(File.Exists(@"C:\Repos\TestReportGenerator\TestReportGenerator\05 InternalFiles\ReportJSON.xml"));
            //string reportJSON = @"C:\Repos\TestReportGenerator\TestReportGenerator\05 InternalFiles\ReportJSON.xml";
            // and ReportJSON is validated for HTML TestReport
            // and default HTML TestReport exists
            Assert.IsTrue(File.Exists(@"C:\Repos\TestReportGenerator\TestReportGenerator\05 InternalFiles\HTMLTestReport.html"));
            // and default CSS TestReport exists
            Assert.IsTrue(File.Exists(@"C:\Repos\TestReportGenerator\TestReportGenerator\stylesheets\HTMLTestReport.css"));

            // Act
            // When generating HTML TestReport
            testReportHTML.CreateReportHTML();

            // Assert
            // Then validate HTML TestReport
        }
        /*
         Scenario: Create an TestReport in HTML using an customized CSS style sheet
         */
        [TestMethod]
        public void CreateAnTestReportInHTMLWithCSSStyleSheet()
        {
            TestReportHTML testReportHTML = new TestReportHTML();

            // Assign
            // Given output ReportJSON file exists
            Assert.IsTrue(File.Exists(@"C:\Repos\TestReportGenerator\TestReportGenerator\05 InternalFiles\ReportJSON.xml"));
            // and ReportJSON is validated for HTML TestReport
            // and default HTML TestReport exists
            // and costumized CSS TestReport exists
            Assert.IsTrue(File.Exists(@"C:\Repos\TestReportGenerator\TestReportGenerator\stylesheets\CustomizedCSSStylesheet.css"));
            // Act

            // When generating HTML TestReport 
            string useCustomizedCSSStylesheet = @"C:\Repos\TestReportGenerator\TestReportGenerator\stylesheets\CustomizedCSSStylesheet.css";
            testReportHTML.CreateReportHTML(null, null, useCustomizedCSSStylesheet);

            // Assert
            // Then validate HTML TestReport
        }
        /*
         Scenario: Create an TestReport in HTML using a Customized Report 
         */
        [TestMethod]
        public void CreateAnTestReportInHTMLInUserCustomizeStyle()
        {
            TestReportHTML testReportHTML = new TestReportHTML();

            // Assign
            // Given output ReportJSON file exists
            string reportJSON = @"C:\Repos\TestReportGenerator\TestReportGenerator\05 InternalFiles\ReportJSON.xml";
            // and ReportJSON is validated for HTML TestReport
            // and customized HTML TestReport exists
            string useCustomizedHTMLTestReport = @"C:\Repos\TestReportGenerator\TestReportGenerator\05 InternalFiles\CustomizedIndex.html";
            // and customized CSS TestReport exists
            string useCustomizedCSSStylesheet = @"C:\Repos\TestReportGenerator\TestReportGenerator\stylesheets\CustomizedCSSStylesheet.css";
            // Act
            // When generating HTML TestReport 
            testReportHTML.CreateReportHTML(reportJSON, useCustomizedHTMLTestReport, useCustomizedCSSStylesheet);

            // Assert
            // Then validate HTML TestReport

        }
        [TestMethod]
        // Scenario : Create HTML page for with only TestRun data
        public void CreateAnHTMLTestReportWithOnlyTestRunData()
        {
            TestReportHTML testReportHTML = new TestReportHTML();
            // Given an trx file exists
            // And trx file is converted into an xml file
            string reportJSON = @"C:\Repos\TestReportGenerator\TestReportGenerator\05 InternalFiles\ReportJSON.xml";
            // When transforming xml file with xslt (TestRun)
            string xsltTestRun = @"C:\Repos\TestReportGenerator\TestReportGenerator\05 InternalFiles\ReportJSONTestRuns.xslt";
            TestReportHTML.CreateReportHTMLFromXmlAndXslt(reportJSON, xsltTestRun, "TestRun.html");
            // Then HTML file is created with only the TRX Testrun data presented.
            Assert.AreEqual(true, TestReportHTML.Result);
        }

        [TestMethod]
        // Scenario : Create HTML page for with only TestResult data
        public void CreateAnHTMLTestReportWithOnlyTestResults()
        {
            TestReportHTML testReportHTML = new TestReportHTML();
            // Given an trx file exists
            // And trx file is converted into an xml file
            string reportJSON = @"C:\Repos\TestReportGenerator\TestReportGenerator\05 InternalFiles\ReportJSON.xml";
            // When transforming xml file with xslt (TestResult)
            string xsltTestResult = @"C:\Repos\TestReportGenerator\TestReportGenerator\05 InternalFiles\ReportJSONTestResult.xslt";
            TestReportHTML.CreateReportHTMLFromXmlAndXslt(reportJSON, xsltTestResult, "TestResult.html");
            // Then HTML file is created with only the TRX TestResult data presented.
            Assert.AreEqual(true, TestReportHTML.Result);
        }
        [TestMethod]
        // Scenario : Create HTML page for with only Tests data
        public void CreateAnHTMLTestReportWithOnlyTests()
        {
            TestReportHTML testReportHTML = new TestReportHTML();
            // Given an trx file exists
            // And trx file is converted into an xml file
            string reportJSON = @"C:\Repos\TestReportGenerator\TestReportGenerator\05 InternalFiles\ReportJSON.xml";
            // When transforming xml file with xslt (Tests)
            string xsltTests = @"C:\Repos\TestReportGenerator\TestReportGenerator\05 InternalFiles\ReportJSONTests.xslt";
            TestReportHTML.CreateReportHTMLFromXmlAndXslt(reportJSON, xsltTests, "Tests.html");
            // Then HTML file is created with only the TRX Tests data presented.
            Assert.AreEqual(true, TestReportHTML.Result);
        }

        private const string ValidReportJSON = @"C:\Repos\TestReportGenerator\TestReportGenerator\05 InternalFiles\ReportJSON.xml";
        private const string ValidXSLT = @"C:\Repos\TestReportGenerator\TestReportGenerator\05 InternalFiles\ReportJSONTests.xslt";
        private const string InvalidReportJSON = @"C:\Repos\TestReportGenerator\TestReportGenerator\10 TestCases\TestData\InvalidReportJSON.xml";
        private const string InvalidXSLT = @"C:\Repos\TestReportGenerator\TestReportGenerator\10 TestCases\TestData\InvalidReportJSONTests.xslt";
        private const string OutputHTML = "Tests.html";

        [TestMethod]
        public void CreateReportHTMLFromXmlAndXslt_ValidInputs_Success()
        {
            // Arrange
            string reportJSON = ValidReportJSON;
            string xsltTestResult = ValidXSLT;
            string htmlPageName = OutputHTML;

            // Act
            TestReportHTML.CreateReportHTMLFromXmlAndXslt(reportJSON, xsltTestResult, htmlPageName);

            // Assert
            // Check if the output HTML file is created
            Assert.IsTrue(File.Exists(htmlPageName));
        }

        [TestMethod]
        public void CreateReportHTMLFromXmlAndXslt_InvalidXML_ThrowsXmlSchemaValidationException()
        {
            // Arrange
            string reportJSON = InvalidReportJSON; // Invalid XML file path
            string xsltTestResult = ValidXSLT;
            string htmlPageName = OutputHTML;

            // Act & Assert
            Assert.ThrowsException<XmlSchemaValidationException>(() =>
            {
                TestReportHTML.CreateReportHTMLFromXmlAndXslt(reportJSON, xsltTestResult, htmlPageName);
            });
        }

        [TestMethod]
        public void CreateReportHTMLFromXmlAndXslt_InvalidXSLT_ThrowsException()
        {
            // Arrange
            string reportJSON = ValidReportJSON;
            string xsltTestResult = InvalidXSLT; // Invalid XSLT file path
            string htmlPageName = OutputHTML;

            // Act & Assert
            Assert.ThrowsException<System.IO.FileNotFoundException>(() =>
            {
                TestReportHTML.CreateReportHTMLFromXmlAndXslt(reportJSON, xsltTestResult, htmlPageName);
            });
        }

        [TestMethod]
        public void CreateReportHTMLFromXmlAndXslt_NoWritePermission_ThrowsException()
        {
            // Arrange
            string reportJSON = ValidReportJSON;
            string xsltTestResult = ValidXSLT;
            string htmlPageName = @"C:\Windows\InvalidHTML.html"; // Invalid output path without write permission

            // Act & Assert
            Assert.ThrowsException<UnauthorizedAccessException>(() =>
            {
                TestReportHTML.CreateReportHTMLFromXmlAndXslt(reportJSON, xsltTestResult, htmlPageName);
            });
        }

    }
}
