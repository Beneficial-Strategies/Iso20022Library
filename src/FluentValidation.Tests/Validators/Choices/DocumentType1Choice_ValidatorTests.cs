// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class DocumentType1Choice_ValidatorTests
{
    private readonly DocumentType1Choice_Validator _sut = new();

    [Fact]
    public void CodeVariant_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.DocumentType1Choice.Code
        {
            Value = ExternalDocumentType1Code.CommercialInvoice,
        };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ProprietaryVariant_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.DocumentType1Choice.Proprietary
        {
            Identification = "TYP-001",
        };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }
}
