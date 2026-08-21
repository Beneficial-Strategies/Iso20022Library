// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.camt;

public class ModifyReservationV07ValidatorTests
{
    private readonly ModifyReservationV07Validator _sut = new();

    private static MessageHeader1 ValidMessageHeader() => new() { MessageIdentification = "MSG-001" };

    private static BeneficialStrategies.Iso20022.Choices.CurrentOrDefaultReservation4Choice_ ValidReservationIdentification() =>
        new BeneficialStrategies.Iso20022.Choices.CurrentOrDefaultReservation4Choice.Current
        {
            Value = new ReservationIdentification4
            {
                Type = new BeneficialStrategies.Iso20022.Choices.ReservationType2Choice.Code
                {
                    Value = ExternalReservationType1Code.CashReservation,
                },
            },
        };

    private static Reservation4 ValidNewReservationValueSet() =>
        new()
        {
            Amount = new BeneficialStrategies.Iso20022.Choices.Amount2Choice.AmountWithCurrency
            {
                Currency = "USD",
                Amount = 100m,
            },
        };

    private static ModifyReservationV07 ValidMessage() =>
        new()
        {
            MessageHeader = ValidMessageHeader(),
            ReservationIdentification = ValidReservationIdentification(),
            NewReservationValueSet = ValidNewReservationValueSet(),
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
