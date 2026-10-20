// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class DocumentFormat1Choice_ValidatorTests
{
    private readonly DocumentFormat1Choice_Validator _sut = new();

    [Fact]
    public void CodeVariant_NoValidationErrors()
    {
        var value = IsoDataFactory.Make<Choices.DocumentFormat1Choice.ICode>(b => b
            .Set(x => x.Value).To(ExternalDocumentFormat1Code.PDF));
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ProprietaryVariant_NoValidationErrors()
    {
        var value = IsoDataFactory.Make<Choices.DocumentFormat1Choice.IProprietary>(b => b
            .Set(x => x.Identification).To("FMT-001"));
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }
}
