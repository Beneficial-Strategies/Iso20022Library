// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class AdviceType1Choice_ValidatorTests
{
    private readonly AdviceType1Choice_Validator _sut = new();

    [Fact]
    public void CodeVariant_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.AdviceType1Choice.Code
        {
            Value = AdviceType1Code.AdviceWithDetails,
        };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ProprietaryVariant_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.AdviceType1Choice.Proprietary { Value = "MYADVICE" };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }
}
