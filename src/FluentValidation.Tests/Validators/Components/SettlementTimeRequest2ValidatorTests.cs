// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class SettlementTimeRequest2ValidatorTests
{
    private readonly SettlementTimeRequest2Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(new SettlementTimeRequest2()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllFieldsPresent_NoValidationErrors()
    {
        var msg = new SettlementTimeRequest2
        {
            CLSTime = new TimeOnly(12, 0, 0),
            TillTime = new TimeOnly(15, 0, 0),
            FromTime = new TimeOnly(9, 0, 0),
            RejectTime = new TimeOnly(16, 0, 0),
        };
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
