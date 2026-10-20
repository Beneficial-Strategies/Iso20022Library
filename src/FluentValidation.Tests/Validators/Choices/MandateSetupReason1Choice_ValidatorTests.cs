// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class MandateSetupReason1Choice_ValidatorTests
{
    private readonly MandateSetupReason1Choice_Validator _sut = new();

    [Fact]
    public void CodeVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.IMandateSetupReason1Choice choice =
            IsoDataFactory.Make<Choices.MandateSetupReason1Choice.ICode>(b => b
                .Set(x => x.Value).To(new ExternalMandateSetupReason1Code("RIKA")));
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ProprietaryVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.IMandateSetupReason1Choice choice =
            IsoDataFactory.Make<Choices.MandateSetupReason1Choice.IProprietary>(b => b
                .Set(x => x.Value).To("MYREASON"));
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }
}
