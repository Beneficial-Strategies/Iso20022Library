// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class GroupHeader131ValidatorTests
{
    private readonly GroupHeader131Validator _sut = new();

    private static GroupHeader131 ValidMessage() =>
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

    // ── TotalInterbankSettlementAmount ────────────────────────────────────────────

    [Fact]
    public void TotalInterbankSettlementAmount_InvalidCurrency_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            TotalInterbankSettlementAmount = new ActiveCurrencyAndAmount { Currency = "eur", Amount = 100m },
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "TotalInterbankSettlementAmount.Currency");
    }

    [Fact]
    public void TotalInterbankSettlementAmount_Valid_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            TotalInterbankSettlementAmount = new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 100m },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
