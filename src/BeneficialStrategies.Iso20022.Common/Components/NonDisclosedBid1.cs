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
[IsoId("_S0yZ2tp-Ed-ak6NoX_4Aeg_1294975941")]
[DisplayName("Non Disclosed Bid")]
public partial record NonDisclosedBid1
{
    #nullable enable
    
    /// <summary>
    /// Identifies a type of bid based on a common characteristic (the currency) of all securities of a list.
    /// </summary>
    [IsoId("_S0yZ29p-Ed-ak6NoX_4Aeg_1391021740")]
    [DisplayName("Bid By Currency")]
    [IsoXmlTag("BidByCcy")]
    public CountryCode? BidByCurrency { get; init; } 
    
    /// <summary>
    /// Identifies a type of bid based on a common characteristic (the sector) of all securities of a list.
    /// </summary>
    [IsoId("_S0yZ3Np-Ed-ak6NoX_4Aeg_1391021783")]
    [DisplayName("Bid By Sector")]
    [IsoXmlTag("BidBySctr")]
    [IsoSimpleType(IsoSimpleType.Max128Text)]
    [StringLength(maximumLength: 128 ,MinimumLength = 1)]
    public IsoMax128Text? BidBySector { get; init; } 
    
    /// <summary>
    /// Identifies a type of bid based on a common characteristic (the index) of all securities of a list.
    /// </summary>
    [IsoId("_S0yZ3dp-Ed-ak6NoX_4Aeg_1391021801")]
    [DisplayName("Bid By Index")]
    [IsoXmlTag("BidByIndx")]
    [IsoSimpleType(IsoSimpleType.Max128Text)]
    [StringLength(maximumLength: 128 ,MinimumLength = 1)]
    public IsoMax128Text? BidByIndex { get; init; } 
    
    /// <summary>
    /// Indicates the side of the bid in the case of a non disclosed bidding process. Used instead of buy and sell side.|True = Side 1|False = Side 2.
    /// </summary>
    [IsoId("_S0yZ3tp-Ed-ak6NoX_4Aeg_1130979716")]
    [DisplayName("Side Indicator")]
    [IsoXmlTag("SdInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? SideIndicator { get; init; } 
    
    /// <summary>
    /// Provides additionnal details about the liquidity of a financial instrument.
    /// </summary>
    [IsoId("_S0yZ39p-Ed-ak6NoX_4Aeg_1163301984")]
    [DisplayName("Liquidity")]
    [IsoXmlTag("Lqdty")]
    public Liquidity1? Liquidity { get; init; } 
    
    /// <summary>
    /// Details about the exchange for physical trade parameters.
    /// </summary>
    [IsoId("_S07jwNp-Ed-ak6NoX_4Aeg_-1312987174")]
    [DisplayName("Exchange For Physical Trade")]
    [IsoXmlTag("XchgForPhysTrad")]
    public ExchangeForPhysicalTradeParameters1? ExchangeForPhysicalTrade { get; init; } 
    
    
    #nullable disable
    
}
