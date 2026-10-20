// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class AdviceType1ValidatorTests
{
    private readonly AdviceType1Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(IsoDataFactory.Make<IAdviceType1>()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.Make<IAdviceType1>(b => b
            .Set(x => x.CreditAdvice).To(IsoDataFactory.Make<Choices.AdviceType1Choice.ICode>(b2 => b2
                .Set(x2 => x2.Value).To(AdviceType1Code.AdviceWithDetails)))
            .Set(x => x.DebitAdvice).To(IsoDataFactory.Make<Choices.AdviceType1Choice.IProprietary>(b2 => b2
                .Set(x2 => x2.Value).To("DEBIT"))));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
