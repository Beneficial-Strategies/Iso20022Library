// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class AccountStatement1ValidatorTests
{
    private readonly AccountStatement1Validator _sut = new();

    private static CashBalance2 ValidBalance() =>
        new()
        {
            Type = new Choices.BalanceType2Choice.Code
            {
                Value = Codesets.BalanceType9Code.OpeningBooked,
            },
            Amount = new CurrencyAndAmount { Currency = "USD", Amount = 100m },
            CreditDebitIndicator = Codesets.CreditDebitCode.Credit,
            Date = new Choices.DateAndDateTimeChoice.Date { Value = new DateOnly(2026, 1, 1) },
        };

    private static AccountStatement1 ValidMessage() =>
        new()
        {
            Identification = "STMT-001",
            CreationDateTime = new DateTime(2026, 1, 1),
            Account = new CashAccount13
            {
                Identification = new Choices.AccountIdentification3Choice.IBAN
                {
                    Value = "DE89370400440532013000",
                },
            },
            Balance = [ValidBalance()],
        };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── Balance: CashBalance2, 1..∞ ────────────────────────────────────────────

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
