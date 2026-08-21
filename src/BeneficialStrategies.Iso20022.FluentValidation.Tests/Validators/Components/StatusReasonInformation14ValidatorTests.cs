// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class StatusReasonInformation14ValidatorTests
{
    private readonly StatusReasonInformation14Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(new StatusReasonInformation14()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = new StatusReasonInformation14
        {
            AdditionalInformation = ["Status note"],
            Originator = new PartyIdentification272 { Name = "Originator Co" },
            Reason = new BeneficialStrategies.Iso20022.Choices.StatusReason6Choice.Proprietary
            {
                Value = "MYSTATUSREASON",
            },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
