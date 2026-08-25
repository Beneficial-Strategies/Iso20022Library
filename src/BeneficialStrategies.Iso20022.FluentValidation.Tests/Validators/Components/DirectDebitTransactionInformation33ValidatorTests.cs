// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class DirectDebitTransactionInformation33ValidatorTests
{
    private readonly DirectDebitTransactionInformation33Validator _sut = new();

    private static DirectDebitTransactionInformation33 ValidMessage() =>
        new()
        {
            PaymentIdentification = new PaymentIdentification13 { EndToEndIdentification = "E2E-001" },
            Debtor = new BranchAndFinancialInstitutionIdentification8
            {
                FinancialInstitutionIdentification = new FinancialInstitutionIdentification23 { BICFI = "DEUTDEFFXXX" },
            },
            InterbankSettlementAmount = new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 100m },
        };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── InterbankSettlementAmount ─────────────────────────────────────────────────

    [Fact]
    public void InterbankSettlementAmount_InvalidCurrency_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            InterbankSettlementAmount = ValidMessage().InterbankSettlementAmount with { Currency = "eur" },
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "InterbankSettlementAmount.Currency");
    }

    [Fact]
    public void InterbankSettlementAmount_ZeroAmount_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            InterbankSettlementAmount = ValidMessage().InterbankSettlementAmount with { Amount = 0m },
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "InterbankSettlementAmount.Amount");
    }

    // ── Optional building blocks ──────────────────────────────────────────────────

    [Fact]
    public void PaymentTypeInformation_Present_NoValidationError()
    {
        var msg = ValidMessage() with { PaymentTypeInformation = new PaymentTypeInformation28() };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void SettlementTimeIndication_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            SettlementTimeIndication = new SettlementDateTimeIndication1 { CreditDateTime = new DateTime(2026, 1, 1) },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void SettlementTimeRequest_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            SettlementTimeRequest = new SettlementTimeRequest2 { FromTime = new TimeOnly(9, 0, 0) },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void UltimateDebtor_Present_NoValidationError()
    {
        var msg = ValidMessage() with { UltimateDebtor = ValidMessage().Debtor };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void DebtorAccount_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            DebtorAccount = new CashAccount40
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
    public void DebtorAgent_Present_NoValidationError()
    {
        var msg = ValidMessage() with { DebtorAgent = ValidMessage().Debtor };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void DebtorAgentAccount_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            DebtorAgentAccount = new CashAccount40
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
    public void Purpose_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            Purpose = new BeneficialStrategies.Iso20022.Choices.Purpose2Choice.Code
            {
                Value = ExternalPurpose1Code.CashManagementTransfer,
            },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void RemittanceInformation_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            RemittanceInformation = new RemittanceInformation2 { Unstructured = ["Invoice 12345"] },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
