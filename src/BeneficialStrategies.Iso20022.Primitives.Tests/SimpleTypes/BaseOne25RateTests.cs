// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class BaseOne25RateTests : SimpleValueXsdNumericContractTests<BaseOne25Rate, decimal>
{
    protected override decimal ValidNativeSample => 12345.5m;

    [Fact]
    public void ExcessiveTotalDigits_ThrowsFormatException()
    {
        Assert.Throws<Iso20022FormatException>(() => new BaseOne25Rate(10000000000000000000000000m));
    }

    [Fact]
    public void ExcessiveFractionDigits_ThrowsFormatException()
    {
        Assert.Throws<Iso20022FormatException>(() => new BaseOne25Rate(1.12345678901234m));
    }
}
