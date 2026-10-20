// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class MandateAmendment8ValidatorTests
{
    private readonly MandateAmendment8Validator _sut = new();

    private static IMandateAmendmentReason3 ValidAmendmentReason() =>
        IsoDataFactory.Make<IMandateAmendmentReason3>(b => b
            .Set(x => x.Reason).To(IsoDataFactory.Make<Choices.MandateReason1Choice.ICode>(b2 => b2
                .Set(x2 => x2.Value).To(ExternalMandateReason1Code.IncorrectAccountNumber))));

    private static IMandate21 ValidMandate() =>
        IsoDataFactory.Make<IMandate21>(b => b
            .Set(x => x.MandateIdentification).To("MNDT-001")
            .Set(x => x.TrackingIndicator).To(true));

    private static BeneficialStrategies.Iso20022.Choices.IOriginalMandate10Choice ValidOriginalMandate() =>
        IsoDataFactory.Make<Choices.OriginalMandate10Choice.IOriginalMandateIdentification>(b => b
            .Set(x => x.Value).To("ORIG-MNDT-001"));

    private static IMandateAmendment8 ValidMessage() =>
        IsoDataFactory.Make<IMandateAmendment8>(b => b
            .Set(x => x.AmendmentReason).To(ValidAmendmentReason())
            .Set(x => x.Mandate).To(ValidMandate())
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
