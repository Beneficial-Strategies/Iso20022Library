// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class ChargesPerType6ValidatorTests
{
    private readonly ChargesPerType6Validator _sut = new();

    private static IBranchAndFinancialInstitutionIdentification8 ValidAgent() =>
        IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b => b
            .Set(x => x.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>()));

    private static ICashAccount40 ValidAccount() => IsoDataFactory.Make<ICashAccount40>();

    private static IChargesPerTypeRecord6 MinimalRecord() =>
        IsoDataFactory.Make<IChargesPerTypeRecord6>(b => b
            .Set(x => x.UnderlyingTransaction).To(IsoDataFactory.Make<ITransactionReferences7>())
            .Set(x => x.Amount).To(new ActiveCurrencyAndAmount { Currency = "USD", Amount = 10m }));

    private static IChargesPerType6 ValidMessage() =>
        IsoDataFactory.Make<IChargesPerType6>(b => b
            .Set(x => x.Type).To(IsoDataFactory.Make<Choices.ChargeType3Choice.IProprietary>(b2 => b2
                .Set(x2 => x2.Identification).To("CHRG")))
            .Set(x => x.Record).To([MinimalRecord()]));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── Record: ChargesPerTypeRecord6, 1..∞ ───────────────────────────────────

    [Fact]
    public void Record_Empty_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Record).To([]));
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.Record);
    }

    // ── ChargesAccountAgent2Rule / ChargesAccountAgentRule ────────────────────
    // Both rules express the same mutual-exclusivity condition from opposite directions.

    [Fact]
    public void TopLevelAgentAndRecordAgent_Violates_BothRules()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ChargesAccountAgent).To(ValidAgent())
            .Set(x => x.Record).To([IsoDataFactory.With(MinimalRecord(), b2 => b2
                .Set(x2 => x2.ChargesAccountAgent).To(ValidAgent()))]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "ChargesAccountAgent2Rule");
        Assert.Contains(result.Errors, e => e.PropertyName == "ChargesAccountAgentRule");
    }

    [Fact]
    public void TopLevelAgentAccountAndRecordAgentAccount_Violates_BothRules()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ChargesAccountAgentAccount).To(ValidAccount())
            .Set(x => x.Record).To([IsoDataFactory.With(MinimalRecord(), b2 => b2
                .Set(x2 => x2.ChargesAccountAgentAccount).To(ValidAccount()))]));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "ChargesAccountAgent2Rule");
        Assert.Contains(result.Errors, e => e.PropertyName == "ChargesAccountAgentRule");
    }

    [Fact]
    public void TopLevelAgentOnly_DoesNotViolate_EitherRule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ChargesAccountAgent).To(ValidAgent()));
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "ChargesAccountAgent2Rule");
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "ChargesAccountAgentRule");
    }

    [Fact]
    public void RecordAgentOnly_DoesNotViolate_EitherRule()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Record).To([IsoDataFactory.With(MinimalRecord(), b2 => b2
            .Set(x2 => x2.ChargesAccountAgent).To(ValidAgent()))]));
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "ChargesAccountAgent2Rule");
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "ChargesAccountAgentRule");
    }
}
