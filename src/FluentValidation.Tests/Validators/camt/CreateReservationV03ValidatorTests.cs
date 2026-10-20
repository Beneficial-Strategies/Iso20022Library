// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.camt;

public class CreateReservationV03ValidatorTests
{
    private readonly CreateReservationV03Validator _sut = new();

    private static IMessageHeader1 ValidMessageHeader() => IsoDataFactory.Make<IMessageHeader1>(b => b
        .Set(x => x.MessageIdentification).To("MSG-001"));

    private static IReservationIdentification4 ValidReservationIdentification() =>
        IsoDataFactory.Make<IReservationIdentification4>(b => b
            .Set(x => x.Type).To(IsoDataFactory.Make<Choices.ReservationType2Choice.ICode>(b2 => b2
                .Set(x2 => x2.Value).To(ExternalReservationType1Code.CashReservation))));

    private static IReservation4 ValidValueSet() =>
        IsoDataFactory.Make<IReservation4>(b => b
            .Set(x => x.Amount).To(IsoDataFactory.Make<Choices.Amount2Choice.IAmountWithCurrency>(b2 => b2
                .Set(x2 => x2.Currency).To("USD")
                .Set(x2 => x2.Amount).To(100m))));

    private static ICreateReservationV03 ValidMessage() =>
        IsoDataFactory.Make<ICreateReservationV03>(b => b
            .Set(x => x.MessageHeader).To(ValidMessageHeader())
            .Set(x => x.ReservationIdentification).To(ValidReservationIdentification())
            .Set(x => x.ValueSet).To(ValidValueSet()));

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
