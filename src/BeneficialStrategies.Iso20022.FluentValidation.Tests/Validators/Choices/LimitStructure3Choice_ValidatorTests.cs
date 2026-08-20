// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class LimitStructure3Choice_ValidatorTests
{
    private readonly LimitStructure3Choice_Validator _sut = new();

    private static BeneficialStrategies.Iso20022.Choices.LimitType1Choice_ ValidType() =>
        new BeneficialStrategies.Iso20022.Choices.LimitType1Choice.Code { Value = LimitType3Code.Bilateral };

    [Fact]
    public void AllCurrentLimitsVariant_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.LimitStructure3Choice.AllCurrentLimits
        {
            Value = new LimitIdentification9 { Type = ValidType() },
        };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void CurrentLimitIdentificationVariant_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.LimitStructure3Choice.CurrentLimitIdentification
        {
            Value = new LimitIdentification8 { Type = ValidType() },
        };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }
}
