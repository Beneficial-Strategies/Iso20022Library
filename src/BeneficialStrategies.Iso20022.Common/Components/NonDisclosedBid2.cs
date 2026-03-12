// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// List trading by which the buy-side provides details to the sell-side information about the sector, country, index and potential market impact of the financial instrument to be bought or sold. Using this information, the sell-side firms bid for the trade.
/// </summary>
[IsoId("_S07jwdp-Ed-ak6NoX_4Aeg_986706325")]
[DisplayName("Non Disclosed Bid")]
public partial record NonDisclosedBid2
{
    #nullable enable
    
    /// <summary>
    /// Identifies a type of bid based on a common characteristic (the currency) of all securities of a list.
    /// </summary>
    [IsoId("_S07jwtp-Ed-ak6NoX_4Aeg_1205583746")]
    [DisplayName("Bid By Currency")]
    [IsoXmlTag("BidByCcy")]
    public CountryCode? BidByCurrency { get; init; } 
    
    /// <summary>
    /// Identifies a type of bid based on a common characteristic (the sector) of all securities of a list.
    /// </summary>
    [IsoId("_S07jw9p-Ed-ak6NoX_4Aeg_1206503753")]
    [DisplayName("Bid By Sector")]
    [IsoXmlTag("BidBySctr")]
    [IsoSimpleType(IsoSimpleType.Max128Text)]
    [StringLength(maximumLength: 128 ,MinimumLength = 1)]
    public IsoMax128Text? BidBySector { get; init; } 
    
    /// <summary>
    /// Identifies a type of bid based on a common characteristic (the index) of all securities of a list.
    /// </summary>
    [IsoId("_S07jxNp-Ed-ak6NoX_4Aeg_1206503778")]
    [DisplayName("Bid By Index")]
    [IsoXmlTag("BidByIndx")]
    [IsoSimpleType(IsoSimpleType.Max128Text)]
    [StringLength(maximumLength: 128 ,MinimumLength = 1)]
    public IsoMax128Text? BidByIndex { get; init; } 
    
    /// <summary>
    /// Difference between the value of a future and the value of the underlying equities after allowing for the discounted cash flows associated with the underlying stocks.
    /// </summary>
    [IsoId("_S07jxdp-Ed-ak6NoX_4Aeg_-1304220816")]
    [DisplayName("Fair Value")]
    [IsoXmlTag("FairVal")]
    public ActiveCurrencyAndAmount? FairValue { get; init; } 
    
    
    #nullable disable
    
}
