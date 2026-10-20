// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class StandingOrderOrAll4Choice_ValidatorTests
{
    private readonly StandingOrderOrAll4Choice_Validator _sut = new();

    private static CashAccount40 ValidAccount() =>
        new()
        {
            Identification = new BeneficialStrategies.Iso20022.Choices.AccountIdentification4Choice.IBAN
            {
                Value = "DE89370400440532013000",
            },
        };

    [Fact]
    public void AllStandingOrdersVariant_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.StandingOrderOrAll4Choice.AllStandingOrders
        {
            Value = new StandingOrderIdentification9 { Account = ValidAccount() },
        };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void StandingOrderVariant_NoValidationErrors()
    {
        var value = new BeneficialStrategies.Iso20022.Choices.StandingOrderOrAll4Choice.StandingOrder
        {
            Value = new StandingOrderIdentification8 { Account = ValidAccount() },
        };
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }
}
