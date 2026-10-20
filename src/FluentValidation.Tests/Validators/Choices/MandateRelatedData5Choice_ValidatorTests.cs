// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class MandateRelatedData5Choice_ValidatorTests
{
    private readonly MandateRelatedData5Choice_Validator _sut = new();

    [Fact]
    public void DirectDebitMandateVariant_NoValidationErrors()
    {
        var value = IsoDataFactory.Make<Choices.MandateRelatedData5Choice.IDirectDebitMandate>(b => b
            .Set(x => x.Value).To(IsoDataFactory.Make<IMandateRelatedInformation16>()));
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void CreditTransferMandateVariant_NoValidationErrors()
    {
        var value = IsoDataFactory.Make<Choices.MandateRelatedData5Choice.ICreditTransferMandate>(b => b
            .Set(x => x.Value).To(IsoDataFactory.Make<ICreditTransferMandateData1>()));
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }
}
