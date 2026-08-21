// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class MandateReason1Choice_ValidatorTests
{
    private readonly MandateReason1Choice_Validator _sut = new();

    [Fact]
    public void CodeVariant_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.MandateReason1Choice.Code
        {
            Value = ExternalMandateReason1Code.IncorrectAccountNumber,
        };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ProprietaryVariant_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.MandateReason1Choice.Proprietary { Value = "MYREASON" };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }
}
