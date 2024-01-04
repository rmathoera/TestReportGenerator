<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

  <xsl:template match="/">
    <html>
      <head>
        <title>Tests</title>
      </head>
      <body>
        <h1>Tests</h1>
        <xsl:apply-templates select="TestResult/TestRun/Tests"/>
      </body>
    </html>
  </xsl:template>

  <xsl:template match="Tests">
      <xsl:for-each select="Tests">
          <p>
            TestCaseId: <xsl:value-of select="TestCaseId"/>
          </p>
          <p>
            TestCaseName: <xsl:value-of select="TestCaseName"/>
          </p>
          <p>
            TestCategory: <xsl:value-of select="TestCategory"/>
          </p>
          <p>
            StartDateTime: <xsl:value-of select="StartDateTime"/>
          </p>
          <p>
            StopDateTime: <xsl:value-of select="StopDateTime"/>
          </p>
          <p>
            Duration: <xsl:value-of select="Duration"/>
          </p>
          <p>
            TestResult: <xsl:value-of select="TestResult"/>
          </p>
      </xsl:for-each>
  </xsl:template>

</xsl:stylesheet>
