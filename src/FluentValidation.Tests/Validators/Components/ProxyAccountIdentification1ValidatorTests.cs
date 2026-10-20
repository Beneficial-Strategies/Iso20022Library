// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class ProxyAccountIdentification1ValidatorTests
{
    private readonly ProxyAccountIdentification1Validator _sut = new();

    private static IProxyAccountIdentification1 ValidMessage() => IsoDataFactory.Make<IProxyAccountIdentification1>(b => b
        .Set(x => x.Identification).To("alias@example.com"));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void Type_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Type).To(IsoDataFactory.Make<Choices.ProxyAccountType1Choice.IProprietary>(b2 => b2
                .Set(x2 => x2.Value).To("MYPROXYTYPE"))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
