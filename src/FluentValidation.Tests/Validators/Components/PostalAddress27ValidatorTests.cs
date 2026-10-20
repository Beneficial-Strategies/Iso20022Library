// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class PostalAddress27ValidatorTests
{
    private readonly PostalAddress27Validator _sut = new();

    private static IPostalAddress27 ValidMessage() => IsoDataFactory.Make<IPostalAddress27>();

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AddressType_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.AddressType).To(IsoDataFactory.Make<Choices.AddressType3Choice.ICode>(b2 => b2
                .Set(x2 => x2.Value).To(AddressType2Code.Business))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
