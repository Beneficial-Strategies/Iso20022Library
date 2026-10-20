// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class GarnishmentType1ValidatorTests
{
    private readonly GarnishmentType1Validator _sut = new();

    private static IGarnishmentType1 ValidMessage() =>
        IsoDataFactory.Make<IGarnishmentType1>(b => b
            .Set(x => x.CodeOrProprietary).To(IsoDataFactory.Make<Choices.GarnishmentType1Choice.IProprietary>(b2 => b2
                .Set(x2 => x2.Value).To("MYGARNISHMENT"))));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Issuer).To("IssuerCo"));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
