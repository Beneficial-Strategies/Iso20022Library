// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details for negotiating and trading a large number of securities contained in or comprising a portfolio. ||One example is index arbitrage, which consists in the purchase or sale of a basket of stocks in conjunction with the sale or purchase of|a derivative product (for example index futures) to profit from price differences between the basket and the derivative product. ||Other examples include liquidation of EFP (Exchange for Physical) stock positions, portfolio realignment and portfolio liquidation.
/// </summary>
[IsoId("_SzmHAtp-Ed-ak6NoX_4Aeg_-606838649")]
[DisplayName("List")]
public partial record List2
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier for a list, as assigned by the trading party. The identifier must be unique within a single trading day.
    /// </summary>
    [IsoId("_SzmHA9p-Ed-ak6NoX_4Aeg_-565279150")]
    [DisplayName("List Identification")]
    [IsoXmlTag("ListId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text ListIdentification { get; init; } 
    
    /// <summary>
    /// Indicates the date and time of the agreement in principal between counter-parties prior to actual trade date.|Used with fixed income for municipal new issue markets.
    /// </summary>
    [IsoId("_SzmHBNp-Ed-ak6NoX_4Aeg_-239278735")]
    [DisplayName("Trade Origination Date Time")]
    [IsoXmlTag("TradOrgtnDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? TradeOriginationDateTime { get; init; } 
    
    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    [IsoId("_SzmHBdp-Ed-ak6NoX_4Aeg_-1356753745")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? TradeDate { get; init; } 
    
    
    #nullable disable
    
}
