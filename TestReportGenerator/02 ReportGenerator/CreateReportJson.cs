using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestReportGenerator;
using static System.Net.Mime.MediaTypeNames;
using Newtonsoft.Json; // Ensure you have the Newtonsoft.Json package installed via NuGet
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Adapter;
using System.ComponentModel;

namespace TestReportGenerator
{
    internal class CreateReport
    {
        public string? TemplateNameDocument { get; set; }
        public string? ProjectTemplate { get; set; }
        public int VersionDocument { get; set; }
        public string? Testsuitename { get; set; }
        public TestRun? TestRun { get; set; }
        public RootObject TestReport()
        {
            RootObject root = new RootObject
            {
                TemplateNameDocument = TemplateNameDocument,
                ProjectTemplate = ProjectTemplate,
                VersionDocument = VersionDocument,
                Testsuitename = Testsuitename,
                TestRun = TestRun
            };
            return root;
        }
    }
    internal class CreateTestRun
    {
        public int TestrunNumber { get; set; }
        public string? Testname { get; set; }
        public string? Testmachine { get; set; }
        public string? Testenvironment { get; set; }
        public string? Testexecuter { get; set; }
        public string? Operatingsystem { get; set; }
        public List<Test>? Test { get; set; }
        public TestRun TestRun()
        {
            TestRun testRun = new TestRun
            {
                TestrunNumber = TestrunNumber,
                Testname = Testname,
                Testmachine = Testmachine,
                Testenvironment = Testenvironment,
                Testexecuter = Testexecuter,
                Operatingsystem = Operatingsystem,
                Test = Test
            };
            return testRun;
        }
    }
    internal class CreateTest
    {
        public int? TestCaseId { get; set; }
        public string? TestCaseName { get; set; }
        public string? TestCategory { get; set; }
        public string? StartDateTime { get; set; }
        public string? StopDateTime { get; set; }
        public string? Duration { get; set; }
        public string? TestResult { get; set; }
        public List<TestLogLine>? TestLogLine { get; set; }
        public Test ToTest()
        {
            return new Test
            {
                TestCaseId = TestCaseId,
                TestCaseName = TestCaseName,
                TestCategory = TestCategory,
                StartDateTime = StartDateTime,
                StopDateTime = StopDateTime,
                Duration = Duration,
                TestResult = TestResult,
                TestLogLine = TestLogLine
            };
        }
        public Test ToTestWithoutLogline()
        {
            return new Test
            {
                TestCaseId = TestCaseId,
                TestCaseName = TestCaseName,
                TestCategory = TestCategory,
                StartDateTime = StartDateTime,
                StopDateTime = StopDateTime,
                Duration = Duration,
                TestResult = TestResult
            };
        }
    }
    internal class CreateTestLogline
    {
        public string? LogTimestamp { get; set; }
        public string? LogLineDescription { get; set; }
        public int? LogAttachmentId { get; set; }
        public TestLogLine ToTestLogLine()
        {
            return new TestLogLine
            {
                LogTimestamp = LogTimestamp,
                LogLineDescription = LogLineDescription,
            };
        }

        public TestLogLine ToTestLogLineWithAttachment()
        {
            return new TestLogLine
            {
                LogTimestamp = LogTimestamp,
                LogLineDescription = LogLineDescription,
                LogAttachmentId = LogAttachmentId
            };
        }
    }
    public class Report
    {
        private CreateReport _emptyReport;

        public void CreateEmptyReport()
        {
            _emptyReport = new CreateReport
            {
                TestRun = null,
                TemplateNameDocument = null,
                Testsuitename = null,
                ProjectTemplate = null,
                VersionDocument = 0
            };
        }
        public void CreateEmptyAASSSReport()
        {
            _emptyReport = new CreateReport
            {
                TestRun = null,
                TemplateNameDocument = null,
                Testsuitename = null,
                ProjectTemplate = null,
                VersionDocument = 0
            };
        }

        public void CreateReportLogline()
        {
            CreateTestLogline createTestLogline = new CreateTestLogline
            {
                LogAttachmentId = null,
                LogLineDescription = null,
                LogTimestamp = null
            };
        }
        public void CreateReportTestRun()
        {
            CreateTestRun createTestRun = new CreateTestRun
            {
                Operatingsystem = null,
                Test = null,
                Testenvironment = null,
                Testexecuter = null,
                Testmachine = null,
                Testname = null,
                TestrunNumber = 0
            };
        }
        public void CreateNewReport()
        {
            CreateReport createReport = new CreateReport
            {
                ProjectTemplate = null,
                TestRun = null,
                Testsuitename = null,
                VersionDocument = 0
            };
        }
    }

}
        //public void CreateReport()
        //{
        //    CreateReport createReport = new CreateReport
        //    {
        //        TemplateNameDocument = "HTMLDocument",
        //        VersionDocument = 1,
        //        ProjectTemplate = "BasicTestReport",
        //        Testsuitename = "First Test Report",
        //        TestRun = null
        //        //            TestRun = new TestRun
        //        //            {
        //        //               new CreateTestRun
        //        //               {
        //        //                TestrunNumber = 1,
        //        //                Testname = "test name",
        //        //                Testmachine = "test machine name",
        //        //                Testenvironment = "ci cd env",
        //        //                Testexecuter = "by who",
        //        //                Operatingsystem = "win32",
        //        //                Test = new List<Test>
        //        //                {
        //        //    //                new CreateTest
        //        //    //                {
        //        //    //                    TestCaseId = 1,
        //        //    //                    TestCaseName = "Test case name",
        //        //    //                    TestCategory = "FAT",
        //        //    //                    StartDateTime = "",
        //        //    //                    StopDateTime = "",
        //        //    //                    Duration = "10ms",
        //        //    //                    TestResult = "Passed",
        //        //    //                    TestLogLine = null
        //        //    //}
        //        //}
        //    }
        //}



