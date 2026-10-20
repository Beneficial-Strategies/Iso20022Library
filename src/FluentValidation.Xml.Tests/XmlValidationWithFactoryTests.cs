// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation;

/// <summary>The same extensions, reading into the interface with the objects of a factory: no record is named.</summary>
public class XmlValidationWithFactoryTests
{
    private static readonly Factory.IsoDataFactory Factory = new();
    private readonly IValidator<IMultilateralSettlementRequestV02> _sut = new MultilateralSettlementRequestV02Validator();

    private static MultilateralSettlementRequestV02 ValidMessage() =>
        new()
        {
            GroupHeader = new GroupHeader104
            {
                MessageIdentification = "MSG-001",
                CreationDateTime = new DateTime(2026, 1, 1),
                NumberOfSettlementRequests = "1",
            },
            SettlementRequest =
            [
                new MultilateralSettlementRequest3
                {
                    InstructionIdentification = "INSTR-001",
                    MovementRecord =
                    [
                        new MovementRecord2
                        {
                            Amount = new AmountAndDirection5 { Amount = new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 100m } },
                            Identification = "MOV-001",
                        },
                        new MovementRecord2
                        {
                            Amount = new AmountAndDirection5 { Amount = new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 200m } },
                            Identification = "MOV-002",
                        },
                    ],
                },
            ],
        };

    private static string Describe(ValidationResult result) =>
        string.Join("; ", result.Errors.Select(e => $"{e.ErrorCode} {e.PropertyName}: {e.ErrorMessage}"));

    [Fact]
    public void ValidXml_IsValid_AndTheInterfaceIsReturned_WithNoRecordNamed()
    {
        var xml = Iso20022XmlSerializer.SerializeToString(ValidMessage());

        var result = _sut.Validate(xml, Factory, out IMultilateralSettlementRequestV02? message);

        Assert.True(result.IsValid, Describe(result));
        Assert.NotNull(message);
        Assert.IsNotType<MultilateralSettlementRequestV02>(message);
        Assert.Equal("MSG-001", message!.GroupHeader.MessageIdentification.Value);
    }

    [Fact]
    public void OutVar_Works_BecauseTheInterfaceIsTheValidatorsOwn()
    {
        var xml = Iso20022XmlSerializer.SerializeToString(ValidMessage());

        var result = _sut.Validate(xml, Factory, out var message);

        Assert.True(result.IsValid, Describe(result));
        Assert.IsAssignableFrom<IMultilateralSettlementRequestV02>(message);
    }

    [Fact]
    public void Document_IsValid()
    {
        var document = Iso20022XmlSerializer.Serialize(ValidMessage());

        var result = _sut.Validate(document, Factory, out IMultilateralSettlementRequestV02? message);

        Assert.True(result.IsValid, Describe(result));
        Assert.NotNull(message);
    }

    [Fact]
    public void ReadableXml_WithARuleViolation_ReturnsTheRuleFailures_AndTheMessage()
    {
        var invalid = new MultilateralSettlementRequestV02
        {
            GroupHeader = new GroupHeader104
            {
                MessageIdentification = "MSG-001",
                CreationDateTime = new DateTime(2026, 1, 1),
                NumberOfSettlementRequests = "0",
            },
        };

        var result = _sut.Validate(Iso20022XmlSerializer.SerializeToString(invalid), Factory, out IMultilateralSettlementRequestV02? message);

        Assert.False(result.IsValid);
        Assert.NotNull(message);
        Assert.All(result.Errors, e => Assert.DoesNotContain("Xml.", e.ErrorCode ?? ""));
    }

    [Fact]
    public void UnreadableXml_ReportsEveryProblemWithItsPath_AndNoMessage()
    {
        var xml = Iso20022XmlSerializer
            .SerializeToString(ValidMessage())
            .Replace("<NbOfSttlmReqs>1</NbOfSttlmReqs>", "")
            .Replace("MOV-001", new string('x', 40));

        var result = _sut.Validate(xml, Factory, out IMultilateralSettlementRequestV02? message);

        Assert.False(result.IsValid);
        Assert.Null(message);
        Assert.True(result.Errors.Count >= 2, Describe(result));
        Assert.All(result.Errors, e => Assert.StartsWith("Xml.", e.ErrorCode));
    }

    [Fact]
    public void MalformedXml_IsOneProblem()
    {
        var result = _sut.Validate("<not-xml", Factory, out IMultilateralSettlementRequestV02? message);

        Assert.Null(message);
        Assert.Equal("Xml.MalformedXml", Assert.Single(result.Errors).ErrorCode);
    }

    [Fact]
    public void AnElement_IsReadWithTheFactory()
    {
        var element = XDocument.Parse(Iso20022XmlSerializer.SerializeToString(ValidMessage())).Root!.Elements().First();

        var result = _sut.Validate(element, Factory, out IMultilateralSettlementRequestV02? message);

        Assert.True(result.IsValid, Describe(result));
        Assert.NotNull(message);
    }

    [Fact]
    public async Task Async_ReturnsTheResultAndTheMessage()
    {
        var xml = Iso20022XmlSerializer.SerializeToString(ValidMessage());

        var (result, message) = await _sut.ValidateAsync(xml, Factory);

        Assert.True(result.IsValid, Describe(result));
        Assert.NotNull(message);
    }

    [Fact]
    public void WithoutAFactory_TheInterfaceCannotBeRead_AndTheRecordOverloadStillWorks()
    {
        var xml = Iso20022XmlSerializer.SerializeToString(ValidMessage());

        var result = _sut.Validate(xml, out MultilateralSettlementRequestV02? record);

        Assert.True(result.IsValid, Describe(result));
        Assert.NotNull(record);
    }

    [Fact]
    public void ANullFactory_IsRefused()
    {
        Assert.Throws<ArgumentNullException>(() => _sut.Validate("<x/>", null!, out IMultilateralSettlementRequestV02? _));
    }
}
