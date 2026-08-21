// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class CurrencyExchangeSearchCriteria1ValidatorTests
{
    private readonly CurrencyExchangeSearchCriteria1Validator _sut = new();

    private static CurrencyExchangeSearchCriteria1 ValidMessage() =>
        new() { SourceCurrency = "USD", TargetCurrency = "EUR" };

    [Fact]
    public void ValidMessage_NoValidationErrors()
    {
        _sut.TestValidate(ValidMessage()).ShouldNotHaveAnyValidationErrors();
    }
}
