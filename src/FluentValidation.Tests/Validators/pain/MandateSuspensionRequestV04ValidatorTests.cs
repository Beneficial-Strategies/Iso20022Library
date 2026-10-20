// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.pain;

public class MandateSuspensionRequestV04ValidatorTests
{
    private readonly MandateSuspensionRequestV04Validator _sut = new();

    private static GroupHeader110 ValidGroupHeader() =>
        new() { MessageIdentification = "MSG-001", CreationDateTime = new DateTime(2026, 1, 1) };

    private static MandateSuspensionRequestV04 ValidMessage() => new() { GroupHeader = ValidGroupHeader() };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void UnderlyingSuspensionDetails_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            UnderlyingSuspensionDetails =
            [
                new MandateSuspension4
                {
                    OriginalMandate =
                        new BeneficialStrategies.Iso20022.Choices.OriginalMandate10Choice.OriginalMandateIdentification
                        {
                            Value = "MNDT-001",
                        },
                    SuspensionReason = new MandateSuspensionReason3
                    {
                        Reason = new BeneficialStrategies.Iso20022.Choices.MandateSuspensionReason1Choice.Code
                        {
                            Value = ExternalMandateSuspensionReason1Code.ContractAmended,
                        },
                    },
                    SuspensionRequestIdentification = "SSPN-001",
                },
            ],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void SupplementaryData_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            SupplementaryData = [new SupplementaryData1 { Envelope = new SupplementaryDataEnvelope1() }],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
