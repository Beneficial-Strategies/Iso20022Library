// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class StandingOrderOrAll4Choice_ValidatorTests
{
    private readonly StandingOrderOrAll4Choice_Validator _sut = new();

    [Fact]
    public void AllStandingOrdersVariant_NoValidationErrors()
    {
        var value = BeneficialStrategies.Iso20022.Messages.Samples.StandingOrderOrAll4Choice.Valid.AllStandingOrders.Minimal;
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void StandingOrderVariant_NoValidationErrors()
    {
        var value = BeneficialStrategies.Iso20022.Messages.Samples.StandingOrderOrAll4Choice.Valid.StandingOrder.Minimal;
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }
}
