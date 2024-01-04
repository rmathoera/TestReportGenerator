using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;
using System.Xml;
using Newtonsoft.Json;
using System.Xml.Schema;

namespace TestReportGenerator._04_Exporters.HTML
{
    internal class TestReportHTML
    {
        internal string expectedJsonReport()
        {
            //string expectedJson = "{\r\n    \"TemplateNameDocument\": \"TestResult\",\r\n    \"ProjectTemplate\": \"CompanyXYZTheme\",\r\n    \"VersionDocument\": 1,\r\n    \"Testsuitename\": \"testsuite TEST OF XYZ project\",\r\n    \"TestRun\": {\r\n        \"TestrunNumber\": 1,\r\n        \"Testname\": \"Test Run Name\",\r\n        \"Testmachine\": \"TEST-MACHINE-ENV\",\r\n        \"Testenvironment\": \"pipeline CI or CD\",\r\n        \"Testexcuter\": \"name of user or system that execute test suite\",\r\n        \"Operatingsystem\": \"Windows\",\r\n        \"Tests\": [\r\n            {\r\n                \"TestCaseId\": 123,\r\n                \"TestCaseName\": \"Test Case 123\",\r\n                \"TestCategory\": \"Functional Acceptance Test\",\r\n                \"StartDateTime\": \"2023-12-01 11:30:00.000\",\r\n                \"StopDateTime\": \"2023-12-01 11:35:10.000\",\r\n                \"Duration\": \"15600\",\r\n                \"TestResult\": \"Passed\",\r\n                \"TestLogLine\": [\r\n                    {\r\n                        \"Logtimestamp\": \"2023-12-01 11:30:05.000\",\r\n                        \"Loglinedescription\": \"test is started\",\r\n                        \"LogAttachmentId\": 434252\r\n                    },\r\n                    {\r\n                        \"Logtimestamp\": \"2023-12-01 11:30:06.000\",\r\n                        \"Loglinedescription\": \"first test step executed\",\r\n                        \"LogAttachmentId\": null\r\n                    },\r\n                    {\r\n                        \"Logtimestamp\": \"2023-12-01 11:33:08.000\",\r\n                        \"LogLineDescription\": \"second test step executed\",\r\n                        \"LogAttachmentId\": null\r\n                    },\r\n                    {\r\n                        \"Logtimestamp\": \"2023-12-01 11:34:05.000\",\r\n                        \"LogLineDescription\": \"test is stopping\",\r\n                        \"LogAttachmentId\": null\r\n                    }\r\n                ]\r\n            },\r\n            {\r\n                \"TestCaseId\": 2568,\r\n                \"TestCaseName\": \"Test Case 2568\",\r\n                \"TestCategory\": \"Unit Test\",\r\n                \"StartDateTime\": \"2023-12-01 11:56:00.000\",\r\n                \"StopDateTime\": \"2023-12-01 11:58:10.000\",\r\n                \"Duration\": \"15600\",\r\n                \"TestResult\": \"Failed\",\r\n                \"TestLogLine\": [\r\n                    {\r\n                        \"Logtimestamp\": \"2023-12-01 11:56:05.000\",\r\n                        \"LogLineDescription\": \"test is started\",\r\n                        \"LogAttachmentId\": null\r\n                    },\r\n                    {\r\n                        \"Logtimestamp\": \"2023-12-01 11:56:06.000\",\r\n                        \"LogLineDescription\": \"first test step executed\",\r\n                        \"LogAttachmentId\": null\r\n                    },\r\n                    {\r\n                        \"Logtimestamp\": \"2023-12-01 11:57:08.000\",\r\n                        \"LogLineDescription\": \"second test step executed\",\r\n                        \"LogAttachmentId\": null\r\n                    },\r\n                    {\r\n                        \"Logtimestamp\": \"2023-12-01 11:58:05.000\",\r\n                        \"LogLineDescription\": \"test is stopping\",\r\n                        \"LogAttachmentId\": null\r\n                    }\r\n                ]\r\n            }\r\n        ]\r\n    }\r\n}";

            string expectedJson = @"{
    ""TemplateNameDocument"": ""TestResult"",
    ""ProjectTemplate"": ""CompanyXYZTheme"",
    ""VersionDocument"": 1,
    ""Testsuitename"": ""testsuite TEST OF XYZ project"",
    ""TestRun"": {
        ""TestrunNumber"": 1,
        ""Testname"": ""Test Run Name"",
        ""Testmachine"": ""TEST-MACHINE-ENV"",
        ""Testenvironment"": ""pipeline CI or CD"",
        ""Testexcuter"": ""name of user or system that execute test suite"",
        ""Operatingsystem"": ""Windows"",
        ""Tests"": [
            {
                ""TestCaseId"": 123,
                ""TestCaseName"": ""Test Case 123"",
                ""TestCategory"": ""Functional Acceptance Test"",
                ""StartDateTime"": ""2023-12-01 11:30:00.000"",
                ""StopDateTime"": ""2023-12-01 11:35:10.000"",
                ""Duration"": ""15600"",
                ""TestResult"": ""Passed"",
                ""TestLogLine"": [
                    {
                        ""Logtimestamp"": ""2023-12-01 11:30:05.000"",
                        ""Loglinedescription"": ""test is started"",
                        ""LogAttachmentId"": 434252
                    },
                    {
                        ""Logtimestamp"": ""2023-12-01 11:30:06.000"",
                        ""Loglinedescription"": ""first test step executed"",
                        ""LogAttachmentId"": null
                    },
                    {
                        ""Logtimestamp"": ""2023-12-01 11:33:08.000"",
                        ""LogLineDescription"": ""second test step executed"",
                        ""LogAttachmentId"": null
                    },
                    {
                        ""Logtimestamp"": ""2023-12-01 11:34:05.000"",
                        ""LogLineDescription"": ""test is stopping"",
                        ""LogAttachmentId"": null
                    }
                ]
            },
            {
                ""TestCaseId"": 2568,
                ""TestCaseName"": ""Test Case 2568"",
                ""TestCategory"": ""Unit Test"",
                ""StartDateTime"": ""2023-12-01 11:56:00.000"",
                ""StopDateTime"": ""2023-12-01 11:58:10.000"",
                ""Duration"": ""15600"",
                ""TestResult"": ""Failed"",
                ""TestLogLine"": [
                    {
                        ""Logtimestamp"": ""2023-12-01 11:56:05.000"",
                        ""LogLineDescription"": ""test is started"",
                        ""LogAttachmentId"": null
                    },
                    {
                        ""Logtimestamp"": ""2023-12-01 11:56:06.000"",
                        ""LogLineDescription"": ""first test step executed"",
                        ""LogAttachmentId"": null
                    },
                    {
                        ""Logtimestamp"": ""2023-12-01 11:57:08.000"",
                        ""LogLineDescription"": ""second test step executed"",
                        ""LogAttachmentId"": null
                    },
                    {
                        ""Logtimestamp"": ""2023-12-01 11:58:05.000"",
                        ""LogLineDescription"": ""test is stopping"",
                        ""LogAttachmentId"": null
                    }
                ]
            }
        ]
    }
}";
            return expectedJson;
        }

        public string? HTMLPath = @"C:\Repos\TestReportGenerator\TestReportGenerator\05 InternalFiles\HTMLTestReport.html";
        public string? CSSPath = @"C:\Repos\TestReportGenerator\TestReportGenerator\stylesheets\HTMLTestReport.css";
        public string? TestReportXML = @"C:\Repos\TestReportGenerator\TestReportGenerator\05 InternalFiles\ReportJSON.xml";
        public string? CSS { get; set; }

        internal void CheckCSS(string? CSS)
        {
            if (CSS == null)
            {
                this.CSS = @"C:\Repos\TestReportGenerator\TestReportGenerator\05 InternalFiles\HTMLTestReport.css";
            }

            if ((CSS != null) && (CSS == "CustomizedHTMLTestReport"))
            {
                this.CSS = @"C:\Repos\TestReportGenerator\TestReportGenerator\05 InternalFiles\CustomizedHTMLTestReport.css";
            }
            else
            {
                this.CSS = $@"{CSS}";
            }
        }

        internal void ReadCSS(string? CSSPath)
        {
            try
            {
                // Check if the file exists
                if (File.Exists(@CSSPath))
                {
                    // Read the entire file content into a string
                    this.CSS = File.ReadAllText(CSSPath);
                }
                else
                {
                    Console.WriteLine("The file does not exist.");
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                throw new Exception();
            }
        }
        public void CreateReportHTML()
        {
            //string reportJSON = @"C:\Repos\TestReportGenerator\TestReportGenerator\05 InternalFiles\ReportJSON.xml";

            CreateReportHTML(null, null, null);
        }
        public static void ParseReportJSONInToHTML(string? ReportJSON, string? HTMLTestReport)
        {
            try
            {
                if (ReportJSON == null)
                {
                    throw new Exception();
                }
                // Read the HTML file content
                string? stringHTMLTestReport = File.ReadAllText(HTMLTestReport);
                // Read the ReportJSON file content
                string? stringReportJSON = File.ReadAllText(ReportJSON);

                // Perform text replacement
                string? updatedHtmlContent = stringHTMLTestReport.Replace("%ReplacewithReportJSONXML%", stringReportJSON);

                // Write the updated content back to the file
                File.WriteAllText(HTMLTestReport, updatedHtmlContent);
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public void CreateReportHTML(string? ReportJSON, string? CustomizedHTMLTestReport, string? CustomizedCSSStylesheet)
        {
            try
            {
                string? HTMLTestReport = HTMLPath;// @"C:\Repos\TestReportGenerator\TestReportGenerator\05 InternalFiles\HTMLTestReport.html";
                string? CSSStylesheet = CSSPath; // @"C:\Repos\TestReportGenerator\TestReportGenerator\stylesheets\HTMLTestReport.css";
                string? testReport = TestReportXML; // @"C:\Repos\TestReportGenerator\TestReportGenerator\05 InternalFiles\ReportJSON.xml";
                if (testReport == null) { Console.WriteLine("No TestReport: "); }
                if (ReportJSON == null) { ReportJSON = testReport; }
                if (CustomizedHTMLTestReport != null) { HTMLTestReport = CustomizedHTMLTestReport; }
                if (CustomizedCSSStylesheet != null) { CSSStylesheet = CustomizedCSSStylesheet; }
                if (File.Exists(ReportJSON)) { File.Delete("ReportJSON.xml"); }
                if (File.Exists(HTMLTestReport)) { File.Delete("Index.html"); }
                if (File.Exists(CustomizedHTMLTestReport)) { File.Delete("CustomizedIndex.html"); }
                if (File.Exists(CustomizedCSSStylesheet)) { File.Delete("CustomizedCSSStylesheet.css"); }
                File.Copy(ReportJSON, "ReportJSON.xml");
                ParseReportJSONWithHTMLTags("ReportJSON.xml");
                if (CustomizedCSSStylesheet != null)
                {
                    File.Copy(CustomizedCSSStylesheet, "CustomizedCSSStylesheet.css");
                    ReadCSS(CustomizedCSSStylesheet);
                    CheckCSS(CustomizedCSSStylesheet);
                }
                if (CustomizedHTMLTestReport == null)
                {
                    File.Copy(HTMLTestReport, "Index.html");
                    ParseReportJSONInToHTML("ReportJSON.xml", "Index.html");
                    if (CustomizedCSSStylesheet != null)
                    {
                        ParseReportStyleSheetInToHTML("Index.html", CustomizedCSSStylesheet);
                    }
                }
                else
                {
                    File.Copy(CustomizedHTMLTestReport, "CustomizedIndex.html");
                    ParseReportJSONInToHTML("ReportJSON.xml", "CustomizedIndex.html");
                    if (CustomizedCSSStylesheet != null)
                    {
                        ParseReportStyleSheetInToHTML("CustomizedIndex.html", CustomizedCSSStylesheet);
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                throw new Exception();
            }
        }

        private static void ParseReportStyleSheetInToHTML(string? HTMLTestReport, string? customizedCSSStylesheet)
        {
            try
            {
                if (HTMLTestReport == null)
                {
                    throw new Exception();
                }
                // Read the HTML file content
                string stringHTMLTestReport = File.ReadAllText(HTMLTestReport);

                // Perform text replacement
                string updatedHtmlContent = stringHTMLTestReport.Replace("stylesheets\\HTMLTestReport.css", stringHTMLTestReport);

                // Write the updated content back to the file
                File.WriteAllText(HTMLTestReport, updatedHtmlContent);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"ArgumentNullException: {ex.ParamName}");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                throw;
            }
        }

        public static void ParseReportJSONWithHTMLTags(string? ReportJSON)
        {
            try
            {
                if (ReportJSON == null)
                {
                    throw new ArgumentNullException(nameof(ReportJSON), "Report JSON is null.");
                }

                // Read the ReportJSON file content
                string stringReportJSON = File.ReadAllText(ReportJSON);

                // Dictionary for mapping JSON tags to HTML structures
                Dictionary<string, string> replacements = new Dictionary<string, string>
        {
            { "<TestResult>\r\n  <TemplateNameDocument>", "<TestReport>\r\n  <TemplateNameDocument>" },
            { "</TestRun>\r\n</TestResult>", "</TestRun>\r\n</TestReport>" },
            { "<TemplateNameDocument>", "<p>Template Name Document: " },
            { "<ProjectTemplate>", "<p>Project Template: " },
            { "<VersionDocument>", "<p>Version Document: " },
            { "<Testsuitename>", "<p>Test Suite Name: " },
            { "<TestrunNumber>", "<p>Test Run Number: " },
            { "<TestCategory>", "<p>Test Category: " },
            { "<Testname>", "<p>Test Name: " },
            { "<Testmachine>", "<p>Test Machine: " },
            { "<Testenvironment>", "<p>Test Environment: " },
            { "<Testexcuter>", "<p>Test Executor: " },
            { "</Operatingsystem>", "</Operatingsystem><p>" },
            { "<Operatingsystem>", "<p>Operating System: " },
            { "<TestCaseId>", "<p>Test Case ID: " },
            { "<TestCaseName>", "<p>Test Case Name: " },
            { "<StartDateTime>", "<p>Start Date Time: " },
            { "<StopDateTime>", "<p>Stop Date Time: " },
            { "<Duration>", "<p>Duration: " },
            { "<TestResult>", "<p>Test Result: " },
            { "<Logtimestamp>", "<p>Log Timestamp: " },
            { "<Loglinedescription>", "<p>Log Line Description: " },
            { "<LogAttachmentId>", "<p>Log Attachment ID: " }
        };


                // Apply replacements
                foreach (var replacement in replacements)
                {
                    stringReportJSON = stringReportJSON.Replace(replacement.Key, replacement.Value);
                }

                // Write the updated content back to the file
                File.WriteAllText(ReportJSON, stringReportJSON);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"ArgumentNullException: {ex.ParamName}");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                throw;
            }
        }

        public static void CreateReportHTMLFromXmlAndXslt(string reportJSON, string xsltTestResult, string htmlPageName)
        {
            try
            {
                // Load XML data
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(reportJSON);

                // Load XSD schema
                XmlSchemaSet schemas = new XmlSchemaSet();
                schemas.Add("", @"C:\Repos\TestReportGenerator\TestReportGenerator\05 InternalFiles\ReportJSON.xsd");
                xmlDoc.Schemas = schemas;
                xmlDoc.Validate(null);

                // Load XSLT stylesheet
                XslCompiledTransform xslt = new XslCompiledTransform();
                xslt.Load(xsltTestResult);

                // Create StringWriter to hold the transformed output
                using (StringWriter writer = new StringWriter())
                {
                    // Create XmlWriter for writing the transformed output
                    XmlWriterSettings settings = new XmlWriterSettings();
                    settings.OmitXmlDeclaration = true; // Omit XML declaration from the output
                    settings.ConformanceLevel = ConformanceLevel.Auto;
                    settings.CloseOutput = false;

                    using (XmlWriter xmlWriter = XmlWriter.Create(writer, settings))
                    {
                        // Perform the transformation
                        xslt.Transform(xmlDoc, null, xmlWriter);
                    }

                    // Get the transformed output as a string
                    string htmlOutput = writer.ToString();

                    // Write the updated content back to the file
                    File.WriteAllText(htmlPageName, htmlOutput);

                    Console.WriteLine("Transformation completed successfully.");
                }
            }
            catch (XmlSchemaValidationException ex)
            {
                Console.WriteLine("XML Schema Validation Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}