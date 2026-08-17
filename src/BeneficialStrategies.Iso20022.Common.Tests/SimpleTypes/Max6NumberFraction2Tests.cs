// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class Max6NumberFraction2Tests : SimpleValueXsdNumericContractTests<Max6NumberFraction2, decimal>
{
    protected override decimal ValidNativeSample => 12.5m;

    [Fact]
    public void ExcessiveTotalDigits_ThrowsFormatException()
    {
        Assert.Throws<Iso20022FormatException>(() => new Max6NumberFraction2(1000000m));
    }

    [Fact]
    public void ExcessiveFractionDigits_ThrowsFormatException()
    {
        Assert.Throws<Iso20022FormatException>(() => new Max6NumberFraction2(1.123m));
    }
}
