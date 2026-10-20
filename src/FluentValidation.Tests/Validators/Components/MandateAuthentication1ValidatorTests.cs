// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class MandateAuthentication1ValidatorTests
{
    private readonly MandateAuthentication1Validator _sut = new();

    private static IMandateAuthentication1 ValidMessage() => IsoDataFactory.Make<IMandateAuthentication1>();

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void Channel_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Channel).To(IsoDataFactory.Make<Choices.AuthenticationChannel1Choice.IProprietary>(b2 => b2
                .Set(x2 => x2.Value).To("CHANNELX"))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
