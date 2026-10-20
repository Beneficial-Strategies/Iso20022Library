// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class MandateSuspensionReason1Choice_ValidatorTests
{
    private readonly MandateSuspensionReason1Choice_Validator _sut = new();

    [Fact]
    public void CodeVariant_NoValidationErrors()
    {
        var value = IsoDataFactory.Make<Choices.MandateSuspensionReason1Choice.ICode>(b => b
            .Set(x => x.Value).To(ExternalMandateSuspensionReason1Code.ContractAmended));
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ProprietaryVariant_NoValidationErrors()
    {
        var value = IsoDataFactory.Make<Choices.MandateSuspensionReason1Choice.IProprietary>(b => b
            .Set(x => x.Value).To("MYREASON"));
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }
}
