// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class CurrencyExchange13ValidatorTests
{
    private readonly CurrencyExchange13Validator _sut = new();

    private static ICurrencyExchange13 ValidMessage() =>
        IsoDataFactory.Make<ICurrencyExchange13>(b => b
            .Set(x => x.SourceCurrency).To("USD")
            .Set(x => x.TargetCurrency).To("EUR")
            .Set(x => x.ExchangeRate).To(0.9m));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllOptionalFields_Present_NoValidationError()
    {
        var msg = IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.UnitCurrency).To("USD"));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void PopulatedRegistry_RejectsCurrencyNotInSet()
    {
        var registry = new InMemoryExternalCodeRegistry<ActiveCurrencyCode>();
        registry.Add("USD");
        registry.Add("EUR");
        var sut = new CurrencyExchange13Validator(new ActiveCurrencyCodeValidator(registry));

        var result = sut.Validate(IsoDataFactory.With(ValidMessage(), b => b
            .Set(x => x.SourceCurrency).To("ZZZ")));
        Assert.False(result.IsValid);
    }
}
