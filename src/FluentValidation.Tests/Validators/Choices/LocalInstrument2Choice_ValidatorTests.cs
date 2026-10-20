// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class LocalInstrument2Choice_ValidatorTests
{
    private readonly LocalInstrument2Choice_Validator _sut = new();

    [Fact]
    public void CodeVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.ILocalInstrument2Choice choice =
            IsoDataFactory.Make<Choices.LocalInstrument2Choice.ICode>(b => b
                .Set(x => x.Value).To(ExternalLocalInstrument1Code.BatchPaymentsAruba));
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ProprietaryVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.ILocalInstrument2Choice choice =
            IsoDataFactory.Make<Choices.LocalInstrument2Choice.IProprietary>(b => b
                .Set(x => x.Value).To("MYINSTR"));
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }
}
