// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data elements contained in the original message.
/// ISO 8583:1987 bit 90 and ISO 8583 1993/2003 bit 56.
/// </summary>
[IsoId("_b9lSwcL9EeujWbERHVYCew")]
[DisplayName("Original Data Elements")]
public partial record OriginalDataElements2
{
    #nullable enable
    
    /// <summary>
    /// Message class of the original message.
    /// </summary>
    [IsoId("_cDJIMcL9EeujWbERHVYCew")]
    [DisplayName("Message Class")]
    [IsoXmlTag("MsgClss")]
    public MessageClass1Code? MessageClass { get; init; } 
    
    /// <summary>
    /// Identifies the type of process related to the message.
    /// </summary>
    [IsoId("_0oSGgDHNEeyTT91yHXSlSQ")]
    [DisplayName("Message Function")]
    [IsoXmlTag("MsgFctn")]
    public MessageFunction16Code? MessageFunction { get; init; } 
    
    /// <summary>
    /// Type of transaction associated with the main service.
    /// </summary>
    [IsoId("_cDJIM8L9EeujWbERHVYCew")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public ISO8583TransactionTypeCode? TransactionType { get; init; } 
    
    /// <summary>
    /// Code identifying the acquirer of the original message.
    /// ISO 8583 bit 32
    /// </summary>
    [IsoId("_cDJINcL9EeujWbERHVYCew")]
    [DisplayName("Acquirer Identification")]
    [IsoXmlTag("AcqrrId")]
    [IsoSimpleType(IsoSimpleType.Max11NumericText)]
    public IsoMax11NumericText? AcquirerIdentification { get; init; } 
    
    /// <summary>
    /// Code identifying the sender of the original message.
    /// ISO 8583 bit 33.
    /// </summary>
    [IsoId("_cDJIN8L9EeujWbERHVYCew")]
    [DisplayName("Sender Identification")]
    [IsoXmlTag("SndrId")]
    [IsoSimpleType(IsoSimpleType.Max11NumericText)]
    public IsoMax11NumericText? SenderIdentification { get; init; } 
    
    /// <summary>
    /// Local date the transaction takes place at the acceptor location.
    /// </summary>
    [IsoId("_cDJIOcL9EeujWbERHVYCew")]
    [DisplayName("Local Date")]
    [IsoXmlTag("LclDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? LocalDate { get; init; } 
    
    /// <summary>
    /// Local time the transaction takes place at the acceptor location.
    /// </summary>
    [IsoId("_iURIAML9EeujWbERHVYCew")]
    [DisplayName("Local Time")]
    [IsoXmlTag("LclTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public IsoISOTime? LocalTime { get; init; } 
    
    /// <summary>
    /// Time zone name (for example, as defined by IANA - Internet Assigned Numbers Authority) in the time zone data base.
    /// </summary>
    [IsoId("_cDJIO8L9EeujWbERHVYCew")]
    [DisplayName("Time Zone")]
    [IsoXmlTag("TmZone")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? TimeZone { get; init; } 
    
    /// <summary>
    /// Identification of the transaction by the card acceptor. It may appear on the receipt of the cardholder. It remains unchanged throughout the lifetime of the transaction.
    /// </summary>
    [IsoId("_cDJIPcL9EeujWbERHVYCew")]
    [DisplayName("Transaction Reference")]
    [IsoXmlTag("TxRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TransactionReference { get; init; } 
    
    /// <summary>
    /// Date and time expressed in UTC of the message as sent by the initiator.
    /// ISO 8583 bit 7
    /// </summary>
    [IsoId("_cDJIP8L9EeujWbERHVYCew")]
    [DisplayName("Transmission Date Time")]
    [IsoXmlTag("TrnsmssnDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? TransmissionDateTime { get; init; } 
    
    /// <summary>
    /// Transaction reference of the original message.
    ///  ISO 8583 bit 11.
    /// </summary>
    [IsoId("_cDJIQcL9EeujWbERHVYCew")]
    [DisplayName("System Trace Audit Number")]
    [IsoXmlTag("SysTracAudtNb")]
    [IsoSimpleType(IsoSimpleType.Max12NumericText)]
    public IsoMax12NumericText? SystemTraceAuditNumber { get; init; } 
    
    /// <summary>
    /// Reference supplied by the system retaining the original source information and used to assist in locating that information or a copy thereof.
    /// ISO 8583 bit 37
    /// </summary>
    [IsoId("_cDJIQ8L9EeujWbERHVYCew")]
    [DisplayName("Retrieval Reference Number")]
    [IsoXmlTag("RtrvlRefNb")]
    [IsoSimpleType(IsoSimpleType.Exact12Text)]
    public IsoExact12Text? RetrievalReferenceNumber { get; init; } 
    
    /// <summary>
    /// Indicate the point in the transaction lifecycle at which the lifecycle identifier was assigned.
    /// </summary>
    [IsoId("_cDJIRcL9EeujWbERHVYCew")]
    [DisplayName("Life Cycle Support")]
    [IsoXmlTag("LifeCyclSpprt")]
    public LifeCycleSupport1Code? LifeCycleSupport { get; init; } 
    
    /// <summary>
    /// Unique global identification structure used to match transactions throughout their lifecycle.
    /// ISO 8583:2003 bit 21
    /// </summary>
    [IsoId("_cDJIR8L9EeujWbERHVYCew")]
    [DisplayName("Life Cycle Trace Identification Data")]
    [IsoXmlTag("LifeCyclTracIdData")]
    public TransactionLifeCycleIdentification1? LifeCycleTraceIdentificationData { get; init; } 
    
    /// <summary>
    /// Reason for not providing a lifecycle trace identification information.
    /// </summary>
    [IsoId("_cDJIScL9EeujWbERHVYCew")]
    [DisplayName("Life Cycle Trace Identification Missing")]
    [IsoXmlTag("LifeCyclTracIdMssng")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? LifeCycleTraceIdentificationMissing { get; init; } 
    
    /// <summary>
    /// Data supplied by an acquirer in an authorisation or financial request, advice or notification that may be required to be provided in a subsequent transaction.
    /// </summary>
    [IsoId("_cDJIS8L9EeujWbERHVYCew")]
    [DisplayName("Acquirer Reference Data")]
    [IsoXmlTag("AcqrrRefData")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? AcquirerReferenceData { get; init; } 
    
    /// <summary>
    /// Data supplied by an acquirer to assist in identifying a transaction (for example, for researching retrievals and chargebacks).
    /// ISO 8583:2003 bit 31
    /// </summary>
    [IsoId("_cDJITcL9EeujWbERHVYCew")]
    [DisplayName("Acquirer Reference Number")]
    [IsoXmlTag("AcqrrRefNb")]
    [IsoSimpleType(IsoSimpleType.Max23NumericText)]
    public IsoMax23NumericText? AcquirerReferenceNumber { get; init; } 
    
    /// <summary>
    /// Data supplied by a card issuer in an authorisation response, financial response message or in a chargeback transaction that the acquirer may be required to provide in subsequent transactions.
    /// ISO 8583:1993 and ISO 8583:2003 bit 95.
    /// </summary>
    [IsoId("_cDJIT8L9EeujWbERHVYCew")]
    [DisplayName("Card Issuer Reference Data")]
    [IsoXmlTag("CardIssrRefData")]
    [IsoSimpleType(IsoSimpleType.Max1000Text)]
    [StringLength(maximumLength: 1000 ,MinimumLength = 1)]
    public IsoMax1000Text? CardIssuerReferenceData { get; init; } 
    
    
    #nullable disable
    
}
