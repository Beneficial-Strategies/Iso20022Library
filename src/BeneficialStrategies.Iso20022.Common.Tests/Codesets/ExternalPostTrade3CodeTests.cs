// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Codesets;

public class ExternalPostTrade3CodeTests : ExternalCodesetContractTests<ExternalPostTrade3Code>
{
    protected override string ValidSample => "ALGO";
    protected override string InvalidSample => "";

    // ── Known-value convenience constants ─────────────────────────────────────
    // The hybrid pattern (open struct + named static instances for known registry values —
    // see CLAUDE.md "Hybrid Pattern: External Code Set With Known Members") must not narrow what
    // the constructor accepts: an unlisted-but-otherwise-valid code must still construct fine.

    [Fact]
    public void KnownValue_AlgorithmicTransactionFlag_HasExpectedWireCode()
    {
        Assert.Equal("ALGO", ExternalPostTrade3Code.AlgorithmicTransactionFlag.Value);
    }

    [Fact]
    public void KnownValue_AmendmentFlag_HasExpectedWireCode()
    {
        Assert.Equal("AMND", ExternalPostTrade3Code.AmendmentFlag.Value);
    }

    [Fact]
    public void KnownValue_BenchmarkTransactionsFlag_HasExpectedWireCode()
    {
        Assert.Equal("BENC", ExternalPostTrade3Code.BenchmarkTransactionsFlag.Value);
    }

    [Fact]
    public void KnownValue_CancellationFlag_HasExpectedWireCode()
    {
        Assert.Equal("CANC", ExternalPostTrade3Code.CancellationFlag.Value);
    }

    [Fact]
    public void KnownValue_ContingentTransactionsFlag_HasExpectedWireCode()
    {
        Assert.Equal("CONT", ExternalPostTrade3Code.ContingentTransactionsFlag.Value);
    }

    [Fact]
    public void KnownValue_DeferralFlag_HasExpectedWireCode()
    {
        Assert.Equal("DEFF", ExternalPostTrade3Code.DeferralFlag.Value);
    }

    [Fact]
    public void KnownValue_PostTradeLISTransactionFlag_HasExpectedWireCode()
    {
        Assert.Equal("LRGS", ExternalPostTrade3Code.PostTradeLISTransactionFlag.Value);
    }

    [Fact]
    public void KnownValue_NegotiatedTransactionInLiquidFinancialInstrumentsFlag_HasExpectedWireCode()
    {
        Assert.Equal("NLIQ", ExternalPostTrade3Code.NegotiatedTransactionInLiquidFinancialInstrumentsFlag.Value);
    }

    [Fact]
    public void KnownValue_NonPriceFormingTransactionFlag_HasExpectedWireCode()
    {
        Assert.Equal("NPFT", ExternalPostTrade3Code.NonPriceFormingTransactionFlag.Value);
    }

    [Fact]
    public void KnownValue_NegotiatedTransactionInIlliquidFinancialInstrumentsFlag_HasExpectedWireCode()
    {
        Assert.Equal("OILQ", ExternalPostTrade3Code.NegotiatedTransactionInIlliquidFinancialInstrumentsFlag.Value);
    }

    [Fact]
    public void KnownValue_PortfolioTradeFlag_HasExpectedWireCode()
    {
        Assert.Equal("PORT", ExternalPostTrade3Code.PortfolioTradeFlag.Value);
    }

    [Fact]
    public void KnownValue_NegotiatedTransactionSubjectToConditionsOtherThanTheCurrentMarketPriceFlag_HasExpectedWireCode()
    {
        Assert.Equal("PRIC", ExternalPostTrade3Code.NegotiatedTransactionSubjectToConditionsOtherThanTheCurrentMarketPriceFlag.Value);
    }

    [Fact]
    public void KnownValue_ReferencePriceTransactionFlag_HasExpectedWireCode()
    {
        Assert.Equal("RFPT", ExternalPostTrade3Code.ReferencePriceTransactionFlag.Value);
    }

    [Fact]
    public void KnownValue_SpecialDividendTransactionFlag_HasExpectedWireCode()
    {
        Assert.Equal("SDIV", ExternalPostTrade3Code.SpecialDividendTransactionFlag.Value);
    }

    [Fact]
    public void KnownValue_MatchesConstructedEquivalent()
    {
        Assert.Equal(new ExternalPostTrade3Code("ALGO"), ExternalPostTrade3Code.AlgorithmicTransactionFlag);
    }

    [Fact]
    public void UnlistedButValidCode_StillConstructs()
    {
        // Not one of the known registry values above, but still satisfies the open Pattern
        // constraint — proving the known-value constants are additive, not a closed set.
        var instance = new ExternalPostTrade3Code("ZZZZ");
        Assert.Equal("ZZZZ", instance.Value);
    }
}
