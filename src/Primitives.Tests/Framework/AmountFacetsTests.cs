// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Globalization;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Amounts;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Framework;

namespace BeneficialStrategies.Iso20022;

/// <summary>
/// The amount types restrict their value (#13): not negative, a number of digits in all and after the decimal point. The limits
/// are those of the ISO 20022 repository (checked against the XSDs of the messages that use them).
/// </summary>
public class AmountFacetsTests
{
    // type name -> (total digits, fraction digits); every one has a minimum of 0 and no maximum
    public static readonly Dictionary<string, (int Total, int Fraction)> Expected = new()
    {
        ["ActiveCurrencyAnd13DecimalAmount"] = (18, 13),
        ["ActiveCurrencyAnd20Amount"] = (20, 19),
        ["ActiveCurrencyAnd24Amount"] = (24, 5),
        ["ActiveCurrencyAndAmount"] = (18, 5),
        ["ActiveOrHistoricCurrencyAnd13DecimalAmount"] = (18, 13),
        ["ActiveOrHistoricCurrencyAnd19DecimalAmount"] = (25, 19),
        ["ActiveOrHistoricCurrencyAnd20Amount"] = (20, 19),
        ["ActiveOrHistoricCurrencyAnd20DecimalAmount"] = (25, 20),
        ["ActiveOrHistoricCurrencyAndAmount"] = (18, 5),
        ["CurrencyAndAmount"] = (18, 5),
        ["RestrictedFINActiveCurrencyAnd13DecimalAmount"] = (14, 13),
        ["RestrictedFINActiveCurrencyAndAmount"] = (14, 5),
        ["RestrictedFINActiveOrHistoricCurrencyAnd13DecimalAmount"] = (14, 13),
        ["RestrictedFINActiveOrHistoricCurrencyAndAmount"] = (14, 5),
    };

    private static Type AmountType(string name) => typeof(ActiveCurrencyAndAmount).Assembly.GetType($"BeneficialStrategies.Iso20022.Amounts.{name}")!;

    public static IEnumerable<object[]> Types() => Expected.Keys.Select(k => new object[] { k });

    [Theory]
    [MemberData(nameof(Types))]
    public void EachAmountRecord_DeclaresTheFacetsOfItsIsoType(string name)
    {
        var facets = AmountType(name).GetProperty("Amount")!.GetCustomAttributes(typeof(IsoAmountAttribute), false).Cast<IsoAmountAttribute>().Single();

        Assert.Equal(Expected[name], (facets.TotalDigits, facets.FractionDigits));
    }

    [Fact]
    public void EveryAmountRecordOfThePackage_IsInTheTable()
    {
        var records = typeof(ActiveCurrencyAndAmount).Assembly.GetTypes()
            .Where(t => t.Namespace == "BeneficialStrategies.Iso20022.Amounts" && t.IsClass && typeof(IIsoAmount).IsAssignableFrom(t))
            .Select(t => t.Name);

        Assert.Empty(records.Where(n => !Expected.ContainsKey(n)));
    }

    [Theory]
    [MemberData(nameof(Types))]
    public void TheLimits_AreAcceptedExactly_AndOneBeyondIsNot(string name)
    {
        var (total, fraction) = Expected[name];
        var type = AmountType(name);
        var integerDigits = total - fraction;
        var largest = decimal.Parse(new string('9', integerDigits) + "." + new string('9', fraction), CultureInfo.InvariantCulture);
        var oneTooManyFractionDigits = decimal.Parse("0." + new string('1', fraction + 1), CultureInfo.InvariantCulture);
        // without a fraction the whole total may be integer digits (the XSD counts digits, not places); one more is too many
        var fullInteger = decimal.Parse(new string('9', total), CultureInfo.InvariantCulture);
        var oneTooManyIntegerDigits = decimal.Parse("1" + new string('0', total), CultureInfo.InvariantCulture);

        Assert.Equal(largest, IsoAmountFacets.Check(type, "Amount", largest));
        Assert.Equal(fullInteger, IsoAmountFacets.Check(type, "Amount", fullInteger));
        Assert.Equal(0m, IsoAmountFacets.Check(type, "Amount", 0m));
        Assert.Throws<Iso20022FormatException>(() => IsoAmountFacets.Check(type, "Amount", -0.01m));
        Assert.Throws<Iso20022FormatException>(() => IsoAmountFacets.Check(type, "Amount", oneTooManyFractionDigits));
        Assert.Throws<Iso20022FormatException>(() => IsoAmountFacets.Check(type, "Amount", oneTooManyIntegerDigits));
    }

    [Fact]
    public void TrailingZeros_DoNotCount_AsInTheXsd()
    {
        // 1.50000000 is the value 1.5: one fraction digit
        Assert.Equal(1.5m, IsoAmountFacets.Check(typeof(ActiveCurrencyAndAmount), "Amount", 1.500000000m));
    }

    [Fact]
    public void ConstructingARecord_WithAnAmountOutsideTheFacets_Throws()
    {
        var negative = Assert.Throws<Iso20022FormatException>(() => new ActiveCurrencyAndAmount { Currency = "EUR", Amount = -1m });
        Assert.Contains("not negative", negative.Message);
        Assert.Throws<Iso20022FormatException>(() => new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 1.234567m });
        Assert.Equal(1.23456m, new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 1.23456m }.Amount);
    }

    [Fact]
    public void AnAmountRecord_StillComparesByValue_AndSupportsWith()
    {
        var a = new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 10.50m };
        var b = new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 10.50m };

        Assert.Equal(a, b);
        Assert.NotEqual(a, a with { Amount = 10.51m });
        Assert.Throws<Iso20022FormatException>(() => a with { Amount = -1m });
    }

    // ── reading XML ─────────────────────────────────────────────────────────────

    private static string Describe(DeserializationResult<ActiveCurrencyAndAmount> result) => string.Join("; ", result.Issues);

    [Theory]
    [InlineData("-1", "not negative")]
    [InlineData("99999999999999999999999999", "at most 18 significant digits in total")]
    [InlineData("12.3456789012345678901234567890", "fraction digits")]
    [InlineData("0.123456", "at most 5 fraction digits")]
    public void ReadingAnAmountOutsideTheFacets_IsReportedAsAFacetViolation_WithItsPath(string text, string reason)
    {
        var element = XElement.Parse($"<InstdAmt xmlns=\"urn:test\" Ccy=\"EUR\">{text}</InstdAmt>");

        var result = Serialization.Iso20022XmlSerializer.Read<ActiveCurrencyAndAmount>(element);

        Assert.False(result.Succeeded);
        var issue = Assert.Single(result.Issues);
        Assert.Equal(Serialization.IssueCode.FacetViolation, issue.Code);
        Assert.Equal("InstdAmt", issue.Path);
        Assert.Equal(text, issue.Value);
        Assert.Contains(reason, issue.Reason);
    }

    [Theory]
    [InlineData("10.50")]
    [InlineData("0")]
    [InlineData("0.00001")]
    [InlineData("1.500000000")]
    [InlineData("999999999999999999")]
    public void ReadingAValidAmount_Succeeds(string text)
    {
        var element = XElement.Parse($"<InstdAmt xmlns=\"urn:test\" Ccy=\"EUR\">{text}</InstdAmt>");

        var result = Serialization.Iso20022XmlSerializer.Read<ActiveCurrencyAndAmount>(element);

        Assert.True(result.Succeeded, Describe(result));
        Assert.Equal(decimal.Parse(text, CultureInfo.InvariantCulture), result.Message!.Amount);
    }

    [Fact]
    public void ABadAmountAndABadCurrency_AreBothReported()
    {
        var element = XElement.Parse("<InstdAmt xmlns=\"urn:test\" Ccy=\"EURO\">-1</InstdAmt>");

        var result = Serialization.Iso20022XmlSerializer.Read<ActiveCurrencyAndAmount>(element);

        Assert.Equal(2, result.Issues.Count);
    }
}
