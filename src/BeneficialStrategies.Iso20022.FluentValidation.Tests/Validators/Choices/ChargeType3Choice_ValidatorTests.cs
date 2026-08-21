// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class ChargeType3Choice_ValidatorTests
{
    private readonly ChargeType3Choice_Validator _sut = new();

    [Fact]
    public void CodeVariant_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.ChargeType3Choice.Code
        {
            Value = ExternalChargeType1Code.BrokerageFee,
        };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ProprietaryVariant_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.ChargeType3Choice.Proprietary
        {
            Identification = "CHG-001",
        };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }
}
