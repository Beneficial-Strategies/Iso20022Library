// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class NonNegativeFraction5DecimalNumberTests : SimpleValueXsdNumericContractTests<NonNegativeFraction5DecimalNumber, decimal>
{
    protected override decimal ValidNativeSample => 12345.5m;

    [Fact]
    public void ExcessiveTotalDigits_ThrowsFormatException()
    {
        Assert.Throws<Iso20022FormatException>(() => new NonNegativeFraction5DecimalNumber(1000000000000000000m));
    }

    [Fact]
    public void ExcessiveFractionDigits_ThrowsFormatException()
    {
        Assert.Throws<Iso20022FormatException>(() => new NonNegativeFraction5DecimalNumber(1.123456m));
    }
}
