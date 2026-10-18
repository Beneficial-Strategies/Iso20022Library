// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

#pragma warning disable CS0612 // ReportData1 is obsolete in the ISO catalogue; camt.061 is built on it

using System.Reflection;
using BeneficialStrategies.Iso20022.Amounts;
using BeneficialStrategies.Iso20022.camt;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Choices.ProfitAndLoss2Choice;
using BeneficialStrategies.Iso20022.Serialization;

namespace BeneficialStrategies.Iso20022;

/// <summary>
/// Issue #8: the currency of an amount (the <c>Ccy</c> attribute) is typed with the code set the
/// specification names for that amount type, so a bad code is rejected on read and cannot be built.
/// </summary>
public class AmountCurrencyTests
{
    private const string Ns = "urn:iso:std:iso:20022:tech:xsd:camt.061.001.01";

    // camt.061's PayInCallAmt/Amt is an ActiveOrHistoricCurrencyAndAmount.
    private static string Xml(string amountElement) =>
        $"""
        <Document xmlns="{Ns}"><PayInCall>
          <PtyId><BICOrBEI><BICOrBEI>DEUTDEFF</BICOrBEI></BICOrBEI></PtyId>
          <RptData>
            <MsgId>M</MsgId><ValDt>2026-01-02</ValDt><DtAndTmStmp>2026-01-02T10:00:00</DtAndTmStmp><Tp>CFAV</Tp>
            <PayInCallAmt>{amountElement}</PayInCallAmt>
          </RptData>
        </PayInCall></Document>
        """;

    // From the ISO 20022 data dictionary: the currencyIdentifierSet of each amount type.
    private static readonly Dictionary<string, Type> CodeSetOf = new()
    {
        [nameof(ActiveCurrencyAnd13DecimalAmount)] = typeof(ActiveCurrencyCode),
        [nameof(ActiveCurrencyAnd20Amount)] = typeof(ActiveCurrencyCode),
        [nameof(ActiveCurrencyAnd24Amount)] = typeof(ActiveCurrencyCode),
        [nameof(ActiveCurrencyAndAmount)] = typeof(ActiveCurrencyCode),
        [nameof(ActiveOrHistoricCurrencyAnd19DecimalAmount)] = typeof(ActiveCurrencyCode), // the dictionary says Active, not ActiveOrHistoric
        [nameof(RestrictedFINActiveCurrencyAndAmount)] = typeof(ActiveCurrencyCode),
        [nameof(RestrictedFINActiveCurrencyAnd13DecimalAmount)] = typeof(ActiveCurrencyCode),
        [nameof(ActiveOrHistoricCurrencyAnd13DecimalAmount)] = typeof(ActiveOrHistoricCurrencyCode),
        [nameof(ActiveOrHistoricCurrencyAnd20Amount)] = typeof(ActiveOrHistoricCurrencyCode),
        [nameof(ActiveOrHistoricCurrencyAnd20DecimalAmount)] = typeof(ActiveOrHistoricCurrencyCode),
        [nameof(ActiveOrHistoricCurrencyAndAmount)] = typeof(ActiveOrHistoricCurrencyCode),
        [nameof(RestrictedFINActiveOrHistoricCurrencyAnd13DecimalAmount)] = typeof(ActiveOrHistoricCurrencyCode),
        [nameof(RestrictedFINActiveOrHistoricCurrencyAndAmount)] = typeof(ActiveOrHistoricCurrencyCode),
        [nameof(CurrencyAndAmount)] = typeof(CurrencyCode),
    };

    // No currency identifier set in the dictionary (see #22), or not in the dictionary at all. They stay strings.
    private static readonly string[] StillStrings =
    [
        nameof(ImpliedCurrencyAndAmount),
        nameof(ImpliedCurrencyAnd20Amount),
        nameof(RestrictedFINImpliedCurrencyAndAmount),
        nameof(EuroMax9Amount),
        nameof(EuroMax15Amount),
        nameof(Restricted15DigitCurrencyAndAmount),
        nameof(CurrencyAnd30Amount),
    ];

    private static IEnumerable<Type> AmountTypes() =>
        typeof(ActiveCurrencyAndAmount).Assembly.GetTypes().Where(t => t.Namespace == typeof(ActiveCurrencyAndAmount).Namespace && t.IsClass);

    [Fact]
    public void Every_amount_type_is_accounted_for()
    {
        var names = AmountTypes().Select(t => t.Name).Order().ToArray();

        Assert.Equal(CodeSetOf.Keys.Concat(StillStrings).Order(), names);
    }

    [Fact]
    public void Each_amount_type_has_the_code_type_of_its_currency_identifier_set()
    {
        foreach (var type in AmountTypes().Where(t => CodeSetOf.ContainsKey(t.Name)))
            Assert.Equal(CodeSetOf[type.Name], type.GetProperty("Currency")!.PropertyType);
    }

    [Fact]
    public void A_choice_variant_that_repeats_an_amount_has_the_same_code_type()
    {
        Assert.Equal(typeof(ActiveCurrencyCode), typeof(Loss).GetProperty("Currency")!.PropertyType);
    }

    [Theory]
    [InlineData("abc")]
    [InlineData("eur")]
    [InlineData("EURO")]
    [InlineData("   ")]
    public void A_currency_that_is_not_a_code_cannot_be_built(string bad)
    {
        Assert.Throws<Iso20022FormatException>(() => new ActiveOrHistoricCurrencyAndAmount { Currency = bad, Amount = 1m });
    }

    [Fact]
    public void A_currency_given_as_text_still_compiles_and_compares_as_text()
    {
        var amount = new ActiveOrHistoricCurrencyAndAmount { Currency = "EUR", Amount = 1m };

        string text = amount.Currency;

        Assert.Equal("EUR", text);
        Assert.True(amount.Currency == "EUR");
    }

    [Theory]
    [InlineData("<Amt Ccy=\"\">10.50</Amt>", IssueCode.RequiredMissing)]
    [InlineData("<Amt>10.50</Amt>", IssueCode.RequiredMissing)]
    [InlineData("<Amt Ccy=\"abc\">10.50</Amt>", IssueCode.FacetViolation)]
    [InlineData("<Amt Ccy=\"   \">10.50</Amt>", IssueCode.FacetViolation)]
    [InlineData("<Amt Ccy=\"EURO\">10.50</Amt>", IssueCode.FacetViolation)]
    public void The_reader_reports_a_bad_or_missing_currency_with_its_path(string amount, IssueCode expected)
    {
        var result = Iso20022XmlSerializer.TryRead<PayInCallV01>(Xml(amount));

        var issue = Assert.Single(result.Issues);
        Assert.Equal("Document/PayInCall/RptData/PayInCallAmt[1]/Amt/@Ccy", issue.Path);
        Assert.Equal(expected, issue.Code);
    }

    [Fact]
    public void A_very_long_currency_is_reported_not_accepted()
    {
        var result = Iso20022XmlSerializer.TryRead<PayInCallV01>(Xml($"<Amt Ccy=\"{new string('X', 5000)}\">10.50</Amt>"));

        Assert.Equal(IssueCode.FacetViolation, Assert.Single(result.Issues).Code);
    }

    [Theory]
    [InlineData("<Amt Ccy=\"\">10.50</Amt>")]
    [InlineData("<Amt>10.50</Amt>")]
    [InlineData("<Amt Ccy=\"abc\">10.50</Amt>")]
    [InlineData("<Amt Ccy=\"   \">10.50</Amt>")]
    public void The_old_reader_rejects_them_too(string amount)
    {
        var ok = Iso20022XmlSerializer.TryDeserialize<PayInCallV01>(Xml(amount), out var message, out var error);

        Assert.False(ok);
        Assert.Null(message);
        Assert.NotNull(error);
    }

    [Fact]
    public void A_valid_currency_is_read_and_written_back()
    {
        var read = Iso20022XmlSerializer.TryRead<PayInCallV01>(Xml("<Amt Ccy=\"EUR\">10.50</Amt>"));

        Assert.True(read.Succeeded, string.Join("\n", read.Issues));
        var amount = read.Message!.ReportData.PayInCallAmount[0].Amount;
        Assert.Equal("EUR", amount.Currency);
        Assert.Contains("Ccy=\"EUR\"", Iso20022XmlSerializer.SerializeToString(read.Message));
    }
}
