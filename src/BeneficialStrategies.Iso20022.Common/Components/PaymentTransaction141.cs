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
/// Payment transaction invoiced to customer.
/// </summary>
[IsoId("_RHVJkSCBEey8XKHwKquEQw")]
[DisplayName("Payment Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentTransaction141
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// List of codes representing type of fleet purchases.
    /// </summary>
    [IsoId("_RMU-USCBEey8XKHwKquEQw")]
    [DisplayName("Purchase Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PurchsTp")]
    #endif
    [IsoXmlTag("PurchsTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FleetPurchaseType1Code? PurchaseType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FleetPurchaseType1Code? PurchaseType { get; init; } 
    #else
    public FleetPurchaseType1Code? PurchaseType { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the identifier assigned by the card acceptor that best categorizes the items being purchased in a standardized commodity group.
    /// </summary>
    [IsoId("_RMU-UyCBEey8XKHwKquEQw")]
    [DisplayName("Summary Commodity Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SummryCmmdtyId")]
    #endif
    [IsoXmlTag("SummryCmmdtyId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SummaryCommodityIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SummaryCommodityIdentification { get; init; } 
    #else
    public System.String? SummaryCommodityIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Discount applied to the transaction.
    /// </summary>
    [IsoId("_RMU-VSCBEey8XKHwKquEQw")]
    [DisplayName("Discount Total")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DscntTtl")]
    #endif
    [IsoXmlTag("DscntTtl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FleetDiscountTotals1? DiscountTotal { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FleetDiscountTotals1? DiscountTotal { get; init; } 
    #else
    public FleetDiscountTotals1? DiscountTotal { get; set; } 
    #endif
    
    /// <summary>
    /// Total taxes related to the products or services. 
    /// </summary>
    [IsoId("_RMU-VyCBEey8XKHwKquEQw")]
    [DisplayName("Tax Total")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxTtl")]
    #endif
    [IsoXmlTag("TaxTtl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Tax39? TaxTotal { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Tax39? TaxTotal { get; init; } 
    #else
    public Tax39? TaxTotal { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of the transaction, inclusive of all applicable taxes and fees. 
    /// </summary>
    [IsoId("_RMU-WSCBEey8XKHwKquEQw")]
    [DisplayName("Total Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlAmt")]
    #endif
    [IsoXmlTag("TtlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? TotalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? TotalAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? TotalAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
