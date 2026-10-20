// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.ChoiceValidators;

public class StandingOrderOrAll4Choice_ValidatorTests
{
    private readonly StandingOrderOrAll4Choice_Validator _sut = new();

    private static ICashAccount40 ValidAccount() =>
        IsoDataFactory.Make<ICashAccount40>(b => b
            .Set(x => x.Identification).To(IsoDataFactory.Make<Choices.AccountIdentification4Choice.IIBAN>(b2 => b2
                .Set(x2 => x2.Value).To("DE89370400440532013000"))));

    [Fact]
    public void AllStandingOrdersVariant_NoValidationErrors()
    {
        var value = IsoDataFactory.Make<Choices.StandingOrderOrAll4Choice.IAllStandingOrders>(b => b
            .Set(x => x.Value).To(IsoDataFactory.Make<IStandingOrderIdentification9>(b2 => b2
                .Set(x2 => x2.Account).To(ValidAccount()))));
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void StandingOrderVariant_NoValidationErrors()
    {
        var value = IsoDataFactory.Make<Choices.StandingOrderOrAll4Choice.IStandingOrder>(b => b
            .Set(x => x.Value).To(IsoDataFactory.Make<IStandingOrderIdentification8>(b2 => b2
                .Set(x2 => x2.Account).To(ValidAccount()))));
        _sut.TestValidate(value).ShouldNotHaveAnyValidationErrors();
    }
}
