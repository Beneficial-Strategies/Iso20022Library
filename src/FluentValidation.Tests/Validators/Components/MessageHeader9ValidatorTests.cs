// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class MessageHeader9ValidatorTests
{
    private readonly MessageHeader9Validator _sut = new();

    private static MessageHeader9 ValidMessage() => new() { MessageIdentification = "MSG-001" };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            CreationDateTime = new DateTime(2026, 1, 1),
            RequestType = new BeneficialStrategies.Iso20022.Choices.RequestType4Choice.Proprietary
            {
                Identification = "REQ-TYPE-001",
            },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
