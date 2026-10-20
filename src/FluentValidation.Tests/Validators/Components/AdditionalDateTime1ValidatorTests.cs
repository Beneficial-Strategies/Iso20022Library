// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class AdditionalDateTime1ValidatorTests
{
    private readonly AdditionalDateTime1Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(IsoDataFactory.Make<IAdditionalDateTime1>()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllFieldsPresent_NoValidationErrors()
    {
        var msg = IsoDataFactory.Make<IAdditionalDateTime1>(b => b
            .Set(x => x.AcceptanceDateTime).To(new DateTime(2026, 1, 1))
            .Set(x => x.ExpiryDateTime).To(new DateTime(2026, 1, 2))
            .Set(x => x.PoolingAdjustmentDate).To(new DateOnly(2026, 1, 1)));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
