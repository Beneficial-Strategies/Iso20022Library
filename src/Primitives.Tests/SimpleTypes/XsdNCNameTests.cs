// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class XsdNCNameTests : SimpleValueStringContractTests<XsdNCName>
{
    protected override string ValidSample => "my_element-1.0";
    protected override string InvalidSample => "my:element"; // colon not allowed in NCName

    [Fact]
    public void LeadingDigit_Rejected()
    {
        Assert.False(XsdNCName.TryCreate("1abc", out _));
    }

    [Fact]
    public void LeadingUnderscore_Accepted()
    {
        Assert.True(XsdNCName.TryCreate("_abc", out _));
    }
}
