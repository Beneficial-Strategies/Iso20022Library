// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class RestrictedFINDecimalNumberTests : SimpleValueXsdNumericContractTests<RestrictedFINDecimalNumber, decimal>
{
    protected override decimal ValidNativeSample => 0.5m;

    [Fact]
    public void ExcessiveTotalDigits_ThrowsFormatException()
    {
        Assert.Throws<Iso20022FormatException>(() => new RestrictedFINDecimalNumber(100000000000000m));
    }

    [Fact]
    public void ExcessiveFractionDigits_ThrowsFormatException()
    {
        Assert.Throws<Iso20022FormatException>(() => new RestrictedFINDecimalNumber(0.123456789012345m));
    }
}
