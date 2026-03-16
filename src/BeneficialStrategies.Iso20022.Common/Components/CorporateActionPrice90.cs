// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action Price90.
/// </summary>
[IsoId("_j5RNIYV6Ee-oeNhl-Tk6YQ")]
[DisplayName("Corporate Action Price90")]
public partial record CorporateActionPrice90
{
    #nullable enable

    /// <summary>
    /// Cash In Lieu Of Share Price.
    /// </summary>
    [DisplayName("Cash In Lieu Of Share Price")]
    [IsoXmlTag("CshInLieuOfShrPric")]
    public PriceFormat81Choice_? CashInLieuOfSharePrice { get; init; } 

    /// <summary>
    /// First Bid Increment Price.
    /// </summary>
    [DisplayName("First Bid Increment Price")]
    [IsoXmlTag("FrstBidIncrmtPric")]
    public PriceFormat80Choice_? FirstBidIncrementPrice { get; init; } 

    /// <summary>
    /// Last Bid Increment Price.
    /// </summary>
    [DisplayName("Last Bid Increment Price")]
    [IsoXmlTag("LastBidIncrmtPric")]
    public PriceFormat80Choice_? LastBidIncrementPrice { get; init; } 

    /// <summary>
    /// Maximum Cash To Instruct.
    /// </summary>
    [DisplayName("Maximum Cash To Instruct")]
    [IsoXmlTag("MaxCshToInst")]
    public PriceFormat61Choice_? MaximumCashToInstruct { get; init; } 

    /// <summary>
    /// Maximum Price.
    /// </summary>
    [DisplayName("Maximum Price")]
    [IsoXmlTag("MaxPric")]
    public PriceFormat80Choice_? MaximumPrice { get; init; } 

    /// <summary>
    /// Minimum Cash To Instruct.
    /// </summary>
    [DisplayName("Minimum Cash To Instruct")]
    [IsoXmlTag("MinCshToInst")]
    public PriceFormat61Choice_? MinimumCashToInstruct { get; init; } 

    /// <summary>
    /// Minimum Multiple Cash To Instruct.
    /// </summary>
    [DisplayName("Minimum Multiple Cash To Instruct")]
    [IsoXmlTag("MinMltplCshToInst")]
    public PriceFormat61Choice_? MinimumMultipleCashToInstruct { get; init; } 

    /// <summary>
    /// Minimum Price.
    /// </summary>
    [DisplayName("Minimum Price")]
    [IsoXmlTag("MinPric")]
    public PriceFormat80Choice_? MinimumPrice { get; init; } 

    /// <summary>
    /// Over Subscription Deposit Price.
    /// </summary>
    [DisplayName("Over Subscription Deposit Price")]
    [IsoXmlTag("OverSbcptDpstPric")]
    public PriceFormat81Choice_? OverSubscriptionDepositPrice { get; init; } 

    
    #nullable disable
    
}
