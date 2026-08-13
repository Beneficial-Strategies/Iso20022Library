// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class PayInFactors1ValidatorTests
{
    private readonly PayInFactors1Validator _sut = new();

    private static CurrencyFactors1 ValidCurrencyFactor() =>
        new()
        {
            Currency = "USD",
            ShortPositionLimit = new ImpliedCurrencyAndAmount { Currency = "USD", Amount = 100m },
            MinimumPayInAmount = new ImpliedCurrencyAndAmount { Currency = "USD", Amount = 10m },
            VolatilityMargin = 5m,
        };

    private static PayInFactors1 ValidMessage() =>
        new()
        {
            AggregateShortPositionLimit = new ActiveCurrencyAndAmount { Currency = "USD", Amount = 1000m },
            CurrencyFactors = [ValidCurrencyFactor()],
        };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    // ── CurrencyFactors: CurrencyFactors1, 1..∞ ───────────────────────────────

    [Fact]
    public void CurrencyFactors_Empty_HasValidationError()
    {
        var msg = ValidMessage() with { CurrencyFactors = [] };
        _sut.TestValidate(msg).ShouldHaveValidationErrorFor(x => x.CurrencyFactors);
    }

    [Fact]
    public void CurrencyFactors_OneElement_NoValidationError()
    {
        var msg = ValidMessage() with { CurrencyFactors = [ValidCurrencyFactor()] };
        _sut.TestValidate(msg).ShouldNotHaveValidationErrorFor(x => x.CurrencyFactors);
    }
}
