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
        }
      </style>
    </html>
  </xsl:template>

  <xsl:template match="TestResult">
    <table>
      <tr>
        <td class="bold">Template Name Document : </td>
        <td>
          <xsl:value-of select="TemplateNameDocument"/>
        </td>
      </tr>
      <tr>
        <td class="bold">Project Template : </td>
        <td>
          <xsl:value-of select="ProjectTemplate"/>
        </td>
      </tr>
      <tr>
        <td class="bold">Version Document : </td>
        <td>
          <xsl:value-of select="VersionDocument"/>
        </td>
      </tr>
      <tr>
        <td class="bold">Test Suitename : </td>
        <td>
          <xsl:value-of select="Testsuitename"/>
        </td>
      </tr>
    </table>
  </xsl:template>

</xsl:stylesheet>
