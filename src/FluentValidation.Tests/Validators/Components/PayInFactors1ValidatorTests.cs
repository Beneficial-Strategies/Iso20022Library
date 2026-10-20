// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class PayInFactors1ValidatorTests
{
    private readonly PayInFactors1Validator _sut = new();

    private static ICurrencyFactors1 ValidCurrencyFactor() =>
        IsoDataFactory.Make<ICurrencyFactors1>(b => b
            .Set(x => x.Currency).To("USD")
            .Set(x => x.ShortPositionLimit).To(100m)
            .Set(x => x.MinimumPayInAmount).To(10m)
            .Set(x => x.VolatilityMargin).To(5m));

    private static IPayInFactors1 ValidMessage() =>
        IsoDataFactory.Make<IPayInFactors1>(b => b
            .Set(x => x.AggregateShortPositionLimit).To(new ActiveCurrencyAndAmount { Currency = "USD", Amount = 1000m })
            .Set(x => x.CurrencyFactors).To([ValidCurrencyFactor()]));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── CurrencyFactors: CurrencyFactors1, 1..∞ ───────────────────────────────

    [Fact]
    public void CurrencyFactors_Empty_HasValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.CurrencyFactors).To([]));
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.CurrencyFactors);
    }

    [Fact]
    public void CurrencyFactors_OneElement_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.CurrencyFactors).To([ValidCurrencyFactor()]));
        _sut.TestValidate(msg).ShouldNotHaveValidationErrorFor(x => x.CurrencyFactors);
    }
}
