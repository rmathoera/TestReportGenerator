using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Microsoft.VisualBasic;

namespace TestReportGenerator._03_Importers.CommandLine
{
    internal class TRX_TestReport
    {
        public static string? TRXXLSTFile { get; set; }
        public static string? TRXFile { get; set; }
        public static bool Result { get; set; }
        public TRX_TestReport()
        {
            XslCompiledTransform xslCompiledTransform = new XslCompiledTransform();
        }

        internal static string? Import_TRX_File(string trxfile)
        {
            try
            {
                if (trxfile == null)
                {
                    throw new Exception();
                }
                if (trxfile != null)
                {
                    TRXFile = trxfile;
                    XDocument trxDocument = XDocument.Load(trxfile);
                    var jsonResult = JsonConvert.SerializeXNode(trxDocument);
                    return jsonResult.ToString();
                }
                return null;
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        internal static void Import_TRX_XSLT_File(string trxxsltfile)
        {
            try
            {
                if (string.IsNullOrEmpty(trxxsltfile))
                {
                    throw new ArgumentNullException(nameof(trxxsltfile), "TRXXSLTFile cannot be null or empty.");
                }

                XslCompiledTransform xslt = new XslCompiledTransform();
                xslt.Load(trxxsltfile);

                TRXXLSTFile = trxxsltfile; // Assuming TRXXLSTFile is a global/static variable
                Result = true; // Assuming Result is a global/static variable to track success

                // Optionally, you might want to return a success indicator here or perform other actions
            }
            catch (ArgumentNullException ex)
            {
                // Handle ArgumentNullException (if required)
                // Log or throw a more specific exception based on your application logic
                throw;
            }
            catch (Exception ex)
            {
                // Handle other exceptions or log them appropriately
                throw new InvalidOperationException("Error importing TRXXSLTFile.", ex);
                // Or throw a more specific exception based on the situation
            }
        }

        internal static object? ToBaseJSON(string TRXFileName)
        {
            try
            {
                if (string.IsNullOrEmpty(TRXFileName))
                {
                    throw new ArgumentNullException(nameof(TRXFileName), "TRXFileName cannot be null or empty.");
                }

                if (TRXXLSTFile == null)
                {
                    throw new InvalidOperationException("TRXXLSTFile is not initialized.");
                }

                TRXFile = TRXFileName;

                if (TRXXLSTFile != null && TRXFile != null)
                {
                    XslCompiledTransform xslt = new XslCompiledTransform();
                    xslt.Load(TRXXLSTFile);

                    using (StringWriter sw = new StringWriter())
                    {
                        xslt.Transform(TRXFile, null, sw);
                        return JsonConvert.SerializeXNode(XDocument.Parse(sw.ToString()));
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                // Log or handle the exception appropriately
                throw new Exception("An error occurred in ToBaseJSON.", ex);
            }
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
