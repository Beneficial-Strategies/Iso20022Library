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
/// Data related to the Loyalty Transaction.
/// </summary>
[IsoId("_2XlUkNuJEeiB5uLfkg9ZJA")]
[DisplayName("Loyalty Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LoyaltyTransaction1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a LoyaltyTransaction1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public LoyaltyTransaction1( LoyaltyTransactionType1Code reqLoyaltyTransactionType )
    {
        LoyaltyTransactionType = reqLoyaltyTransactionType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Data related to the loyalty transaction.
    /// </summary>
    [IsoId("_90WysNuKEeiB5uLfkg9ZJA")]
    [DisplayName("Loyalty Transaction Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LltyTxTp")]
    #endif
    [IsoXmlTag("LltyTxTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required LoyaltyTransactionType1Code LoyaltyTransactionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required LoyaltyTransactionType1Code LoyaltyTransactionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LoyaltyTransactionType1Code LoyaltyTransactionType { get; init; } 
    #else
    public LoyaltyTransactionType1Code LoyaltyTransactionType { get; set; } 
    #endif
    
    /// <summary>
    /// Currency of the loyalty transaction.
    /// </summary>
    [IsoId("_BJlpINuLEeiB5uLfkg9ZJA")]
    [DisplayName("Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ccy")]
    #endif
    [IsoXmlTag("Ccy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Currency { get; init; } 
    #else
    public string? Currency { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the payment transaction related to the Loyalty.
    /// </summary>
    [IsoId("_EIBwMNuLEeiB5uLfkg9ZJA")]
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
    
    /// <summary>
    /// Data of a previous POI payment transaction.
    /// </summary>
    [IsoId("_IQTNINuLEeiB5uLfkg9ZJA")]
    [DisplayName("Original POI Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlPOITx")]
    #endif
    [IsoXmlTag("OrgnlPOITx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardPaymentTransaction91? OriginalPOITransaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentTransaction91? OriginalPOITransaction { get; init; } 
    #else
    public CardPaymentTransaction91? OriginalPOITransaction { get; set; } 
    #endif
    
    /// <summary>
    /// Item purchased with the transaction.
    /// </summary>
    [IsoId("_OynqoNuLEeiB5uLfkg9ZJA")]
    [DisplayName("Sale Item")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SaleItm")]
    #endif
    [IsoXmlTag("SaleItm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Product6? SaleItem { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Product6? SaleItem { get; init; } 
    #else
    public Product6? SaleItem { get; set; } 
    #endif
    
    
    #nullable disable
    
}
