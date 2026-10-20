// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class AdditionalDateTime1ValidatorTests
{
    private readonly AdditionalDateTime1Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(new AdditionalDateTime1()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllFieldsPresent_NoValidationErrors()
    {
        var msg = new AdditionalDateTime1
        {
            AcceptanceDateTime = new DateTime(2026, 1, 1),
            ExpiryDateTime = new DateTime(2026, 1, 2),
            PoolingAdjustmentDate = new DateOnly(2026, 1, 1),
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
