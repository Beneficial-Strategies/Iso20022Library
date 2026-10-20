// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class Frequency36Choice_ValidatorTests
{
    private readonly Frequency36Choice_Validator _sut = new();

    [Fact]
    public void TypeVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.Frequency36Choice_ choice =
            new BeneficialStrategies.Iso20022.Choices.Frequency36Choice.Type
            {
                Value = Frequency6Code.Monthly,
            };
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void PeriodVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.Frequency36Choice_ choice =
            new BeneficialStrategies.Iso20022.Choices.Frequency36Choice.Period
            {
                Type = Frequency6Code.Monthly,
                CountPerPeriod = 2m,
            };
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void PointInTimeVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.Frequency36Choice_ choice =
            new BeneficialStrategies.Iso20022.Choices.Frequency36Choice.PointInTime
            {
                Type = Frequency6Code.Monthly,
                Value = "15",
            };
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }
}
