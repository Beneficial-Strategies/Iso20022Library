// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the billing adjustments for a specific service.
/// </summary>
[IsoId("_6Oww7pqlEeGSON8vddiWzQ_453454713")]
[DisplayName("Billing Service Adjustment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BillingServiceAdjustment1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BillingServiceAdjustment1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BillingServiceAdjustment1( ServiceAdjustmentType1Code reqType,System.String reqDescription,AmountAndDirection34 reqAmount )
    {
        Type = reqType;
        Description = reqDescription;
        Amount = reqAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the type of adjustment.
    /// </summary>
    [IsoId("_6Oww75qlEeGSON8vddiWzQ_1574741940")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ServiceAdjustmentType1Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ServiceAdjustmentType1Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ServiceAdjustmentType1Code Type { get; init; } 
    #else
    public ServiceAdjustmentType1Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Free-form description and clarification of the adjustment.
    /// </summary>
    [IsoId("_6O560JqlEeGSON8vddiWzQ_-1074957921")]
    [DisplayName("Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Desc")]
    #endif
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax140Text Description { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Description { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Description { get; init; } 
    #else
    public System.String Description { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the adjustment, expressed in the settlement currency.||Usage: If the amount would reduce charges due then the amount should be negatively signed.
    /// </summary>
    [IsoId("_6O560ZqlEeGSON8vddiWzQ_463830521")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndDirection34 Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndDirection34 Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection34 Amount { get; init; } 
    #else
    public AmountAndDirection34 Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the balance amount requires an adjustment.
    /// </summary>
    [IsoId("_6O560pqlEeGSON8vddiWzQ_661454739")]
    [DisplayName("Balance Required Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BalReqrdAmt")]
    #endif
    [IsoXmlTag("BalReqrdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection34? BalanceRequiredAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection34? BalanceRequiredAmount { get; init; } 
    #else
    public AmountAndDirection34? BalanceRequiredAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the situation causing the service adjustment occurred. If the date is not known then used the last day of the month in which the situation occurred or the date of the billing statement which reported the original service to which this adjustment applies.
    /// </summary>
    [IsoId("_6O5605qlEeGSON8vddiWzQ_-241284094")]
    [DisplayName("Error Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ErrDt")]
    #endif
    [IsoXmlTag("ErrDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ErrorDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ErrorDate { get; init; } 
    #else
    public System.DateOnly? ErrorDate { get; set; } 
    #endif
    
    /// <summary>
    /// Financial institution&apos;s own, internal service identification code, used to uniquely identify the service within the financial institution.
    /// </summary>
    [IsoId("_6O561JqlEeGSON8vddiWzQ_-823688632")]
    [DisplayName("Adjustment Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AdjstmntId")]
    #endif
    [IsoXmlTag("AdjstmntId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AdjustmentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdjustmentIdentification { get; init; } 
    #else
    public System.String? AdjustmentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the financial institution sub-service identification if the financial institution service identification code is used for more than one service.
    /// </summary>
    [IsoId("_6O561ZqlEeGSON8vddiWzQ_821578803")]
    [DisplayName("Sub Service")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubSvc")]
    #endif
    [IsoXmlTag("SubSvc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BillingSubServiceIdentification1? SubService { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BillingSubServiceIdentification1? SubService { get; init; } 
    #else
    public BillingSubServiceIdentification1? SubService { get; set; } 
    #endif
    
    /// <summary>
    /// Change in the service price, expressed in the pricing currency. A negative value indicates a price reduction.
    /// </summary>
    [IsoId("_6O561pqlEeGSON8vddiWzQ_-1934600051")]
    [DisplayName("Price Change")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricChng")]
    #endif
    [IsoXmlTag("PricChng")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection34? PriceChange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection34? PriceChange { get; init; } 
    #else
    public AmountAndDirection34? PriceChange { get; set; } 
    #endif
    
    /// <summary>
    /// Price that was applied to the service, prior to the change, expressed in the pricing currency.
    /// </summary>
    [IsoId("_6O5615qlEeGSON8vddiWzQ_1655252630")]
    [DisplayName("Original Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlPric")]
    #endif
    [IsoXmlTag("OrgnlPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection34? OriginalPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection34? OriginalPrice { get; init; } 
    #else
    public AmountAndDirection34? OriginalPrice { get; set; } 
    #endif
    
    /// <summary>
    /// New, adjusted service price, expressed in the pricing currency.
    /// </summary>
    [IsoId("_6O562JqlEeGSON8vddiWzQ_480061605")]
    [DisplayName("New Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewPric")]
    #endif
    [IsoXmlTag("NewPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection34? NewPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection34? NewPrice { get; init; } 
    #else
    public AmountAndDirection34? NewPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Change in the service volume. A negative value indicates a volume reduction.
    /// </summary>
    [IsoId("_6PDr0JqlEeGSON8vddiWzQ_2125329040")]
    [DisplayName("Volume Change")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VolChng")]
    #endif
    [IsoXmlTag("VolChng")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? VolumeChange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? VolumeChange { get; init; } 
    #else
    public System.UInt64? VolumeChange { get; set; } 
    #endif
    
    /// <summary>
    /// Original service volume.
    /// </summary>
    [IsoId("_6PDr0ZqlEeGSON8vddiWzQ_-1006641385")]
    [DisplayName("Original Volume")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlVol")]
    #endif
    [IsoXmlTag("OrgnlVol")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? OriginalVolume { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? OriginalVolume { get; init; } 
    #else
    public System.UInt64? OriginalVolume { get; set; } 
    #endif
    
    /// <summary>
    /// New, adjusted service volume.
    /// </summary>
    [IsoId("_6PDr0pqlEeGSON8vddiWzQ_-630849814")]
    [DisplayName("New Volume")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewVol")]
    #endif
    [IsoXmlTag("NewVol")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? NewVolume { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? NewVolume { get; init; } 
    #else
    public System.UInt64? NewVolume { get; set; } 
    #endif
    
    /// <summary>
    /// Service charge that was applied to the service, prior to the change, expressed in the pricing currency.
    /// </summary>
    [IsoId("_6PDr05qlEeGSON8vddiWzQ_-1335964429")]
    [DisplayName("Original Charge Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlChrgAmt")]
    #endif
    [IsoXmlTag("OrgnlChrgAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection34? OriginalChargeAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection34? OriginalChargeAmount { get; init; } 
    #else
    public AmountAndDirection34? OriginalChargeAmount { get; set; } 
    #endif
    
    /// <summary>
    /// New, adjusted service charge, expressed in the pricing currency.
    /// </summary>
    [IsoId("_6PDr1JqlEeGSON8vddiWzQ_1783811842")]
    [DisplayName("New Charge Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewChrgAmt")]
    #endif
    [IsoXmlTag("NewChrgAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection34? NewChargeAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection34? NewChargeAmount { get; init; } 
    #else
    public AmountAndDirection34? NewChargeAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
