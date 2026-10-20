// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Codesets;

public class ExternalPostTradeEventTypeCodeTests : ExternalCodesetContractTests<ExternalPostTradeEventTypeCode>
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
        Assert.Equal("EAMT", ExternalPostTradeEventTypeCode.EarlyDelivery.Value);
    }

    [Fact]
    public void KnownValue_PartialEarlyDelivery_HasExpectedWireCode()
    {
        Assert.Equal("PEAM", ExternalPostTradeEventTypeCode.PartialEarlyDelivery.Value);
    }

    [Fact]
    public void KnownValue_PartialUnwindRollover_HasExpectedWireCode()
    {
        Assert.Equal("PRUR", ExternalPostTradeEventTypeCode.PartialUnwindRollover.Value);
    }

    [Fact]
    public void KnownValue_PartialUnwind_HasExpectedWireCode()
    {
        Assert.Equal("PRUW", ExternalPostTradeEventTypeCode.PartialUnwind.Value);
    }

    [Fact]
    public void KnownValue_Rollover_HasExpectedWireCode()
    {
        Assert.Equal("ROLL", ExternalPostTradeEventTypeCode.Rollover.Value);
    }

    [Fact]
    public void KnownValue_Unwind_HasExpectedWireCode()
    {
        Assert.Equal("UNWD", ExternalPostTradeEventTypeCode.Unwind.Value);
    }

    [Fact]
    public void KnownValue_UnwindRollover_HasExpectedWireCode()
    {
        Assert.Equal("UNWR", ExternalPostTradeEventTypeCode.UnwindRollover.Value);
    }

    [Fact]
    public void KnownValue_MatchesConstructedEquivalent()
    {
        Assert.Equal(new ExternalPostTradeEventTypeCode("EAMT"), ExternalPostTradeEventTypeCode.EarlyDelivery);
    }

    [Fact]
    public void UnlistedButValidCode_StillConstructs()
    {
        // Not one of the known registry values above, but still satisfies the open Pattern
        // constraint — proving the known-value constants are additive, not a closed set.
        var instance = new ExternalPostTradeEventTypeCode("ZZZZ");
        Assert.Equal("ZZZZ", instance.Value);
    }
}
