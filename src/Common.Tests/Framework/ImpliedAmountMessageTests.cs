// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Amounts;
using BeneficialStrategies.Iso20022.camt;
using BeneficialStrategies.Iso20022.Serialization;

namespace BeneficialStrategies.Iso20022;

/// <summary>An amount whose currency is implied by the context is a plain decimal on the wire, with no <c>Ccy</c> attribute (#22).</summary>
public class ImpliedAmountMessageTests
{
    // camt.062: CurrencyFactors1.ShortPositionLimit and MinimumPayInAmount are ImpliedCurrencyAndAmount.
    private static string Xml(string shortPositionLimit = "<ShrtPosLmt>100.50</ShrtPosLmt>") =>
        $"""
        <Document xmlns="urn:iso:std:iso:20022:tech:xsd:camt.062.001.03">
          <PayInSchdl>
            <PtyId><AnyBIC><AnyBIC>DEUTDEFF</AnyBIC></AnyBIC></PtyId>
            <RptData>
              <MsgId>M</MsgId><ValDt>2026-01-02</ValDt><DtAndTmStmp>2026-01-02T10:00:00</DtAndTmStmp><Tp>OFFI</Tp><SchdlTp>ABCD</SchdlTp>
            </RptData>
            <PayInFctrs>
              <AggtShrtPosLmt Ccy="EUR">5.00</AggtShrtPosLmt>
              <CcyFctrs>
                <Ccy>USD</Ccy>
                {shortPositionLimit}
                <MinPayInAmt>10</MinPayInAmt>
                <VoltlyMrgn>5</VoltlyMrgn>
              </CcyFctrs>
            </PayInFctrs>
          </PayInSchdl>
        </Document>
        """;

    [Fact]
    public void AnImpliedAmount_IsReadFromAPlainDecimal_AndWrittenWithoutCcy()
    {
        var result = Iso20022XmlSerializer.TryRead<PayInScheduleV03>(Xml());

        Assert.True(result.Succeeded, string.Join("\n", result.Issues));
        var factor = Assert.Single(result.Message!.PayInFactors!.CurrencyFactors);
        Assert.Equal(100.50m, factor.ShortPositionLimit.Value);
        Assert.Equal(10m, factor.MinimumPayInAmount.Value);

        var written = Iso20022XmlSerializer.SerializeToString(result.Message);
        Assert.Contains("<ShrtPosLmt>100.50</ShrtPosLmt>", written);
        Assert.Contains("<MinPayInAmt>10</MinPayInAmt>", written);
        Assert.DoesNotContain("<ShrtPosLmt Ccy", written);
        Assert.Contains("<AggtShrtPosLmt Ccy=\"EUR\">5.00</AggtShrtPosLmt>", written); // an amount that names its currency still does
    }

    [Theory]
    [InlineData("<ShrtPosLmt>-1</ShrtPosLmt>")]
    [InlineData("<ShrtPosLmt>1,000.50</ShrtPosLmt>")]
    [InlineData("<ShrtPosLmt> 7 </ShrtPosLmt>")]
    [InlineData("<ShrtPosLmt>1.1234567</ShrtPosLmt>")]
    [InlineData("<ShrtPosLmt>1234567890123456789</ShrtPosLmt>")]
    public void ABadImpliedAmount_IsReportedAtItsElement(string element)
    {
        var result = Iso20022XmlSerializer.TryRead<PayInScheduleV03>(Xml(element));

        Assert.False(result.Succeeded);
        var issue = Assert.Single(result.Issues);
        Assert.Equal("Document/PayInSchdl/PayInFctrs/CcyFctrs[1]/ShrtPosLmt", issue.Path);
        Assert.Equal(IssueCode.FacetViolation, issue.Code);
    }

    [Fact]
    public void AVariantThatHoldsAnImpliedAmount_ReadsAndWritesLikeAnyOtherSimpleVariant()
    {
        var variant = new Choices.Amount2Choice.AmountWithoutCurrency { Value = 100.5m };
        Assert.Equal(100.5m, variant.Value.Value);
        Assert.Equal(typeof(RestrictedFINImpliedCurrencyAndAmount), typeof(Choices.FinancialInstrumentQuantity36Choice.FaceAmount).GetProperty("Value")!.PropertyType);
        Assert.Null(typeof(Choices.Amount2Choice.AmountWithoutCurrency).GetProperty("Currency"));
    }
}
