// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.camt;

public class DeleteStandingOrderV05ValidatorTests
{
    private readonly DeleteStandingOrderV05Validator _sut = new();

    private static IMessageHeader1 ValidMessageHeader() => IsoDataFactory.Make<IMessageHeader1>(b => b
        .Set(x => x.MessageIdentification).To("MSG-001"));

    private static BeneficialStrategies.Iso20022.Choices.IStandingOrderOrAll4Choice ValidStandingOrderDetails() =>
        IsoDataFactory.Make<Choices.StandingOrderOrAll4Choice.IStandingOrder>(b => b
            .Set(x => x.Value).To(IsoDataFactory.Make<IStandingOrderIdentification8>(b2 => b2
                .Set(x2 => x2.Account).To(IsoDataFactory.Make<ICashAccount40>(b3 => b3
                    .Set(x3 => x3.Identification).To(IsoDataFactory.Make<Choices.AccountIdentification4Choice.IIBAN>(b4 => b4
                        .Set(x4 => x4.Value).To("DE89370400440532013000"))))))));

    private static IDeleteStandingOrderV05 ValidMessage() =>
        IsoDataFactory.Make<IDeleteStandingOrderV05>(b => b
            .Set(x => x.MessageHeader).To(ValidMessageHeader())
            .Set(x => x.StandingOrderDetails).To(ValidStandingOrderDetails()));

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
