// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class ClearingSystemIdentification3Choice_ValidatorTests
{
    private readonly ClearingSystemIdentification3Choice_Validator _sut = new();

    [Fact]
    public void CodeVariant_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.ClearingSystemIdentification3Choice.Code
        {
            Value = ExternalCashClearingSystem1Code.EBAEuro1Step1,
        };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ProprietaryVariant_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.ClearingSystemIdentification3Choice.Proprietary
        {
            Value = "MYSYS",
        };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }
}
