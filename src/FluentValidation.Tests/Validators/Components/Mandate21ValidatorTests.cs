// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class Mandate21ValidatorTests
{
    private readonly Mandate21Validator _sut = new();

    private static IPartyIdentification272 ValidParty(string name) => IsoDataFactory.Make<IPartyIdentification272>(b => b
        .Set(x => x.Name).To(name));

    private static IMandate21 ValidMessage() =>
        IsoDataFactory.Make<IMandate21>(b => b
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
            .Set(x => x.Debtor).To(ValidParty("Debtor Co"))
            .Set(x => x.UltimateDebtor).To(ValidParty("Debtor Co")));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "UltimateDebtorGuideline");
    }

    [Fact]
    public void UltimateDebtor_DifferentFromDebtor_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Debtor).To(ValidParty("Debtor Co"))
            .Set(x => x.UltimateDebtor).To(ValidParty("Someone Else")));
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "UltimateDebtorGuideline");
    }

    [Fact]
    public void UltimateCreditor_SameAsCreditor_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Creditor).To(ValidParty("Creditor Co"))
            .Set(x => x.UltimateCreditor).To(ValidParty("Creditor Co")));
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "UltimateCreditorGuideline");
    }

    [Fact]
    public void UltimateCreditor_DifferentFromCreditor_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Creditor).To(ValidParty("Creditor Co"))
            .Set(x => x.UltimateCreditor).To(ValidParty("Someone Else")));
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "UltimateCreditorGuideline");
    }
}
