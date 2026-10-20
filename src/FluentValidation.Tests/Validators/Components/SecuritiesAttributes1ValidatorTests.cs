// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class SecuritiesAttributes1ValidatorTests
{
    private readonly SecuritiesAttributes1Validator _sut = new();

    private static ISecuritiesAttributes1 ValidMessage() =>
        IsoDataFactory.Make<ISecuritiesAttributes1>(b => b
            .Set(x => x.UniqueTransactionIdentifier).To("ABCDEFGHIJKLMNOPQR12"));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.Amount).To(new ActiveCurrencyAndAmount { Currency = "USD", Amount = 100m }));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
