// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.pain;

public class MandateCancellationRequestV08ValidatorTests
{
    private readonly MandateCancellationRequestV08Validator _sut = new();

    private static GroupHeader110 ValidGroupHeader() =>
        new() { MessageIdentification = "MSG-001", CreationDateTime = new DateTime(2026, 1, 1) };

    private static MandateCancellationRequestV08 ValidMessage() => new() { GroupHeader = ValidGroupHeader() };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void UnderlyingCancellationDetails_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            UnderlyingCancellationDetails =
            [
                new MandateCancellation8
                {
                    CancellationReason = new MandateCancellationReason2
                    {
                        Reason = new BeneficialStrategies.Iso20022.Choices.MandateReason1Choice.Code
                        {
                            Value = ExternalMandateReason1Code.IncorrectAccountNumber,
                        },
                    },
                    OriginalMandate =
                        new BeneficialStrategies.Iso20022.Choices.OriginalMandate10Choice.OriginalMandateIdentification
                        {
                            Value = "MNDT-001",
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
