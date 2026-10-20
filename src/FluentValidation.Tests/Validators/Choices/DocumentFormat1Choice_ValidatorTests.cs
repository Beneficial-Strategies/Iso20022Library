// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class DocumentFormat1Choice_ValidatorTests
{
    private readonly DocumentFormat1Choice_Validator _sut = new();

    [Fact]
    public void CodeVariant_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.DocumentFormat1Choice.Code
        {
            Value = ExternalDocumentFormat1Code.PDF,
        };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ProprietaryVariant_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.DocumentFormat1Choice.Proprietary
        {
            Identification = "FMT-001",
        };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }
}
