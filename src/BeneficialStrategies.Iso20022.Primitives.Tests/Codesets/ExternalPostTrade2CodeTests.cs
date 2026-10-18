// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Codesets;

public class ExternalPostTrade2CodeTests : ExternalCodesetContractTests<ExternalPostTrade2Code>
{
    protected override string ValidSample => "DATF";
    protected override string InvalidSample => "";

    // ── Known-value convenience constants ─────────────────────────────────────
    // The hybrid pattern (open struct + named static instances for known registry values —
    // see CLAUDE.md "Hybrid Pattern: External Code Set With Known Members") must not narrow what
    // the constructor accepts: an unlisted-but-otherwise-valid code must still construct fine.

    [Fact]
    public void KnownValue_DailyAggregatedTransactionFlag_HasExpectedWireCode()
    {
        Assert.Equal("DATF", ExternalPostTrade2Code.DailyAggregatedTransactionFlag.Value);
    }

    [Fact]
    public void KnownValue_FullDetailsFlagA_HasExpectedWireCode()
    {
        Assert.Equal("FULA", ExternalPostTrade2Code.FullDetailsFlagA.Value);
    }

    [Fact]
    public void KnownValue_FullDetailsFlagF_HasExpectedWireCode()
    {
        Assert.Equal("FULF", ExternalPostTrade2Code.FullDetailsFlagF.Value);
    }

    [Fact]
    public void KnownValue_FullDetailsFlagJ_HasExpectedWireCode()
    {
        Assert.Equal("FULJ", ExternalPostTrade2Code.FullDetailsFlagJ.Value);
    }

    [Fact]
    public void KnownValue_FullDetailsFlagV_HasExpectedWireCode()
    {
        Assert.Equal("FULV", ExternalPostTrade2Code.FullDetailsFlagV.Value);
    }

    [Fact]
    public void KnownValue_FourWeeksAggregationDerivativeFlag_HasExpectedWireCode()
    {
        Assert.Equal("FWAF", ExternalPostTrade2Code.FourWeeksAggregationDerivativeFlag.Value);
    }

    [Fact]
    public void KnownValue_IlliquidInstrumentTransactionFlag_HasExpectedWireCode()
    {
        Assert.Equal("ILQD", ExternalPostTrade2Code.IlliquidInstrumentTransactionFlag.Value);
    }

    [Fact]
    public void KnownValue_LimitedDetailsFlag_HasExpectedWireCode()
    {
        Assert.Equal("LMTF", ExternalPostTrade2Code.LimitedDetailsFlag.Value);
    }

    [Fact]
    public void KnownValue_PostTradeLISTransactionFlag_HasExpectedWireCode()
    {
        Assert.Equal("LRGS", ExternalPostTrade2Code.PostTradeLISTransactionFlag.Value);
    }

    [Fact]
    public void KnownValue_PostTradeSSTITransactionFlag_HasExpectedWireCode()
    {
        Assert.Equal("SIZE", ExternalPostTrade2Code.PostTradeSSTITransactionFlag.Value);
    }

    [Fact]
    public void KnownValue_VolumeOmissionDerivativeFlag_HasExpectedWireCode()
    {
        Assert.Equal("VOLO", ExternalPostTrade2Code.VolumeOmissionDerivativeFlag.Value);
    }

    [Fact]
    public void KnownValue_MatchesConstructedEquivalent()
    {
        Assert.Equal(new ExternalPostTrade2Code("DATF"), ExternalPostTrade2Code.DailyAggregatedTransactionFlag);
    }

    [Fact]
    public void UnlistedButValidCode_StillConstructs()
    {
        // Not one of the known registry values above, but still satisfies the open Pattern
        // constraint — proving the known-value constants are additive, not a closed set.
        var instance = new ExternalPostTrade2Code("ZZZZ");
        Assert.Equal("ZZZZ", instance.Value);
    }
}
