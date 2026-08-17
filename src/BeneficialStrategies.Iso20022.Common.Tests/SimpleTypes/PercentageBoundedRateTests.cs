// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class PercentageBoundedRateTests : SimpleValueXsdNumericContractTests<PercentageBoundedRate, decimal>
{
    protected override decimal ValidNativeSample => 50m;

    [Fact]
    public void ExcessiveTotalDigits_ThrowsFormatException()
    {
        Assert.Throws<Iso20022FormatException>(() => new PercentageBoundedRate(100000000000m));
    }

    [Fact]
    public void ExcessiveFractionDigits_ThrowsFormatException()
    {
        Assert.Throws<Iso20022FormatException>(() => new PercentageBoundedRate(1.234567890123m));
    }
}
