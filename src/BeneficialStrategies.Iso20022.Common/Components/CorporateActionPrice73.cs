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
[IsoId("_MnttAxbUEeyroI8qKgB7Mg")]
[DisplayName("Corporate Action Price")]
public partial record CorporateActionPrice73
{
    #nullable enable
    
    /// <summary>
    /// Cash disbursement in lieu of equities; usually in lieu of fractional quantity.
    /// </summary>
    [IsoId("_M9B04xbUEeyroI8qKgB7Mg")]
    [DisplayName("Cash In Lieu Of Share Price")]
    [IsoXmlTag("CshInLieuOfShrPric")]
    public PriceFormat45Choice_? CashInLieuOfSharePrice { get; init; } 
    
    /// <summary>
    /// Amount of money required per over-subscribed equity as defined by the issuer.
    /// </summary>
    [IsoId("_M9B06xbUEeyroI8qKgB7Mg")]
    [DisplayName("Over Subscription Deposit Price")]
    [IsoXmlTag("OverSbcptDpstPric")]
    public PriceFormat45Choice_? OverSubscriptionDepositPrice { get; init; } 
    
    /// <summary>
    /// Maximum cash amount that may be instructed.
    /// </summary>
    [IsoId("_M9B08xbUEeyroI8qKgB7Mg")]
    [DisplayName("Maximum Cash To Instruct")]
    [IsoXmlTag("MaxCshToInst")]
    public PriceFormat61Choice_? MaximumCashToInstruct { get; init; } 
    
    /// <summary>
    /// Minimum cash amount that may be instructed.
    /// </summary>
    [IsoId("_M9B09RbUEeyroI8qKgB7Mg")]
    [DisplayName("Minimum Cash To Instruct")]
    [IsoXmlTag("MinCshToInst")]
    public PriceFormat61Choice_? MinimumCashToInstruct { get; init; } 
    
    /// <summary>
    /// Minimum multiple of a cash amount that may be instructed.
    /// </summary>
    [IsoId("_M9B09xbUEeyroI8qKgB7Mg")]
    [DisplayName("Minimum Multiple Cash To Instruct")]
    [IsoXmlTag("MinMltplCshToInst")]
    public PriceFormat61Choice_? MinimumMultipleCashToInstruct { get; init; } 
    
    /// <summary>
    /// Maximum or cap price at which a holder can bid, for example, on a Dutch auction offer.
    /// </summary>
    [IsoId("_M9B0-RbUEeyroI8qKgB7Mg")]
    [DisplayName("Maximum Price")]
    [IsoXmlTag("MaxPric")]
    public PriceFormat44Choice_? MaximumPrice { get; init; } 
    
    /// <summary>
    /// Minimum or floor price at which a holder can bid, for example, on a Dutch auction offer.
    /// </summary>
    [IsoId("_M9B1ARbUEeyroI8qKgB7Mg")]
    [DisplayName("Minimum Price")]
    [IsoXmlTag("MinPric")]
    public PriceFormat44Choice_? MinimumPrice { get; init; } 
    
    /// <summary>
    /// First acceptable price after the Minimum Price at which a holder can bid, for example on a Dutch auction offer.
    /// </summary>
    [IsoId("_LCYtIhbUEeyroI8qKgB7Mg")]
    [DisplayName("First Bid Increment Price")]
    [IsoXmlTag("FrstBidIncrmtPric")]
    public PriceFormat44Choice_? FirstBidIncrementPrice { get; init; } 
    
    /// <summary>
    /// Last acceptable price before the Maximum Price at which a holder can bid, for example on a Dutch auction offer.
    /// </summary>
    [IsoId("_LCYtIxbUEeyroI8qKgB7Mg")]
    [DisplayName("Last Bid Increment Price")]
    [IsoXmlTag("LastBidIncrmtPric")]
    public PriceFormat44Choice_? LastBidIncrementPrice { get; init; } 
    
    
    #nullable disable
    
}
