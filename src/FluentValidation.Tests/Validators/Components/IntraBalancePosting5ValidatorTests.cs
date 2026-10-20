// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class IntraBalancePosting5ValidatorTests
{
    private readonly IntraBalancePosting5Validator _sut = new();

    private static CashSubBalanceTypeAndQuantityBreakdown3 ValidBalance() =>
        new()
        {
            Type = new Choices.CashBalanceType3Choice.Code
            {
                Value = Codesets.ExternalBalanceType1Code.ClosingAvailable,
            },
        };

    private static IntraBalancePosting6 MinimalItem() =>
        new()
        {
            AccountOwnerTransactionIdentification = "TXN-001",
            BalanceTo = ValidBalance(),
            SettledAmount = new Choices.Amount2Choice.AmountWithCurrency { Currency = "USD", Amount = 100m },
            EffectiveSettlementDate = new Choices.DateAndDateTime2Choice.Date { Value = new DateOnly(2026, 1, 1) },
            CreationDateTime = new DateTime(2026, 1, 1),
        };

    private static IntraBalancePosting5 ValidMessage() => new() { BalanceFrom = ValidBalance(), Movement = [MinimalItem()] };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── Movement: IntraBalancePosting6, 1..∞ ──────────────────────────────────

    [Fact]
    public void Movement_Empty_HasValidationError()
    {
        var msg = ValidMessage() with { Movement = [] };
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.Movement);
    }

    [Fact]
    public void Movement_OneElement_NoValidationError()
    {
        var msg = ValidMessage() with { Movement = [MinimalItem()] };
        _sut.TestValidate(msg).ShouldNotHaveValidationErrorFor(x => x.Movement);
    }
}
