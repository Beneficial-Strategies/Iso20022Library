// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.OutputData1Choice
{
    /// <summary>Data related to the auction trading system for the pre-trade output report.</summary>
    [IsoId("_uk_s8GIZEfCeoPFCHQnhvA")]
    [DisplayName("Auction Trading System")]
    public record AuctionTradingSystem : OutputData1Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("AuctnTradgSys")]
        public required AuctionTradingSystemData1 Value { get; init; }
    }
}
