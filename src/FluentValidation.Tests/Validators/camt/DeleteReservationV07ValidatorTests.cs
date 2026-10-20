// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.camt;

public class DeleteReservationV07ValidatorTests
{
    private readonly DeleteReservationV07Validator _sut = new();

    private static MessageHeader1 ValidMessageHeader() => new() { MessageIdentification = "MSG-001" };

    private static DeleteReservationV07 ValidMessage() => new() { MessageHeader = ValidMessageHeader() };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void CurrentReservation_Present_NoValidationError()
    {
        var msg = ValidMessage() with
        {
            CurrentReservation = new ReservationIdentification4
            {
                Type = new BeneficialStrategies.Iso20022.Choices.ReservationType2Choice.Code
                {
                    Value = ExternalReservationType1Code.CashReservation,
                },
            },
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
