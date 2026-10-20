// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class MovementRecord2ValidatorTests
{
    private readonly MovementRecord2Validator _sut = new();

    private static MovementRecord2 ValidMessage() =>
        new()
        {
            Identification = "MVMT-001",
            Amount = new AmountAndDirection5
            {
                Amount = new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 100m },
            },
        };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void Amount_Invalid_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            Amount = ValidMessage().Amount with
            {
                Amount = ValidMessage().Amount.Amount with { Amount = 0m },
            },
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "Amount.Amount.Amount");
    }

    [Fact]
    public void Participant_Present_NoValidationError()
    {
        var msg = ValidMessage() with { Participant = new PartyIdentification272() };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void SettlementAgent_Present_NoValidationError()
    {
        var msg = ValidMessage() with { SettlementAgent = new PartyIdentification272() };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ParticipantAccount_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            ParticipantAccount = new CashAccount40
            {
                Identification = new BeneficialStrategies.Iso20022.Choices.AccountIdentification4Choice.IBAN
                {
                    Value = "DE89370400440532013000",
                },
            },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void SettlementAgentAccount_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            SettlementAgentAccount = new CashAccount40
            {
                Identification = new BeneficialStrategies.Iso20022.Choices.AccountIdentification4Choice.IBAN
                {
                    Value = "DE89370400440532013000",
                },
            },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
