// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Codesets;

public class ExternalBenchmarkTypeCodeTests : ExternalCodesetContractTests<ExternalBenchmarkTypeCode>
{
    protected override string ValidSample => "CAII";
    protected override string InvalidSample => "";

    // ── Known-value convenience constants ─────────────────────────────────────
    // The hybrid pattern (open struct + named static instances for known registry values —
    // see CLAUDE.md "Hybrid Pattern: External Code Set With Known Members") must not narrow what
    // the constructor accepts: an unlisted-but-otherwise-valid code must still construct fine.

    [Fact]
    public void KnownValue_CommodityBenchmarkAnnexII_HasExpectedWireCode()
    {
        Assert.Equal("CAII", ExternalBenchmarkTypeCode.CommodityBenchmarkAnnexII.Value);
    }

    [Fact]
    public void KnownValue_EUClimateTransitionBenchmark_HasExpectedWireCode()
    {
        Assert.Equal("ECTB", ExternalBenchmarkTypeCode.EUClimateTransitionBenchmark.Value);
    }

    [Fact]
    public void KnownValue_EUParisAlignedBenchmark_HasExpectedWireCode()
    {
        Assert.Equal("EPAB", ExternalBenchmarkTypeCode.EUParisAlignedBenchmark.Value);
    }

    [Fact]
    public void KnownValue_Other_HasExpectedWireCode()
    {
        Assert.Equal("OTHR", ExternalBenchmarkTypeCode.Other.Value);
    }

    [Fact]
    public void KnownValue_MatchesConstructedEquivalent()
    {
        Assert.Equal(new ExternalBenchmarkTypeCode("CAII"), ExternalBenchmarkTypeCode.CommodityBenchmarkAnnexII);
    }

    [Fact]
    public void UnlistedButValidCode_StillConstructs()
    {
        // Not one of the known registry values above, but still satisfies the open Pattern
        // constraint — proving the known-value constants are additive, not a closed set.
        var instance = new ExternalBenchmarkTypeCode("ZZZZ");
        Assert.Equal("ZZZZ", instance.Value);
    }
}
