// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.pacs;
using BeneficialStrategies.Iso20022.Serialization;

namespace BeneficialStrategies.Iso20022;

/// <summary>An amount that breaks its facets is a <see cref="JsonException"/> from every JSON entry point (#77).</summary>
public class JsonAmountFacetTests
{
    private static string SampleJson(string amount)
    {
        var resource = "BeneficialStrategies.Iso20022.TestData.pacs.008.001.13_sample.xml";
        using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resource)!;
        var message = Iso20022XmlSerializer.Deserialize<FIToFICustomerCreditTransferV13>(XDocument.Load(stream));
        var node = JsonNode.Parse(Iso20022JsonSerializer.SerializeToString(message))!;
        node["credit_transfer_transaction_information"]![0]!["interbank_settlement_amount"]!["amount"] = amount;
        return node.ToJsonString();
    }

    [Theory]
    [InlineData("-1", "not negative")]
    [InlineData("99999999999999999999999999", "significant digits")]
    [InlineData("0.123456789012345678901234567890", "fraction digits")]
    public void Deserialize_AnAmountThatBreaksItsFacets_IsAJsonException(string amount, string rule)
    {
        var ex = Assert.Throws<JsonException>(() => Iso20022JsonSerializer.Deserialize<FIToFICustomerCreditTransferV13>(SampleJson(amount)));

        Assert.Contains(rule, ex.Message);
        Assert.IsType<Iso20022FormatException>(ex.InnerException);
    }

    [Theory]
    [InlineData("-1")]
    [InlineData("99999999999999999999999999")]
    [InlineData("0.123456789012345678901234567890")]
    public void TryDeserialize_AnAmountThatBreaksItsFacets_ReturnsFalseAndDoesNotThrow(string amount)
    {
        var ok = Iso20022JsonSerializer.TryDeserialize<FIToFICustomerCreditTransferV13>(SampleJson(amount), out var message, out var error);

        Assert.False(ok);
        Assert.Null(message);
        Assert.IsType<JsonException>(error);
    }

    [Fact]
    public void AValidAmount_StillReads() =>
        Assert.True(Iso20022JsonSerializer.TryDeserialize<FIToFICustomerCreditTransferV13>(SampleJson("47250.00"), out _, out _));
}
