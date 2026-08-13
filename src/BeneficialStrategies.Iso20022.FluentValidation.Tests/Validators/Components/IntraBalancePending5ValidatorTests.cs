// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class IntraBalancePending5ValidatorTests
{
    private readonly IntraBalancePending5Validator _sut = new();

    private static CashSubBalanceTypeAndQuantityBreakdown3 ValidBalance() =>
        new()
        {
            Type = new Choices.CashBalanceType3Choice.Code
            {
                Value = Codesets.ExternalBalanceType1Code.ClosingAvailable,
            },
        };

    private static PendingStatusAndReason2 ValidStatusAndReason() => new();

    private static IntraBalancePending6 MinimalItem() =>
        new()
        {
            AccountOwnerTransactionIdentification = "TXN-001",
            BalanceFrom = ValidBalance(),
            BalanceTo = ValidBalance(),
            SettlementAmount = new Choices.Amount2Choice.AmountWithCurrency { Currency = "USD", Amount = 100m },
            IntendedSettlementDate = new Choices.DateAndDateTime2Choice.Date { Value = new DateOnly(2026, 1, 1) },
            CreationDateTime = new DateTime(2026, 1, 1),
        };

    // ValidMessage sets the top-level field and no item-level equivalent — satisfies the XOR
    // constraint (top-level present, item-level absent).
    private static IntraBalancePending5 ValidMessage() =>
        new() { StatusAndReason = ValidStatusAndReason(), Movement = [MinimalItem()] };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── Movement: 1..* ────────────────────────────────────────────────────────

    [Fact]
    public void Movement_Empty_HasValidationError()
    {
        var msg = ValidMessage() with { Movement = [] };
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.Movement);
    }

    // ── StatusAndReasonRule ───────────────────────────────────────────────────

    [Fact]
    public void TopLevelAndItemStatusAndReason_Violates_StatusAndReasonRule()
    {
        var msg = ValidMessage() with
        {
            Movement = [MinimalItem() with { StatusAndReason = ValidStatusAndReason() }],
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "StatusAndReasonRule");
    }

    [Fact]
    public void NeitherStatusAndReason_Violates_StatusAndReasonRule()
    {
        var msg = ValidMessage() with { StatusAndReason = null };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "StatusAndReasonRule");
    }

    [Fact]
    public void TopLevelStatusAndReasonOnly_DoesNotViolate_StatusAndReasonRule()
    {
        var result = _sut.Validate(ValidMessage());
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "StatusAndReasonRule");
    }
}
