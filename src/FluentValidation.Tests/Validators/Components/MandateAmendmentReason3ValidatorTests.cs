// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class MandateAmendmentReason3ValidatorTests
{
    private readonly MandateAmendmentReason3Validator _sut = new();

    private static BeneficialStrategies.Iso20022.Choices.MandateReason1Choice_ ValidReason() =>
        new BeneficialStrategies.Iso20022.Choices.MandateReason1Choice.Code
        {
            Value = ExternalMandateReason1Code.IncorrectAccountNumber,
        };

    private static MandateAmendmentReason3 ValidMessage() => new() { Reason = ValidReason() };

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
            AdditionalInformation = ["Additional detail"],
            Originator = new PartyIdentification272 { Name = "Originator Co" },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
