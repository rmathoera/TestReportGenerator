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
        .bold{
        font-weight: bold;
      </style>
    </html>
  </xsl:template>

  <xsl:template match="TestRun">
    <table>
      <tr>
        <td class="bold">Test Run Number : </td>
        <td>
          <xsl:value-of select="TestrunNumber"/>
        </td>
      </tr>
      <tr>
        <td class="bold">Test Name : </td>
        <td>
          <xsl:value-of select="Testname"/>
        </td>
      </tr>
      <tr>
        <td class="bold">Test Machine : </td>
        <td>
          <xsl:value-of select="Testmachine"/>
        </td>
      </tr>
      <tr>
        <td class="bold">Test Environment : </td>
        <td>
          <xsl:value-of select="Testenvironment"/>
        </td>
      </tr>
      <tr>
        <td class="bold">Test Executer : </td>
        <td>
          <xsl:value-of select="Testexcuter"/>
        </td>
      </tr>
      <tr>
        <td class="bold">Operatingsystem : </td>
        <td>
          <xsl:value-of select="Operatingsystem"/>
        </td>
      </tr>
    </table>
  </xsl:template>

</xsl:stylesheet>
