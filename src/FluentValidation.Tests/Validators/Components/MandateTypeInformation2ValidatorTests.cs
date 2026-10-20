// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class MandateTypeInformation2ValidatorTests
{
    private readonly MandateTypeInformation2Validator _sut = new();

    private static IMandateTypeInformation2 ValidMessage() => IsoDataFactory.Make<IMandateTypeInformation2>();

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalChildren_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.ServiceLevel).To(IsoDataFactory.Make<Choices.ServiceLevel8Choice.IProprietary>(b2 => b2
                .Set(x2 => x2.Value).To("MYSVCLVL")))
            .Set(x => x.LocalInstrument).To(IsoDataFactory.Make<Choices.LocalInstrument2Choice.IProprietary>(b2 => b2
                .Set(x2 => x2.Value).To("MYINSTR")))
            .Set(x => x.CategoryPurpose).To(IsoDataFactory.Make<Choices.CategoryPurpose1Choice.IProprietary>(b2 => b2
                .Set(x2 => x2.Value).To("MYCAT")))
            .Set(x => x.Classification).To(IsoDataFactory.Make<Choices.MandateClassification1Choice.IProprietary>(b2 => b2
                .Set(x2 => x2.Value).To("MYCLASS"))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
