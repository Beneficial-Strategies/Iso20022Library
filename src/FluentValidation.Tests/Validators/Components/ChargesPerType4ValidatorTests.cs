// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class ChargesPerType4ValidatorTests
{
    private readonly ChargesPerType4Validator _sut = new();

    private static ICashAccount40 ValidAccount() => IsoDataFactory.Make<ICashAccount40>();

    private static IBranchAndFinancialInstitutionIdentification8 ValidOwner() =>
        IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b => b
            .Set(x => x.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>()));

    private static IChargesPerTypeRecord4 MinimalRecord() =>
        IsoDataFactory.Make<IChargesPerTypeRecord4>(b => b
            .Set(x => x.UnderlyingTransaction).To(IsoDataFactory.Make<ITransactionReferences7>())
            .Set(x => x.Amount).To(new ActiveCurrencyAndAmount { Currency = "USD", Amount = 10m }));

    private static IChargesPerType4 ValidMessage() =>
        IsoDataFactory.Make<IChargesPerType4>(b => b
            .Set(x => x.Type).To(IsoDataFactory.Make<Choices.ChargeType3Choice.IProprietary>(b2 => b2
                .Set(x2 => x2.Identification).To("CHRG")))
            .Set(x => x.Record).To([MinimalRecord()]));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── Record: ChargesPerTypeRecord4, 1..∞ ───────────────────────────────────

    [Fact]
    public void Record_Empty_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Record).To([]));
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.Record);
    }

    // ── ChargesAccountTypeOrRecord2Rule / 1Rule ───────────────────────────────
    // Both rules express the same mutual-exclusivity condition from opposite directions.

    [Fact]
    public void TopLevelAccountAndRecordAccount_Violates_BothRules()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ChargesAccount).To(ValidAccount())
            .Set(x => x.Record).To([IsoDataFactory.With(MinimalRecord(), b2 => b2
                .Set(x2 => x2.ChargesAccount).To(ValidAccount()))]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "ChargesAccountTypeOrRecord2Rule");
        Assert.Contains(result.Errors, e => e.PropertyName == "ChargesAccountTypeOrRecord1Rule");
    }

    [Fact]
    public void TopLevelOwnerAndRecordOwner_Violates_BothRules()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ChargesAccountOwner).To(ValidOwner())
            .Set(x => x.Record).To([IsoDataFactory.With(MinimalRecord(), b2 => b2
                .Set(x2 => x2.ChargesAccountOwner).To(ValidOwner()))]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "ChargesAccountTypeOrRecord2Rule");
        Assert.Contains(result.Errors, e => e.PropertyName == "ChargesAccountTypeOrRecord1Rule");
    }

    [Fact]
    public void TopLevelAccountOnly_DoesNotViolate_EitherRule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ChargesAccount).To(ValidAccount()));
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "ChargesAccountTypeOrRecord2Rule");
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "ChargesAccountTypeOrRecord1Rule");
    }

    [Fact]
    public void RecordAccountOnly_DoesNotViolate_EitherRule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Record).To([IsoDataFactory.With(MinimalRecord(), b2 => b2
            .Set(x2 => x2.ChargesAccount).To(ValidAccount()))]));
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "ChargesAccountTypeOrRecord2Rule");
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "ChargesAccountTypeOrRecord1Rule");
    }
}
