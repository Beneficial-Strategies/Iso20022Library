// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.camt;

public class ModifyStandingOrderV08ValidatorTests
{
    private readonly ModifyStandingOrderV08Validator _sut = new();

    private static IMessageHeader1 ValidMessageHeader() => IsoDataFactory.Make<IMessageHeader1>(b => b
        .Set(x => x.MessageIdentification).To("MSG-001"));

    private static IStandingOrderIdentification8 ValidStandingOrderIdentification() =>
        IsoDataFactory.Make<IStandingOrderIdentification8>(b => b
            .Set(x => x.Account).To(IsoDataFactory.Make<ICashAccount40>(b2 => b2
                .Set(x2 => x2.Identification).To(IsoDataFactory.Make<Choices.AccountIdentification4Choice.IIBAN>(b3 => b3
                    .Set(x3 => x3.Value).To("DE89370400440532013000"))))));

    private static IModifyStandingOrderV08 ValidMessage() =>
        IsoDataFactory.Make<IModifyStandingOrderV08>(b => b
            .Set(x => x.MessageHeader).To(ValidMessageHeader())
            .Set(x => x.StandingOrderIdentification).To(ValidStandingOrderIdentification())
            .Set(x => x.NewStandingOrderValueSet).To(IsoDataFactory.Make<IStandingOrder10>()));

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
