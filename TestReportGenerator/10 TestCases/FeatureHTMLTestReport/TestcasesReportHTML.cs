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
            // and default CSS TestReport exists

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
            string reportJSON = @"C:\Repos\TestReportGenerator\TestReportGenerator\05 InternalFiles\ReportJSON.xml";
            // and ReportJSON is validated for HTML TestReport
            // and default HTML TestReport exists
            // and costumized CSS TestReport exists
            // Act

            // When generating HTML TestReport 
            string useCustomizedCSSStylesheet = @"C:\Repos\TestReportGenerator\TestReportGenerator\05 InternalFiles\CustomizedHTMLTestReport.css";
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
            string useCustomizedHTMLTestReport = @"C:\Repos\TestReportGenerator\TestReportGenerator\05 InternalFiles\CustomizedHTMLTestReport.html";
            // and customized CSS TestReport exists
            string useCustomizedCSSStylesheet = @"C:\Repos\TestReportGenerator\TestReportGenerator\05 InternalFiles\CustomizedHTMLTestReport.css";
            // Act
            // When generating HTML TestReport 
            testReportHTML.CreateReportHTML(reportJSON, useCustomizedHTMLTestReport, useCustomizedCSSStylesheet);

            // Assert
            // Then validate HTML TestReport

        }
    }


}
