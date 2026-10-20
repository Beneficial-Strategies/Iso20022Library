// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class ReservationType2Choice_ValidatorTests
{
    private readonly ReservationType2Choice_Validator _sut = new();

    [Fact]
    public void CodeVariant_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.ReservationType2Choice.Code
        {
            Value = ExternalReservationType1Code.CashReservation,
        };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void ProprietaryVariant_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.ReservationType2Choice.Proprietary
        {
            Value = "MYRESERVATION",
        };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }
}
