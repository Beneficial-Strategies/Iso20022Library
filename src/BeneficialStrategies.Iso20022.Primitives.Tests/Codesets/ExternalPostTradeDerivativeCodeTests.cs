// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Codesets;

namespace BeneficialStrategies.Iso20022.Codesets;

public class ExternalPostTradeDerivativeCodeTests : ExternalCodesetContractTests<ExternalPostTradeDerivativeCode>
{
    protected override string ValidSample => "DEFF";
    protected override string InvalidSample => "TOOLONG";

    [Fact]
    public void KnownValue_Deferral_HasExpectedWireCode()
    {
        Assert.Equal("DEFF", ExternalPostTradeDerivativeCode.Deferral.Value);
    }

    [Fact]
    public void KnownValue_MatchesConstructedEquivalent()
    {
        Assert.Equal(new ExternalPostTradeDerivativeCode("DEFF"), ExternalPostTradeDerivativeCode.Deferral);
    }

    [Fact]
    public void UnlistedButValidCode_StillConstructs()
    {
        var instance = new ExternalPostTradeDerivativeCode("ZZZZ");
        Assert.Equal("ZZZZ", instance.Value);
    }
}
