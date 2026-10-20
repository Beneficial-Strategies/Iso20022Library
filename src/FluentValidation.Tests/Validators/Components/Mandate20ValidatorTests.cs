// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class Mandate20ValidatorTests
{
    private readonly Mandate20Validator _sut = new();

    private static PartyIdentification272 ValidParty(string name) => new() { Name = name };

    private static BranchAndFinancialInstitutionIdentification8 ValidAgent() =>
        new() { FinancialInstitutionIdentification = new FinancialInstitutionIdentification23() };

    private static Mandate20 ValidMessage() =>
        new()
        {
            Creditor = ValidParty("Creditor Co"),
            Debtor = ValidParty("Debtor Co"),
            DebtorAgent = ValidAgent(),
            MandateIdentification = "MNDT-001",
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
    public void UltimateDebtor_DifferentFromDebtor_NoValidationError()
    {
        var msg = ValidMessage() with { UltimateDebtor = ValidParty("Someone Else") };
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "UltimateDebtorGuideline");
    }

    [Fact]
    public void UltimateCreditor_SameAsCreditor_HasValidationError()
    {
        var msg = ValidMessage() with { UltimateCreditor = ValidParty("Creditor Co") };
        var result = _sut.Validate(msg);
        Assert.Contains(result.Errors, e => e.PropertyName == "UltimateCreditorGuideline");
    }

    [Fact]
    public void UltimateCreditor_DifferentFromCreditor_NoValidationError()
    {
        var msg = ValidMessage() with { UltimateCreditor = ValidParty("Someone Else") };
        var result = _sut.Validate(msg);
        Assert.DoesNotContain(result.Errors, e => e.PropertyName == "UltimateCreditorGuideline");
    }

    // ── Deep nested children ────────────────────────────────────────────────────

    [Fact]
    public void AllOptionalChildren_Present_NoValidationError()
    {
        var account = new CashAccount40
        {
            Identification = new BeneficialStrategies.Iso20022.Choices.AccountIdentification4Choice.IBAN
            {
                Value = "DE89370400440532013000",
            },
        };
        var msg = ValidMessage() with
        {
            Adjustment = new MandateAdjustment1 { DateAdjustmentRuleIndicator = false },
            Authentication = new MandateAuthentication1(),
            CreditorAccount = account,
            CreditorAgent = ValidAgent(),
            CreditorSchemeIdentification = ValidParty("Scheme Owner"),
            DebtorAccount = account,
            Occurrences = new MandateOccurrences5 { SequenceType = SequenceType2Code.Recurring },
            Reason = new BeneficialStrategies.Iso20022.Choices.MandateSetupReason1Choice.Proprietary
            {
                Value = "MYREASON",
            },
            ReferredDocument = [new ReferredMandateDocument2()],
            Type = new MandateTypeInformation2(),
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
