// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class GroupHeader123ValidatorTests
{
    private readonly GroupHeader123Validator _sut = new();

    private static GroupHeader123 ValidMessage() =>
        new()
        {
            MessageIdentification = "MSG-001",
            CreationDateTime = new DateTime(2026, 1, 1),
            NumberOfTransactions = "1",
            SettlementInformation = new SettlementInstruction15 { SettlementMethod = SettlementMethod1Code.ClearingSystem },
        };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── Authorisation maximum-count (0..2) ───────────────────────────────────────

    [Fact]
    public void Authorisation_ThreeElements_HasValidationError()
    {
        var auth = new BeneficialStrategies.Iso20022.Choices.Authorisation1Choice.Code
        {
            Value = Authorisation1Code.PreAuthorisedFile,
        };
        var msg = ValidMessage() with { Authorisation = [auth, auth, auth] };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "Authorisation");
    }

    [Fact]
    public void Authorisation_TwoElements_NoValidationError()
    {
        var auth = new BeneficialStrategies.Iso20022.Choices.Authorisation1Choice.Code
        {
            Value = Authorisation1Code.PreAuthorisedFile,
        };
        var msg = ValidMessage() with { Authorisation = [auth, auth] };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void InstructedAgent_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            InstructedAgent = new BranchAndFinancialInstitutionIdentification8
            {
                FinancialInstitutionIdentification = new FinancialInstitutionIdentification23 { BICFI = "DEUTDEFFXXX" },
            },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void InstructingAgent_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            InstructingAgent = new BranchAndFinancialInstitutionIdentification8
            {
                FinancialInstitutionIdentification = new FinancialInstitutionIdentification23 { BICFI = "DEUTDEFFXXX" },
            },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void PaymentTypeInformation_Present_NoValidationError()
    {
        var msg = ValidMessage() with { PaymentTypeInformation = new PaymentTypeInformation28() };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void GroupReturn_Present_NoValidationError()
    {
        var msg = ValidMessage() with { GroupReturn = true };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    // ── TotalReturnedInterbankSettlementAmount ────────────────────────────────────

    [Fact]
    public void TotalReturnedInterbankSettlementAmount_InvalidCurrency_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            TotalReturnedInterbankSettlementAmount = new ActiveCurrencyAndAmount { Currency = "eur", Amount = 100m },
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "TotalReturnedInterbankSettlementAmount.Currency");
    }

    [Fact]
    public void TotalReturnedInterbankSettlementAmount_ZeroAmount_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            TotalReturnedInterbankSettlementAmount = new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 0m },
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "TotalReturnedInterbankSettlementAmount.Amount");
    }

    [Fact]
    public void TotalReturnedInterbankSettlementAmount_Valid_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            TotalReturnedInterbankSettlementAmount = new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 100m },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
