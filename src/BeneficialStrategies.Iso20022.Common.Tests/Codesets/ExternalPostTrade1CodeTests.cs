// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Codesets;

public class ExternalPostTrade1CodeTests : ExternalCodesetContractTests<ExternalPostTrade1Code>
{
    protected override string ValidSample => "AGFW";
    protected override string InvalidSample => "";

    // ── Known-value convenience constants ─────────────────────────────────────
    // The hybrid pattern (open struct + named static instances for known registry values —
    // see CLAUDE.md "Hybrid Pattern: External Code Set With Known Members") must not narrow what
    // the constructor accepts: an unlisted-but-otherwise-valid code must still construct fine.

    [Fact]
    public void KnownValue_FourWeeksAggregationBondFlag_HasExpectedWireCode()
    {
        Assert.Equal("AGFW", ExternalPostTrade1Code.FourWeeksAggregationBondFlag.Value);
    }

    [Fact]
    public void KnownValue_AmendmentFlag_HasExpectedWireCode()
    {
        Assert.Equal("AMND", ExternalPostTrade1Code.AmendmentFlag.Value);
    }

    [Fact]
    public void KnownValue_BenchmarkTransactionsFlag_HasExpectedWireCode()
    {
        Assert.Equal("BENC", ExternalPostTrade1Code.BenchmarkTransactionsFlag.Value);
    }

    [Fact]
    public void KnownValue_CancellationFlag_HasExpectedWireCode()
    {
        Assert.Equal("CANC", ExternalPostTrade1Code.CancellationFlag.Value);
    }

    [Fact]
    public void KnownValue_FullDetailsFlagG_HasExpectedWireCode()
    {
        Assert.Equal("FULG", ExternalPostTrade1Code.FullDetailsFlagG.Value);
    }

    [Fact]
    public void KnownValue_FullDetailsFlagO_HasExpectedWireCode()
    {
        Assert.Equal("FULO", ExternalPostTrade1Code.FullDetailsFlagO.Value);
    }

    [Fact]
    public void KnownValue_LargeIlliquidFlag_HasExpectedWireCode()
    {
        Assert.Equal("LIF4", ExternalPostTrade1Code.LargeIlliquidFlag.Value);
    }

    [Fact]
    public void KnownValue_LargeLiquidFlag_HasExpectedWireCode()
    {
        Assert.Equal("LLF3", ExternalPostTrade1Code.LargeLiquidFlag.Value);
    }

    [Fact]
    public void KnownValue_MediumIlliquidFlag_HasExpectedWireCode()
    {
        Assert.Equal("MIF2", ExternalPostTrade1Code.MediumIlliquidFlag.Value);
    }

    [Fact]
    public void KnownValue_MediumLiquidFlag_HasExpectedWireCode()
    {
        Assert.Equal("MLF1", ExternalPostTrade1Code.MediumLiquidFlag.Value);
    }

    [Fact]
    public void KnownValue_MatchedPrincipalTradingFlag_HasExpectedWireCode()
    {
        Assert.Equal("MTCH", ExternalPostTrade1Code.MatchedPrincipalTradingFlag.Value);
    }

    [Fact]
    public void KnownValue_NegotiatedTransactionFlag_HasExpectedWireCode()
    {
        Assert.Equal("NEGO", ExternalPostTrade1Code.NegotiatedTransactionFlag.Value);
    }

    [Fact]
    public void KnownValue_NonPriceFormingTransactionFlag_HasExpectedWireCode()
    {
        Assert.Equal("NPFT", ExternalPostTrade1Code.NonPriceFormingTransactionFlag.Value);
    }

    [Fact]
    public void KnownValue_VolumeOmissionBondFlag_HasExpectedWireCode()
    {
        Assert.Equal("OMIS", ExternalPostTrade1Code.VolumeOmissionBondFlag.Value);
    }

    [Fact]
    public void KnownValue_PortfolioTradeFlag_HasExpectedWireCode()
    {
        Assert.Equal("PORT", ExternalPostTrade1Code.PortfolioTradeFlag.Value);
    }

    [Fact]
    public void KnownValue_PackageTransactionFlag_HasExpectedWireCode()
    {
        Assert.Equal("TPAC", ExternalPostTrade1Code.PackageTransactionFlag.Value);
    }

    [Fact]
    public void KnownValue_VeryLargeIlliquidFlag_HasExpectedWireCode()
    {
        Assert.Equal("VIF5", ExternalPostTrade1Code.VeryLargeIlliquidFlag.Value);
    }

    [Fact]
    public void KnownValue_VeryLargeLiquidFlag_HasExpectedWireCode()
    {
        Assert.Equal("VLF5", ExternalPostTrade1Code.VeryLargeLiquidFlag.Value);
    }

    [Fact]
    public void KnownValue_ExchangeForPhysicalsTransactionFlag_HasExpectedWireCode()
    {
        Assert.Equal("XPFH", ExternalPostTrade1Code.ExchangeForPhysicalsTransactionFlag.Value);
    }

    [Fact]
    public void KnownValue_MatchesConstructedEquivalent()
    {
        Assert.Equal(new ExternalPostTrade1Code("AGFW"), ExternalPostTrade1Code.FourWeeksAggregationBondFlag);
    }

    [Fact]
    public void UnlistedButValidCode_StillConstructs()
    {
        // Not one of the known registry values above, but still satisfies the open Pattern
        // constraint — proving the known-value constants are additive, not a closed set.
        var instance = new ExternalPostTrade1Code("ZZZZ");
        Assert.Equal("ZZZZ", instance.Value);
    }
}
