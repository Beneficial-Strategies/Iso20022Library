// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class Mandate22ValidatorTests
{
    private readonly Mandate22Validator _sut = new();

    private static IPartyIdentification272 ValidParty(string name) => IsoDataFactory.Make<IPartyIdentification272>(b => b
        .Set(x => x.Name).To(name));

    private static IBranchAndFinancialInstitutionIdentification8 ValidAgent() =>
        IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b => b
            .Set(x => x.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>()));

    private static IMandate22 ValidMessage() =>
        IsoDataFactory.Make<IMandate22>(b => b
            .Set(x => x.Creditor).To(ValidParty("Creditor Co"))
            .Set(x => x.Debtor).To(ValidParty("Debtor Co"))
            .Set(x => x.DebtorAgent).To(ValidAgent())
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
    public void UltimateCreditor_SameAsCreditor_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.UltimateCreditor).To(ValidParty("Creditor Co")));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "UltimateCreditorGuideline");
    }
}
