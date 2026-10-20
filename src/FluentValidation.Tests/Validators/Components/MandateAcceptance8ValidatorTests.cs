// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class MandateAcceptance8ValidatorTests
{
    private readonly MandateAcceptance8Validator _sut = new();

    private static IAcceptanceResult6 ValidAcceptanceResult() => IsoDataFactory.Make<IAcceptanceResult6>(b => b
        .Set(x => x.Accepted).To(true));

    private static IMandateAcceptance8 ValidMessage() => IsoDataFactory.Make<IMandateAcceptance8>(b => b
        .Set(x => x.AcceptanceResult).To(ValidAcceptanceResult()));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.OriginalMandate).To(IsoDataFactory.Make<Choices.OriginalMandate11Choice.IOriginalMandateIdentification>(b2 => b2
                .Set(x2 => x2.Value).To("ORIG-MNDT-001")))
            .Set(x => x.OriginalMessageInformation).To(IsoDataFactory.Make<IOriginalMessageInformation1>(b2 => b2
                .Set(x2 => x2.MessageIdentification).To("ORIG-MSG-001")
                .Set(x2 => x2.MessageNameIdentification).To("pain.009.001.08")))
            .Set(x => x.SupplementaryData).To([IsoDataFactory.Make<ISupplementaryData1>(b2 => b2
                .Set(x2 => x2.Envelope).To(new SupplementaryDataEnvelope1()))]));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
