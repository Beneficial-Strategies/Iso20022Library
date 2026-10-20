// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class MandateCancellation8ValidatorTests
{
    private readonly MandateCancellation8Validator _sut = new();

    private static BeneficialStrategies.Iso20022.Choices.IOriginalMandate10Choice ValidOriginalMandate() =>
        IsoDataFactory.Make<Choices.OriginalMandate10Choice.IOriginalMandateIdentification>(b => b
            .Set(x => x.Value).To("MNDT-001"));

    private static IMandateCancellationReason2 ValidReason() =>
        IsoDataFactory.Make<IMandateCancellationReason2>(b => b
            .Set(x => x.Reason).To(IsoDataFactory.Make<Choices.MandateReason1Choice.ICode>(b2 => b2
                .Set(x2 => x2.Value).To(ExternalMandateReason1Code.IncorrectAccountNumber))));

    private static IMandateCancellation8 ValidMessage() =>
        IsoDataFactory.Make<IMandateCancellation8>(b => b
            .Set(x => x.CancellationReason).To(ValidReason())
            .Set(x => x.OriginalMandate).To(ValidOriginalMandate()));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.OriginalMessageInformation).To(IsoDataFactory.Make<IOriginalMessageInformation1>(b2 => b2
                .Set(x2 => x2.MessageIdentification).To("ORIG-MSG-001")
                .Set(x2 => x2.MessageNameIdentification).To("pain.009.001.08")))
            .Set(x => x.SupplementaryData).To([IsoDataFactory.Make<ISupplementaryData1>(b2 => b2
                .Set(x2 => x2.Envelope).To(new SupplementaryDataEnvelope1()))]));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
