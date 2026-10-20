// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class OriginalMandate10Choice_ValidatorTests
{
    private readonly OriginalMandate10Choice_Validator _sut = new();

    [Fact]
    public void OriginalMandateIdentificationVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.IOriginalMandate10Choice choice =
            IsoDataFactory.Make<Choices.OriginalMandate10Choice.IOriginalMandateIdentification>(b => b
                .Set(x => x.Value).To("MNDT-001"));
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void OriginalMandateVariant_Valid_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.IOriginalMandate10Choice choice =
            IsoDataFactory.Make<Choices.OriginalMandate10Choice.IOriginalMandate>(b => b
                .Set(x => x.Value).To(IsoDataFactory.Make<IMandate20>(b2 => b2
                    .Set(x2 => x2.Creditor).To(IsoDataFactory.Make<IPartyIdentification272>(b3 => b3
                        .Set(x3 => x3.Name).To("Creditor Co")))
                    .Set(x2 => x2.Debtor).To(IsoDataFactory.Make<IPartyIdentification272>(b3 => b3
                        .Set(x3 => x3.Name).To("Debtor Co")))
                    .Set(x2 => x2.DebtorAgent).To(IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b3 => b3
                        .Set(x3 => x3.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>())))
                    .Set(x2 => x2.MandateIdentification).To("MNDT-001")
                    .Set(x2 => x2.TrackingIndicator).To(true))));
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void OriginalMandateVariant_InvalidNestedGuideline_PropagatesError()
    {
        var party = IsoDataFactory.Make<IPartyIdentification272>(b => b
            .Set(x => x.Name).To("Same Co"));
        BeneficialStrategies.Iso20022.Choices.IOriginalMandate10Choice choice =
            IsoDataFactory.Make<Choices.OriginalMandate10Choice.IOriginalMandate>(b => b
                .Set(x => x.Value).To(IsoDataFactory.Make<IMandate20>(b2 => b2
                    .Set(x2 => x2.Creditor).To(party)
                    .Set(x2 => x2.Debtor).To(IsoDataFactory.Make<IPartyIdentification272>(b3 => b3
                        .Set(x3 => x3.Name).To("Debtor Co")))
                    .Set(x2 => x2.DebtorAgent).To(IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b3 => b3
                        .Set(x3 => x3.FinancialInstitutionIdentification).To(IsoDataFactory.Make<IFinancialInstitutionIdentification23>())))
                    .Set(x2 => x2.MandateIdentification).To("MNDT-001")
                    .Set(x2 => x2.TrackingIndicator).To(true)
                    .Set(x2 => x2.UltimateCreditor).To(party))));

        var result = _sut.Validate(choice);
        Assert.False(result.IsValid);
        Assert.Contains(result.Errors, e => e.PropertyName.Contains("UltimateCreditorGuideline"));
    }
}
