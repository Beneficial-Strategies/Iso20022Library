// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class Max20PositiveNumberTests : SimpleValueXsdNumericContractTests<Max20PositiveNumber, decimal>
{
    protected override decimal ValidNativeSample => 12345m;

    [Fact]
    public void ExcessiveTotalDigits_ThrowsFormatException()
    {
        Assert.Throws<Iso20022FormatException>(() => new Max20PositiveNumber(100000000000000000000m));
    }

    [Fact]
    public void ExcessiveFractionDigits_ThrowsFormatException()
    {
        Assert.Throws<Iso20022FormatException>(() => new Max20PositiveNumber(1.5m));
    }
}
