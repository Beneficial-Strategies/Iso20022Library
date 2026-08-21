// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class MessageHeader7ValidatorTests
{
    private readonly MessageHeader7Validator _sut = new();

    private static MessageHeader7 ValidMessage() => new() { MessageIdentification = "MSG-001" };

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
            OriginalBusinessQuery = new OriginalBusinessQuery1 { MessageIdentification = "ORIG-MSG-001" },
            QueryName = "PREVIOUS-QUERY",
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
