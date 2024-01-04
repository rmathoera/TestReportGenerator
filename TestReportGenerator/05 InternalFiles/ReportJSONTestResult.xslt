<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

  <xsl:template match="/">
    <html>
      <head>
        <title>Test Result Detailst</title>
      </head>
      <body>
        <h1>Test Result</h1>
        <xsl:apply-templates select="TestResult"/>
      </body>
    </html>
  </xsl:template>

  <xsl:template match="TestResult">
    <div>
      <h2>Test Result Details</h2>
      <p>
        TemplateNameDocument: <xsl:value-of select="TemplateNameDocument"/>
      </p>
      <p>
        ProjectTemplate: <xsl:value-of select="ProjectTemplate"/>
      </p>
      <p>
        VersionDocument: <xsl:value-of select="VersionDocument"/>
      </p>
      <p>
        Testsuitename: <xsl:value-of select="Testsuitename"/>
      </p>
      <!--<h3>Test Runs</h3>
      <xsl:apply-templates select="TestRun"/>-->
    </div>
  </xsl:template>

</xsl:stylesheet>
