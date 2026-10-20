// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class MandateAdjustment1ValidatorTests
{
    private readonly MandateAdjustment1Validator _sut = new();

    private static IMandateAdjustment1 ValidMessage() => IsoDataFactory.Make<IMandateAdjustment1>(b => b
        .Set(x => x.DateAdjustmentRuleIndicator).To(true));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void Category_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Category).To(IsoDataFactory.Make<Choices.Frequency37Choice.IProprietary>(b2 => b2
                .Set(x2 => x2.Value).To("MYFREQ"))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
