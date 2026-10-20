// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class ReturnReason5Choice_ValidatorTests
{
    private readonly ReturnReason5Choice_Validator _sut = new();

    [Fact]
    public void CodeVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.IReturnReason5Choice choice =
            IsoDataFactory.Make<Choices.ReturnReason5Choice.ICode>(b => b
                .Set(x => x.Value).To(ExternalReturnReason1Code.IncorrectAccountNumber));
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ProprietaryVariant_NoValidationErrors()
    {
        BeneficialStrategies.Iso20022.Choices.IReturnReason5Choice choice =
            IsoDataFactory.Make<Choices.ReturnReason5Choice.IProprietary>(b => b
                .Set(x => x.Value).To("CUSTOM-REASON"));
        _sut.TestValidate(choice).ShouldNotHaveAnyValidationErrors();
    }
}
