// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Codesets;

namespace BeneficialStrategies.Iso20022.Codesets;

public class ExternalPostTradeBondCodeTests : ExternalCodesetContractTests<ExternalPostTradeBondCode>
{
    protected override string ValidSample => "AMND";
    protected override string InvalidSample => "TOOLONG";

    [Fact]
    public void KnownValue_Amendment_HasExpectedWireCode()
    {
        Assert.Equal("AMND", ExternalPostTradeBondCode.Amendment.Value);
    }

    [Fact]
    public void KnownValue_MatchesConstructedEquivalent()
    {
        Assert.Equal(new ExternalPostTradeBondCode("AMND"), ExternalPostTradeBondCode.Amendment);
    }

    [Fact]
    public void UnlistedButValidCode_StillConstructs()
    {
        var instance = new ExternalPostTradeBondCode("ZZZZ");
        Assert.Equal("ZZZZ", instance.Value);
    }
}
