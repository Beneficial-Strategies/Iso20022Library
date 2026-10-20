// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class ReversalReason4Choice_ValidatorTests
{
    private readonly ReversalReason4Choice_Validator _sut = new();

    [Fact]
    public void CodeVariant_NoValidationErrors()
    {
        var value = IsoDataFactory.Make<Choices.ReversalReason4Choice.ICode>(b => b
            .Set(x => x.Value).To(ExternalReversalReason1Code.InvalidCreditorAccountNumber));
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ProprietaryVariant_NoValidationErrors()
    {
        var value = IsoDataFactory.Make<Choices.ReversalReason4Choice.IProprietary>(b => b
            .Set(x => x.Value).To("MYREVREASON"));
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }
}
