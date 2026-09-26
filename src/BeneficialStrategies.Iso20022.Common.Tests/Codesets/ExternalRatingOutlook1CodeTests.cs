// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Codesets;

public class ExternalRatingOutlook1CodeTests : ExternalCodesetContractTests<ExternalRatingOutlook1Code>
{
    protected override string ValidSample => "DEVL";
    protected override string InvalidSample => "";

    // ── Known-value convenience constants ─────────────────────────────────────
    // The hybrid pattern (open struct + named static instances for known registry values —
    // see CLAUDE.md "Hybrid Pattern: External Code Set With Known Members") must not narrow what
    // the constructor accepts: an unlisted-but-otherwise-valid code must still construct fine.

    [Fact]
    public void KnownValue_Developing_HasExpectedWireCode()
    {
        Assert.Equal("DEVL", ExternalRatingOutlook1Code.Developing.Value);
    }

    [Fact]
    public void KnownValue_Evolving_HasExpectedWireCode()
    {
        Assert.Equal("EVLV", ExternalRatingOutlook1Code.Evolving.Value);
    }

    [Fact]
    public void KnownValue_NotApplicable_HasExpectedWireCode()
    {
        Assert.Equal("NAPP", ExternalRatingOutlook1Code.NotApplicable.Value);
    }

    [Fact]
    public void KnownValue_Negative_HasExpectedWireCode()
    {
        Assert.Equal("NGTV", ExternalRatingOutlook1Code.Negative.Value);
    }

    [Fact]
    public void KnownValue_NotMeaningful_HasExpectedWireCode()
    {
        Assert.Equal("NMEA", ExternalRatingOutlook1Code.NotMeaningful.Value);
    }

    [Fact]
    public void KnownValue_Positive_HasExpectedWireCode()
    {
        Assert.Equal("PSTV", ExternalRatingOutlook1Code.Positive.Value);
    }

    [Fact]
    public void KnownValue_Stable_HasExpectedWireCode()
    {
        Assert.Equal("STBL", ExternalRatingOutlook1Code.Stable.Value);
    }

    [Fact]
    public void KnownValue_MatchesConstructedEquivalent()
    {
        Assert.Equal(new ExternalRatingOutlook1Code("DEVL"), ExternalRatingOutlook1Code.Developing);
    }

    [Fact]
    public void UnlistedButValidCode_StillConstructs()
    {
        // Not one of the known registry values above, but still satisfies the open Pattern
        // constraint — proving the known-value constants are additive, not a closed set.
        var instance = new ExternalRatingOutlook1Code("ZZZZ");
        Assert.Equal("ZZZZ", instance.Value);
    }
}
