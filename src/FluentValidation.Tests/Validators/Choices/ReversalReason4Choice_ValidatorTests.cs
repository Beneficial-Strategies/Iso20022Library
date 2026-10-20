// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class ReversalReason4Choice_ValidatorTests
{
    private readonly ReversalReason4Choice_Validator _sut = new();

    [Fact]
    public void CodeVariant_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.ReversalReason4Choice.Code
        {
            Value = ExternalReversalReason1Code.InvalidCreditorAccountNumber,
        };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ProprietaryVariant_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.ReversalReason4Choice.Proprietary
        {
            Value = "MYREVREASON",
        };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }
}
