// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Codesets;

namespace BeneficialStrategies.Iso20022.Codesets;

public class ExternalPostTradeBond1CodeTests : ExternalCodesetContractTests<ExternalPostTradeBond1Code>
{
    protected override string ValidSample => "AMND";
    protected override string InvalidSample => "TOOLONG";

    [Fact]
    public void KnownValue_Amendment_HasExpectedWireCode()
    {
        Assert.Equal("AMND", ExternalPostTradeBond1Code.Amendment.Value);
    }

    [Fact]
    public void KnownValue_MatchesConstructedEquivalent()
    {
        Assert.Equal(new ExternalPostTradeBond1Code("AMND"), ExternalPostTradeBond1Code.Amendment);
    }

    [Fact]
    public void UnlistedButValidCode_StillConstructs()
    {
        var instance = new ExternalPostTradeBond1Code("ZZZZ");
        Assert.Equal("ZZZZ", instance.Value);
    }
}
