// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Codesets;

public class ExternalPostTradeEventType1CodeTests : ExternalCodesetContractTests<ExternalPostTradeEventType1Code>
{
    protected override string ValidSample => "ROLL";
    protected override string InvalidSample => "";

    // ── Known-value convenience constants ─────────────────────────────────────
    // The hybrid pattern (open struct + named static instances for known registry values —
    // see CLAUDE.md "Hybrid Pattern: External Code Set With Known Members") must not narrow what
    // the constructor accepts: an unlisted-but-otherwise-valid code must still construct fine.

    [Fact]
    public void KnownValue_EarlyDelivery_HasExpectedWireCode()
    {
        Assert.Equal("EAMT", ExternalPostTradeEventType1Code.EarlyDelivery.Value);
    }

    [Fact]
    public void KnownValue_PartialEarlyDelivery_HasExpectedWireCode()
    {
        Assert.Equal("PEAM", ExternalPostTradeEventType1Code.PartialEarlyDelivery.Value);
    }

    [Fact]
    public void KnownValue_PartialUnwindRollover_HasExpectedWireCode()
    {
        Assert.Equal("PRUR", ExternalPostTradeEventType1Code.PartialUnwindRollover.Value);
    }

    [Fact]
    public void KnownValue_PartialUnwind_HasExpectedWireCode()
    {
        Assert.Equal("PRUW", ExternalPostTradeEventType1Code.PartialUnwind.Value);
    }

    [Fact]
    public void KnownValue_Rollover_HasExpectedWireCode()
    {
        Assert.Equal("ROLL", ExternalPostTradeEventType1Code.Rollover.Value);
    }

    [Fact]
    public void KnownValue_Unwind_HasExpectedWireCode()
    {
        Assert.Equal("UNWD", ExternalPostTradeEventType1Code.Unwind.Value);
    }

    [Fact]
    public void KnownValue_UnwindRollover_HasExpectedWireCode()
    {
        Assert.Equal("UNWR", ExternalPostTradeEventType1Code.UnwindRollover.Value);
    }

    [Fact]
    public void KnownValue_MatchesConstructedEquivalent()
    {
        Assert.Equal(new ExternalPostTradeEventType1Code("EAMT"), ExternalPostTradeEventType1Code.EarlyDelivery);
    }

    [Fact]
    public void UnlistedButValidCode_StillConstructs()
    {
        // Not one of the known registry values above, but still satisfies the open Pattern
        // constraint — proving the known-value constants are additive, not a closed set.
        var instance = new ExternalPostTradeEventType1Code("ZZZZ");
        Assert.Equal("ZZZZ", instance.Value);
    }
}
