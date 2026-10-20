// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class Max10NumberFraction2Tests : SimpleValueXsdNumericContractTests<Max10NumberFraction2, decimal>
{
    protected override decimal ValidNativeSample => 1234.5m;

    [Fact]
    public void ExcessiveTotalDigits_ThrowsFormatException()
    {
        Assert.Throws<Iso20022FormatException>(() => new Max10NumberFraction2(10000000000m));
    }

    [Fact]
    public void ExcessiveFractionDigits_ThrowsFormatException()
    {
        Assert.Throws<Iso20022FormatException>(() => new Max10NumberFraction2(1.123m));
    }
}
