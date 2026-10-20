// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class BaseOneRateTests : SimpleValueXsdNumericContractTests<BaseOneRate, decimal>
{
    protected override decimal ValidNativeSample => 0.5m;

    [Fact]
    public void ExcessiveTotalDigits_ThrowsFormatException()
    {
        Assert.Throws<Iso20022FormatException>(() => new BaseOneRate(100000000000m));
    }

    [Fact]
    public void ExcessiveFractionDigits_ThrowsFormatException()
    {
        Assert.Throws<Iso20022FormatException>(() => new BaseOneRate(1.234567890123m));
    }
}
