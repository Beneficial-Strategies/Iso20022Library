// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class PaymentTransaction182ValidatorTests
{
    private readonly PaymentTransaction182Validator _sut = new();

    private static PaymentTransaction182 ValidMessage() =>
        new()
        {
            ReversedInterbankSettlementAmount = new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 100m },
        };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── ReversedInterbankSettlementAmount (required) ─────────────────────────────

    [Fact]
    public void ReversedInterbankSettlementAmount_InvalidCurrency_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            ReversedInterbankSettlementAmount = ValidMessage().ReversedInterbankSettlementAmount with { Currency = "eur" },
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "ReversedInterbankSettlementAmount.Currency");
    }

    [Fact]
    public void ReversedInterbankSettlementAmount_ZeroAmount_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            ReversedInterbankSettlementAmount = ValidMessage().ReversedInterbankSettlementAmount with { Amount = 0m },
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "ReversedInterbankSettlementAmount.Amount");
    }

    // ── The three ActiveOrHistoricCurrencyAndAmount optional fields ──────────────

    [Theory]
    [InlineData("OriginalInterbankSettlementAmount")]
    [InlineData("ReversedInstructedAmount")]
    [InlineData("CompensationAmount")]
    public void OptionalAmountField_Valid_NoValidationError(string fieldName)
    {
        var amount = new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 50m };
        var msg = fieldName switch
        {
            "OriginalInterbankSettlementAmount" => ValidMessage() with { OriginalInterbankSettlementAmount = amount },
            "ReversedInstructedAmount" => ValidMessage() with { ReversedInstructedAmount = amount },
            "CompensationAmount" => ValidMessage() with { CompensationAmount = amount },
            _ => throw new ArgumentOutOfRangeException(nameof(fieldName)),
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void OriginalInterbankSettlementAmount_InvalidCurrency_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            OriginalInterbankSettlementAmount = new ActiveOrHistoricCurrencyAndAmount { Currency = "US", Amount = 50m },
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "OriginalInterbankSettlementAmount.Currency");
    }

    [Fact]
    public void CompensationAmount_ZeroAmount_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            CompensationAmount = new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 0m },
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "CompensationAmount.Amount");
    }

    // ── Other optional building blocks ────────────────────────────────────────────

    [Fact]
    public void OriginalGroupInformation_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            OriginalGroupInformation = new OriginalGroupInformation33
            {
                OriginalMessageIdentification = "MSG-001",
                OriginalMessageNameIdentification = "pacs.008.001.08",
            },
        };
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
    public void ChargesInformation_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            ChargesInformation =
            [
                new Charges16
                {
                    Agent = new BranchAndFinancialInstitutionIdentification8
                    {
                        FinancialInstitutionIdentification = new FinancialInstitutionIdentification23 { BICFI = "DEUTDEFFXXX" },
                    },
                    Amount = new ActiveOrHistoricCurrencyAndAmount { Currency = "EUR", Amount = 5m },
                },
            ],
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
    public void ReversalReasonInformation_Present_NoValidationError()
    {
        var msg = ValidMessage() with { ReversalReasonInformation = [new PaymentReversalReason10()] };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void OriginalTransactionReference_Present_NoValidationError()
    {
        var msg = ValidMessage() with { OriginalTransactionReference = new OriginalTransactionReference47() };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void SupplementaryData_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            SupplementaryData = [new SupplementaryData1 { Envelope = new SupplementaryDataEnvelope1() }],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
