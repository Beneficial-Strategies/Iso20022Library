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
/// Data to respond to a Payment request.
/// </summary>
[IsoId("_7OgBINxCEeioifFt1dhnJA")]
[DisplayName("Payment Response")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentResponse1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PaymentResponse1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PaymentResponse1( TransactionIdentifier1 reqSaleTransactionIdentification,TransactionIdentifier1 reqPOITransactionIdentification,RetailerPaymentResult1 reqRetailerPaymentResult )
    {
        SaleTransactionIdentification = reqSaleTransactionIdentification;
        POITransactionIdentification = reqPOITransactionIdentification;
        RetailerPaymentResult = reqRetailerPaymentResult;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Sale System identification of the transaction in an unambiguous way.
    /// </summary>
    [IsoId("_F05YENxDEeioifFt1dhnJA")]
    [DisplayName("Sale Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SaleTxId")]
    #endif
    [IsoXmlTag("SaleTxId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionIdentifier1 SaleTransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionIdentifier1 SaleTransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionIdentifier1 SaleTransactionIdentification { get; init; } 
    #else
    public TransactionIdentifier1 SaleTransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Global reference of the sale transaction for the sale system.
    /// </summary>
    [IsoId("_gJ5GYezMEeiojesOXOKoug")]
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
    /// POI identification of the transaction in an unambiguous way.
    /// </summary>
    [IsoId("_JPaXINxDEeioifFt1dhnJA")]
    [DisplayName("POI Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POITxId")]
    #endif
    [IsoXmlTag("POITxId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionIdentifier1 POITransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionIdentifier1 POITransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionIdentifier1 POITransactionIdentification { get; init; } 
    #else
    public TransactionIdentifier1 POITransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification of the reconciliation period between the acceptor and the acquirer.
    /// </summary>
    [IsoId("_OOZZoNxDEeioifFt1dhnJA")]
    [DisplayName("POI Reconciliation Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POIRcncltnId")]
    #endif
    [IsoXmlTag("POIRcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? POIReconciliationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? POIReconciliationIdentification { get; init; } 
    #else
    public System.String? POIReconciliationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the transaction given by the Issuer.
    /// </summary>
    [IsoId("_MSzBQe2qEei-V5h0ja04AA")]
    [DisplayName("Issuer Reference Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssrRefData")]
    #endif
    [IsoXmlTag("IssrRefData")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? IssuerReferenceData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? IssuerReferenceData { get; init; } 
    #else
    public System.String? IssuerReferenceData { get; set; } 
    #endif
    
    /// <summary>
    /// Data related to the result of a processed payment transaction.
    /// </summary>
    [IsoId("_lugjENxFEeioifFt1dhnJA")]
    [DisplayName("Retailer Payment Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RtlrPmtRslt")]
    #endif
    [IsoXmlTag("RtlrPmtRslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RetailerPaymentResult1 RetailerPaymentResult { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RetailerPaymentResult1 RetailerPaymentResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RetailerPaymentResult1 RetailerPaymentResult { get; init; } 
    #else
    public RetailerPaymentResult1 RetailerPaymentResult { get; set; } 
    #endif
    
    /// <summary>
    /// Customer or Merchant payment receipt.
    /// </summary>
    [IsoId("_9N76kNxIEeioifFt1dhnJA")]
    [DisplayName("Payment Receipt")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtRct")]
    #endif
    [IsoXmlTag("PmtRct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentReceipt1? PaymentReceipt { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentReceipt1? PaymentReceipt { get; init; } 
    #else
    public PaymentReceipt1? PaymentReceipt { get; set; } 
    #endif
    
    /// <summary>
    /// Data related to the result of a processed loyalty transaction.
    /// </summary>
    [IsoId("_MhX9gNxLEeioifFt1dhnJA")]
    [DisplayName("Loyalty Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LltyRslt")]
    #endif
    [IsoXmlTag("LltyRslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LoyaltyResult1? LoyaltyResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LoyaltyResult1? LoyaltyResult { get; init; } 
    #else
    public LoyaltyResult1? LoyaltyResult { get; set; } 
    #endif
    
    /// <summary>
    /// Customer order attached to a customer, recorded in the POI system.
    /// </summary>
    [IsoId("_Pv1dkNxLEeioifFt1dhnJA")]
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
    
    
    #nullable disable
    
}
