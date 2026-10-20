// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class AddressType3Choice_ValidatorTests
{
    private readonly AddressType3Choice_Validator _sut = new();

    [Fact]
    public void CodeVariant_NoValidationErrors()
    {
        var choice = BeneficialStrategies.Iso20022.Samples.AddressType3Choice.Valid.Code.Minimal;
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ProprietaryVariant_NoValidationErrors()
    {
        var choice = BeneficialStrategies.Iso20022.Samples.AddressType3Choice.Valid.Proprietary.Minimal;
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }
}
