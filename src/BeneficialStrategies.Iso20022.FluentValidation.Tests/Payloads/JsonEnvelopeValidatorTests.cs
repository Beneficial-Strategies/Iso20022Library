// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Payloads;

public class JsonEnvelopeValidatorTests
{
    private readonly JsonEnvelopeValidator<MultilateralSettlementRequestV02> _sut = new(
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
    public void ValidJson_NoValidationErrors()
    {
        var json = Iso20022JsonSerializer.SerializeToString(ValidMessage());

        var result = _sut.Validate(new JsonEnvelope<MultilateralSettlementRequestV02>(json));

        Assert.True(result.IsValid, string.Join("; ", result.Errors.Select(e => e.ErrorMessage)));
    }

    [Fact]
    public void MalformedJson_SingleFailure_WithJsonParseErrorCode()
    {
        var result = _sut.Validate(
            new JsonEnvelope<MultilateralSettlementRequestV02>("{ this is not valid json")
        );

        Assert.False(result.IsValid);
        var failure = Assert.Single(result.Errors);
        Assert.Equal("JsonParseError", failure.ErrorCode);
    }

    [Fact]
    public void NullJson_SingleFailure_WithJsonParseErrorCode()
    {
        var result = _sut.Validate(new JsonEnvelope<MultilateralSettlementRequestV02>(null!));

        Assert.False(result.IsValid);
        var failure = Assert.Single(result.Errors);
        Assert.Equal("JsonParseError", failure.ErrorCode);
    }

    [Fact]
    public void ValidJson_BusinessRuleViolation_PassesThroughUnderlyingFailure()
    {
        var invalidMessage = new MultilateralSettlementRequestV02
        {
            GroupHeader = new GroupHeader104
            {
                MessageIdentification = "MSG-001",
                CreationDateTime = new DateTime(2026, 1, 1),
                NumberOfSettlementRequests = "0",
            },
        };
        var json = Iso20022JsonSerializer.SerializeToString(invalidMessage);

        var result = _sut.Validate(new JsonEnvelope<MultilateralSettlementRequestV02>(json));

        Assert.False(result.IsValid);
        Assert.Contains(result.Errors, e => e.PropertyName == "SettlementRequest");
    }
}
