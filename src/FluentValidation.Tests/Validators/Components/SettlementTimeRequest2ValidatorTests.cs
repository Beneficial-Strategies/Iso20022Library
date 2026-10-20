// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

public class SettlementTimeRequest2ValidatorTests
{
    private readonly SettlementTimeRequest2Validator _sut = new();

    [Fact]
    public void EmptyMessage_NoValidationErrors()
    {
        _sut.TestValidate(IsoDataFactory.Make<ISettlementTimeRequest2>()).ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void AllFieldsPresent_NoValidationErrors()
    {
        var msg = IsoDataFactory.Make<ISettlementTimeRequest2>(b => b
            .Set(x => x.CLSTime).To(new TimeOnly(12, 0, 0))
            .Set(x => x.TillTime).To(new TimeOnly(15, 0, 0))
            .Set(x => x.FromTime).To(new TimeOnly(9, 0, 0))
            .Set(x => x.RejectTime).To(new TimeOnly(16, 0, 0)));
        _sut.TestValidate(msg).ShouldNotHaveAnyValidationErrors();
    }
}
