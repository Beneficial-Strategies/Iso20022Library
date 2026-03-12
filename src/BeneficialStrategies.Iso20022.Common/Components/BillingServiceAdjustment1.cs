// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the billing adjustments for a specific service.
/// </summary>
[IsoId("_6Oww7pqlEeGSON8vddiWzQ_453454713")]
[DisplayName("Billing Service Adjustment")]
public partial record BillingServiceAdjustment1
{
    #nullable enable
    
    /// <summary>
    /// Identifies the type of adjustment.
    /// </summary>
    [IsoId("_6Oww75qlEeGSON8vddiWzQ_1574741940")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ServiceAdjustmentType1Code Type { get; init; } 
    
    /// <summary>
    /// Free-form description and clarification of the adjustment.
    /// </summary>
    [IsoId("_6O560JqlEeGSON8vddiWzQ_-1074957921")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public required IsoMax140Text Description { get; init; } 
    
    /// <summary>
    /// Amount of the adjustment, expressed in the settlement currency.||Usage: If the amount would reduce charges due then the amount should be negatively signed.
    /// </summary>
    [IsoId("_6O560ZqlEeGSON8vddiWzQ_463830521")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required AmountAndDirection34 Amount { get; init; } 
    
    /// <summary>
    /// Specifies whether the balance amount requires an adjustment.
    /// </summary>
    [IsoId("_6O560pqlEeGSON8vddiWzQ_661454739")]
    [DisplayName("Balance Required Amount")]
    [IsoXmlTag("BalReqrdAmt")]
    public AmountAndDirection34? BalanceRequiredAmount { get; init; } 
    
    /// <summary>
    /// Date on which the situation causing the service adjustment occurred. If the date is not known then used the last day of the month in which the situation occurred or the date of the billing statement which reported the original service to which this adjustment applies.
    /// </summary>
    [IsoId("_6O5605qlEeGSON8vddiWzQ_-241284094")]
    [DisplayName("Error Date")]
    [IsoXmlTag("ErrDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ErrorDate { get; init; } 
    
    /// <summary>
    /// Financial institution&apos;s own, internal service identification code, used to uniquely identify the service within the financial institution.
    /// </summary>
    [IsoId("_6O561JqlEeGSON8vddiWzQ_-823688632")]
    [DisplayName("Adjustment Identification")]
    [IsoXmlTag("AdjstmntId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AdjustmentIdentification { get; init; } 
    
    /// <summary>
    /// Defines the financial institution sub-service identification if the financial institution service identification code is used for more than one service.
    /// </summary>
    [IsoId("_6O561ZqlEeGSON8vddiWzQ_821578803")]
    [DisplayName("Sub Service")]
    [IsoXmlTag("SubSvc")]
    public BillingSubServiceIdentification1? SubService { get; init; } 
    
    /// <summary>
    /// Change in the service price, expressed in the pricing currency. A negative value indicates a price reduction.
    /// </summary>
    [IsoId("_6O561pqlEeGSON8vddiWzQ_-1934600051")]
    [DisplayName("Price Change")]
    [IsoXmlTag("PricChng")]
    public AmountAndDirection34? PriceChange { get; init; } 
    
    /// <summary>
    /// Price that was applied to the service, prior to the change, expressed in the pricing currency.
    /// </summary>
    [IsoId("_6O5615qlEeGSON8vddiWzQ_1655252630")]
    [DisplayName("Original Price")]
    [IsoXmlTag("OrgnlPric")]
    public AmountAndDirection34? OriginalPrice { get; init; } 
    
    /// <summary>
    /// New, adjusted service price, expressed in the pricing currency.
    /// </summary>
    [IsoId("_6O562JqlEeGSON8vddiWzQ_480061605")]
    [DisplayName("New Price")]
    [IsoXmlTag("NewPric")]
    public AmountAndDirection34? NewPrice { get; init; } 
    
    /// <summary>
    /// Change in the service volume. A negative value indicates a volume reduction.
    /// </summary>
    [IsoId("_6PDr0JqlEeGSON8vddiWzQ_2125329040")]
    [DisplayName("Volume Change")]
    [IsoXmlTag("VolChng")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? VolumeChange { get; init; } 
    
    /// <summary>
    /// Original service volume.
    /// </summary>
    [IsoId("_6PDr0ZqlEeGSON8vddiWzQ_-1006641385")]
    [DisplayName("Original Volume")]
    [IsoXmlTag("OrgnlVol")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? OriginalVolume { get; init; } 
    
    /// <summary>
    /// New, adjusted service volume.
    /// </summary>
    [IsoId("_6PDr0pqlEeGSON8vddiWzQ_-630849814")]
    [DisplayName("New Volume")]
    [IsoXmlTag("NewVol")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? NewVolume { get; init; } 
    
    /// <summary>
    /// Service charge that was applied to the service, prior to the change, expressed in the pricing currency.
    /// </summary>
    [IsoId("_6PDr05qlEeGSON8vddiWzQ_-1335964429")]
    [DisplayName("Original Charge Amount")]
    [IsoXmlTag("OrgnlChrgAmt")]
    public AmountAndDirection34? OriginalChargeAmount { get; init; } 
    
    /// <summary>
    /// New, adjusted service charge, expressed in the pricing currency.
    /// </summary>
    [IsoId("_6PDr1JqlEeGSON8vddiWzQ_1783811842")]
    [DisplayName("New Charge Amount")]
    [IsoXmlTag("NewChrgAmt")]
    public AmountAndDirection34? NewChargeAmount { get; init; } 
    
    
    #nullable disable
    
}
