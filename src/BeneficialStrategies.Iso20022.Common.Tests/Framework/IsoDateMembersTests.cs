// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

#pragma warning disable CS0612 // ReportData1 is obsolete in the ISO catalogue; camt.061 is built on it

using BeneficialStrategies.Iso20022.camt;
using BeneficialStrategies.Iso20022.SimpleTypes;
using BeneficialStrategies.Iso20022.Serialization;

namespace BeneficialStrategies.Iso20022;

/// <summary>A record member of the ISO 20022 type ISODate is an <see cref="ISODate"/>: <c>YYYY-MM-DD</c>, nothing else (#33).</summary>
public class IsoDateMembersTests
{
    private static string Xml(string valDt) =>
        $"""
        <Document xmlns="urn:iso:std:iso:20022:tech:xsd:camt.061.001.01">
          <PayInCall>
            <PtyId><BICOrBEI><BICOrBEI>DEUTDEFF</BICOrBEI></BICOrBEI></PtyId>
            <RptData>
              <MsgId>M</MsgId>
              <ValDt>{valDt}</ValDt>
              <DtAndTmStmp>2026-01-02T10:00:00</DtAndTmStmp>
              <Tp>CFAV</Tp>
              <PayInCallAmt><Amt Ccy="EUR">10.50</Amt></PayInCallAmt>
            </RptData>
          </PayInCall>
        </Document>
        """;

    [Fact]
    public void ADate_IsReadAsAnISODate_AndWrittenBackAsTheSameText()
    {
        var result = Iso20022XmlSerializer.TryRead<PayInCallV01>(Xml("2026-01-02"));

        Assert.True(result.Succeeded, string.Join("\n", result.Issues));
        ISODate date = result.Message!.ReportData.ValueDate;
        Assert.Equal(new DateOnly(2026, 1, 2), date.Value);
        Assert.Contains("<ValDt>2026-01-02</ValDt>", Iso20022XmlSerializer.SerializeToString(result.Message));
    }

    [Theory]
    [InlineData("2026-01-02Z")] // the format has no timezone
    [InlineData("2026-01-02+01:00")]
    [InlineData("01/02/2026")]
    [InlineData("2026-1-2")]
    [InlineData("2026-01-02T00:00:00")]
    [InlineData(" 2026-01-02")]
    [InlineData("2026-02-30")]
    public void ATextThatIsNotYyyyMmDd_IsReportedAtTheElement_NotThrown(string text)
    {
        var result = Iso20022XmlSerializer.TryRead<PayInCallV01>(Xml(text));

        Assert.False(result.Succeeded);
        var issue = Assert.Single(result.Issues);
        Assert.Equal("Document/PayInCall/RptData/ValDt", issue.Path);
        Assert.Equal(text, issue.Value);
        Assert.Equal(IssueCode.FacetViolation, issue.Code);
    }

    [Fact]
    public void TheOldReader_RefusesTheSameTextsWithAnIso20022FormatException_NotARawFormatException()
    {
        var ex = Record.Exception(() => Iso20022XmlSerializer.Deserialize<PayInCallV01>(Xml("2026-01-02Z")));
        Assert.NotNull(ex);
        Assert.IsNotType<FormatException>(ex);
    }
}
