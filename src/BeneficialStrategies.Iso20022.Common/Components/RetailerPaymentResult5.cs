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
/// Payment Data Results.
/// </summary>
[IsoId("_ty9jwXG8Ee2TbaNWBpRZpQ")]
[DisplayName("Retailer Payment Result")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RetailerPaymentResult5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RetailerPaymentResult5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RetailerPaymentResult5( CardPaymentServiceType12Code reqTransactionType )
    {
        TransactionType = reqTransactionType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of payment transaction.
    /// </summary>
    [IsoId("_t54rIXG8Ee2TbaNWBpRZpQ")]
    [DisplayName("Transaction Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxTp")]
    #endif
    [IsoXmlTag("TxTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardPaymentServiceType12Code TransactionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CardPaymentServiceType12Code TransactionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentServiceType12Code TransactionType { get; init; } 
    #else
    public CardPaymentServiceType12Code TransactionType { get; set; } 
    #endif
    
    /// <summary>
    /// Service provided by the card payment transaction, in addition to the main service.
    /// </summary>
    [IsoId("_t54rI3G8Ee2TbaNWBpRZpQ")]
    [DisplayName("Additional Service")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlSvc")]
    #endif
    [IsoXmlTag("AddtlSvc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardPaymentServiceType9Code? AdditionalService { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentServiceType9Code? AdditionalService { get; init; } 
    #else
    public CardPaymentServiceType9Code? AdditionalService { get; set; } 
    #endif
    
    /// <summary>
    /// Additional attribute of the service type.
    /// </summary>
    [IsoId("_t54rJXG8Ee2TbaNWBpRZpQ")]
    [DisplayName("Service Attribute")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcAttr")]
    #endif
    [IsoXmlTag("SvcAttr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardPaymentServiceType14Code? ServiceAttribute { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentServiceType14Code? ServiceAttribute { get; init; } 
    #else
    public CardPaymentServiceType14Code? ServiceAttribute { get; set; } 
    #endif
    
    /// <summary>
    /// Data associated with the Transaction.
    /// </summary>
    [IsoId("_t54rJ3G8Ee2TbaNWBpRZpQ")]
    [DisplayName("Requested Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdTx")]
    #endif
    [IsoXmlTag("ReqdTx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardPaymentTransaction127? RequestedTransaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentTransaction127? RequestedTransaction { get; init; } 
    #else
    public CardPaymentTransaction127? RequestedTransaction { get; set; } 
    #endif
    
    /// <summary>
    /// Result of the transaction processing.
    /// </summary>
    [IsoId("_t54rKXG8Ee2TbaNWBpRZpQ")]
    [DisplayName("Transaction Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxRspn")]
    #endif
    [IsoXmlTag("TxRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardPaymentTransaction128? TransactionResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentTransaction128? TransactionResponse { get; init; } 
    #else
    public CardPaymentTransaction128? TransactionResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Customer order attached to a customer, recorded in the POI system.
    /// </summary>
    [IsoId("_t54rK3G8Ee2TbaNWBpRZpQ")]
    [DisplayName("Customer Order")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CstmrOrdr")]
    #endif
    [IsoXmlTag("CstmrOrdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CustomerOrder1? CustomerOrder { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CustomerOrder1? CustomerOrder { get; init; } 
    #else
    public CustomerOrder1? CustomerOrder { get; set; } 
    #endif
    
    /// <summary>
    /// Numeric value of a handwritten signature.
    /// </summary>
    [IsoId("_t54rLXG8Ee2TbaNWBpRZpQ")]
    [DisplayName("Image Captured Signature")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ImgCaptrdSgntr")]
    #endif
    [IsoXmlTag("ImgCaptrdSgntr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CapturedSignature1? ImageCapturedSignature { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CapturedSignature1? ImageCapturedSignature { get; init; } 
    #else
    public CapturedSignature1? ImageCapturedSignature { get; set; } 
    #endif
    
    /// <summary>
    /// Protected value of a handwritten signature.
    /// </summary>
    [IsoId("_t54rL3G8Ee2TbaNWBpRZpQ")]
    [DisplayName("Protected Captured Signature")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctdCaptrdSgntr")]
    #endif
    [IsoXmlTag("PrtctdCaptrdSgntr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType35? ProtectedCapturedSignature { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType35? ProtectedCapturedSignature { get; init; } 
    #else
    public ContentInformationType35? ProtectedCapturedSignature { get; set; } 
    #endif
    
    /// <summary>
    /// Indicate that the Merchant forced the result of the payment to successful.
    /// </summary>
    [IsoId("_t54rMXG8Ee2TbaNWBpRZpQ")]
    [DisplayName("Merchant Override Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrchntOvrrdFlg")]
    #endif
    [IsoXmlTag("MrchntOvrrdFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? MerchantOverrideFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MerchantOverrideFlag { get; init; } 
    #else
    public System.String? MerchantOverrideFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Language used to display messages to the customer.
    /// </summary>
    [IsoId("_t54rM3G8Ee2TbaNWBpRZpQ")]
    [DisplayName("Customer Language")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CstmrLang")]
    #endif
    [IsoXmlTag("CstmrLang")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LanguageCode? CustomerLanguage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? CustomerLanguage { get; init; } 
    #else
    public string? CustomerLanguage { get; set; } 
    #endif
    
    /// <summary>
    /// Indicate that the payment transaction processing has required the approval of an acquirer.
    /// </summary>
    [IsoId("_t54rNXG8Ee2TbaNWBpRZpQ")]
    [DisplayName("Online Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OnlnFlg")]
    #endif
    [IsoXmlTag("OnlnFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? OnlineFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OnlineFlag { get; init; } 
    #else
    public System.String? OnlineFlag { get; set; } 
    #endif
    
    
    #nullable disable
    
}
