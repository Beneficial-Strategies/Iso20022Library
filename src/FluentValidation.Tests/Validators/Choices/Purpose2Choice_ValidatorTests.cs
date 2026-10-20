// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class Purpose2Choice_ValidatorTests
{
    private readonly Purpose2Choice_Validator _sut = new();

    [Fact]
    public void CodeVariant_NoValidationErrors()
    {
        var value = IsoDataFactory.Make<Choices.Purpose2Choice.ICode>(b => b
            .Set(x => x.Value).To(ExternalPurpose1Code.BankLoanDelayedDrawFunding));
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ProprietaryVariant_NoValidationErrors()
    {
        var value = IsoDataFactory.Make<Choices.Purpose2Choice.IProprietary>(b => b
            .Set(x => x.Value).To("MYPURPOSE"));
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }
}
