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
/// Details of the transaction in the authorisation request.
/// </summary>
[IsoId("_Y-phEPwLEeGHDMP28rpT3g_1109146762")]
[DisplayName("Card Payment Transaction Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardPaymentTransactionDetails8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Amounts associated with the total amount of transaction.
    /// </summary>
    [IsoId("_Y-phEfwLEeGHDMP28rpT3g_-629455657")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardAmountAndCurrencyExchange1? Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardAmountAndCurrencyExchange1? Amount { get; init; } 
    #else
    public CardAmountAndCurrencyExchange1? Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Data related to an integrated circuit card application.
    /// </summary>
    [IsoId("_Y-phEvwLEeGHDMP28rpT3g_-739980496")]
    [DisplayName("ICC Related Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ICCRltdData")]
    #endif
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax1025Text? ICCRelatedData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ICCRelatedData { get; init; } 
    #else
    public System.String? ICCRelatedData { get; set; } 
    #endif
    
    /// <summary>
    /// Context of the card payment transaction.
    /// </summary>
    [IsoId("_Y-phE_wLEeGHDMP28rpT3g_385046417")]
    [DisplayName("Payment Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtCntxt")]
    #endif
    [IsoXmlTag("PmtCntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentContext3? PaymentContext { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentContext3? PaymentContext { get; init; } 
    #else
    public PaymentContext3? PaymentContext { get; set; } 
    #endif
    
    /// <summary>
    /// Category code conform to ISO 18245, related to the type of services or goods the merchant provides for the transaction.
    /// </summary>
    [IsoId("_Y-yrAPwLEeGHDMP28rpT3g_-832794042")]
    [DisplayName("Merchant Category Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrchntCtgyCd")]
    #endif
    [IsoXmlTag("MrchntCtgyCd")]
    [IsoSimpleType(IsoSimpleType.Min3Max4Text)]
    [StringLength(maximumLength: 4 ,MinimumLength = 3)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMin3Max4Text? MerchantCategoryCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MerchantCategoryCode { get; init; } 
    #else
    public System.String? MerchantCategoryCode { get; set; } 
    #endif
    
    /// <summary>
    /// Local date and time of the transaction assigned by the POI (Point Of Interaction).
    /// </summary>
    [IsoId("_Y-yrAfwLEeGHDMP28rpT3g_990760651")]
    [DisplayName("Transaction Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxDtTm")]
    #endif
    [IsoXmlTag("TxDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? TransactionDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? TransactionDateTime { get; init; } 
    #else
    public System.DateTime? TransactionDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a sale transaction assigned by the sale system.
    /// </summary>
    [IsoId("_Y-yrAvwLEeGHDMP28rpT3g_183251499")]
    [DisplayName("Sale Reference Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SaleRefNb")]
    #endif
    [IsoXmlTag("SaleRefNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SaleReferenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SaleReferenceNumber { get; init; } 
    #else
    public System.String? SaleReferenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Reason for representment of a card transaction.
    /// </summary>
    [IsoId("_Y-yrA_wLEeGHDMP28rpT3g_-373585340")]
    [DisplayName("Re Presentment Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RePresntmntRsn")]
    #endif
    [IsoXmlTag("RePresntmntRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExternalRePresentmentReason1Code? RePresentmentReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalRePresentmentReason1Code? RePresentmentReason { get; init; } 
    #else
    public ExternalRePresentmentReason1Code? RePresentmentReason { get; set; } 
    #endif
    
    /// <summary>
    /// Service in addition to the main service.
    /// </summary>
    [IsoId("_Y-yrBPwLEeGHDMP28rpT3g_-1801982595")]
    [DisplayName("Additional Service")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlSvc")]
    #endif
    [IsoXmlTag("AddtlSvc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardPaymentServiceType2Code? AdditionalService { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentServiceType2Code? AdditionalService { get; init; } 
    #else
    public CardPaymentServiceType2Code? AdditionalService { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the transaction that has to be unique for a time period.
    /// </summary>
    [IsoId("_Y-8cAPwLEeGHDMP28rpT3g_-454629875")]
    [DisplayName("Transaction Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxRef")]
    #endif
    [IsoXmlTag("TxRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TransactionReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TransactionReference { get; init; } 
    #else
    public System.String? TransactionReference { get; set; } 
    #endif
    
    
    #nullable disable
    
}
