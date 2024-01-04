<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

  <xsl:template match="/">
    <html>
      <head>
        <title>Test Result</title>
      </head>
      <body>
        <h1>Test Result</h1>
        <xsl:apply-templates select="TestResult"/>
      </body>
      <style>
        .container {
        max-width: 1024px;
        margin: 0 auto;
        border: 1px solid #000;
        padding: 20px;
        }
        .row {
        margin-bottom: 10px;
        }
        .label {
        font-weight: bold;
        }
      </style>
      <style>
        table {
        width: 100%;
        border-collapse: collapse;
        }
        th, td {
        border: 1px solid #000;
        padding: 8px;
        text-align: left;
        }
        th {
        background-color: #f2f2f2;
        }
      </style>
    </html>
  </xsl:template>

  <xsl:template match="TestResult">
    <div>
      <div>
        Test Suite Name: <xsl:value-of select="Testsuitename"/>
      </div>
      <xsl:apply-templates select="TestRun"/>
    </div>
  </xsl:template>

  <xsl:template match="TestRun">
    <div>
      <p>
        Testname: <xsl:value-of select="Testname"/>
      </p>
      <h3>Tests</h3>
      <ul>
        <xsl:apply-templates select="Tests"/>
      </ul>
    </div>
  </xsl:template>

  <xsl:template match="Tests">
    <!--<xsl:for-each select="Test">-->
    <div class="container">
      <div class="row">
        <span class="label">Test Case Id : </span>
        <xsl:value-of select="TestCaseId"/>
        <span class="label">   Test Case Name : </span>
        <xsl:value-of select="TestCaseName"/>
        <span class="label">   Test Category : </span>
        <xsl:value-of select="TestCategory"/>
      </div>
      <div class="row">
        <span class="label">Start Date Time : </span>
        <xsl:value-of select="StartDateTime"/>
        <span class="label">   Stop Date Time : </span>
        <xsl:value-of select="StopDateTime"/>
      </div>
      <div class="row">
        <span class="label">Duration : </span>
        <xsl:value-of select="Duration"/>
        <!--<span class="label">   Test Result : </span>-->
        <!--<xsl:value-of select="TestResult"/>-->
        <span class="label">   Test Result : </span>
        <xsl:choose>
          <xsl:when test="TestResult='Failed'">
            <span style="color: red;">
              <xsl:value-of select="TestResult"/>
            </span>
          </xsl:when>
          <xsl:when test="TestResult='Passed'">
            <span style="color: green;">
              <xsl:value-of select="TestResult"/>
            </span>
          </xsl:when>
          <xsl:otherwise>
            <xsl:value-of select="TestResult"/>
          </xsl:otherwise>
        </xsl:choose>
      </div>
      <h4>Test Log Lines</h4>
      <table>
        <thead>
          <tr>
            <th>Log Timestamp</th>
            <th>Log Line Description</th>
            <th>Log Attachment Id</th>
          </tr>
        </thead>
        <xsl:apply-templates select="TestLogLine"/>
      </table>
    </div>
    <!--</xsl:for-each>-->
  </xsl:template>

  <xsl:template match="TestLogLine">
    <!--<xsl:for-each select="Test">-->
    <tbody>
      <tr>
        <td>
          <xsl:value-of select="Logtimestamp"/>
        </td>
        <td>
          <xsl:value-of select="LogLineDescription"/>
        </td>
        <td>
          <xsl:value-of select="LogAttachmentId"/>
        </td>
      </tr>
    </tbody>
    <!--</xsl:for-each>-->
  </xsl:template>

</xsl:stylesheet>
