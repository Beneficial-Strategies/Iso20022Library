// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class MandateSuspensionReason3ValidatorTests
{
    private readonly MandateSuspensionReason3Validator _sut = new();

    private static BeneficialStrategies.Iso20022.Choices.MandateSuspensionReason1Choice_ ValidReason() =>
        new BeneficialStrategies.Iso20022.Choices.MandateSuspensionReason1Choice.Code
        {
            Value = ExternalMandateSuspensionReason1Code.ContractAmended,
        };

    private static MandateSuspensionReason3 ValidMessage() => new() { Reason = ValidReason() };

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
