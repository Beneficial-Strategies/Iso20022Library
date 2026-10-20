// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class ChargesPerTransaction3ValidatorTests
{
    private readonly ChargesPerTransaction3Validator _sut = new();

    private static IBranchAndFinancialInstitutionIdentification8 ValidAgent() =>
        IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b => b
            .Set(x => x.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>()));

    private static ICashAccount40 ValidAccount() => IsoDataFactory.Make<ICashAccount40>();

    private static IChargesBreakdown1 ValidChargesBreakdown() =>
        IsoDataFactory.Make<IChargesBreakdown1>(b => b
            .Set(x => x.Amount).To(new ActiveCurrencyAndAmount { Currency = "USD", Amount = 5m }));

    private static IChargesPerTransactionRecord3 MinimalRecord() =>
        IsoDataFactory.Make<IChargesPerTransactionRecord3>(b => b
            .Set(x => x.UnderlyingTransaction).To(IsoDataFactory.Make<ITransactionReferences7>())
            .Set(x => x.ChargesBreakdown).To([ValidChargesBreakdown()]));

    private static IChargesPerTransaction3 ValidMessage() => IsoDataFactory.Make<IChargesPerTransaction3>(b => b
        .Set(x => x.Record).To([MinimalRecord()]));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── Record: ChargesPerTransactionRecord3, 1..∞ ────────────────────────────

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
