// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class GroupHeader125ValidatorTests
{
    private readonly GroupHeader125Validator _sut = new();

    private static IGroupHeader125 ValidMessage() =>
        IsoDataFactory.Make<IGroupHeader125>(b => b
            .Set(x => x.MessageIdentification).To("MSG-001")
            .Set(x => x.CreationDateTime).To(new DateTime(2026, 1, 1))
            .Set(x => x.NumberOfTransactions).To("1")
            .Set(x => x.SettlementInformation).To(IsoDataFactory.Make<ISettlementInstruction14>(b2 => b2
                .Set(x2 => x2.SettlementMethod).To(SettlementMethod2Code.ClearingSystem))));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── Authorisation maximum-count (0..2) ───────────────────────────────────────

    [Fact]
    public void Authorisation_ThreeElements_HasValidationError()
    {
        var auth = IsoDataFactory.Make<Choices.Authorisation1Choice.ICode>(b => b
            .Set(x => x.Value).To(Authorisation1Code.PreAuthorisedFile));
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Authorisation).To([auth, auth, auth]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "Authorisation");
    }

    [Fact]
    public void Authorisation_TwoElements_NoValidationError()
    {
        var auth = IsoDataFactory.Make<Choices.Authorisation1Choice.ICode>(b => b
            .Set(x => x.Value).To(Authorisation1Code.PreAuthorisedFile));
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Authorisation).To([auth, auth]));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void InstructedAgent_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.InstructedAgent).To(IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b2 => b2
                .Set(x2 => x2.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>(b3 => b3
                    .Set(x3 => x3.BICFI).To("DEUTDEFFXXX"))))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void InstructingAgent_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.InstructingAgent).To(IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b2 => b2
                .Set(x2 => x2.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>(b3 => b3
                    .Set(x3 => x3.BICFI).To("DEUTDEFFXXX"))))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void PaymentTypeInformation_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.PaymentTypeInformation).To(IsoDataFactory.Make<IPaymentTypeInformation27>()));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    // ── TotalInterbankSettlementAmount ────────────────────────────────────────────

    [Fact]
    public void TotalInterbankSettlementAmount_UnsetCurrency_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.TotalInterbankSettlementAmount).To(new ActiveCurrencyAndAmount { Currency = default, Amount = 100m }));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "TotalInterbankSettlementAmount.Currency");
    }

    [Fact]
    public void TotalInterbankSettlementAmount_ZeroAmount_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.TotalInterbankSettlementAmount).To(new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 0m }));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "TotalInterbankSettlementAmount.Amount");
    }

    [Fact]
    public void TotalInterbankSettlementAmount_Valid_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.TotalInterbankSettlementAmount).To(new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 100m }));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
