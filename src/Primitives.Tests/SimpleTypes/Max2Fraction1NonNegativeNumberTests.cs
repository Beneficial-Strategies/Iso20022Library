// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class Max2Fraction1NonNegativeNumberTests : SimpleValueXsdNumericContractTests<Max2Fraction1NonNegativeNumber, decimal>
{
    protected override decimal ValidNativeSample => 5.5m;

    [Fact]
    public void ExcessiveTotalDigits_ThrowsFormatException()
    {
        Assert.Throws<Iso20022FormatException>(() => new Max2Fraction1NonNegativeNumber(100m));
    }

    [Fact]
    public void ExcessiveFractionDigits_ThrowsFormatException()
    {
        Assert.Throws<Iso20022FormatException>(() => new Max2Fraction1NonNegativeNumber(1.12m));
    }
}
