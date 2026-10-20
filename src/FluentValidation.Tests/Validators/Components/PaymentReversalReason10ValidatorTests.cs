// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class PaymentReversalReason10ValidatorTests
{
    private readonly PaymentReversalReason10Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(new PaymentReversalReason10()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = new PaymentReversalReason10
        {
            AdditionalInformation = ["Reversal note"],
            Originator = new PartyIdentification272 { Name = "Originator Co" },
            Reason = new BeneficialStrategies.Iso20022.Choices.ReversalReason4Choice.Proprietary
            {
                Value = "MYREVREASON",
            },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
