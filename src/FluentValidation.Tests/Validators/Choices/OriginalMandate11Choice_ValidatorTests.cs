// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class OriginalMandate11Choice_ValidatorTests
{
    private readonly OriginalMandate11Choice_Validator _sut = new();

    private static IPartyIdentification272 ValidParty(string name) => IsoDataFactory.Make<IPartyIdentification272>(b => b
        .Set(x => x.Name).To(name));

    private static IBranchAndFinancialInstitutionIdentification8 ValidAgent() =>
        IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b => b
            .Set(x => x.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>()));

    private static IMandate22 ValidMandate() =>
        IsoDataFactory.Make<IMandate22>(b => b
            .Set(x => x.Creditor).To(ValidParty("Creditor Co"))
            .Set(x => x.Debtor).To(ValidParty("Debtor Co"))
            .Set(x => x.DebtorAgent).To(ValidAgent())
            .Set(x => x.TrackingIndicator).To(true));

    [Fact]
    public void OriginalMandateIdentificationVariant_NoValidationErrors()
    {
        var value = IsoDataFactory.Make<Choices.OriginalMandate11Choice.IOriginalMandateIdentification>(b => b
            .Set(x => x.Value).To("MNDT-001"));
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void OriginalMandateVariant_NoValidationErrors()
    {
        var value = IsoDataFactory.Make<Choices.OriginalMandate11Choice.IOriginalMandate>(b => b
            .Set(x => x.Value).To(ValidMandate()));
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }
}
