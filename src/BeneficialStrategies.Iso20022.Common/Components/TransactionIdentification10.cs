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
/// Identification of the transaction for network management.
/// </summary>
[IsoId("_ie4K4VWQEeeiG_nL4vgKnQ")]
[DisplayName("Transaction Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransactionIdentification10
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransactionIdentification10 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransactionIdentification10( System.DateTime reqLocalDateTime,System.String reqSystemTraceAuditNumber,System.String reqRetrievalReferenceNumber )
    {
        LocalDateTime = reqLocalDateTime;
        SystemTraceAuditNumber = reqSystemTraceAuditNumber;
        RetrievalReferenceNumber = reqRetrievalReferenceNumber;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Local date and time the transaction takes place at the card acceptor location.
    /// ISO 8583:87 bit 12 and 13, ISO 8583:93/2003 bit 12
    /// </summary>
    [IsoId("_iqou8VWQEeeiG_nL4vgKnQ")]
    [DisplayName("Local Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LclDtTm")]
    #endif
    [IsoXmlTag("LclDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime LocalDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime LocalDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime LocalDateTime { get; init; } 
    #else
    public System.DateTime LocalDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Time zone name (for example, as defined by IANA - Internet Assigned Numbers Authority - in the time zone database.
    /// </summary>
    [IsoId("_iqou81WQEeeiG_nL4vgKnQ")]
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
    [IsoId("_iqou9VWQEeeiG_nL4vgKnQ")]
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
    [IsoId("_iqou91WQEeeiG_nL4vgKnQ")]
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
    /// A number assigned by a transaction originator to assist in identifying a transaction uniquely. The trace number remains unchanged for all messages within a two-message exchange (for example,  request/repeat and response)
    /// ISO 8583 bit 11.
    /// </summary>
    [IsoId("_iqou-VWQEeeiG_nL4vgKnQ")]
    [DisplayName("System Trace Audit Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SysTracAudtNb")]
    #endif
    [IsoXmlTag("SysTracAudtNb")]
    [IsoSimpleType(IsoSimpleType.Max12NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax12NumericText SystemTraceAuditNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String SystemTraceAuditNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String SystemTraceAuditNumber { get; init; } 
    #else
    public System.String SystemTraceAuditNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Reference supplied by the system retaining the original source information and used to assist in locating that information or a copy thereof.
    /// ISO 8583 bit 37
    /// </summary>
    [IsoId("_iqou-1WQEeeiG_nL4vgKnQ")]
    [DisplayName("Retrieval Reference Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RtrvlRefNb")]
    #endif
    [IsoXmlTag("RtrvlRefNb")]
    [IsoSimpleType(IsoSimpleType.Exact12Text)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoExact12Text RetrievalReferenceNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String RetrievalReferenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String RetrievalReferenceNumber { get; init; } 
    #else
    public System.String RetrievalReferenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Indicate the point in the transaction lifecycle at which the lifecycle identifier was assigned.
    /// </summary>
    [IsoId("_iqou_VWQEeeiG_nL4vgKnQ")]
    [DisplayName("Life Cycle Support Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LifeCyclSpprtInd")]
    #endif
    [IsoXmlTag("LifeCyclSpprtInd")]
    [IsoSimpleType(IsoSimpleType.Exact2NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact2NumericText? LifeCycleSupportIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LifeCycleSupportIndicator { get; init; } 
    #else
    public System.String? LifeCycleSupportIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Unique global identification structure used to match transactions throughout their lifecycle.
    /// ISO 8583:2003 bit 21
    /// </summary>
    [IsoId("_iqou_1WQEeeiG_nL4vgKnQ")]
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
    [IsoId("_iqovAVWQEeeiG_nL4vgKnQ")]
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
    /// ISO 8583:93 bit 31
    /// </summary>
    [IsoId("_iqovA1WQEeeiG_nL4vgKnQ")]
    [DisplayName("Acquirer Reference Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcqrrRefData")]
    #endif
    [IsoXmlTag("AcqrrRefData")]
    [IsoSimpleType(IsoSimpleType.Max99Text)]
    [StringLength(maximumLength: 99 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax99Text? AcquirerReferenceData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AcquirerReferenceData { get; init; } 
    #else
    public System.String? AcquirerReferenceData { get; set; } 
    #endif
    
    /// <summary>
    /// Data supplied by an acquirer to assist in identifying a transaction (for example, for researching retrievals and chargebacks).
    /// ISO 8583:2003 bit 31
    /// </summary>
    [IsoId("_iqovBVWQEeeiG_nL4vgKnQ")]
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
    [IsoId("_iqovB1WQEeeiG_nL4vgKnQ")]
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
