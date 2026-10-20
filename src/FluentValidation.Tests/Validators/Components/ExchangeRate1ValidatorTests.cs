// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class ExchangeRate1ValidatorTests
{
    private readonly ExchangeRate1Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(IsoDataFactory.Make<IExchangeRate1>()).ShouldNotHaveAnyValidationErrors();
    }
}
