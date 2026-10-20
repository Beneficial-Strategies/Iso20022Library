// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class MandateCopy4ValidatorTests
{
    private readonly MandateCopy4Validator _sut = new();

    private static MandateCopy4 ValidMessage() =>
        new()
        {
            OriginalMandate =
                new BeneficialStrategies.Iso20022.Choices.OriginalMandate10Choice.OriginalMandateIdentification
                {
                    Value = "MNDT-001",
                },
        };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalChildren_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            MandateStatus = new BeneficialStrategies.Iso20022.Choices.MandateStatus1Choice.Proprietary
            {
                Value = "CUSTOMSTATUS",
            },
            OriginalMessageInformation = new OriginalMessageInformation1
            {
                MessageIdentification = "MSG-001",
                MessageNameIdentification = "pain.017.001.04",
            },
            SupplementaryData = [new SupplementaryData1 { Envelope = new SupplementaryDataEnvelope1() }],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
