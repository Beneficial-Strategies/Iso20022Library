// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class TransactionAllocation2ValidatorTests
{
    private readonly TransactionAllocation2Validator _sut = new();

    private static TransactionAllocation2 ValidMessage() =>
        new()
        {
            Amount = new ActiveOrHistoricCurrencyAndAmount { Currency = "EUR", Amount = 100m },
            CreditDebitIndicator = CreditDebitCode.Credit,
            Account = new CashAccount40
            {
                Identification = new BeneficialStrategies.Iso20022.Choices.AccountIdentification4Choice.IBAN
                {
                    Value = "DE89370400440532013000",
                },
            },
            Purpose = new BeneficialStrategies.Iso20022.Choices.Purpose2Choice.Code
            {
                Value = ExternalPurpose1Code.CashManagementTransfer,
            },
            Reference = "REF-001",
        };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void Amount_InvalidCurrency_HasValidationError()
    {
        var msg = ValidMessage() with { Amount = ValidMessage().Amount with { Currency = "eur" } };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "Amount.Currency");
    }

    [Fact]
    public void Amount_ZeroAmount_HasValidationError()
    {
        var msg = ValidMessage() with { Amount = ValidMessage().Amount with { Amount = 0m } };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "Amount.Amount");
    }

    [Fact]
    public void RelatedReferences_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            RelatedReferences =
            [
                new BeneficialStrategies.Iso20022.Choices.References80Choice.CommonIdentification { Value = "REF-002" },
            ],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
