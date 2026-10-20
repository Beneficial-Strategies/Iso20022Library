// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.pain;

public class MandateSuspensionRequestV04ValidatorTests
{
    private readonly MandateSuspensionRequestV04Validator _sut = new();

    private static IGroupHeader110 ValidGroupHeader() =>
        IsoDataFactory.Make<IGroupHeader110>(b => b
            .Set(x => x.MessageIdentification).To("MSG-001")
            .Set(x => x.CreationDateTime).To(new DateTime(2026, 1, 1)));

    private static IMandateSuspensionRequestV04 ValidMessage() => IsoDataFactory.Make<IMandateSuspensionRequestV04>(b => b
        .Set(x => x.GroupHeader).To(ValidGroupHeader()));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void UnderlyingSuspensionDetails_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.UnderlyingSuspensionDetails).To([
                IsoDataFactory.Make<IMandateSuspension4>(b2 => b2
                    .Set(x2 => x2.OriginalMandate).To(IsoDataFactory.Make<Choices.OriginalMandate10Choice.IOriginalMandateIdentification>(b3 => b3
                            .Set(x3 => x3.Value).To("MNDT-001")))
                    .Set(x2 => x2.SuspensionReason).To(IsoDataFactory.Make<IMandateSuspensionReason3>(b3 => b3
                        .Set(x3 => x3.Reason).To(IsoDataFactory.Make<Choices.MandateSuspensionReason1Choice.ICode>(b4 => b4
                            .Set(x4 => x4.Value).To(ExternalMandateSuspensionReason1Code.ContractAmended)))))
                    .Set(x2 => x2.SuspensionRequestIdentification).To("SSPN-001")),
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
