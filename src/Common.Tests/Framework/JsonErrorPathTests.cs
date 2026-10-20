// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.camt;
using BeneficialStrategies.Iso20022.Serialization;

namespace BeneficialStrategies.Iso20022;

/// <summary>A JSON read error says where it is, also inside lists, and a choice without its discriminator is a <see cref="JsonException"/> (#79).</summary>
public class JsonErrorPathTests
{
    private static JsonNode Statement()
    {
        using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("BeneficialStrategies.Iso20022.TestData.camt.053.001.11_sample.xml")!;
        var message = Iso20022XmlSerializer.Deserialize<BankToCustomerStatementV11>(XDocument.Load(stream));
        return JsonNode.Parse(Iso20022JsonSerializer.SerializeToString(message))!;
    }

    [Fact]
    public void ABadValueInsideTwoNestedLists_NamesTheWholePath()
    {
        var json = Statement();
        json["statement"]![0]!["entry"]![1]!["amount"]!["currency"] = "xx";

        var ex = Assert.Throws<JsonException>(() => Iso20022JsonSerializer.Deserialize<BankToCustomerStatementV11>(json.ToJsonString()));

        Assert.Equal("$.statement[0].entry[1].amount.currency", ex.Path);
        Assert.Contains("$.statement[0].entry[1].amount.currency", ex.Message);
        Assert.Contains("ActiveOrHistoricCurrencyCode", ex.Message);
    }

    [Fact]
    public void TryDeserialize_ReturnsTheSameError()
    {
        var json = Statement();
        json["statement"]![0]!["balance"]![0]!["amount"]!["currency"] = "xx";

        var ok = Iso20022JsonSerializer.TryDeserialize<BankToCustomerStatementV11>(json.ToJsonString(), out _, out var error);

        Assert.False(ok);
        Assert.Equal("$.statement[0].balance[0].amount.currency", Assert.IsType<JsonException>(error).Path);
    }

    [Fact]
    public void AValueOutsideAnyList_KeepsItsPath()
    {
        var json = Statement();
        json["group_header"]!["creation_date_time"] = "2026-13-45";

        var ex = Assert.Throws<JsonException>(() => Iso20022JsonSerializer.Deserialize<BankToCustomerStatementV11>(json.ToJsonString()));

        Assert.Equal("$.group_header.creation_date_time", ex.Path);
    }

    [Fact]
    public void AChoiceWithoutItsDiscriminator_IsAJsonException()
    {
        var json = Statement();
        ((JsonObject)json["statement"]![0]!["account"]!["identification"]!).Remove("$type");

        var ex = Assert.Throws<JsonException>(() => Iso20022JsonSerializer.Deserialize<BankToCustomerStatementV11>(json.ToJsonString()));

        Assert.IsType<NotSupportedException>(ex.InnerException);
        Assert.False(Iso20022JsonSerializer.TryDeserialize<BankToCustomerStatementV11>(json.ToJsonString(), out _, out var error));
        Assert.IsType<JsonException>(error);
    }
}
