// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class OriginalMandate10Choice_ValidatorTests
{
    private readonly OriginalMandate10Choice_Validator _sut = new();

    [Fact]
    public void OriginalMandateIdentificationVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.OriginalMandate10Choice_ choice =
            new BeneficialStrategies.Iso20022.Choices.OriginalMandate10Choice.OriginalMandateIdentification
            {
                Value = "MNDT-001",
            };
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void OriginalMandateVariant_Valid_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.OriginalMandate10Choice_ choice =
            new BeneficialStrategies.Iso20022.Choices.OriginalMandate10Choice.OriginalMandate
            {
                Value = new Mandate20
                {
                    Creditor = new PartyIdentification272 { Name = "Creditor Co" },
                    Debtor = new PartyIdentification272 { Name = "Debtor Co" },
                    DebtorAgent = new BranchAndFinancialInstitutionIdentification8
                    {
                        FinancialInstitutionIdentification = new FinancialInstitutionIdentification23(),
                    },
                    MandateIdentification = "MNDT-001",
                    TrackingIndicator = true,
                },
            };
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void OriginalMandateVariant_InvalidNestedGuideline_PropagatesError()
    {
        var party = new PartyIdentification272 { Name = "Same Co" };
        BeneficialStrategies.Iso20022.Choices.OriginalMandate10Choice_ choice =
            new BeneficialStrategies.Iso20022.Choices.OriginalMandate10Choice.OriginalMandate
            {
                Value = new Mandate20
                {
                    Creditor = party,
                    Debtor = new PartyIdentification272 { Name = "Debtor Co" },
                    DebtorAgent = new BranchAndFinancialInstitutionIdentification8
                    {
                        FinancialInstitutionIdentification = new FinancialInstitutionIdentification23(),
                    },
                    MandateIdentification = "MNDT-001",
                    TrackingIndicator = true,
                    // Violates Mandate20's UltimateCreditorGuideline (must differ from Creditor).
                    UltimateCreditor = party,
                },
            };

        var result = _sut.Validate(choice);
        Assert.False(result.IsValid);
        Assert.Contains(result.Errors, e => e.PropertyName.Contains("UltimateCreditorGuideline"));
    }
}
