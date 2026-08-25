// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Payloads;

public class XmlEnvelopeValidatorTests
{
    private readonly XmlEnvelopeValidator<MultilateralSettlementRequestV02> _sut = new(
        new MultilateralSettlementRequestV02Validator()
    );

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

    [Fact]
    public void ValidXml_NoValidationErrors()
    {
        var xml = Iso20022XmlSerializer.SerializeToString(ValidMessage());

        var result = _sut.Validate(new XmlEnvelope<MultilateralSettlementRequestV02>(xml));

        Assert.True(result.IsValid, string.Join("; ", result.Errors.Select(e => e.ErrorMessage)));
    }

    [Fact]
    public void MalformedXml_SingleFailure_WithXmlParseErrorCode()
    {
        var result = _sut.Validate(new XmlEnvelope<MultilateralSettlementRequestV02>("<Document><Unclosed>"));

        Assert.False(result.IsValid);
        var failure = Assert.Single(result.Errors);
        Assert.Equal("XmlParseError", failure.ErrorCode);
    }

    [Fact]
    public void WrongRootElement_SingleFailure_WithXmlParseErrorCode()
    {
        var result = _sut.Validate(
            new XmlEnvelope<MultilateralSettlementRequestV02>(
                "<SomethingElse xmlns=\"urn:not-iso20022\"><Inner/></SomethingElse>"
            )
        );

        Assert.False(result.IsValid);
        var failure = Assert.Single(result.Errors);
        Assert.Equal("XmlParseError", failure.ErrorCode);
    }

    [Fact]
    public void ValidXml_BusinessRuleViolation_PassesThroughUnderlyingFailure_WithUnchangedPropertyName()
    {
        // Well-formed and structurally valid XML, but SettlementRequest is empty — a genuine
        // business-rule violation the underlying MultilateralSettlementRequestV02Validator itself
        // reports on its "SettlementRequest" property. Confirms the envelope validator passes
        // failures through unmodified rather than prefixing/renaming them.
        var invalidMessage = new MultilateralSettlementRequestV02
        {
            GroupHeader = new GroupHeader104
            {
                MessageIdentification = "MSG-001",
                CreationDateTime = new DateTime(2026, 1, 1),
                NumberOfSettlementRequests = "0",
            },
        };
        var xml = Iso20022XmlSerializer.SerializeToString(invalidMessage);

        var result = _sut.Validate(new XmlEnvelope<MultilateralSettlementRequestV02>(xml));

        Assert.False(result.IsValid);
        Assert.Contains(result.Errors, e => e.PropertyName == "SettlementRequest");

        // Directly validating the deserialized message reports the identical property name —
        // proof the envelope adds nothing to it.
        var directResult = new MultilateralSettlementRequestV02Validator().Validate(invalidMessage);
        Assert.Equal(
            directResult.Errors.Select(e => e.PropertyName).OrderBy(n => n),
            result.Errors.Select(e => e.PropertyName).OrderBy(n => n)
        );
    }
}
