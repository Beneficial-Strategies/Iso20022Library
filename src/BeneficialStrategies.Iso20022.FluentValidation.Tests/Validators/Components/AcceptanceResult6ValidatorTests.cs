// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class AcceptanceResult6ValidatorTests
{
    private readonly AcceptanceResult6Validator _sut = new();

    private static AcceptanceResult6 ValidMessage() => new() { Accepted = true };

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
            Accepted = false,
            RejectReason = new BeneficialStrategies.Iso20022.Choices.MandateReason1Choice.Code
            {
                Value = ExternalMandateReason1Code.IncorrectAccountNumber,
            },
            AdditionalRejectReasonInformation = ["Additional detail"],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
