// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class ServiceLevel8Choice_ValidatorTests
{
    private readonly ServiceLevel8Choice_Validator _sut = new();

    [Fact]
    public void CodeVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.IServiceLevel8Choice choice =
            IsoDataFactory.Make<Choices.ServiceLevel8Choice.ICode>(b => b
                .Set(x => x.Value).To(ExternalServiceLevel1Code.BookTransaction));
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ProprietaryVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.IServiceLevel8Choice choice =
            IsoDataFactory.Make<Choices.ServiceLevel8Choice.IProprietary>(b => b
                .Set(x => x.Value).To("MYSVCLVL"));
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }
}
