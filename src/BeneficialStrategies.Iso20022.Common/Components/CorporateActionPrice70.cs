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
/// Specifies prices related to a corporate action option.
/// </summary>
[IsoId("_eQMS0e3LEeqc-LCjwLsUVg")]
[DisplayName("Corporate Action Price")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionPrice70
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Cash disbursement in lieu of equities; usually in lieu of fractional quantity.
    /// </summary>
    [IsoId("_ej1Ag-3LEeqc-LCjwLsUVg")]
    [DisplayName("Cash In Lieu Of Share Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshInLieuOfShrPric")]
    #endif
    [IsoXmlTag("CshInLieuOfShrPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceFormat45Choice_? CashInLieuOfSharePrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceFormat45Choice_? CashInLieuOfSharePrice { get; init; } 
    #else
    public PriceFormat45Choice_? CashInLieuOfSharePrice { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money required per over-subscribed equity as defined by the issuer.
    /// </summary>
    [IsoId("_ej1Ai-3LEeqc-LCjwLsUVg")]
    [DisplayName("Over Subscription Deposit Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OverSbcptDpstPric")]
    #endif
    [IsoXmlTag("OverSbcptDpstPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceFormat45Choice_? OverSubscriptionDepositPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceFormat45Choice_? OverSubscriptionDepositPrice { get; init; } 
    #else
    public PriceFormat45Choice_? OverSubscriptionDepositPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum cash amount that may be instructed.
    /// </summary>
    [IsoId("_ej1Ak-3LEeqc-LCjwLsUVg")]
    [DisplayName("Maximum Cash To Instruct")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MaxCshToInst")]
    #endif
    [IsoXmlTag("MaxCshToInst")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceFormat61Choice_? MaximumCashToInstruct { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceFormat61Choice_? MaximumCashToInstruct { get; init; } 
    #else
    public PriceFormat61Choice_? MaximumCashToInstruct { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum cash amount that may be instructed.
    /// </summary>
    [IsoId("_ej1Ale3LEeqc-LCjwLsUVg")]
    [DisplayName("Minimum Cash To Instruct")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinCshToInst")]
    #endif
    [IsoXmlTag("MinCshToInst")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceFormat61Choice_? MinimumCashToInstruct { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceFormat61Choice_? MinimumCashToInstruct { get; init; } 
    #else
    public PriceFormat61Choice_? MinimumCashToInstruct { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum multiple of a cash amount that may be instructed.
    /// </summary>
    [IsoId("_ej1Al-3LEeqc-LCjwLsUVg")]
    [DisplayName("Minimum Multiple Cash To Instruct")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinMltplCshToInst")]
    #endif
    [IsoXmlTag("MinMltplCshToInst")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceFormat61Choice_? MinimumMultipleCashToInstruct { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceFormat61Choice_? MinimumMultipleCashToInstruct { get; init; } 
    #else
    public PriceFormat61Choice_? MinimumMultipleCashToInstruct { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum or cap price at which a holder can bid, for example, on a Dutch auction offer.
    /// </summary>
    [IsoId("_ZtBCmO3LEeqc-LCjwLsUVg")]
    [DisplayName("Maximum Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MaxPric")]
    #endif
    [IsoXmlTag("MaxPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceFormat44Choice_? MaximumPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceFormat44Choice_? MaximumPrice { get; init; } 
    #else
    public PriceFormat44Choice_? MaximumPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum or floor price at which a holder can bid, for example, on a Dutch auction offer.
    /// </summary>
    [IsoId("_ZtBCme3LEeqc-LCjwLsUVg")]
    [DisplayName("Minimum Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinPric")]
    #endif
    [IsoXmlTag("MinPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceFormat44Choice_? MinimumPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceFormat44Choice_? MinimumPrice { get; init; } 
    #else
    public PriceFormat44Choice_? MinimumPrice { get; set; } 
    #endif
    
    
    #nullable disable
    
}
