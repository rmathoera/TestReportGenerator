using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;


namespace TestReportGenerator._03_Importers.CommandLine
{
    internal class TRX_TestReport
    {
        public TRX_TestReport()
        {
            XslCompiledTransform xslCompiledTransform = new XslCompiledTransform();
        }

        internal static string Import_TRX_File(string trxfile)
        {
            throw new NotImplementedException();
        }

        internal static string Import_TRX_XSLT_File(string trxxsltfile)
        {
            throw new NotImplementedException();
        }

        internal static object? ToBaseJSON(string fullPathToFile)
        {
            throw new NotImplementedException();
        }

        internal static object? ToBaseXML(string fullPathToFile)
        {
            throw new NotImplementedException();
        }

        internal static object? ValidateTRX(string trxfile, string trxxsltfile)
        {
            throw new NotImplementedException();
        }
    }
}
