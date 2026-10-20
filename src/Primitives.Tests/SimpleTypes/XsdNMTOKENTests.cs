// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class XsdNMTOKENTests : SimpleValueStringContractTests<XsdNMTOKEN>
{
    protected override string ValidSample => "1st-token";
    protected override string InvalidSample => "has space";

    [Fact]
    public void LeadingDigit_Accepted()
    {
        // Unlike xs:Name/xs:NCName, xs:NMTOKEN has no NameStartChar restriction.
        Assert.True(XsdNMTOKEN.TryCreate("123", out _));
    }
}
