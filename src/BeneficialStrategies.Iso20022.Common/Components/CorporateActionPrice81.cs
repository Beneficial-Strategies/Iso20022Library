// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies prices related to a corporate action option.
/// </summary>
[IsoId("_p4btWzi7Eeydid5dcNPKvg")]
[DisplayName("Corporate Action Price")]
public partial record CorporateActionPrice81
{
    #nullable enable
    
    /// <summary>
    /// Cash disbursement in lieu of equities; usually in lieu of fractional quantity.
    /// </summary>
    [IsoId("_p4btXzi7Eeydid5dcNPKvg")]
    [DisplayName("Cash In Lieu Of Share Price")]
    [IsoXmlTag("CshInLieuOfShrPric")]
    public PriceFormat57Choice_? CashInLieuOfSharePrice { get; init; } 
    
    /// <summary>
    /// Amount of money required per over-subscribed equity as defined by the issuer.
    /// </summary>
    [IsoId("_p4btZzi7Eeydid5dcNPKvg")]
    [DisplayName("Over Subscription Deposit Price")]
    [IsoXmlTag("OverSbcptDpstPric")]
    public PriceFormat57Choice_? OverSubscriptionDepositPrice { get; init; } 
    
    /// <summary>
    /// Maximum cash amount that may be instructed.
    /// </summary>
    [IsoId("_p4btbzi7Eeydid5dcNPKvg")]
    [DisplayName("Maximum Cash To Instruct")]
    [IsoXmlTag("MaxCshToInst")]
    public PriceFormat62Choice_? MaximumCashToInstruct { get; init; } 
    
    /// <summary>
    /// Minimum cash amount that may be instructed.
    /// </summary>
    [IsoId("_p4btcTi7Eeydid5dcNPKvg")]
    [DisplayName("Minimum Cash To Instruct")]
    [IsoXmlTag("MinCshToInst")]
    public PriceFormat62Choice_? MinimumCashToInstruct { get; init; } 
    
    /// <summary>
    /// Minimum multiple of a cash amount that may be instructed.
    /// </summary>
    [IsoId("_p4btczi7Eeydid5dcNPKvg")]
    [DisplayName("Minimum Multiple Cash To Instruct")]
    [IsoXmlTag("MinMltplCshToInst")]
    public PriceFormat62Choice_? MinimumMultipleCashToInstruct { get; init; } 
    
    /// <summary>
    /// Maximum or cap price at which a holder can bid, for example, on a Dutch auction offer.
    /// </summary>
    [IsoId("_p4btdTi7Eeydid5dcNPKvg")]
    [DisplayName("Maximum Price")]
    [IsoXmlTag("MaxPric")]
    public PriceFormat59Choice_? MaximumPrice { get; init; } 
    
    /// <summary>
    /// Minimum or floor price at which a holder can bid, for example, on a Dutch auction offer.
    /// </summary>
    [IsoId("_p4btfTi7Eeydid5dcNPKvg")]
    [DisplayName("Minimum Price")]
    [IsoXmlTag("MinPric")]
    public PriceFormat59Choice_? MinimumPrice { get; init; } 
    
    /// <summary>
    /// First acceptable price after the Minimum Price at which a holder can bid, for example on a Dutch auction offer.
    /// </summary>
    [IsoId("_p4bthTi7Eeydid5dcNPKvg")]
    [DisplayName("First Bid Increment Price")]
    [IsoXmlTag("FrstBidIncrmtPric")]
    public PriceFormat59Choice_? FirstBidIncrementPrice { get; init; } 
    
    /// <summary>
    /// Last acceptable price before the Maximum Price at which a holder can bid, for example on a Dutch auction offer.
    /// </summary>
    [IsoId("_p4bthzi7Eeydid5dcNPKvg")]
    [DisplayName("Last Bid Increment Price")]
    [IsoXmlTag("LastBidIncrmtPric")]
    public PriceFormat59Choice_? LastBidIncrementPrice { get; init; } 
    
    
    #nullable disable
    
}
