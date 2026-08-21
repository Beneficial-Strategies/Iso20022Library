// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.pain;

public class MandateAmendmentRequestV08ValidatorTests
{
    private readonly MandateAmendmentRequestV08Validator _sut = new();

    private static GroupHeader110 ValidGroupHeader() =>
        new() { MessageIdentification = "MSG-001", CreationDateTime = new DateTime(2026, 1, 1) };

    private static MandateAmendmentRequestV08 ValidMessage() => new() { GroupHeader = ValidGroupHeader() };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void UnderlyingAmendmentDetails_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            UnderlyingAmendmentDetails =
            [
                new MandateAmendment8
                {
                    AmendmentReason = new MandateAmendmentReason3
                    {
                        Reason = new BeneficialStrategies.Iso20022.Choices.MandateReason1Choice.Code
                        {
                            Value = ExternalMandateReason1Code.IncorrectAccountNumber,
                        },
                    },
                    Mandate = new Mandate21 { MandateIdentification = "MNDT-001", TrackingIndicator = true },
                    OriginalMandate =
                        new BeneficialStrategies.Iso20022.Choices.OriginalMandate10Choice.OriginalMandateIdentification
                        {
                            Value = "ORIG-MNDT-001",
                        },
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
