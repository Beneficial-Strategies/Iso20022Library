// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Auction Data2.
/// </summary>
[IsoId("_7Zfv4RA2Ee6N57R8Wekj-w")]
[DisplayName("Auction Data2")]
public partial record AuctionData2
{
    #nullable enable

    /// <summary>
    /// Indicative Auction Price.
    /// </summary>
    [DisplayName("Indicative Auction Price")]
    [IsoXmlTag("IndctvAuctnPric")]
    public SecuritiesTransactionPrice21Choice_? IndicativeAuctionPrice { get; init; } 

    /// <summary>
    /// Indicative Auction Volume.
    /// </summary>
    [DisplayName("Indicative Auction Volume")]
    [IsoXmlTag("IndctvAuctnVol")]
    public FinancialInstrumentQuantity25Choice_? IndicativeAuctionVolume { get; init; } 

    /// <summary>
    /// Trading Phase.
    /// </summary>
    [DisplayName("Trading Phase")]
    [IsoXmlTag("TradgPhs")]
    public IsoMax50Text? TradingPhase { get; init; } 

    
    #nullable disable
    
}
