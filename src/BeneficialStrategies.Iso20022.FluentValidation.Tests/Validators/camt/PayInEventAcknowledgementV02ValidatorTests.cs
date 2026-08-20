// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.camt;

public class PayInEventAcknowledgementV02ValidatorTests
{
    private readonly PayInEventAcknowledgementV02Validator _sut = new();

    private static PayInEventAcknowledgementV02 ValidMessage() =>
        new()
        {
            MessageIdentification = "MSG-001",
            AcknowledgementDetails =
                new BeneficialStrategies.Iso20022.Choices.AcknowledgementDetails1Choice.PayInScheduleReference
                {
                    Value = "PIS-001",
                },
        };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void SupplementaryData_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            SupplementaryData = new SupplementaryData1 { Envelope = new SupplementaryDataEnvelope1() },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void PayInCallReferenceVariant_NoValidationErrors()
    {
        var msg = ValidMessage() with
        {
            AcknowledgementDetails =
                new BeneficialStrategies.Iso20022.Choices.AcknowledgementDetails1Choice.PayInCallReference
                {
                    Value = "PIC-001",
                },
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
