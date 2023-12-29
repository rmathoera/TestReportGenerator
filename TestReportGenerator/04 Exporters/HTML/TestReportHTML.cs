using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

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

        public string? HTMLPath = @"C:\\Repos\\TestReportGenerator\\TestReportGenerator\\05 InternalFiles\\HTMLTestReport.html";
        public string? CSSPath = @"C:\\Repos\\TestReportGenerator\\TestReportGenerator\\05 InternalFiles\\HTMLTestReport.css";
        public string? CSS { get; set; }

        internal void CheckCSS(string? CSS)
        {
            if (CSS == null)
            {
                this.CSS = @"C:\\Repos\\TestReportGenerator\\TestReportGenerator\\05 InternalFiles\\HTMLTestReport.css";
            }

            if ((CSS != null) && (CSS == "CustomizedHTMLTestReport"))
            {
                this.CSS = @"C:\\Repos\\TestReportGenerator\\TestReportGenerator\\05 InternalFiles\\CustomizedHTMLTestReport.css";
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
                if (File.Exists(CSSPath))
                {
                    // Read the entire file content into a string
                    this.CSS = File.ReadAllText(CSSPath);
                }
                else
                {
                    Console.WriteLine("The file does not exist.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
        public void CreateReportHTML()
        {
            CreateReportHTML(null,null);
        }

        public void CreateReportHTML(string? CustomizedHTMLTestReport, string? CustomizedCSSStylesheet)
        {
            try
            {
                string indexFile = "index.html";
                string cssFile = "stylesheet.css";
                if (CustomizedHTMLTestReport != null) { indexFile = "customized.html"; this.HTMLPath = CustomizedHTMLTestReport; }
                if (CustomizedCSSStylesheet != null) { cssFile = "customized_stylesheet"; this.CSSPath = CustomizedCSSStylesheet; }
                ReadCSS(CSS);
                CheckCSS(null);
                File.Copy(HTMLPath, indexFile);
                File.Copy(CSSPath, cssFile);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
        internal void ParseReportJSONInToHTMLTestReport()
        {
            // Create the JSON structure
            var jsonData = this.expectedJsonReport();

            // Serialize the JSON object to a string
            string json = JsonConvert.SerializeObject(jsonData);

            // Inject the JSON string into an HTML element
            string script = $"<script>var jsonData = {json};</script>";
        }
    }
}
