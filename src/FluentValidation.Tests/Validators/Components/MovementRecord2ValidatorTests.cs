// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class MovementRecord2ValidatorTests
{
    private readonly MovementRecord2Validator _sut = new();

    private static IMovementRecord2 ValidMessage() =>
        IsoDataFactory.Make<IMovementRecord2>(b => b
            .Set(x => x.Identification).To("MVMT-001")
            .Set(x => x.Amount).To(IsoDataFactory.Make<IAmountAndDirection5>(b2 => b2
                .Set(x2 => x2.Amount).To(new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 100m }))));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void Amount_Invalid_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Amount).To(IsoDataFactory.With(ValidMessage().Amount, b2 => b2
                .Set(x2 => x2.Amount).To(ValidMessage().Amount.Amount with { Amount = 0m }))));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "Amount.Amount.Amount");
    }

    [Fact]
    public void Participant_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Participant).To(IsoDataFactory.Make<IPartyIdentification272>()));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void SettlementAgent_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.SettlementAgent).To(IsoDataFactory.Make<IPartyIdentification272>()));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ParticipantAccount_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ParticipantAccount).To(IsoDataFactory.Make<ICashAccount40>(b2 => b2
                .Set(x2 => x2.Identification).To(IsoDataFactory.Make<Choices.AccountIdentification4Choice.IIBAN>(b3 => b3
                    .Set(x3 => x3.Value).To("DE89370400440532013000"))))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void SettlementAgentAccount_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.SettlementAgentAccount).To(IsoDataFactory.Make<ICashAccount40>(b2 => b2
                .Set(x2 => x2.Identification).To(IsoDataFactory.Make<Choices.AccountIdentification4Choice.IIBAN>(b3 => b3
                    .Set(x3 => x3.Value).To("DE89370400440532013000"))))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
