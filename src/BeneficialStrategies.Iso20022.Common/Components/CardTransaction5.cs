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
/// Card transaction for which the financial authorisation is requested.
/// </summary>
[IsoId("_H1_E8YIdEeSvPp7yXrNQIw")]
[DisplayName("Card Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardTransaction5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardTransaction5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardTransaction5( CardPaymentServiceType7Code reqTransactionType,System.DateTime reqAcceptorTransactionDateTime,System.String reqAcceptorTransactionIdentification,System.String reqInitiatorTransactionIdentification,CardTransactionDetail3 reqTransactionDetails )
    {
        TransactionType = reqTransactionType;
        AcceptorTransactionDateTime = reqAcceptorTransactionDateTime;
        AcceptorTransactionIdentification = reqAcceptorTransactionIdentification;
        InitiatorTransactionIdentification = reqInitiatorTransactionIdentification;
        TransactionDetails = reqTransactionDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of transaction being undertaken for the main service. 
    /// It correspond partially to the ISO 8583 field number 3.
    /// </summary>
    [IsoId("_ICgeAYIdEeSvPp7yXrNQIw")]
    [DisplayName("Transaction Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxTp")]
    #endif
    [IsoXmlTag("TxTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardPaymentServiceType7Code TransactionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CardPaymentServiceType7Code TransactionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentServiceType7Code TransactionType { get; init; } 
    #else
    public CardPaymentServiceType7Code TransactionType { get; set; } 
    #endif
    
    /// <summary>
    /// Service in addition to the main service. 
    /// It correspond partially to the ISO 8583: 2003 field number 22-3.
    /// </summary>
    [IsoId("_ICgeA4IdEeSvPp7yXrNQIw")]
    [DisplayName("Additional Service")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlSvc")]
    #endif
    [IsoXmlTag("AddtlSvc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardPaymentServiceType8Code? AdditionalService { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentServiceType8Code? AdditionalService { get; init; } 
    #else
    public CardPaymentServiceType8Code? AdditionalService { get; set; } 
    #endif
    
    /// <summary>
    /// Additional attribute of the service type. 
    /// It correspond partially to the ISO 8583: 2003 field number 22-3.
    /// </summary>
    [IsoId("_ICgeBYIdEeSvPp7yXrNQIw")]
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
    /// It correspond to the ISO 8583 field number 18 for the version 87, field numbers 18 and 26 for the version 93, and field number 26 for the version 2003.
    /// </summary>
    [IsoId("_ICgeB4IdEeSvPp7yXrNQIw")]
    [DisplayName("Merchant Category Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrchntCtgyCd")]
    #endif
    [IsoXmlTag("MrchntCtgyCd")]
    [IsoSimpleType(IsoSimpleType.Min3Max4NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMin3Max4NumericText? MerchantCategoryCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MerchantCategoryCode { get; init; } 
    #else
    public System.String? MerchantCategoryCode { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the reconciliation period between the acquirer and the issuer or their respective agents.
    /// </summary>
    [IsoId("_ICgeCYIdEeSvPp7yXrNQIw")]
    [DisplayName("Reconciliation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rcncltn")]
    #endif
    [IsoXmlTag("Rcncltn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionIdentifier2? Reconciliation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionIdentifier2? Reconciliation { get; init; } 
    #else
    public TransactionIdentifier2? Reconciliation { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time of the transaction transported unchanged by the acquirer from the card acceptor to the issuer. Corresponds to the CAPE data element TransactionIdentification/ TransactionDateTime.
    /// It correspond to the ISO 8583 field number 12.
    /// </summary>
    [IsoId("_ICgeC4IdEeSvPp7yXrNQIw")]
    [DisplayName("Acceptor Transaction Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AccptrTxDtTm")]
    #endif
    [IsoXmlTag("AccptrTxDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime AcceptorTransactionDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime AcceptorTransactionDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime AcceptorTransactionDateTime { get; init; } 
    #else
    public System.DateTime AcceptorTransactionDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Unique transaction identification generated by the acceptor or the acquirer transported unchanged by the acquirer from the card acceptor to the issuer. It is used to assist locating the original source information. Eventually it could be included in the cardholder statement. It corresponds to ISO 8583, field 37 and CAPE data element TransactionIdentification/TransactionReference.
    /// </summary>
    [IsoId("_ICgeDYIdEeSvPp7yXrNQIw")]
    [DisplayName("Acceptor Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AccptrTxId")]
    #endif
    [IsoXmlTag("AccptrTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text AcceptorTransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String AcceptorTransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String AcceptorTransactionIdentification { get; init; } 
    #else
    public System.String AcceptorTransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Number generated by the transaction Initiator to assist in identifying a transaction uniquely. This value remains unchanged for all messages within a message pair exchange, for instance an initiation/response. It corresponds to the ISO 8583 field number 11.
    /// </summary>
    [IsoId("_ICgeD4IdEeSvPp7yXrNQIw")]
    [DisplayName("Initiator Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitrTxId")]
    #endif
    [IsoXmlTag("InitrTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text InitiatorTransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String InitiatorTransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String InitiatorTransactionIdentification { get; init; } 
    #else
    public System.String InitiatorTransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification to match transactions throughout their life cycle (for example, authorisation to financial presentment, financial presentment to chargeback). It shall contain the same value in all messages throughout a transaction’s life cycle. It corresponds partially to ISO 8583: 2003 field number 21.
    /// </summary>
    [IsoId("_ICgeEYIdEeSvPp7yXrNQIw")]
    [DisplayName("Transaction Life Cycle Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxLifeCyclId")]
    #endif
    [IsoXmlTag("TxLifeCyclId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TransactionLifeCycleIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TransactionLifeCycleIdentification { get; init; } 
    #else
    public System.String? TransactionLifeCycleIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Life cycle transaction sequence number when multiple authorisations are performed for the same presentment.
    /// It corresponds partially to ISO 8583: 2003 field number 21.
    /// </summary>
    [IsoId("_ICgeE4IdEeSvPp7yXrNQIw")]
    [DisplayName("Transaction Life Cycle Sequence Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxLifeCyclSeqNb")]
    #endif
    [IsoXmlTag("TxLifeCyclSeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? TransactionLifeCycleSequenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? TransactionLifeCycleSequenceNumber { get; init; } 
    #else
    public System.UInt64? TransactionLifeCycleSequenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Total number of transactions under the same life cycle transaction sequence number.
    /// </summary>
    [IsoId("_ICgeFYIdEeSvPp7yXrNQIw")]
    [DisplayName("Transaction Life Cycle Sequence Counter")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxLifeCyclSeqCntr")]
    #endif
    [IsoXmlTag("TxLifeCyclSeqCntr")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? TransactionLifeCycleSequenceCounter { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? TransactionLifeCycleSequenceCounter { get; init; } 
    #else
    public System.UInt64? TransactionLifeCycleSequenceCounter { get; set; } 
    #endif
    
    /// <summary>
    /// Data supplied by an acquirer at clearing time to assist in identifying the original transaction in subsequent messages, for example when researching retrievals and chargebacks. It corresponds to ISO 8583: 2003 field number 31, acquirer reference number.
    /// </summary>
    [IsoId("_aTYsQC7jEeWc7f-D6ByqMg")]
    [DisplayName("Acquirer Transaction Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcqrrTxRef")]
    #endif
    [IsoXmlTag("AcqrrTxRef")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35NumericText? AcquirerTransactionReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AcquirerTransactionReference { get; init; } 
    #else
    public System.String? AcquirerTransactionReference { get; set; } 
    #endif
    
    /// <summary>
    /// Data supplied by a card issuer in response messages or in issuer generated messages, that the acquirer may be required to be provided in subsequent messages. It corresponds to ISO 8583: 93 and 2003 field number 95.
    /// </summary>
    [IsoId("_6l4QUC7wEeWc7f-D6ByqMg")]
    [DisplayName("Card Issuer Reference Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardIssrRefData")]
    #endif
    [IsoXmlTag("CardIssrRefData")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? CardIssuerReferenceData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CardIssuerReferenceData { get; init; } 
    #else
    public System.String? CardIssuerReferenceData { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the original transaction.
    /// It corresponds to ISO 8583, field number 90 for the version 87, and 56 for the other versions.
    /// </summary>
    [IsoId("_ICgeF4IdEeSvPp7yXrNQIw")]
    [DisplayName("Original Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlTx")]
    #endif
    [IsoXmlTag("OrgnlTx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardTransaction3? OriginalTransaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardTransaction3? OriginalTransaction { get; init; } 
    #else
    public CardTransaction3? OriginalTransaction { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the card transaction.
    /// </summary>
    [IsoId("_ICgeGYIdEeSvPp7yXrNQIw")]
    [DisplayName("Transaction Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxDtls")]
    #endif
    [IsoXmlTag("TxDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardTransactionDetail3 TransactionDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CardTransactionDetail3 TransactionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardTransactionDetail3 TransactionDetails { get; init; } 
    #else
    public CardTransactionDetail3 TransactionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Outcome of the authorisation.
    /// </summary>
    [IsoId("_ICgeG4IdEeSvPp7yXrNQIw")]
    [DisplayName("Authorisation Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthstnRslt")]
    #endif
    [IsoXmlTag("AuthstnRslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AuthorisationResult7? AuthorisationResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AuthorisationResult7? AuthorisationResult { get; init; } 
    #else
    public AuthorisationResult7? AuthorisationResult { get; set; } 
    #endif
    
    
    #nullable disable
    
}
