// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Codesets;

public class ExternalPostTradeCodeTests : ExternalCodesetContractTests<ExternalPostTradeCode>
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
        Assert.Equal("AGFW", ExternalPostTradeCode.FourWeeksAggregationBondFlag.Value);
    }

    [Fact]
    public void KnownValue_AlgorithmicTransactionFlag_HasExpectedWireCode()
    {
        Assert.Equal("ALGO", ExternalPostTradeCode.AlgorithmicTransactionFlag.Value);
    }

    [Fact]
    public void KnownValue_AmendmentFlag_HasExpectedWireCode()
    {
        Assert.Equal("AMND", ExternalPostTradeCode.AmendmentFlag.Value);
    }

    [Fact]
    public void KnownValue_BenchmarkTransactionsFlag_HasExpectedWireCode()
    {
        Assert.Equal("BENC", ExternalPostTradeCode.BenchmarkTransactionsFlag.Value);
    }

    [Fact]
    public void KnownValue_CancellationFlag_HasExpectedWireCode()
    {
        Assert.Equal("CANC", ExternalPostTradeCode.CancellationFlag.Value);
    }

    [Fact]
    public void KnownValue_ContingentTransactionsFlag_HasExpectedWireCode()
    {
        Assert.Equal("CONT", ExternalPostTradeCode.ContingentTransactionsFlag.Value);
    }

    [Fact]
    public void KnownValue_DailyAggregatedTransactionFlag_HasExpectedWireCode()
    {
        Assert.Equal("DATF", ExternalPostTradeCode.DailyAggregatedTransactionFlag.Value);
    }

    [Fact]
    public void KnownValue_DeferralFlag_HasExpectedWireCode()
    {
        Assert.Equal("DEFF", ExternalPostTradeCode.DeferralFlag.Value);
    }

    [Fact]
    public void KnownValue_FullDetailsFlagA_HasExpectedWireCode()
    {
        Assert.Equal("FULA", ExternalPostTradeCode.FullDetailsFlagA.Value);
    }

    [Fact]
    public void KnownValue_FullDetailsFlagF_HasExpectedWireCode()
    {
        Assert.Equal("FULF", ExternalPostTradeCode.FullDetailsFlagF.Value);
    }

    [Fact]
    public void KnownValue_FullDetailsFlagG_HasExpectedWireCode()
    {
        Assert.Equal("FULG", ExternalPostTradeCode.FullDetailsFlagG.Value);
    }

    [Fact]
    public void KnownValue_FullDetailsFlagJ_HasExpectedWireCode()
    {
        Assert.Equal("FULJ", ExternalPostTradeCode.FullDetailsFlagJ.Value);
    }

    [Fact]
    public void KnownValue_FullDetailsFlagO_HasExpectedWireCode()
    {
        Assert.Equal("FULO", ExternalPostTradeCode.FullDetailsFlagO.Value);
    }

    [Fact]
    public void KnownValue_FullDetailsFlagV_HasExpectedWireCode()
    {
        Assert.Equal("FULV", ExternalPostTradeCode.FullDetailsFlagV.Value);
    }

    [Fact]
    public void KnownValue_FourWeeksAggregationDerivativeFlag_HasExpectedWireCode()
    {
        Assert.Equal("FWAF", ExternalPostTradeCode.FourWeeksAggregationDerivativeFlag.Value);
    }

    [Fact]
    public void KnownValue_IlliquidInstrumentTransactionFlag_HasExpectedWireCode()
    {
        Assert.Equal("ILQD", ExternalPostTradeCode.IlliquidInstrumentTransactionFlag.Value);
    }

    [Fact]
    public void KnownValue_LargeIlliquidFlag_HasExpectedWireCode()
    {
        Assert.Equal("LIF4", ExternalPostTradeCode.LargeIlliquidFlag.Value);
    }

    [Fact]
    public void KnownValue_LargeLiquidFlag_HasExpectedWireCode()
    {
        Assert.Equal("LLF3", ExternalPostTradeCode.LargeLiquidFlag.Value);
    }

    [Fact]
    public void KnownValue_LimitedDetailsFlag_HasExpectedWireCode()
    {
        Assert.Equal("LMTF", ExternalPostTradeCode.LimitedDetailsFlag.Value);
    }

    [Fact]
    public void KnownValue_PostTradeLISTransactionFlag_HasExpectedWireCode()
    {
        Assert.Equal("LRGS", ExternalPostTradeCode.PostTradeLISTransactionFlag.Value);
    }

    [Fact]
    public void KnownValue_MediumIlliquidFlag_HasExpectedWireCode()
    {
        Assert.Equal("MIF2", ExternalPostTradeCode.MediumIlliquidFlag.Value);
    }

    [Fact]
    public void KnownValue_MediumLiquidFlag_HasExpectedWireCode()
    {
        Assert.Equal("MLF1", ExternalPostTradeCode.MediumLiquidFlag.Value);
    }

    [Fact]
    public void KnownValue_MatchedPrincipalTradingFlag_HasExpectedWireCode()
    {
        Assert.Equal("MTCH", ExternalPostTradeCode.MatchedPrincipalTradingFlag.Value);
    }

    [Fact]
    public void KnownValue_NegotiatedTransactionFlag_HasExpectedWireCode()
    {
        Assert.Equal("NEGO", ExternalPostTradeCode.NegotiatedTransactionFlag.Value);
    }

    [Fact]
    public void KnownValue_NegotiatedTransactionInLiquidFinancialInstrumentsFlag_HasExpectedWireCode()
    {
        Assert.Equal("NLIQ", ExternalPostTradeCode.NegotiatedTransactionInLiquidFinancialInstrumentsFlag.Value);
    }

    [Fact]
    public void KnownValue_NonPriceFormingTransactionFlag_HasExpectedWireCode()
    {
        Assert.Equal("NPFT", ExternalPostTradeCode.NonPriceFormingTransactionFlag.Value);
    }

    [Fact]
    public void KnownValue_NegotiatedTransactionInIlliquidFinancialInstrumentsFlag_HasExpectedWireCode()
    {
        Assert.Equal("OILQ", ExternalPostTradeCode.NegotiatedTransactionInIlliquidFinancialInstrumentsFlag.Value);
    }

    [Fact]
    public void KnownValue_VolumeOmissionBondFlag_HasExpectedWireCode()
    {
        Assert.Equal("OMIS", ExternalPostTradeCode.VolumeOmissionBondFlag.Value);
    }

    [Fact]
    public void KnownValue_PortfolioTradeFlag_HasExpectedWireCode()
    {
        Assert.Equal("PORT", ExternalPostTradeCode.PortfolioTradeFlag.Value);
    }

    [Fact]
    public void KnownValue_NegotiatedTransactionSubjectToConditionsOtherThanTheCurrentMarketPriceFlag_HasExpectedWireCode()
    {
        Assert.Equal("PRIC", ExternalPostTradeCode.NegotiatedTransactionSubjectToConditionsOtherThanTheCurrentMarketPriceFlag.Value);
    }

    [Fact]
    public void KnownValue_ReferencePriceTransactionFlag_HasExpectedWireCode()
    {
        Assert.Equal("RFPT", ExternalPostTradeCode.ReferencePriceTransactionFlag.Value);
    }

    [Fact]
    public void KnownValue_SpecialDividendTransactionFlag_HasExpectedWireCode()
    {
        Assert.Equal("SDIV", ExternalPostTradeCode.SpecialDividendTransactionFlag.Value);
    }

    [Fact]
    public void KnownValue_PostTradeSSTITransactionFlag_HasExpectedWireCode()
    {
        Assert.Equal("SIZE", ExternalPostTradeCode.PostTradeSSTITransactionFlag.Value);
    }

    [Fact]
    public void KnownValue_PackageTransactionFlag_HasExpectedWireCode()
    {
        Assert.Equal("TPAC", ExternalPostTradeCode.PackageTransactionFlag.Value);
    }

    [Fact]
    public void KnownValue_VeryLargeIlliquidFlag_HasExpectedWireCode()
    {
        Assert.Equal("VIF5", ExternalPostTradeCode.VeryLargeIlliquidFlag.Value);
    }

    [Fact]
    public void KnownValue_VeryLargeLiquidFlag_HasExpectedWireCode()
    {
        Assert.Equal("VLF5", ExternalPostTradeCode.VeryLargeLiquidFlag.Value);
    }

    [Fact]
    public void KnownValue_VolumeOmissionDerivativeFlag_HasExpectedWireCode()
    {
        Assert.Equal("VOLO", ExternalPostTradeCode.VolumeOmissionDerivativeFlag.Value);
    }

    [Fact]
    public void KnownValue_ExchangeForPhysicalsTransactionFlag_HasExpectedWireCode()
    {
        Assert.Equal("XPFH", ExternalPostTradeCode.ExchangeForPhysicalsTransactionFlag.Value);
    }

    [Fact]
    public void KnownValue_MatchesConstructedEquivalent()
    {
        Assert.Equal(new ExternalPostTradeCode("AGFW"), ExternalPostTradeCode.FourWeeksAggregationBondFlag);
    }

    [Fact]
    public void UnlistedButValidCode_StillConstructs()
    {
        // Not one of the known registry values above, but still satisfies the open Pattern
        // constraint — proving the known-value constants are additive, not a closed set.
        var instance = new ExternalPostTradeCode("ZZZZ");
        Assert.Equal("ZZZZ", instance.Value);
    }
}
