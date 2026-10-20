// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class XsdNameTests : SimpleValueStringContractTests<XsdName>
{
    protected override string ValidSample => "my:element-1.0";
    protected override string InvalidSample => "1abc"; // must not start with a digit

    [Fact]
    public void LeadingColon_Accepted()
    {
        // Unlike xs:NCName, xs:Name permits a leading colon.
        Assert.True(XsdName.TryCreate(":abc", out _));
    }
}
