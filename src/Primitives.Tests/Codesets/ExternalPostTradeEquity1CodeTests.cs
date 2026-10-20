// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Codesets;

namespace BeneficialStrategies.Iso20022.Codesets;

public class ExternalPostTradeEquity1CodeTests : ExternalCodesetContractTests<ExternalPostTradeEquity1Code>
{
    protected override string ValidSample => "AMND";
    protected override string InvalidSample => "TOOLONG";

    [Fact]
    public void KnownValue_Amendment_HasExpectedWireCode()
    {
        Assert.Equal("AMND", ExternalPostTradeEquity1Code.Amendment.Value);
    }

    [Fact]
    public void KnownValue_MatchesConstructedEquivalent()
    {
        Assert.Equal(new ExternalPostTradeEquity1Code("AMND"), ExternalPostTradeEquity1Code.Amendment);
    }

    [Fact]
    public void UnlistedButValidCode_StillConstructs()
    {
        var instance = new ExternalPostTradeEquity1Code("ZZZZ");
        Assert.Equal("ZZZZ", instance.Value);
    }
}
