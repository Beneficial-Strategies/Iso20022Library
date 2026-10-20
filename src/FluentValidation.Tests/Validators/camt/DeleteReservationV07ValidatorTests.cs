// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.camt;

public class DeleteReservationV07ValidatorTests
{
    private readonly DeleteReservationV07Validator _sut = new();

    private static IMessageHeader1 ValidMessageHeader() => IsoDataFactory.Make<IMessageHeader1>(b => b
        .Set(x => x.MessageIdentification).To("MSG-001"));

    private static IDeleteReservationV07 ValidMessage() => IsoDataFactory.Make<IDeleteReservationV07>(b => b
        .Set(x => x.MessageHeader).To(ValidMessageHeader()));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void CurrentReservation_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.CurrentReservation).To(IsoDataFactory.Make<IReservationIdentification4>(b2 => b2
                .Set(x2 => x2.Type).To(IsoDataFactory.Make<Choices.ReservationType2Choice.ICode>(b3 => b3
                    .Set(x3 => x3.Value).To(ExternalReservationType1Code.CashReservation))))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
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
