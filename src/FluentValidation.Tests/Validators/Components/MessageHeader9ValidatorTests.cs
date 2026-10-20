// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class MessageHeader9ValidatorTests
{
    private readonly MessageHeader9Validator _sut = new();

    private static IMessageHeader9 ValidMessage() => IsoDataFactory.Make<IMessageHeader9>(b => b
        .Set(x => x.MessageIdentification).To("MSG-001"));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.CreationDateTime).To(new DateTime(2026, 1, 1))
            .Set(x => x.RequestType).To(IsoDataFactory.Make<Choices.RequestType4Choice.IProprietary>(b2 => b2
                .Set(x2 => x2.Identification).To("REQ-TYPE-001"))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
