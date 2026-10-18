// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Codesets;

public class ExternalBenchmarkSignificance1CodeTests : ExternalCodesetContractTests<ExternalBenchmarkSignificance1Code>
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
        Assert.Equal("C201", ExternalBenchmarkSignificance1Code.CriticalBenchmarkUnderArt201.Value);
    }

    [Fact]
    public void KnownValue_NonSignificantAndNonCritical_HasExpectedWireCode()
    {
        Assert.Equal("NSNC", ExternalBenchmarkSignificance1Code.NonSignificantAndNonCritical.Value);
    }

    [Fact]
    public void KnownValue_SignificantBenchmarkUnderArt242_HasExpectedWireCode()
    {
        Assert.Equal("S242", ExternalBenchmarkSignificance1Code.SignificantBenchmarkUnderArt242.Value);
    }

    [Fact]
    public void KnownValue_SignificantBenchmarkUnderArt243_HasExpectedWireCode()
    {
        Assert.Equal("S243", ExternalBenchmarkSignificance1Code.SignificantBenchmarkUnderArt243.Value);
    }

    [Fact]
    public void KnownValue_SignificantBenchmarkUnderArt246_HasExpectedWireCode()
    {
        Assert.Equal("S246", ExternalBenchmarkSignificance1Code.SignificantBenchmarkUnderArt246.Value);
    }

    [Fact]
    public void KnownValue_SignificantBenchmarkUnderArt247_HasExpectedWireCode()
    {
        Assert.Equal("S247", ExternalBenchmarkSignificance1Code.SignificantBenchmarkUnderArt247.Value);
    }

    [Fact]
    public void KnownValue_MatchesConstructedEquivalent()
    {
        Assert.Equal(new ExternalBenchmarkSignificance1Code("C201"), ExternalBenchmarkSignificance1Code.CriticalBenchmarkUnderArt201);
    }

    [Fact]
    public void UnlistedButValidCode_StillConstructs()
    {
        // Not one of the known registry values above, but still satisfies the open Pattern
        // constraint — proving the known-value constants are additive, not a closed set.
        var instance = new ExternalBenchmarkSignificance1Code("ZZZZ");
        Assert.Equal("ZZZZ", instance.Value);
    }
}
