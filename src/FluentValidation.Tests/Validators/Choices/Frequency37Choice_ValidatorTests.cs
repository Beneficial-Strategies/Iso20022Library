// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class Frequency37Choice_ValidatorTests
{
    private readonly Frequency37Choice_Validator _sut = new();

    [Fact]
    public void CodeVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.IFrequency37Choice choice =
            IsoDataFactory.Make<Choices.Frequency37Choice.ICode>(b => b
                .Set(x => x.Value).To(Frequency10Code.Annual));
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ProprietaryVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.IFrequency37Choice choice =
            IsoDataFactory.Make<Choices.Frequency37Choice.IProprietary>(b => b
                .Set(x => x.Value).To("MYFREQ"));
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }
}
