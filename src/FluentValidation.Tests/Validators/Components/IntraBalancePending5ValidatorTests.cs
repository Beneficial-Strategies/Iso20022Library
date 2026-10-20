// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class IntraBalancePending5ValidatorTests
{
    private readonly IntraBalancePending5Validator _sut = new();

    private static ICashSubBalanceTypeAndQuantityBreakdown3 ValidBalance() =>
        IsoDataFactory.Make<ICashSubBalanceTypeAndQuantityBreakdown3>(b => b
            .Set(x => x.Type).To(IsoDataFactory.Make<Choices.CashBalanceType3Choice.ICode>(b2 => b2
                .Set(x2 => x2.Value).To(Codesets.ExternalBalanceType1Code.ClosingAvailable))));

    private static IPendingStatusAndReason2 ValidStatusAndReason() => IsoDataFactory.Make<IPendingStatusAndReason2>();

    private static IIntraBalancePending6 MinimalItem() =>
        IsoDataFactory.Make<IIntraBalancePending6>(b => b
            .Set(x => x.AccountOwnerTransactionIdentification).To("TXN-001")
            .Set(x => x.BalanceFrom).To(ValidBalance())
            .Set(x => x.BalanceTo).To(ValidBalance())
            .Set(x => x.SettlementAmount).To(IsoDataFactory.Make<Choices.Amount2Choice.IAmountWithCurrency>(b2 => b2
                .Set(x2 => x2.Currency).To("USD")
                .Set(x2 => x2.Amount).To(100m)))
            .Set(x => x.IntendedSettlementDate).To(IsoDataFactory.Make<Choices.DateAndDateTime2Choice.IDate>(b2 => b2
                .Set(x2 => x2.Value).To(new DateOnly(2026, 1, 1))))
            .Set(x => x.CreationDateTime).To(new DateTime(2026, 1, 1)));

    // ValidMessage sets the top-level field and no item-level equivalent — satisfies the XOR
    // constraint (top-level present, item-level absent).
    private static IIntraBalancePending5 ValidMessage() =>
        IsoDataFactory.Make<IIntraBalancePending5>(b => b
            .Set(x => x.StatusAndReason).To(ValidStatusAndReason())
            .Set(x => x.Movement).To([MinimalItem()]));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── Movement: 1..* ────────────────────────────────────────────────────────

    [Fact]
    public void Movement_Empty_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Movement).To([]));
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.Movement);
    }

    // ── StatusAndReasonRule ───────────────────────────────────────────────────

    [Fact]
    public void TopLevelAndItemStatusAndReason_Violates_StatusAndReasonRule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Movement).To([IsoDataFactory.With(MinimalItem(), b2 => b2
                .Set(x2 => x2.StatusAndReason).To(ValidStatusAndReason()))]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "StatusAndReasonRule");
    }

    [Fact]
    public void NeitherStatusAndReason_Violates_StatusAndReasonRule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.StatusAndReason).To(null));
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
