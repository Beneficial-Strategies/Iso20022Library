// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class Mandate21ValidatorTests
{
    private readonly Mandate21Validator _sut = new();

    private static PartyIdentification272 ValidParty(string name) => new() { Name = name };

    private static Mandate21 ValidMessage() =>
        new() { MandateIdentification = "MNDT-001", TrackingIndicator = true };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── UltimateDebtorGuideline / UltimateCreditorGuideline ────────────────────

    [Fact]
    public void UltimateDebtor_SameAsDebtor_HasValidationError()
    {
        var msg = ValidMessage() with { Debtor = ValidParty("Debtor Co"), UltimateDebtor = ValidParty("Debtor Co") };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "UltimateDebtorGuideline");
    }

    [Fact]
    public void UltimateDebtor_DifferentFromDebtor_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            Debtor = ValidParty("Debtor Co"),
            UltimateDebtor = ValidParty("Someone Else"),
        };
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "UltimateDebtorGuideline");
    }

    [Fact]
    public void UltimateCreditor_SameAsCreditor_HasValidationError()
    {
        var msg = ValidMessage() with
        {
            Creditor = ValidParty("Creditor Co"),
            UltimateCreditor = ValidParty("Creditor Co"),
        };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "UltimateCreditorGuideline");
    }

    [Fact]
    public void UltimateCreditor_DifferentFromCreditor_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            Creditor = ValidParty("Creditor Co"),
            UltimateCreditor = ValidParty("Someone Else"),
        };
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "UltimateCreditorGuideline");
    }
}
