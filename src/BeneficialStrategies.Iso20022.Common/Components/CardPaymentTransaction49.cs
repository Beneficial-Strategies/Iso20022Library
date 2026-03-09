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
/// Data associated with the transaction for a potential currency conversion.
/// </summary>
[IsoId("_QnPcwWpDEeS4VPLpYyQgxQ")]
[DisplayName("Card Payment Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardPaymentTransaction49
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardPaymentTransaction49 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardPaymentTransaction49( System.String reqTransactionCapture,CardPaymentServiceType5Code reqTransactionType,System.String reqMerchantCategoryCode,TransactionIdentifier1 reqTransactionIdentification,CardPaymentTransactionDetails26 reqTransactionDetails )
    {
        TransactionCapture = reqTransactionCapture;
        TransactionType = reqTransactionType;
        MerchantCategoryCode = reqMerchantCategoryCode;
        TransactionIdentification = reqTransactionIdentification;
        TransactionDetails = reqTransactionDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Flag indicating whether the transaction data must be captured or not in addition to the message process.
    /// </summary>
    [IsoId("_QznE0WpDEeS4VPLpYyQgxQ")]
    [DisplayName("Transaction Capture")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxCaptr")]
    #endif
    [IsoXmlTag("TxCaptr")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoTrueFalseIndicator TransactionCapture { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TransactionCapture { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TransactionCapture { get; init; } 
    #else
    public System.String TransactionCapture { get; set; } 
    #endif
    
    /// <summary>
    /// Type of transaction being undertaken for the main service.
    /// </summary>
    [IsoId("_QznE02pDEeS4VPLpYyQgxQ")]
    [DisplayName("Transaction Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxTp")]
    #endif
    [IsoXmlTag("TxTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardPaymentServiceType5Code TransactionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CardPaymentServiceType5Code TransactionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentServiceType5Code TransactionType { get; init; } 
    #else
    public CardPaymentServiceType5Code TransactionType { get; set; } 
    #endif
    
    /// <summary>
    /// Service in addition to the main service.
    /// </summary>
    [IsoId("_QznE1WpDEeS4VPLpYyQgxQ")]
    [DisplayName("Additional Service")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlSvc")]
    #endif
    [IsoXmlTag("AddtlSvc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardPaymentServiceType6Code? AdditionalService { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentServiceType6Code? AdditionalService { get; init; } 
    #else
    public CardPaymentServiceType6Code? AdditionalService { get; set; } 
    #endif
    
    /// <summary>
    /// Additional attribute of the service type.
    /// </summary>
    [IsoId("_QznE12pDEeS4VPLpYyQgxQ")]
    [DisplayName("Service Attribute")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcAttr")]
    #endif
    [IsoXmlTag("SvcAttr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardPaymentServiceType3Code? ServiceAttribute { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentServiceType3Code? ServiceAttribute { get; init; } 
    #else
    public CardPaymentServiceType3Code? ServiceAttribute { get; set; } 
    #endif
    
    /// <summary>
    /// Category code conform to ISO 18245, related to the type of services or goods the merchant provides for the transaction.
    /// </summary>
    [IsoId("_QznE2WpDEeS4VPLpYyQgxQ")]
    [DisplayName("Merchant Category Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrchntCtgyCd")]
    #endif
    [IsoXmlTag("MrchntCtgyCd")]
    [IsoSimpleType(IsoSimpleType.Min3Max4Text)]
    [StringLength(maximumLength: 4 ,MinimumLength = 3)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMin3Max4Text MerchantCategoryCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String MerchantCategoryCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String MerchantCategoryCode { get; init; } 
    #else
    public System.String MerchantCategoryCode { get; set; } 
    #endif
    
    /// <summary>
    /// Global reference of the sale transaction for the sale system.
    /// </summary>
    [IsoId("_QznE22pDEeS4VPLpYyQgxQ")]
    [DisplayName("Sale Reference Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SaleRefId")]
    #endif
    [IsoXmlTag("SaleRefId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SaleReferenceIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SaleReferenceIdentification { get; init; } 
    #else
    public System.String? SaleReferenceIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the transaction assigned by the POI (Point Of Interaction).
    /// </summary>
    [IsoId("_QznE3WpDEeS4VPLpYyQgxQ")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionIdentifier1 TransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionIdentifier1 TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionIdentifier1 TransactionIdentification { get; init; } 
    #else
    public TransactionIdentifier1 TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the original transaction.
    /// </summary>
    [IsoId("_QznE32pDEeS4VPLpYyQgxQ")]
    [DisplayName("Original Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlTx")]
    #endif
    [IsoXmlTag("OrgnlTx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardPaymentTransaction50? OriginalTransaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentTransaction50? OriginalTransaction { get; init; } 
    #else
    public CardPaymentTransaction50? OriginalTransaction { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the transaction.
    /// </summary>
    [IsoId("_QznE4WpDEeS4VPLpYyQgxQ")]
    [DisplayName("Transaction Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxDtls")]
    #endif
    [IsoXmlTag("TxDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardPaymentTransactionDetails26 TransactionDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CardPaymentTransactionDetails26 TransactionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentTransactionDetails26 TransactionDetails { get; init; } 
    #else
    public CardPaymentTransactionDetails26 TransactionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information related to the transaction.
    /// </summary>
    [IsoId("_QznE42pDEeS4VPLpYyQgxQ")]
    [DisplayName("Additional Transaction Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlTxData")]
    #endif
    [IsoXmlTag("AddtlTxData")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? AdditionalTransactionData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalTransactionData { get; init; } 
    #else
    public System.String? AdditionalTransactionData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
