// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class IntraBalanceCancellation7ValidatorTests
{
    private readonly IntraBalanceCancellation7Validator _sut = new();

    private static ICashAccount40 ValidAccount() => IsoDataFactory.Make<ICashAccount40>();

    private static ISystemPartyIdentification8 ValidOwner() =>
        IsoDataFactory.Make<ISystemPartyIdentification8>(b => b
            .Set(x => x.Identification).To(IsoDataFactory.Make<IPartyIdentification136>(b2 => b2
            .Set(x2 => x2.Identification).To(IsoDataFactory.Make<Choices.PartyIdentification120Choice.INameAndAddress>(b3 => b3
            .Set(x3 => x3.Name).To("Owner"))))));

    private static IBranchAndFinancialInstitutionIdentification8 ValidServicer() =>
        IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b => b
            .Set(x => x.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>()));

    private static IProcessingStatus69Choice ValidStatus() => IsoDataFactory.Make<Choices.ProcessingStatus69Choice.IAcknowledgedAccepted>(b => b
        .Set(x => x.Value).To(IsoDataFactory.Make<Choices.AcknowledgedAcceptedStatus24Choice.INoSpecifiedReason>(b2 => b2
        .Set(x2 => x2.Value).To(default))));

    private static IIntraBalanceCancellation8 MinimalItem() => IsoDataFactory.Make<IIntraBalanceCancellation8>(b => b
        .Set(x => x.RequestReference).To("REQ-001"));

    // ValidMessage sets all four top-level fields and no item-level equivalents — satisfies all
    // four XOR constraints simultaneously (top-level present, item-level absent).
    private static IIntraBalanceCancellation7 ValidMessage() =>
        IsoDataFactory.Make<IIntraBalanceCancellation7>(b => b
            .Set(x => x.CashAccount).To(ValidAccount())
            .Set(x => x.CashAccountOwner).To(ValidOwner())
            .Set(x => x.CashAccountServicer).To(ValidServicer())
            .Set(x => x.ProcessingStatus).To(ValidStatus())
            .Set(x => x.Cancellation).To([MinimalItem()]));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── Cancellation: 1..* ────────────────────────────────────────────────────

    [Fact]
    public void Cancellation_Empty_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Cancellation).To([]));
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.Cancellation);
    }

    // ── CashAccountRule ───────────────────────────────────────────────────────

    [Fact]
    public void TopLevelAndItemCashAccount_Violates_CashAccountRule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Cancellation).To([IsoDataFactory.With(MinimalItem(), b2 => b2
            .Set(x2 => x2.CashAccount).To(ValidAccount()))]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "CashAccountRule");
    }

    [Fact]
    public void NeitherCashAccount_Violates_CashAccountRule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.CashAccount).To(null));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "CashAccountRule");
    }

    [Fact]
    public void TopLevelCashAccountOnly_DoesNotViolate_CashAccountRule()
    {
        var result = _sut.Validate(ValidMessage());
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "CashAccountRule");
    }

    // ── CashAccountOwnerRule ──────────────────────────────────────────────────

    [Fact]
    public void TopLevelAndItemCashAccountOwner_Violates_CashAccountOwnerRule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Cancellation).To([IsoDataFactory.With(MinimalItem(), b2 => b2
            .Set(x2 => x2.CashAccountOwner).To(ValidOwner()))]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "CashAccountOwnerRule");
    }

    [Fact]
    public void NeitherCashAccountOwner_Violates_CashAccountOwnerRule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.CashAccountOwner).To(null));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "CashAccountOwnerRule");
    }

    // ── ProcessingStatusRule ──────────────────────────────────────────────────

    [Fact]
    public void TopLevelAndItemProcessingStatus_Violates_ProcessingStatusRule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Cancellation).To([IsoDataFactory.With(MinimalItem(), b2 => b2
            .Set(x2 => x2.ProcessingStatus).To(ValidStatus()))]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "ProcessingStatusRule");
    }

    [Fact]
    public void NeitherProcessingStatus_Violates_ProcessingStatusRule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ProcessingStatus).To(null));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "ProcessingStatusRule");
    }

    // ── CashAccountServicerRule ───────────────────────────────────────────────

    [Fact]
    public void TopLevelAndItemCashAccountServicer_Violates_CashAccountServicerRule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Cancellation).To([IsoDataFactory.With(MinimalItem(), b2 => b2
                .Set(x2 => x2.CashAccountServicer).To(ValidServicer()))]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "CashAccountServicerRule");
    }

    [Fact]
    public void NeitherCashAccountServicer_Violates_CashAccountServicerRule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.CashAccountServicer).To(null));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "CashAccountServicerRule");
    }
}
