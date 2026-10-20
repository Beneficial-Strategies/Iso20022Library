// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class Frequency36Choice_ValidatorTests
{
    private readonly Frequency36Choice_Validator _sut = new();

    [Fact]
    public void TypeVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.IFrequency36Choice choice =
            IsoDataFactory.Make<Choices.Frequency36Choice.IType>(b => b
                .Set(x => x.Value).To(Frequency6Code.Monthly));
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void PeriodVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.IFrequency36Choice choice =
            IsoDataFactory.Make<Choices.Frequency36Choice.IPeriod>(b => b
                .Set(x => x.Type).To(Frequency6Code.Monthly)
                .Set(x => x.CountPerPeriod).To(2m));
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void PointInTimeVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.IFrequency36Choice choice =
            IsoDataFactory.Make<Choices.Frequency36Choice.IPointInTime>(b => b
                .Set(x => x.Type).To(Frequency6Code.Monthly)
                .Set(x => x.Value).To("15"));
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }
}
