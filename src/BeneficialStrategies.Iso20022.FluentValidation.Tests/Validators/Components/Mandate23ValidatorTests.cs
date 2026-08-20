// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class Mandate23ValidatorTests
{
    private readonly Mandate23Validator _sut = new();

    private static PartyIdentification272 ValidParty(string name) => new() { Name = name };

    private static BranchAndFinancialInstitutionIdentification8 ValidAgent() =>
        new() { FinancialInstitutionIdentification = new FinancialInstitutionIdentification23() };

    private static Mandate23 ValidMessage() =>
        new()
        {
            Creditor = ValidParty("Creditor Co"),
            Debtor = ValidParty("Debtor Co"),
            DebtorAgent = ValidAgent(),
            MandateRequestIdentification = "MNDTREQ-001",
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
            CollectionAmount = new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 50m },
            CreditorAccount = account,
            CreditorAgent = ValidAgent(),
            CreditorSchemeIdentification = ValidParty("Scheme Owner"),
            DebtorAccount = account,
            FirstCollectionAmount = new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 75m },
            MandateIdentification = ["MNDT-001"],
            MaximumAmount = new ActiveCurrencyAndAmount { Currency = "EUR", Amount = 500m },
            Occurrences = new MandateOccurrences5 { SequenceType = SequenceType2Code.Recurring },
            Reason = new BeneficialStrategies.Iso20022.Choices.MandateSetupReason1Choice.Proprietary
            {
                Value = "MYREASON",
            },
            ReferredDocument = [new ReferredMandateDocument2()],
            SupplementaryData = [new SupplementaryData1 { Envelope = new SupplementaryDataEnvelope1() }],
            Type = new MandateTypeInformation2(),
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
