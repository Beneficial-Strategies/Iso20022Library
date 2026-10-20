// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class OriginalMandate11Choice_ValidatorTests
{
    private readonly OriginalMandate11Choice_Validator _sut = new();

    private static PartyIdentification272 ValidParty(string name) => new() { Name = name };

    private static BranchAndFinancialInstitutionIdentification8 ValidAgent() =>
        new() { FinancialInstitutionIdentification = new FinancialInstitutionIdentification23() };

    private static Mandate22 ValidMandate() =>
        new()
        {
            Creditor = ValidParty("Creditor Co"),
            Debtor = ValidParty("Debtor Co"),
            DebtorAgent = ValidAgent(),
            TrackingIndicator = true,
        };

    [Fact]
    public void OriginalMandateIdentificationVariant_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.OriginalMandate11Choice.OriginalMandateIdentification
        {
            Value = "MNDT-001",
        };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void OriginalMandateVariant_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.OriginalMandate11Choice.OriginalMandate
        {
            Value = ValidMandate(),
        };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }
}
