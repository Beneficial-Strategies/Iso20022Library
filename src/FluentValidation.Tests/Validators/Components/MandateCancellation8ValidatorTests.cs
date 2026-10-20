// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class MandateCancellation8ValidatorTests
{
    private readonly MandateCancellation8Validator _sut = new();

    private static BeneficialStrategies.Iso20022.Choices.OriginalMandate10Choice_ ValidOriginalMandate() =>
        new BeneficialStrategies.Iso20022.Choices.OriginalMandate10Choice.OriginalMandateIdentification
        {
            Value = "MNDT-001",
        };

    private static MandateCancellationReason2 ValidReason() =>
        new()
        {
            Reason = new BeneficialStrategies.Iso20022.Choices.MandateReason1Choice.Code
            {
                Value = ExternalMandateReason1Code.IncorrectAccountNumber,
            },
        };

    private static MandateCancellation8 ValidMessage() =>
        new() { CancellationReason = ValidReason(), OriginalMandate = ValidOriginalMandate() };

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
