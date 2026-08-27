// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to the auction trading system for the pre-trade output report.
/// </summary>
[IsoId("_kyABgGIcEfCeoPFCHQnhvA")]
[DisplayName("Auction Trading System Data1")]
public record AuctionTradingSystemData1
{
    /// <summary>
    /// Most recent dates and times of the prices that participate in the Consolidated Tape Provider (CTP)’s indicative auction price as reported by the data contributors.
    /// </summary>
    [IsoId("_xRzKEGIcEfCeoPFCHQnhvA")]
    [DisplayName("Indicative Price Date Time")]
    [IsoXmlTag("IndctvPricDtTm")]
    public required IsoISODateTime IndicativePriceDateTime { get; init; }

    /// <summary>
    /// Data related to the auction price for the auction trading system.
    /// </summary>
    [IsoId("_D3QCQGIdEfCeoPFCHQnhvA")]
    [DisplayName("Auction Price")]
    [IsoXmlTag("AuctnPric")]
    public required AuctionPriceData1 AuctionPrice { get; init; }

    /// <summary>
    /// Total auction volume, where applicable, across venues.
    /// </summary>
    [IsoId("_1Va2sGlSEfCI49VeRStxJw")]
    [DisplayName("Auction Volume")]
    [IsoXmlTag("AuctnVol")]
    public IsoDecimalNumber? AuctionVolume { get; init; }
}
