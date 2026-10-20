// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class Mandate20ValidatorTests
{
    private readonly Mandate20Validator _sut = new();

    private static IPartyIdentification272 ValidParty(string name) => IsoDataFactory.Make<IPartyIdentification272>(b => b
        .Set(x => x.Name).To(name));

    private static IBranchAndFinancialInstitutionIdentification8 ValidAgent() =>
        IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b => b
            .Set(x => x.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>()));

    private static IMandate20 ValidMessage() =>
        IsoDataFactory.Make<IMandate20>(b => b
            .Set(x => x.Creditor).To(ValidParty("Creditor Co"))
            .Set(x => x.Debtor).To(ValidParty("Debtor Co"))
            .Set(x => x.DebtorAgent).To(ValidAgent())
            .Set(x => x.MandateIdentification).To("MNDT-001")
            .Set(x => x.TrackingIndicator).To(true));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── UltimateDebtorGuideline / UltimateCreditorGuideline ────────────────────

    [Fact]
    public void UltimateDebtor_SameAsDebtor_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.UltimateDebtor).To(ValidParty("Debtor Co")));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "UltimateDebtorGuideline");
    }

    [Fact]
    public void UltimateDebtor_DifferentFromDebtor_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.UltimateDebtor).To(ValidParty("Someone Else")));
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "UltimateDebtorGuideline");
    }

    [Fact]
    public void UltimateCreditor_SameAsCreditor_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.UltimateCreditor).To(ValidParty("Creditor Co")));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "UltimateCreditorGuideline");
    }

    [Fact]
    public void UltimateCreditor_DifferentFromCreditor_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.UltimateCreditor).To(ValidParty("Someone Else")));
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "UltimateCreditorGuideline");
    }

    // ── Deep nested children ────────────────────────────────────────────────────

    [Fact]
    public void AllOptionalChildren_Present_NoValidationError()
    {
        var account = IsoDataFactory.Make<ICashAccount40>(b => b
            .Set(x => x.Identification).To(IsoDataFactory.Make<Choices.AccountIdentification4Choice.IIBAN>(b2 => b2
                .Set(x2 => x2.Value).To("DE89370400440532013000"))));
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Adjustment).To(IsoDataFactory.Make<IMandateAdjustment1>(b2 => b2
                .Set(x2 => x2.DateAdjustmentRuleIndicator).To(false)))
            .Set(x => x.Authentication).To(IsoDataFactory.Make<IMandateAuthentication1>())
            .Set(x => x.CreditorAccount).To(account)
            .Set(x => x.CreditorAgent).To(ValidAgent())
            .Set(x => x.CreditorSchemeIdentification).To(ValidParty("Scheme Owner"))
            .Set(x => x.DebtorAccount).To(account)
            .Set(x => x.Occurrences).To(IsoDataFactory.Make<IMandateOccurrences5>(b2 => b2
                .Set(x2 => x2.SequenceType).To(SequenceType2Code.Recurring)))
            .Set(x => x.Reason).To(IsoDataFactory.Make<Choices.MandateSetupReason1Choice.IProprietary>(b2 => b2
                .Set(x2 => x2.Value).To("MYREASON")))
            .Set(x => x.ReferredDocument).To([IsoDataFactory.Make<IReferredMandateDocument2>()])
            .Set(x => x.Type).To(IsoDataFactory.Make<IMandateTypeInformation2>()));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
