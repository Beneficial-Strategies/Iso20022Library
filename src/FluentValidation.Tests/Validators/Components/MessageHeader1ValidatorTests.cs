// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class MessageHeader1ValidatorTests
{
    private readonly MessageHeader1Validator _sut = new();

    private static IMessageHeader1 ValidMessage() => IsoDataFactory.Make<IMessageHeader1>(b => b
        .Set(x => x.MessageIdentification).To("MSG-001"));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void CreationDateTime_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.CreationDateTime).To(new DateTime(2026, 1, 1)));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
