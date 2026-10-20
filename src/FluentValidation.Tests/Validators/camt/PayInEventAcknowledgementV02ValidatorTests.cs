// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.camt;

public class PayInEventAcknowledgementV02ValidatorTests
{
    private readonly PayInEventAcknowledgementV02Validator _sut = new();

    private static IPayInEventAcknowledgementV02 ValidMessage() =>
        IsoDataFactory.Make<IPayInEventAcknowledgementV02>(b => b
            .Set(x => x.MessageIdentification).To("MSG-001")
            .Set(x => x.AcknowledgementDetails).To(IsoDataFactory.Make<Choices.AcknowledgementDetails1Choice.IPayInScheduleReference>(b2 => b2
                    .Set(x2 => x2.Value).To("PIS-001"))));

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

    [Fact]
    public void PayInCallReferenceVariant_NoValidationErrors()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.AcknowledgementDetails).To(IsoDataFactory.Make<Choices.AcknowledgementDetails1Choice.IPayInCallReference>(b2 => b2
                    .Set(x2 => x2.Value).To("PIC-001"))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
