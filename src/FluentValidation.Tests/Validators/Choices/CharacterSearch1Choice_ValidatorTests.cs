// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class CharacterSearch1Choice_ValidatorTests
{
    private readonly CharacterSearch1Choice_Validator _sut = new();

    [Fact]
    public void EqualVariant_NoValidationErrors()
    {
        var value = BeneficialStrategies.Iso20022.Messages.Samples.CharacterSearch1Choice.Valid.Equal.Minimal;
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ContainVariant_NoValidationErrors()
    {
        var value = BeneficialStrategies.Iso20022.Messages.Samples.CharacterSearch1Choice.Valid.Contain.Minimal;
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }
}
