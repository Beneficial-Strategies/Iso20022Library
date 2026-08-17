// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class DecimalNumberTests : SimpleValueXsdNumericContractTests<DecimalNumber, decimal>
{
    protected override decimal ValidNativeSample => 1.5m;

    [Fact]
    public void ExcessiveTotalDigits_ThrowsFormatException()
    {
        Assert.Throws<Iso20022FormatException>(() => new DecimalNumber(1000000000000000000m));
    }

    [Fact]
    public void ExcessiveFractionDigits_ThrowsFormatException()
    {
        Assert.Throws<Iso20022FormatException>(() => new DecimalNumber(1.234567890123456789m));
    }
}
