// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class Mandate22ValidatorTests
{
    private readonly Mandate22Validator _sut = new();

    private static PartyIdentification272 ValidParty(string name) => new() { Name = name };

    private static BranchAndFinancialInstitutionIdentification8 ValidAgent() =>
        new() { FinancialInstitutionIdentification = new FinancialInstitutionIdentification23() };

    private static Mandate22 ValidMessage() =>
        new()
        {
            Creditor = ValidParty("Creditor Co"),
            Debtor = ValidParty("Debtor Co"),
            DebtorAgent = ValidAgent(),
            TrackingIndicator = true,
        };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── UltimateDebtorGuideline / UltimateCreditorGuideline ────────────────────

    [Fact]
    public void UltimateDebtor_SameAsDebtor_HasValidationError()
    {
        var msg = ValidMessage() with { UltimateDebtor = ValidParty("Debtor Co") };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "UltimateDebtorGuideline");
    }

    [Fact]
    public void UltimateCreditor_SameAsCreditor_HasValidationError()
    {
        var msg = ValidMessage() with { UltimateCreditor = ValidParty("Creditor Co") };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "UltimateCreditorGuideline");
    }
}
