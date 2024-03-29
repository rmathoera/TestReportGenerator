﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using TestReportGenerator;

namespace TestReportGeneratorTest
{
    [TestClass]
    public class TestCasesJsonSerializationTests
    {
        internal TestReport generateTemplateReport()
        {
            // Arrange
            TestReport data = new TestReport
            {
                TemplateNameDocument = "TestResult",
                ProjectTemplate = "CompanyXYZTheme",
                VersionDocument = 1,
                Testsuitename = "testsuite TEST OF XYZ project",
                TestRun = new TestRun
                {
                    TestrunNumber = 1,
                    Testname = "Test Run Name",
                    Testmachine = "TEST-MACHINE-ENV",
                    Testenvironment = "pipeline CI or CD",
                    Testexecuter = "name of user or system that execute test suite",
                    Operatingsystem = "Windows",
                    Test = new System.Collections.Generic.List<Test>
                {
                    new Test
                    {
                        TestCaseId = 123,
                        TestCaseName = "Test Case 123",
                        TestCategory = "Functional Acceptance Test",
                        StartDateTime = "2023-12-01 11:30:00.000",
                        StopDateTime = "2023-12-01 11:35:10.000",
                        Duration = "15600",
                        TestResult = "Passed",
                        TestLogLine = new System.Collections.Generic.List<TestLogLine>
                        {
                            new TestLogLine
                            {
                                LogTimestamp = "2023-12-01 11:30:05.000",
                                LogLineDescription = "test is started"
                            },
                            new TestLogLine
                            {
                                LogTimestamp = "2023-12-01 11:30:06.000",
                                LogLineDescription = "first test step executed",
                                LogAttachmentId = 434252
                            },
                            new TestLogLine
                            {
                                LogTimestamp = "2023-12-01 11:33:08.000",
                                LogLineDescription = "second test step executed"
                            },
                            new TestLogLine
                            {
                                LogTimestamp = "2023-12-01 11:34:05.000",
                                LogLineDescription = "test is stopping"
                            }
                        }
                    },
                    new Test
                    {
                        TestCaseId = 2568,
                        TestCaseName = "Test Case 2568",
                        TestCategory = "Unit Test",
                        StartDateTime = "2023-12-01 11:56:00.000",
                        StopDateTime = "2023-12-01 11:58:10.000",
                        Duration = "15600",
                        TestResult = "Failed",
                        TestLogLine = new System.Collections.Generic.List<TestLogLine>
                        {
                            new TestLogLine
                            {
                                LogTimestamp = "2023-12-01 11:56:05.000",
                                LogLineDescription = "test is started"
                            },
                            new TestLogLine
                            {
                                LogTimestamp = "2023-12-01 11:56:06.000",
                                LogLineDescription = "first test step executed"
                            },
                            new TestLogLine
                            {
                                LogTimestamp = "2023-12-01 11:57:08.000",
                                LogLineDescription = "second test step executed"
                            },
                            new TestLogLine
                            {
                                LogTimestamp = "2023-12-01 11:58:05.000",
                                LogLineDescription = "test is stopping"
                            }
                        }
                    }
                }
                }
            };
            return data;
        }
        internal string expectedJsonReport()
        {
            string expectedJson = "{\r\n  \"TemplateNameDocument\": \"TestResult\",\r\n  \"ProjectTemplate\": \"CompanyXYZTheme\",\r\n  \"VersionDocument\": 1,\r\n  \"Testsuitename\": \"testsuite TEST OF XYZ project\",\r\n  \"TestRun\": {\r\n    \"TestrunNumber\": 1,\r\n    \"Testname\": \"Test Run Name\",\r\n    \"Testmachine\": \"TEST-MACHINE-ENV\",\r\n    \"Testenvironment\": \"pipeline CI or CD\",\r\n    \"Testexecuter\": \"name of user or system that execute test suite\",\r\n    \"Operatingsystem\": \"Windows\",\r\n    \"Test\": [\r\n      {\r\n        \"TestCaseId\": 123,\r\n        \"TestCaseName\": \"Test Case 123\",\r\n        \"TestCategory\": \"Functional Acceptance Test\",\r\n        \"StartDateTime\": \"2023-12-01 11:30:00.000\",\r\n        \"StopDateTime\": \"2023-12-01 11:35:10.000\",\r\n        \"Duration\": \"15600\",\r\n        \"TestResult\": \"Passed\",\r\n        \"TestLogLine\": [\r\n          {\r\n            \"LogTimestamp\": \"2023-12-01 11:30:05.000\",\r\n            \"LogLineDescription\": \"test is started\"\r\n          },\r\n          {\r\n            \"LogTimestamp\": \"2023-12-01 11:30:06.000\",\r\n            \"LogLineDescription\": \"first test step executed\",\r\n            \"LogAttachmentId\": 434252\r\n          },\r\n          {\r\n            \"LogTimestamp\": \"2023-12-01 11:33:08.000\",\r\n            \"LogLineDescription\": \"second test step executed\"\r\n          },\r\n          {\r\n            \"LogTimestamp\": \"2023-12-01 11:34:05.000\",\r\n            \"LogLineDescription\": \"test is stopping\"\r\n          }\r\n        ]\r\n      },\r\n      {\r\n        \"TestCaseId\": 2568,\r\n        \"TestCaseName\": \"Test Case 2568\",\r\n        \"TestCategory\": \"Unit Test\",\r\n        \"StartDateTime\": \"2023-12-01 11:56:00.000\",\r\n        \"StopDateTime\": \"2023-12-01 11:58:10.000\",\r\n        \"Duration\": \"15600\",\r\n        \"TestResult\": \"Failed\",\r\n        \"TestLogLine\": [\r\n          {\r\n            \"LogTimestamp\": \"2023-12-01 11:56:05.000\",\r\n            \"LogLineDescription\": \"test is started\"\r\n          },\r\n          {\r\n            \"LogTimestamp\": \"2023-12-01 11:56:06.000\",\r\n            \"LogLineDescription\": \"first test step executed\"\r\n          },\r\n          {\r\n            \"LogTimestamp\": \"2023-12-01 11:57:08.000\",\r\n            \"LogLineDescription\": \"second test step executed\"\r\n          },\r\n          {\r\n            \"LogTimestamp\": \"2023-12-01 11:58:05.000\",\r\n            \"LogLineDescription\": \"test is stopping\"\r\n          }\r\n        ]\r\n      }\r\n    ]\r\n  }\r\n}";
            return expectedJson;
        }
        internal string expectedJsonReportX()
        {
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
    ""Testexecuter"": ""name of user or system that execute test suite"",
    ""Operatingsystem"": ""Windows"",
    ""Test"": [
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
            ""LogTimestamp"": ""2023-12-01 11:30:05.000"",
            ""LogLineDescription"": ""test is started""
          },
          {
            ""LogTimestamp"": ""2023-12-01 11:30:06.000"",
            ""LogLineDescription"": ""first test step executed"",
            ""LogAttachmentId"": 434252
          },
          {
            ""LogTimestamp"": ""2023-12-01 11:33:08.000"",
            ""LogLineDescription"": ""second test step executed""
          },
          {
            ""LogTimestamp"": ""2023-12-01 11:34:05.000"",
            ""LogLineDescription"": ""test is stopping""
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
            ""LogTimestamp"": ""2023-12-01 11:56:05.000"",
            ""LogLineDescription"": ""test is started""
          },
          {
            ""LogTimestamp"": ""2023-12-01 11:56:06.000"",
            ""LogLineDescription"": ""first test step executed""
          },
          {
            ""LogTimestamp"": ""2023-12-01 11:57:08.000"",
            ""LogLineDescription"": ""second test step executed""
          },
          {
            ""LogTimestamp"": ""2023-12-01 11:58:05.000"",
            ""LogLineDescription"": ""test is stopping""
          }
        ]
      }
    ]
  }
}";
            return expectedJson;
        }
        [TestMethod]
        public void ShouldMatchExpectedJson()
        {
            // Arrange
            TestReport data = generateTemplateReport();

            // Act
            string actualJson = data.ToJson(false);

            // Assert
            Assert.AreEqual(expectedJsonReport(), actualJson);
        }
        [TestMethod]
        public void ShouldMatchExpectedJsonString()
        {
            // Arrange
            TestReport data = generateTemplateReport();

            // Act
            string actualJson = data.ToString();

            // Assert
            Assert.AreEqual(expectedJsonReport(), actualJson);
        }
        [TestMethod]
        public void ShouldMatchExpectedAsJson()
        {
            // Arrange
            TestReport data = generateTemplateReport();

            // Act
            string actualJson = data.ToJson(false);

            // Assert
            Assert.AreEqual(expectedJsonReportX(), actualJson);
        }

        [TestMethod]
        public void ShouldMatchExpectedAsEmptyJson()
        {
            // Arrange
            TestReport data = generateTemplateReport();
            data.VersionDocument = null;
            data.TemplateNameDocument = null;
            data.Testsuitename = null;
            data.TestRun = null;
            data.ProjectTemplate = null;

            string? expectedJson = @"{}";

            // Act
            string actualJson = data.ToJson(false);

            // Assert
            Assert.AreEqual(expectedJson, actualJson);
        }


        [TestMethod]
        public void ShouldMatchExpectedAsNotEmptyTestRun()
        {
            // Arrange
            TestReport data = generateTemplateReport();
            data.VersionDocument = null;
            data.TemplateNameDocument = null;
            data.Testsuitename = null;
            data.ProjectTemplate = null;
            data.TestRun = null;

            string? expectedJson = @"{
  ""TemplateNameDocument"": null,
  ""ProjectTemplate"": null,
  ""VersionDocument"": null,
  ""Testsuitename"": null,
  ""TestRun"": null
}";

            // You can perform operations with this JSON string as needed
            // For example, deserialization or comparison

            // Act
            string actualJson = data.ToJson(true);

            // Assert
            Assert.AreEqual(expectedJson, actualJson);
        }

        [TestMethod]
        public void ShouldNotMatchExpectedJsonValue()
        {
            // Arrange
            TestReport data = generateTemplateReport();
            string expectedJson = expectedJsonReport();

            if (data.TestRun is not null)
            {
                // change an JSON value
                // Update TestRun properties
                data.TestRun.TestrunNumber = 2;
                data.TestRun.Testname = "Updated Test Run Name";
                data.TestRun.Testmachine = "UPDATED-TEST-MACHINE-ENV";
                data.TestRun.Testenvironment = "updated pipeline CI or CD";
                data.TestRun.Testexecuter = "Updated name of user or system";
                data.TestRun.Operatingsystem = "Linux"; // Changed to Linux
            }

            // Act
            string actualJson = data.ToJson();

            // Assert
            Assert.AreNotEqual(expectedJson, actualJson);
        }

        [TestMethod]
        public void ShouldNotMatchExpectedJsonNullValue()
        {
            // Arrange
            TestReport data = generateTemplateReport();
            string expectedJson = expectedJsonReport();

            data.TestRun = null;

            // Act
            string actualJson = data.ToJson();

            // Assert
            Assert.AreNotEqual(expectedJson, actualJson);
        }
    }
}