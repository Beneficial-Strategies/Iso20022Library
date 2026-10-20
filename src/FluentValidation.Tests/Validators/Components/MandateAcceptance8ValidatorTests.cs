// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class MandateAcceptance8ValidatorTests
{
    private readonly MandateAcceptance8Validator _sut = new();

    private static AcceptanceResult6 ValidAcceptanceResult() => new() { Accepted = true };

    private static MandateAcceptance8 ValidMessage() => new() { AcceptanceResult = ValidAcceptanceResult() };

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
            OriginalMandate = new BeneficialStrategies.Iso20022.Choices.OriginalMandate11Choice.OriginalMandateIdentification
            {
                Value = "ORIG-MNDT-001",
            },
            OriginalMessageInformation = new OriginalMessageInformation1
            {
                MessageIdentification = "ORIG-MSG-001",
                MessageNameIdentification = "pain.009.001.08",
            },
            SupplementaryData = [new SupplementaryData1 { Envelope = new SupplementaryDataEnvelope1() }],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
