// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class CategoryPurpose1Choice_ValidatorTests
{
    private readonly CategoryPurpose1Choice_Validator _sut = new();

    [Fact]
    public void CodeVariant_NoValidationErrors()
    {
        var choice = BeneficialStrategies.Iso20022.Messages.Samples.CategoryPurpose1Choice.Valid.Code.Minimal;
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ProprietaryVariant_NoValidationErrors()
    {
        var choice = BeneficialStrategies.Iso20022.Messages.Samples.CategoryPurpose1Choice.Valid.Proprietary.Minimal;
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }
}
