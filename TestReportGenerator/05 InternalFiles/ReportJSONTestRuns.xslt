<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

  <xsl:template match="/">
    <html>
      <head>
        <title>Test Run Details</title>
      </head>
      <body>
        <h1>Test Run Details</h1>
        <!--<xsl:apply-templates select="TestResult"/>-->
        <xsl:apply-templates select="TestResult/TestRun"/>
      </body>
    </html>
  </xsl:template>

  <xsl:template match="TestRun">
    <div>
      <h2>Test Run Details</h2>
      <p>
        TestrunNumber: <xsl:value-of select="TestrunNumber"/>
      </p>
      <p>
        Testname: <xsl:value-of select="Testname"/>
      </p>
      <p>
        Testmachine: <xsl:value-of select="Testmachine"/>
      </p>
      <p>
        Testenvironment: <xsl:value-of select="Testenvironment"/>
      </p>
      <p>
        Testexcuter: <xsl:value-of select="Testexcuter"/>
      </p>
      <p>
        Operatingsystem: <xsl:value-of select="Operatingsystem"/>
      </p>
      <!--<h4>Tests</h4>
      <xsl:apply-templates select="Tests"/>-->
    </div>
  </xsl:template>

</xsl:stylesheet>
