// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class DocumentAmountType1Choice_ValidatorTests
{
    private readonly DocumentAmountType1Choice_Validator _sut = new();

    [Fact]
    public void CodeVariant_NoValidationErrors()
    {
        var value = IsoDataFactory.Make<Choices.DocumentAmountType1Choice.ICode>(b => b
            .Set(x => x.Value).To(ExternalDocumentAmountType1Code.AdditionalPromotionalDiscount));
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ProprietaryVariant_NoValidationErrors()
    {
        var value = IsoDataFactory.Make<Choices.DocumentAmountType1Choice.IProprietary>(b => b
            .Set(x => x.Value).To("MYAMTTYPE"));
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }
}
