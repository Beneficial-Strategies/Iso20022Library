// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class ChargesPerTransaction5ValidatorTests
{
    private readonly ChargesPerTransaction5Validator _sut = new();

    private static ICashAccount40 ValidAccount() => IsoDataFactory.Make<ICashAccount40>();

    private static IBranchAndFinancialInstitutionIdentification8 ValidOwner() =>
        IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b => b
            .Set(x => x.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>()));

    private static IChargesBreakdown1 ValidChargesBreakdown() =>
        IsoDataFactory.Make<IChargesBreakdown1>(b => b
            .Set(x => x.Amount).To(new ActiveCurrencyAndAmount { Currency = "USD", Amount = 5m }));

    private static IChargesPerTransactionRecord5 MinimalRecord() =>
        IsoDataFactory.Make<IChargesPerTransactionRecord5>(b => b
            .Set(x => x.UnderlyingTransaction).To(IsoDataFactory.Make<ITransactionReferences7>())
            .Set(x => x.ChargesBreakdown).To([ValidChargesBreakdown()]));

    private static IChargesPerTransaction5 ValidMessage() => IsoDataFactory.Make<IChargesPerTransaction5>(b => b
        .Set(x => x.Record).To([MinimalRecord()]));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── Record: ChargesPerTransactionRecord5, 1..∞ ────────────────────────────

    [Fact]
    public void Record_Empty_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Record).To([]));
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.Record);
    }

    // ── ChargesAccountTransactionOrRecord2Rule / 1Rule ────────────────────────
    // Both rules express the same mutual-exclusivity condition from opposite directions.

    [Fact]
    public void TopLevelAccountAndRecordAccount_Violates_BothRules()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ChargesAccount).To(ValidAccount())
            .Set(x => x.Record).To([IsoDataFactory.With(MinimalRecord(), b2 => b2
                .Set(x2 => x2.ChargesAccount).To(ValidAccount()))]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "ChargesAccountTransactionOrRecord2Rule");
        Assert.Contains(result.Errors, e => e.PropertyName == "ChargesAccountTransactionOrRecord1Rule");
    }

    [Fact]
    public void TopLevelOwnerAndRecordOwner_Violates_BothRules()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ChargesAccountOwner).To(ValidOwner())
            .Set(x => x.Record).To([IsoDataFactory.With(MinimalRecord(), b2 => b2
                .Set(x2 => x2.ChargesAccountOwner).To(ValidOwner()))]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "ChargesAccountTransactionOrRecord2Rule");
        Assert.Contains(result.Errors, e => e.PropertyName == "ChargesAccountTransactionOrRecord1Rule");
    }

    [Fact]
    public void TopLevelAccountOnly_DoesNotViolate_EitherRule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ChargesAccount).To(ValidAccount()));
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "ChargesAccountTransactionOrRecord2Rule");
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "ChargesAccountTransactionOrRecord1Rule");
    }

    [Fact]
    public void RecordAccountOnly_DoesNotViolate_EitherRule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Record).To([IsoDataFactory.With(MinimalRecord(), b2 => b2
            .Set(x2 => x2.ChargesAccount).To(ValidAccount()))]));
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "ChargesAccountTransactionOrRecord2Rule");
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "ChargesAccountTransactionOrRecord1Rule");
    }
}
