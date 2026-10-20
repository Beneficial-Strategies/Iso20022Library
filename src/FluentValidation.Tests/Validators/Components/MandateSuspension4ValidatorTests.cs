// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class MandateSuspension4ValidatorTests
{
    private readonly MandateSuspension4Validator _sut = new();

    private static BeneficialStrategies.Iso20022.Choices.IOriginalMandate10Choice ValidOriginalMandate() =>
        IsoDataFactory.Make<Choices.OriginalMandate10Choice.IOriginalMandateIdentification>(b => b
            .Set(x => x.Value).To("MNDT-001"));

    private static IMandateSuspensionReason3 ValidReason() =>
        IsoDataFactory.Make<IMandateSuspensionReason3>(b => b
            .Set(x => x.Reason).To(IsoDataFactory.Make<Choices.MandateSuspensionReason1Choice.ICode>(b2 => b2
                .Set(x2 => x2.Value).To(ExternalMandateSuspensionReason1Code.ContractAmended))));

    private static IMandateSuspension4 ValidMessage() =>
        IsoDataFactory.Make<IMandateSuspension4>(b => b
            .Set(x => x.OriginalMandate).To(ValidOriginalMandate())
            .Set(x => x.SuspensionReason).To(ValidReason())
            .Set(x => x.SuspensionRequestIdentification).To("SSPN-001"));

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
