// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class GarnishmentType1Choice_ValidatorTests
{
    private readonly GarnishmentType1Choice_Validator _sut = new();

    [Fact]
    public void CodeVariant_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.GarnishmentType1Choice.Code
        {
            Value = ExternalGarnishmentType1Code.GarnishmentForChildSupport,
        };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ProprietaryVariant_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.GarnishmentType1Choice.Proprietary
        {
            Value = "MYGARNISHMENT",
        };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }
}
