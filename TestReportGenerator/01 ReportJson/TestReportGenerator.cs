namespace TestReportGenerator
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using System.Text.Json;

    public class TestLogLine
    {
        public string? LogTimestamp { get; set; }
        public string? LogLineDescription { get; set; }
        public int? LogAttachmentId { get; set; }
    }

    public class Test
    {
        public int? TestCaseId { get; set; }
        public string? TestCaseName { get; set; }
        public string? TestCategory { get; set; }
        public string? StartDateTime { get; set; }
        public string? StopDateTime { get; set; }
        public string? Duration { get; set; }
        public string? TestResult { get; set; }
        public List<TestLogLine>? TestLogLine { get; set; }
    }

    public class TestRun
    {
        public int? TestrunNumber { get; set; }
        public string? Testname { get; set; }
        public string? Testmachine { get; set; }
        public string? Testenvironment { get; set; }
        public string? Testexecuter { get; set; }
        public string? Operatingsystem { get; set; }
        public List<Test>? Test { get; set; }
    }

    public class TestReport
    {
        public string? TemplateNameDocument { get; set; }
        public string? ProjectTemplate { get; set; }
        public int? VersionDocument { get; set; }
        public string? Testsuitename { get; set; }
        public TestRun? TestRun { get; set; }
        // Method to convert object to JSON with specific settings or modifications
        public string ToJson(bool includeNullValues = false)
        {
            var settings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented
            };

            if (!includeNullValues)
            {
                settings.NullValueHandling = NullValueHandling.Ignore;
            }

            return JsonConvert.SerializeObject(this, settings);
        }
        public string ToString()
        {
            return (this.ToString());
        }
    }
}