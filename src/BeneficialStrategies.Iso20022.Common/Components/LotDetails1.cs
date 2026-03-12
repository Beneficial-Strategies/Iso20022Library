// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Facilitates the redemption of one or more lots.
/// </summary>
[IsoId("_Sd15cNp-Ed-ak6NoX_4Aeg_-767969447")]
[DisplayName("Lot Details")]
public partial record LotDetails1
{
    #nullable enable
    
    /// <summary>
    /// Description of the lot.
    /// </summary>
    [IsoId("_Sd15cdp-Ed-ak6NoX_4Aeg_186028060")]
    [DisplayName("Lot Description")]
    [IsoXmlTag("LotDesc")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? LotDescription { get; init; } 
    
    /// <summary>
    /// Date the units were created.
    /// </summary>
    [IsoId("_Sd15ctp-Ed-ak6NoX_4Aeg_-1080360479")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate TradeDate { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identifier of the original order that resulted in the lot.
    /// </summary>
    [IsoId("_Sd15c9p-Ed-ak6NoX_4Aeg_1722044927")]
    [DisplayName("Order Reference")]
    [IsoXmlTag("OrdrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text OrderReference { get; init; } 
    
    /// <summary>
    /// Deal reference of the original subscription execution that resulted in the lot.
    /// </summary>
    [IsoId("_Sd15dNp-Ed-ak6NoX_4Aeg_658630436")]
    [DisplayName("Deal Reference")]
    [IsoXmlTag("DealRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? DealReference { get; init; } 
    
    /// <summary>
    /// Quantity of the lot.
    /// </summary>
    [IsoId("_Sd15ddp-Ed-ak6NoX_4Aeg_-1763708618")]
    [DisplayName("Lot Quantity And Amount")]
    [IsoXmlTag("LotQtyAndAmt")]
    public SidePocketQuantityAndAmount1? LotQuantityAndAmount { get; init; } 
    
    
    #nullable disable
    
}
