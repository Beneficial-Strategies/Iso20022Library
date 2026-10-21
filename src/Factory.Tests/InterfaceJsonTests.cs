// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json;
using System.Text.Json.Nodes;

namespace BeneficialStrategies.Iso20022.Factory;

/// <summary>The interfaces of the model read and write as JSON in the shape of the records, with the objects made by the factory (#70).</summary>
public class InterfaceJsonTests
{
    private static readonly IsoDataFactory Factory = new();

    private static readonly JsonSerializerOptions Options = Build(Iso20022JsonSerializerOptions.Default);

    private static JsonSerializerOptions Build(JsonSerializerOptions basis)
    {
        var options = new JsonSerializerOptions(basis);
        options.Converters.Add(new Iso20022InterfaceJsonConverterFactory(Factory));
        return options;
    }

    private static IMultilateralSettlementRequestV02 ReadXml() =>
        Iso20022XmlSerializer.TryRead<IMultilateralSettlementRequestV02>(Golden.Xml, Factory).Message!;

    [Fact]
    public void AMessageOfTheFactory_IsWrittenAsTheRecordsWriteIt()
    {
        var fromInterface = JsonSerializer.Serialize(ReadXml(), Options);

        Assert.True(JsonNode.DeepEquals(JsonNode.Parse(Golden.Json), JsonNode.Parse(fromInterface)), fromInterface);
    }

    [Fact]
    public void AnInterfaceReadFromTheJsonOfARecord_IsTheObjectReadFromTheXmlOfARecord()
    {
        var viaJson = JsonSerializer.Deserialize<IMultilateralSettlementRequestV02>(Golden.Json, Options)!;

        Assert.Equal(ReadXml(), viaJson);
        Assert.Equal(2, viaJson.SettlementRequest.Single().MovementRecord.Count());
    }

    [Fact]
    public void AChoice_IsWrittenWithItsVariantAndReadBackIntoTheSameVariant()
    {
        var choice = Iso20022XmlSerializer.Read<IAccountIdentification4Choice>(
            XElement.Parse("<Id xmlns=\"urn:test\"><Othr><Id>ABC-1</Id><Issr>BANK</Issr></Othr></Id>"), factory: Factory).Message!;

        var json = JsonSerializer.Serialize(choice, Options);
        var back = JsonSerializer.Deserialize<IAccountIdentification4Choice>(json, Options)!;

        Assert.Equal("Other", JsonNode.Parse(json)!["$type"]!.GetValue<string>());
        Assert.Equal(choice, back);
        Assert.Equal("BANK", Assert.IsAssignableFrom<Choices.AccountIdentification4Choice.IOther>(back).Issuer!.Value.Value);
    }

    [Fact]
    public void AChoiceWithoutItsVariant_IsAJsonExceptionThatSaysWhatIsExpected()
    {
        var ex = Assert.Throws<JsonException>(() => JsonSerializer.Deserialize<IAccountIdentification4Choice>("{\"value\":\"x\"}", Options));
        Assert.Contains("$type", ex.Message);

        ex = Assert.Throws<JsonException>(() => JsonSerializer.Deserialize<IAccountIdentification4Choice>("{\"$type\":\"Nope\"}", Options));
        Assert.Contains("Other", ex.Message);
    }

    [Fact]
    public void ABadValue_IsAJsonExceptionThatNamesTheMember()
    {
        var json = JsonNode.Parse(Golden.Json)!;
        json["group_header"]!["creation_date_time"] = "2026-13-45";

        var ex = Assert.Throws<JsonException>(() => JsonSerializer.Deserialize<IMultilateralSettlementRequestV02>(json.ToJsonString(), Options));

        Assert.Contains("creation_date_time", ex.Message);
    }

    [Fact]
    public void ARequiredMemberThatIsMissing_IsAJsonException()
    {
        var json = JsonNode.Parse(Golden.Json)!;
        ((JsonObject)json).Remove("group_header");

        var ex = Assert.Throws<JsonException>(() => JsonSerializer.Deserialize<IMultilateralSettlementRequestV02>(json.ToJsonString(), Options));

        Assert.Contains("group_header", ex.Message);
    }

    [Fact]
    public void AnAbsentList_IsEmpty()
    {
        var json = JsonNode.Parse(Golden.Json)!;
        ((JsonObject)json["settlement_request"]![0]!).Remove("movement_record");

        var message = JsonSerializer.Deserialize<IMultilateralSettlementRequestV02>(json.ToJsonString(), Options)!;

        Assert.Empty(message.SettlementRequest.Single().MovementRecord);
    }

    [Fact]
    public void TheNamesFollowTheOptionsOfTheCaller()
    {
        var camel = Build(new JsonSerializerOptions(Iso20022JsonSerializerOptions.Default) { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
        var message = ReadXml();

        var json = JsonSerializer.Serialize(message, camel);

        Assert.NotNull(JsonNode.Parse(json)!["groupHeader"]);
        Assert.Equal(message, JsonSerializer.Deserialize<IMultilateralSettlementRequestV02>(json, camel));
    }
}
