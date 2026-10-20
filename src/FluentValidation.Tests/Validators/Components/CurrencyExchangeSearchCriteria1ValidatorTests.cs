// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class CurrencyExchangeSearchCriteria1ValidatorTests
{
    private readonly CurrencyExchangeSearchCriteria1Validator _sut = new();

    private static ICurrencyExchangeSearchCriteria1 ValidMessage() =>
        IsoDataFactory.Make<ICurrencyExchangeSearchCriteria1>(b => b
            .Set(x => x.SourceCurrency).To("USD")
            .Set(x => x.TargetCurrency).To("EUR"));

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }
}
