// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class MandateStatus1Choice_ValidatorTests
{
    private readonly MandateStatus1Choice_Validator _sut = new();

    [Fact]
    public void CodeVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.IMandateStatus1Choice choice =
            IsoDataFactory.Make<Choices.MandateStatus1Choice.ICode>(b => b
                .Set(x => x.Value).To(ExternalMandateStatus1Code.Active));
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ProprietaryVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.IMandateStatus1Choice choice =
            IsoDataFactory.Make<Choices.MandateStatus1Choice.IProprietary>(b => b
                .Set(x => x.Value).To("CUSTOMSTATUS"));
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }
}
