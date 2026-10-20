// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.camt;

public class ModifyReservationV07ValidatorTests
{
    private readonly ModifyReservationV07Validator _sut = new();

    private static IMessageHeader1 ValidMessageHeader() => IsoDataFactory.Make<IMessageHeader1>(b => b
        .Set(x => x.MessageIdentification).To("MSG-001"));

    private static BeneficialStrategies.Iso20022.Choices.ICurrentOrDefaultReservation4Choice ValidReservationIdentification() =>
        IsoDataFactory.Make<Choices.CurrentOrDefaultReservation4Choice.ICurrent>(b => b
            .Set(x => x.Value).To(IsoDataFactory.Make<IReservationIdentification4>(b2 => b2
                .Set(x2 => x2.Type).To(IsoDataFactory.Make<Choices.ReservationType2Choice.ICode>(b3 => b3
                    .Set(x3 => x3.Value).To(ExternalReservationType1Code.CashReservation))))));

    private static IReservation4 ValidNewReservationValueSet() =>
        IsoDataFactory.Make<IReservation4>(b => b
            .Set(x => x.Amount).To(IsoDataFactory.Make<Choices.Amount2Choice.IAmountWithCurrency>(b2 => b2
                .Set(x2 => x2.Currency).To("USD")
                .Set(x2 => x2.Amount).To(100m))));

    private static IModifyReservationV07 ValidMessage() =>
        IsoDataFactory.Make<IModifyReservationV07>(b => b
            .Set(x => x.MessageHeader).To(ValidMessageHeader())
            .Set(x => x.ReservationIdentification).To(ValidReservationIdentification())
            .Set(x => x.NewReservationValueSet).To(ValidNewReservationValueSet()));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void SupplementaryData_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.SupplementaryData).To([IsoDataFactory.Make<ISupplementaryData1>(b2 => b2
                .Set(x2 => x2.Envelope).To(new SupplementaryDataEnvelope1()))]));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
