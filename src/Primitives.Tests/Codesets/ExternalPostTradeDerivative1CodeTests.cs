// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Codesets;

namespace BeneficialStrategies.Iso20022.Codesets;

public class ExternalPostTradeDerivative1CodeTests : ExternalCodesetContractTests<ExternalPostTradeDerivative1Code>
{
    protected override string ValidSample => "DEFF";
    protected override string InvalidSample => "TOOLONG";

    [Fact]
    public void KnownValue_Deferral_HasExpectedWireCode()
    {
        Assert.Equal("DEFF", ExternalPostTradeDerivative1Code.Deferral.Value);
    }

    [Fact]
    public void KnownValue_MatchesConstructedEquivalent()
    {
        Assert.Equal(new ExternalPostTradeDerivative1Code("DEFF"), ExternalPostTradeDerivative1Code.Deferral);
    }

    [Fact]
    public void UnlistedButValidCode_StillConstructs()
    {
        var instance = new ExternalPostTradeDerivative1Code("ZZZZ");
        Assert.Equal("ZZZZ", instance.Value);
    }
}
