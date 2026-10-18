// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class RestrictedMonthExact2NumberTests : SimpleValueCompositeIntContractTests<RestrictedMonthExact2Number>
{
    protected override int ValidNativeSample => 9;
    protected override string ValidWireText => "09";
    protected override int OutOfRangeNativeSample => 13;

    [Fact]
    public void January_ZeroPadsToTwoDigits()
    {
        var instance = new RestrictedMonthExact2Number(1);
        Assert.Equal("01", instance.ToString());
    }
}
