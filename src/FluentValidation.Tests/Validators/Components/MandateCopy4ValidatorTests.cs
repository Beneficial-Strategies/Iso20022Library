// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class MandateCopy4ValidatorTests
{
    private readonly MandateCopy4Validator _sut = new();

    private static IMandateCopy4 ValidMessage() =>
        IsoDataFactory.Make<IMandateCopy4>(b => b
            .Set(x => x.OriginalMandate).To(IsoDataFactory.Make<Choices.OriginalMandate10Choice.IOriginalMandateIdentification>(b2 => b2
                    .Set(x2 => x2.Value).To("MNDT-001"))));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalChildren_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.MandateStatus).To(IsoDataFactory.Make<Choices.MandateStatus1Choice.IProprietary>(b2 => b2
                .Set(x2 => x2.Value).To("CUSTOMSTATUS")))
            .Set(x => x.OriginalMessageInformation).To(IsoDataFactory.Make<IOriginalMessageInformation1>(b2 => b2
                .Set(x2 => x2.MessageIdentification).To("MSG-001")
                .Set(x2 => x2.MessageNameIdentification).To("pain.017.001.04")))
            .Set(x => x.SupplementaryData).To([IsoDataFactory.Make<ISupplementaryData1>(b2 => b2
                .Set(x2 => x2.Envelope).To(new SupplementaryDataEnvelope1()))]));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
