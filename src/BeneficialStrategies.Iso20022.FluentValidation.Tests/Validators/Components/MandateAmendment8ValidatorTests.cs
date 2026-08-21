// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class MandateAmendment8ValidatorTests
{
    private readonly MandateAmendment8Validator _sut = new();

    private static MandateAmendmentReason3 ValidAmendmentReason() =>
        new()
        {
            Reason = new BeneficialStrategies.Iso20022.Choices.MandateReason1Choice.Code
            {
                Value = ExternalMandateReason1Code.IncorrectAccountNumber,
            },
        };

    private static Mandate21 ValidMandate() =>
        new() { MandateIdentification = "MNDT-001", TrackingIndicator = true };

    private static BeneficialStrategies.Iso20022.Choices.OriginalMandate10Choice_ ValidOriginalMandate() =>
        new BeneficialStrategies.Iso20022.Choices.OriginalMandate10Choice.OriginalMandateIdentification
        {
            Value = "ORIG-MNDT-001",
        };

    private static MandateAmendment8 ValidMessage() =>
        new()
        {
            AmendmentReason = ValidAmendmentReason(),
            Mandate = ValidMandate(),
            OriginalMandate = ValidOriginalMandate(),
        };

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
