// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.pain;

public class MandateAmendmentRequestV08ValidatorTests
{
    private readonly MandateAmendmentRequestV08Validator _sut = new();

    private static IGroupHeader110 ValidGroupHeader() =>
        IsoDataFactory.Make<IGroupHeader110>(b => b
            .Set(x => x.MessageIdentification).To("MSG-001")
            .Set(x => x.CreationDateTime).To(new DateTime(2026, 1, 1)));

    private static IMandateAmendmentRequestV08 ValidMessage() => IsoDataFactory.Make<IMandateAmendmentRequestV08>(b => b
        .Set(x => x.GroupHeader).To(ValidGroupHeader()));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void UnderlyingAmendmentDetails_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.UnderlyingAmendmentDetails).To([
                IsoDataFactory.Make<IMandateAmendment8>(b2 => b2
                    .Set(x2 => x2.AmendmentReason).To(IsoDataFactory.Make<IMandateAmendmentReason3>(b3 => b3
                        .Set(x3 => x3.Reason).To(IsoDataFactory.Make<Choices.MandateReason1Choice.ICode>(b4 => b4
                            .Set(x4 => x4.Value).To(ExternalMandateReason1Code.IncorrectAccountNumber)))))
                    .Set(x2 => x2.Mandate).To(IsoDataFactory.Make<IMandate21>(b3 => b3
                        .Set(x3 => x3.MandateIdentification).To("MNDT-001")
                        .Set(x3 => x3.TrackingIndicator).To(true)))
                    .Set(x2 => x2.OriginalMandate).To(IsoDataFactory.Make<Choices.OriginalMandate10Choice.IOriginalMandateIdentification>(b3 => b3
                            .Set(x3 => x3.Value).To("ORIG-MNDT-001")))),
            ]));
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
