// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class MandateSuspension4ValidatorTests
{
    private readonly MandateSuspension4Validator _sut = new();

    private static BeneficialStrategies.Iso20022.Choices.OriginalMandate10Choice_ ValidOriginalMandate() =>
        new BeneficialStrategies.Iso20022.Choices.OriginalMandate10Choice.OriginalMandateIdentification
        {
            Value = "MNDT-001",
        };

    private static MandateSuspensionReason3 ValidReason() =>
        new()
        {
            Reason = new BeneficialStrategies.Iso20022.Choices.MandateSuspensionReason1Choice.Code
            {
                Value = ExternalMandateSuspensionReason1Code.ContractAmended,
            },
        };

    private static MandateSuspension4 ValidMessage() =>
        new()
        {
            OriginalMandate = ValidOriginalMandate(),
            SuspensionReason = ValidReason(),
            SuspensionRequestIdentification = "SSPN-001",
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
