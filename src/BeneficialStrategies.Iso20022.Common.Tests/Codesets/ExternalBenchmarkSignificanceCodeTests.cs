// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Codesets;

public class ExternalBenchmarkSignificanceCodeTests : ExternalCodesetContractTests<ExternalBenchmarkSignificanceCode>
{
    protected override string ValidSample => "C201";
    protected override string InvalidSample => "";

    // ── Known-value convenience constants ─────────────────────────────────────
    // The hybrid pattern (open struct + named static instances for known registry values —
    // see CLAUDE.md "Hybrid Pattern: External Code Set With Known Members") must not narrow what
    // the constructor accepts: an unlisted-but-otherwise-valid code must still construct fine.

    [Fact]
    public void KnownValue_CriticalBenchmarkUnderArt201_HasExpectedWireCode()
    {
        Assert.Equal("C201", ExternalBenchmarkSignificanceCode.CriticalBenchmarkUnderArt201.Value);
    }

    [Fact]
    public void KnownValue_NonSignificantAndNonCritical_HasExpectedWireCode()
    {
        Assert.Equal("NSNC", ExternalBenchmarkSignificanceCode.NonSignificantAndNonCritical.Value);
    }

    [Fact]
    public void KnownValue_SignificantBenchmarkUnderArt242_HasExpectedWireCode()
    {
        Assert.Equal("S242", ExternalBenchmarkSignificanceCode.SignificantBenchmarkUnderArt242.Value);
    }

    [Fact]
    public void KnownValue_SignificantBenchmarkUnderArt243_HasExpectedWireCode()
    {
        Assert.Equal("S243", ExternalBenchmarkSignificanceCode.SignificantBenchmarkUnderArt243.Value);
    }

    [Fact]
    public void KnownValue_SignificantBenchmarkUnderArt246_HasExpectedWireCode()
    {
        Assert.Equal("S246", ExternalBenchmarkSignificanceCode.SignificantBenchmarkUnderArt246.Value);
    }

    [Fact]
    public void KnownValue_SignificantBenchmarkUnderArt247_HasExpectedWireCode()
    {
        Assert.Equal("S247", ExternalBenchmarkSignificanceCode.SignificantBenchmarkUnderArt247.Value);
    }

    [Fact]
    public void KnownValue_MatchesConstructedEquivalent()
    {
        Assert.Equal(new ExternalBenchmarkSignificanceCode("C201"), ExternalBenchmarkSignificanceCode.CriticalBenchmarkUnderArt201);
    }

    [Fact]
    public void UnlistedButValidCode_StillConstructs()
    {
        // Not one of the known registry values above, but still satisfies the open Pattern
        // constraint — proving the known-value constants are additive, not a closed set.
        var instance = new ExternalBenchmarkSignificanceCode("ZZZZ");
        Assert.Equal("ZZZZ", instance.Value);
    }
}
