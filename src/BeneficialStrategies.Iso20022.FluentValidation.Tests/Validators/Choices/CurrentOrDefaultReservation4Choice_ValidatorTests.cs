// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class CurrentOrDefaultReservation4Choice_ValidatorTests
{
    private readonly CurrentOrDefaultReservation4Choice_Validator _sut = new();

    [Fact]
    public void CurrentVariant_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.CurrentOrDefaultReservation4Choice.Current
        {
            Value = new ReservationIdentification4
            {
                Type = new BeneficialStrategies.Iso20022.Choices.ReservationType2Choice.Code
                {
                    Value = ExternalReservationType1Code.CashReservation,
                },
            },
        };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void DefaultVariant_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.CurrentOrDefaultReservation4Choice.Default
        {
            Value = new ReservationIdentification4
            {
                Type = new BeneficialStrategies.Iso20022.Choices.ReservationType2Choice.Code
                {
                    Value = ExternalReservationType1Code.CashReservation,
                },
            },
        };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }
}
