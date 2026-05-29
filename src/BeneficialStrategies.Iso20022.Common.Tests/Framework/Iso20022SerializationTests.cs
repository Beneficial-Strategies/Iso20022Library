// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json;
using BeneficialStrategies.Iso20022.Amounts;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Serialization;

namespace BeneficialStrategies.Iso20022;

/// <summary>
/// Tests for <see cref="Iso20022JsonNamingPolicy"/>, <see cref="Iso20022EnumJsonConverter{T}"/>,
/// <see cref="Iso20022DecimalJsonConverter"/>, and <see cref="Iso20022JsonSerializerOptions"/>.
/// </summary>
public class Iso20022SerializationTests
{
    // ── Iso20022JsonNamingPolicy ──────────────────────────────────────────────

    [Theory]
    [InlineData("GroupHeader",           "group_header")]
    [InlineData("MessageIdentification", "message_identification")]
    [InlineData("CreationDateTime",      "creation_date_time")]
    [InlineData("BIC",                   "bic")]           // all-caps acronym — no underscores
    [InlineData("IBAN",                  "iban")]
    [InlineData("XMLParser",             "xml_parser")]    // acronym followed by word
    [InlineData("Amount",                "amount")]
    [InlineData("Currency",              "currency")]
    [InlineData("Id",                    "id")]
    public void NamingPolicy_ConvertsToSnakeCase(string input, string expected)
    {
        Assert.Equal(expected, Iso20022JsonNamingPolicy.Instance.ConvertName(input));
    }

    // ── Iso20022EnumJsonConverter<T> ─────────────────────────────────────────

    [Fact]
    public void EnumConverter_WritesEnumMemberWireCode()
    {
        var opts = new JsonSerializerOptions
        {
            Converters = { new Iso20022EnumJsonConverter<CreditDebitCode>() },
        };

        Assert.Equal("\"CRDT\"", JsonSerializer.Serialize(CreditDebitCode.Credit, opts));
        Assert.Equal("\"DBIT\"", JsonSerializer.Serialize(CreditDebitCode.Debit, opts));
    }

    [Fact]
    public void EnumConverter_ReadsEnumMemberWireCode()
    {
        var opts = new JsonSerializerOptions
        {
            Converters = { new Iso20022EnumJsonConverter<CreditDebitCode>() },
        };

        Assert.Equal(CreditDebitCode.Credit, JsonSerializer.Deserialize<CreditDebitCode>("\"CRDT\"", opts));
        Assert.Equal(CreditDebitCode.Debit,  JsonSerializer.Deserialize<CreditDebitCode>("\"DBIT\"", opts));
    }

    [Fact]
    public void EnumConverter_UnknownWireCode_ThrowsJsonException()
    {
        var opts = new JsonSerializerOptions
        {
            Converters = { new Iso20022EnumJsonConverter<CreditDebitCode>() },
        };

        Assert.Throws<JsonException>(() => JsonSerializer.Deserialize<CreditDebitCode>("\"XXXX\"", opts));
    }

    [Fact]
    public void EnumConverter_RoundTrips()
    {
        var opts = new JsonSerializerOptions
        {
            Converters = { new Iso20022EnumJsonConverter<CreditDebitCode>() },
        };

        foreach (CreditDebitCode value in Enum.GetValues<CreditDebitCode>())
        {
            var json = JsonSerializer.Serialize(value, opts);
            Assert.Equal(value, JsonSerializer.Deserialize<CreditDebitCode>(json, opts));
        }
    }

    // ── Iso20022DecimalJsonConverter ──────────────────────────────────────────

    [Fact]
    public void DecimalConverter_WritesAsString()
    {
        var opts = new JsonSerializerOptions
        {
            Converters = { Iso20022DecimalJsonConverter.Instance },
        };

        Assert.Equal("\"47250.00\"", JsonSerializer.Serialize(47250.00m, opts));
    }

    [Fact]
    public void DecimalConverter_ReadsFromString()
    {
        var opts = new JsonSerializerOptions
        {
            Converters = { Iso20022DecimalJsonConverter.Instance },
        };

        Assert.Equal(47250.00m, JsonSerializer.Deserialize<decimal>("\"47250.00\"", opts));
    }

    [Fact]
    public void DecimalConverter_ReadsFromNumber_ForCompatibility()
    {
        var opts = new JsonSerializerOptions
        {
            Converters = { Iso20022DecimalJsonConverter.Instance },
        };

        Assert.Equal(47250.00m, JsonSerializer.Deserialize<decimal>("47250.00", opts));
    }

    [Fact]
    public void DecimalConverter_PreservesTrailingZeros()
    {
        var opts = new JsonSerializerOptions
        {
            Converters = { Iso20022DecimalJsonConverter.Instance },
        };

        // Financial amounts must not lose precision information
        Assert.Equal("\"1.000\"", JsonSerializer.Serialize(1.000m, opts));
    }

    // ── Amounts — special case: Currency + decimal Amount ────────────────────

    [Fact]
    public void Default_Amount_CurrencySerializesAsString_AmountSerializesAsString()
    {
        var amount = new ActiveOrHistoricCurrencyAndAmount
        {
            Currency = "EUR",
            Amount   = 47250.00m,
        };

        var json = JsonSerializer.Serialize(amount, Iso20022JsonSerializerOptions.Default);

        // Both the currency code and the amount value must be JSON strings (not a number)
        // per ISO 20022 JSON binding spec rule 4b.
        Assert.Contains("\"currency\":\"EUR\"", json.Replace(" ", ""));
        Assert.Contains("\"amount\":\"47250.00\"", json.Replace(" ", ""));
    }

    [Fact]
    public void Default_Amount_RoundTrips()
    {
        var original = new ActiveOrHistoricCurrencyAndAmount
        {
            Currency = "USD",
            Amount   = 1_000_000.50m,
        };

        var json   = JsonSerializer.Serialize(original, Iso20022JsonSerializerOptions.Default);
        var result = JsonSerializer.Deserialize<ActiveOrHistoricCurrencyAndAmount>(json, Iso20022JsonSerializerOptions.Default);

        Assert.NotNull(result);
        Assert.Equal(original.Currency, result.Currency);
        Assert.Equal(original.Amount,   result.Amount);
    }

    // ── Iso20022JsonSerializerOptions.Default — combined behaviour ────────────

    [Fact]
    public void Default_IsReadOnly()
    {
        Assert.True(Iso20022JsonSerializerOptions.Default.IsReadOnly);
    }

    [Fact]
    public void Default_UsesSnakeCaseNamingPolicy()
    {
        Assert.IsType<Iso20022JsonNamingPolicy>(
            Iso20022JsonSerializerOptions.Default.PropertyNamingPolicy);
    }

    [Fact]
    public void Default_EnumSerializesAsWireCode()
    {
        // A component with an enum property should serialize the ISO wire code,
        // not the C# member name, under Default options.
        var record = new { Value = CreditDebitCode.Credit };

        var json = JsonSerializer.Serialize(record, Iso20022JsonSerializerOptions.Default);

        Assert.Contains("\"CRDT\"", json);
        Assert.DoesNotContain("\"Credit\"", json);
    }
}
