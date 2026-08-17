// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Codesets;

public class ExternalProductTypeCodeTests : ExternalCodesetContractTests<ExternalProductTypeCode>
{
    protected override string ValidSample => "EQUI";
    protected override string InvalidSample => "";

    // ── Known-value convenience constants ─────────────────────────────────────
    // The hybrid pattern (open struct + named static instances for known registry values —
    // see CLAUDE.md "Hybrid Pattern: External Code Set With Known Members") must not narrow what
    // the constructor accepts: an unlisted-but-otherwise-valid code must still construct fine.

    [Fact]
    public void KnownValue_Commodity_HasExpectedWireCode()
    {
        Assert.Equal("COMM", ExternalProductTypeCode.Commodity.Value);
    }

    [Fact]
    public void KnownValue_Credit_HasExpectedWireCode()
    {
        Assert.Equal("CRDT", ExternalProductTypeCode.Credit.Value);
    }

    [Fact]
    public void KnownValue_Currency_HasExpectedWireCode()
    {
        Assert.Equal("CURR", ExternalProductTypeCode.Currency.Value);
    }

    [Fact]
    public void KnownValue_EmissionAllowance_HasExpectedWireCode()
    {
        Assert.Equal("EMAL", ExternalProductTypeCode.EmissionAllowance.Value);
    }

    [Fact]
    public void KnownValue_Equity_HasExpectedWireCode()
    {
        Assert.Equal("EQUI", ExternalProductTypeCode.Equity.Value);
    }

    [Fact]
    public void KnownValue_InterestRate_HasExpectedWireCode()
    {
        Assert.Equal("INTR", ExternalProductTypeCode.InterestRate.Value);
    }

    [Fact]
    public void KnownValue_OtherC10_HasExpectedWireCode()
    {
        Assert.Equal("OCTN", ExternalProductTypeCode.OtherC10.Value);
    }

    [Fact]
    public void KnownValue_MatchesConstructedEquivalent()
    {
        Assert.Equal(new ExternalProductTypeCode("COMM"), ExternalProductTypeCode.Commodity);
    }

    [Fact]
    public void UnlistedButValidCode_StillConstructs()
    {
        // Not one of the known registry values above, but still satisfies the open Pattern
        // constraint — proving the known-value constants are additive, not a closed set.
        var instance = new ExternalProductTypeCode("ZZZZ");
        Assert.Equal("ZZZZ", instance.Value);
    }
}
