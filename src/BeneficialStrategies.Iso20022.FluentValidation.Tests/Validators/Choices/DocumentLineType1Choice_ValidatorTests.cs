// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class DocumentLineType1Choice_ValidatorTests
{
    private readonly DocumentLineType1Choice_Validator _sut = new();

    [Fact]
    public void CodeVariant_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.DocumentLineType1Choice.Code
        {
            Value = ExternalDocumentLineType1Code.AdditionalProductIdentificationAssignedByTheManufacturer,
        };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ProprietaryVariant_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.DocumentLineType1Choice.Proprietary
        {
            Value = "MYLINETYPE",
        };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }
}
