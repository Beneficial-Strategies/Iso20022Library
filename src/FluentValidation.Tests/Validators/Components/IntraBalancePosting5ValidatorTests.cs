// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class IntraBalancePosting5ValidatorTests
{
    private readonly IntraBalancePosting5Validator _sut = new();

    private static ICashSubBalanceTypeAndQuantityBreakdown3 ValidBalance() =>
        IsoDataFactory.Make<ICashSubBalanceTypeAndQuantityBreakdown3>(b => b
            .Set(x => x.Type).To(IsoDataFactory.Make<Choices.CashBalanceType3Choice.ICode>(b2 => b2
                .Set(x2 => x2.Value).To(Codesets.ExternalBalanceType1Code.ClosingAvailable))));

    private static IIntraBalancePosting6 MinimalItem() =>
        IsoDataFactory.Make<IIntraBalancePosting6>(b => b
            .Set(x => x.AccountOwnerTransactionIdentification).To("TXN-001")
            .Set(x => x.BalanceTo).To(ValidBalance())
            .Set(x => x.SettledAmount).To(IsoDataFactory.Make<Choices.Amount2Choice.IAmountWithCurrency>(b2 => b2
                .Set(x2 => x2.Currency).To("USD")
                .Set(x2 => x2.Amount).To(100m)))
            .Set(x => x.EffectiveSettlementDate).To(IsoDataFactory.Make<Choices.DateAndDateTime2Choice.IDate>(b2 => b2
                .Set(x2 => x2.Value).To(new DateOnly(2026, 1, 1))))
            .Set(x => x.CreationDateTime).To(new DateTime(2026, 1, 1)));

    private static IIntraBalancePosting5 ValidMessage() => IsoDataFactory.Make<IIntraBalancePosting5>(b => b
        .Set(x => x.BalanceFrom).To(ValidBalance())
        .Set(x => x.Movement).To([MinimalItem()]));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── Movement: IntraBalancePosting6, 1..∞ ──────────────────────────────────

    [Fact]
    public void Movement_Empty_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Movement).To([]));
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.Movement);
    }

    [Fact]
    public void Movement_OneElement_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Movement).To([MinimalItem()]));
        _sut.TestValidate(msg).ShouldNotHaveValidationErrorFor(x => x.Movement);
    }
}
