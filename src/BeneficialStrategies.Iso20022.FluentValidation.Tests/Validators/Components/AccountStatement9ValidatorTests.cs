// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class AccountStatement9ValidatorTests
{
    private readonly AccountStatement9Validator _sut = new();

    private static CashBalance8 ValidBalance() =>
        new()
        {
            Type = new BalanceType13
            {
                CodeOrProprietary = new Choices.BalanceType10Choice.Code
                {
                    Value = Codesets.ExternalBalanceType1Code.ClosingAvailable,
                },
            },
            Amount = new ActiveOrHistoricCurrencyAndAmount { Currency = "USD", Amount = 100m },
            CreditDebitIndicator = Codesets.CreditDebitCode.Credit,
            Date = new Choices.DateAndDateTime2Choice.Date { Value = new DateOnly(2026, 1, 1) },
        };

    private static AccountStatement9 ValidMessage() =>
        new()
        {
            Identification = "STMT-001",
            Account = new CashAccount39
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

    // ── Balance: CashBalance8, 1..∞ ────────────────────────────────────────────

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
