// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Codesets;

public class ExternalBenchmarkType1CodeTests : ExternalCodesetContractTests<ExternalBenchmarkType1Code>
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
        Assert.Equal("CAII", ExternalBenchmarkType1Code.CommodityBenchmarkAnnexII.Value);
    }

    [Fact]
    public void KnownValue_EUClimateTransitionBenchmark_HasExpectedWireCode()
    {
        Assert.Equal("ECTB", ExternalBenchmarkType1Code.EUClimateTransitionBenchmark.Value);
    }

    [Fact]
    public void KnownValue_EUParisAlignedBenchmark_HasExpectedWireCode()
    {
        Assert.Equal("EPAB", ExternalBenchmarkType1Code.EUParisAlignedBenchmark.Value);
    }

    [Fact]
    public void KnownValue_Other_HasExpectedWireCode()
    {
        Assert.Equal("OTHR", ExternalBenchmarkType1Code.Other.Value);
    }

    [Fact]
    public void KnownValue_MatchesConstructedEquivalent()
    {
        Assert.Equal(new ExternalBenchmarkType1Code("CAII"), ExternalBenchmarkType1Code.CommodityBenchmarkAnnexII);
    }

    [Fact]
    public void UnlistedButValidCode_StillConstructs()
    {
        // Not one of the known registry values above, but still satisfies the open Pattern
        // constraint — proving the known-value constants are additive, not a closed set.
        var instance = new ExternalBenchmarkType1Code("ZZZZ");
        Assert.Equal("ZZZZ", instance.Value);
    }
}
