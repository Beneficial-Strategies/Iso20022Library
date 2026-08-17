// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class ISOYearMonthTests : SimpleValueISOYearMonthContractTests<ISOYearMonth>
{
    [Fact]
    public void ShortYear_ZeroPads()
    {
        var instance = new ISOYearMonth(99, 1);
        Assert.Equal("0099-01", instance.ToString());
    }
}
