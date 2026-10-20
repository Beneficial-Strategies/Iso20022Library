// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.camt;

public class CreateReservationV03ValidatorTests
{
    private readonly CreateReservationV03Validator _sut = new();

    private static MessageHeader1 ValidMessageHeader() => new() { MessageIdentification = "MSG-001" };

    private static ReservationIdentification4 ValidReservationIdentification() =>
        new()
        {
            Type = new BeneficialStrategies.Iso20022.Choices.ReservationType2Choice.Code
            {
                Value = ExternalReservationType1Code.CashReservation,
            },
        };

    private static Reservation4 ValidValueSet() =>
        new()
        {
            Amount = new BeneficialStrategies.Iso20022.Choices.Amount2Choice.AmountWithCurrency
            {
                Currency = "USD",
                Amount = 100m,
            },
        };

    private static CreateReservationV03 ValidMessage() =>
        new()
        {
            MessageHeader = ValidMessageHeader(),
            ReservationIdentification = ValidReservationIdentification(),
            ValueSet = ValidValueSet(),
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
            SupplementaryData = [new SupplementaryData1 { Envelope = new SupplementaryDataEnvelope1() }],
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
