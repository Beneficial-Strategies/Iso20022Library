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
/// Data elements contained in the original message.
/// ISO 8583:1987 bit 90 and ISO 8583 1993/2003 bit 56.
/// </summary>
[IsoId("_b9lSwcL9EeujWbERHVYCew")]
[DisplayName("Original Data Elements")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OriginalDataElements2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Message class of the original message.
    /// </summary>
    [IsoId("_cDJIMcL9EeujWbERHVYCew")]
    [DisplayName("Message Class")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgClss")]
    #endif
    [IsoXmlTag("MsgClss")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MessageClass1Code? MessageClass { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageClass1Code? MessageClass { get; init; } 
    #else
    public MessageClass1Code? MessageClass { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the type of process related to the message.
    /// </summary>
    [IsoId("_0oSGgDHNEeyTT91yHXSlSQ")]
    [DisplayName("Message Function")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgFctn")]
    #endif
    [IsoXmlTag("MsgFctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MessageFunction16Code? MessageFunction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageFunction16Code? MessageFunction { get; init; } 
    #else
    public MessageFunction16Code? MessageFunction { get; set; } 
    #endif
    
    /// <summary>
    /// Type of transaction associated with the main service.
    /// </summary>
    [IsoId("_cDJIM8L9EeujWbERHVYCew")]
    [DisplayName("Transaction Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxTp")]
    #endif
    [IsoXmlTag("TxTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ISO8583TransactionTypeCode? TransactionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? TransactionType { get; init; } 
    #else
    public string? TransactionType { get; set; } 
    #endif
    
    /// <summary>
    /// Code identifying the acquirer of the original message.
    /// ISO 8583 bit 32
    /// </summary>
    [IsoId("_cDJINcL9EeujWbERHVYCew")]
    [DisplayName("Acquirer Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcqrrId")]
    #endif
    [IsoXmlTag("AcqrrId")]
    [IsoSimpleType(IsoSimpleType.Max11NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax11NumericText? AcquirerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AcquirerIdentification { get; init; } 
    #else
    public System.String? AcquirerIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Code identifying the sender of the original message.
    /// ISO 8583 bit 33.
    /// </summary>
    [IsoId("_cDJIN8L9EeujWbERHVYCew")]
    [DisplayName("Sender Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SndrId")]
    #endif
    [IsoXmlTag("SndrId")]
    [IsoSimpleType(IsoSimpleType.Max11NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax11NumericText? SenderIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SenderIdentification { get; init; } 
    #else
    public System.String? SenderIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Local date the transaction takes place at the acceptor location.
    /// </summary>
    [IsoId("_cDJIOcL9EeujWbERHVYCew")]
    [DisplayName("Local Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LclDt")]
    #endif
    [IsoXmlTag("LclDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? LocalDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? LocalDate { get; init; } 
    #else
    public System.DateOnly? LocalDate { get; set; } 
    #endif
    
    /// <summary>
    /// Local time the transaction takes place at the acceptor location.
    /// </summary>
    [IsoId("_iURIAML9EeujWbERHVYCew")]
    [DisplayName("Local Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LclTm")]
    #endif
    [IsoXmlTag("LclTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISOTime? LocalTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.TimeOnly? LocalTime { get; init; } 
    #else
    public System.TimeOnly? LocalTime { get; set; } 
    #endif
    
    /// <summary>
    /// Time zone name (for example, as defined by IANA - Internet Assigned Numbers Authority) in the time zone data base.
    /// </summary>
    [IsoId("_cDJIO8L9EeujWbERHVYCew")]
    [DisplayName("Time Zone")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TmZone")]
    #endif
    [IsoXmlTag("TmZone")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? TimeZone { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TimeZone { get; init; } 
    #else
    public System.String? TimeZone { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the transaction by the card acceptor. It may appear on the receipt of the cardholder. It remains unchanged throughout the lifetime of the transaction.
    /// </summary>
    [IsoId("_cDJIPcL9EeujWbERHVYCew")]
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
    
    /// <summary>
    /// Date and time expressed in UTC of the message as sent by the initiator.
    /// ISO 8583 bit 7
    /// </summary>
    [IsoId("_cDJIP8L9EeujWbERHVYCew")]
    [DisplayName("Transmission Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrnsmssnDtTm")]
    #endif
    [IsoXmlTag("TrnsmssnDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? TransmissionDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? TransmissionDateTime { get; init; } 
    #else
    public System.DateTime? TransmissionDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Transaction reference of the original message.
    ///  ISO 8583 bit 11.
    /// </summary>
    [IsoId("_cDJIQcL9EeujWbERHVYCew")]
    [DisplayName("System Trace Audit Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SysTracAudtNb")]
    #endif
    [IsoXmlTag("SysTracAudtNb")]
    [IsoSimpleType(IsoSimpleType.Max12NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax12NumericText? SystemTraceAuditNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SystemTraceAuditNumber { get; init; } 
    #else
    public System.String? SystemTraceAuditNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Reference supplied by the system retaining the original source information and used to assist in locating that information or a copy thereof.
    /// ISO 8583 bit 37
    /// </summary>
    [IsoId("_cDJIQ8L9EeujWbERHVYCew")]
    [DisplayName("Retrieval Reference Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RtrvlRefNb")]
    #endif
    [IsoXmlTag("RtrvlRefNb")]
    [IsoSimpleType(IsoSimpleType.Exact12Text)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact12Text? RetrievalReferenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RetrievalReferenceNumber { get; init; } 
    #else
    public System.String? RetrievalReferenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Indicate the point in the transaction lifecycle at which the lifecycle identifier was assigned.
    /// </summary>
    [IsoId("_cDJIRcL9EeujWbERHVYCew")]
    [DisplayName("Life Cycle Support")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LifeCyclSpprt")]
    #endif
    [IsoXmlTag("LifeCyclSpprt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LifeCycleSupport1Code? LifeCycleSupport { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LifeCycleSupport1Code? LifeCycleSupport { get; init; } 
    #else
    public LifeCycleSupport1Code? LifeCycleSupport { get; set; } 
    #endif
    
    /// <summary>
    /// Unique global identification structure used to match transactions throughout their lifecycle.
    /// ISO 8583:2003 bit 21
    /// </summary>
    [IsoId("_cDJIR8L9EeujWbERHVYCew")]
    [DisplayName("Life Cycle Trace Identification Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LifeCyclTracIdData")]
    #endif
    [IsoXmlTag("LifeCyclTracIdData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionLifeCycleIdentification1? LifeCycleTraceIdentificationData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionLifeCycleIdentification1? LifeCycleTraceIdentificationData { get; init; } 
    #else
    public TransactionLifeCycleIdentification1? LifeCycleTraceIdentificationData { get; set; } 
    #endif
    
    /// <summary>
    /// Reason for not providing a lifecycle trace identification information.
    /// </summary>
    [IsoId("_cDJIScL9EeujWbERHVYCew")]
    [DisplayName("Life Cycle Trace Identification Missing")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LifeCyclTracIdMssng")]
    #endif
    [IsoXmlTag("LifeCyclTracIdMssng")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? LifeCycleTraceIdentificationMissing { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LifeCycleTraceIdentificationMissing { get; init; } 
    #else
    public System.String? LifeCycleTraceIdentificationMissing { get; set; } 
    #endif
    
    /// <summary>
    /// Data supplied by an acquirer in an authorisation or financial request, advice or notification that may be required to be provided in a subsequent transaction.
    /// </summary>
    [IsoId("_cDJIS8L9EeujWbERHVYCew")]
    [DisplayName("Acquirer Reference Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcqrrRefData")]
    #endif
    [IsoXmlTag("AcqrrRefData")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? AcquirerReferenceData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AcquirerReferenceData { get; init; } 
    #else
    public System.String? AcquirerReferenceData { get; set; } 
    #endif
    
    /// <summary>
    /// Data supplied by an acquirer to assist in identifying a transaction (for example, for researching retrievals and chargebacks).
    /// ISO 8583:2003 bit 31
    /// </summary>
    [IsoId("_cDJITcL9EeujWbERHVYCew")]
    [DisplayName("Acquirer Reference Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcqrrRefNb")]
    #endif
    [IsoXmlTag("AcqrrRefNb")]
    [IsoSimpleType(IsoSimpleType.Max23NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax23NumericText? AcquirerReferenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AcquirerReferenceNumber { get; init; } 
    #else
    public System.String? AcquirerReferenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Data supplied by a card issuer in an authorisation response, financial response message or in a chargeback transaction that the acquirer may be required to provide in subsequent transactions.
    /// ISO 8583:1993 and ISO 8583:2003 bit 95.
    /// </summary>
    [IsoId("_cDJIT8L9EeujWbERHVYCew")]
    [DisplayName("Card Issuer Reference Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardIssrRefData")]
    #endif
    [IsoXmlTag("CardIssrRefData")]
    [IsoSimpleType(IsoSimpleType.Max1000Text)]
    [StringLength(maximumLength: 1000 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax1000Text? CardIssuerReferenceData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CardIssuerReferenceData { get; init; } 
    #else
    public System.String? CardIssuerReferenceData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
