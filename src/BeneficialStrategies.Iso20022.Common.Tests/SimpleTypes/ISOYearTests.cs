// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class ISOYearTests : SimpleValueCompositeIntContractTests<ISOYear>
{
    protected override int ValidNativeSample => 2026;
    protected override string ValidWireText => "2026";
    protected override int OutOfRangeNativeSample => -1;

    [Fact]
    public void ShortYear_ZeroPadsToFourDigits()
    {
        var instance = new ISOYear(99);
        Assert.Equal("0099", instance.ToString());
    }
}
