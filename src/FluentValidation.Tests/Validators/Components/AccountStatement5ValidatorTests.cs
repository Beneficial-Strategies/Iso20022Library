// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class AccountStatement5ValidatorTests
{
    private readonly AccountStatement5Validator _sut = new();

    private static CashBalance3 ValidBalance() =>
        new()
        {
            Type = new BalanceType12
            {
                CodeOrProprietary = new Choices.BalanceType5Choice.Code
                {
                    Value = Codesets.BalanceType12Code.OpeningAvailable,
                },
            },
            Amount = new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 100m },
            CreditDebitIndicator = Codesets.CreditDebitCode.Credit,
            Date = new Choices.DateAndDateTimeChoice.Date { Value = new DateOnly(2026, 1, 1) },
        };

    private static AccountStatement5 ValidMessage() =>
        new()
        {
            Identification = "STMT-001",
            CreationDateTime = new DateTime(2026, 1, 1),
            Account = new CashAccount25
            {
                Identification = new Choices.AccountIdentification4Choice.Other { Identification = "ACC-001" },
            },
            Balance = [ValidBalance()],
        };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── Balance: CashBalance3, 1..∞ ────────────────────────────────────────────

    [Fact]
    public void Balance_Empty_HasValidationError()
    {
        var msg = ValidMessage() with { Balance = [] };
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.Balance);
    }

    [Fact]
    public void Balance_OneElement_NoValidationError()
    {
        var msg = ValidMessage() with { Balance = [ValidBalance()] };
        _sut.TestValidate(msg).ShouldNotHaveValidationErrorFor(x => x.Balance);
    }
}
