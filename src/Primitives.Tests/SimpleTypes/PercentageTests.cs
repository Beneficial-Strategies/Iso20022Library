// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

[Obsolete("The type being tested is obsolete in the ISO 20022 specification.")]
public class PercentageTests : SimpleValueXsdNumericContractTests<Percentage, decimal>
{
    protected override decimal ValidNativeSample => 1.5m;

    [Fact]
    public void ExcessiveTotalDigits_ThrowsFormatException()
    {
        Assert.Throws<Iso20022FormatException>(() => new Percentage(100000000000m));
    }

    [Fact]
    public void ExcessiveFractionDigits_ThrowsFormatException()
    {
        Assert.Throws<Iso20022FormatException>(() => new Percentage(1.234567890123m));
    }
}
