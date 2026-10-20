// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class CurrencyExchange13ValidatorTests
{
    private readonly CurrencyExchange13Validator _sut = new();

    private static CurrencyExchange13 ValidMessage() =>
        new()
        {
            SourceCurrency = "USD",
            TargetCurrency = "EUR",
            ExchangeRate = 0.9m,
        };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = ValidMessage() with { UnitCurrency = "USD" };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void PopulatedRegistry_RejectsCurrencyNotInSet()
    {
        var registry = new InMemoryExternalCodeRegistry<ActiveCurrencyCode>();
        registry.Add("USD");
        registry.Add("EUR");
        var sut = new CurrencyExchange13Validator(new ActiveCurrencyCodeValidator(registry));

        var result = sut.Validate(ValidMessage() with { SourceCurrency = "ZZZ" });
        Assert.False(result.IsValid);
    }
}
