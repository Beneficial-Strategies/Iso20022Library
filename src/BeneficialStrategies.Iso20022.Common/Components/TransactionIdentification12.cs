// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the transaction for network management.
/// </summary>
[IsoId("_yGEF8cWZEeiCfKAZkk6ZAQ")]
[DisplayName("Transaction Identification")]
public partial record TransactionIdentification12
{
    #nullable enable
    
    /// <summary>
    /// Number assigned by a transaction originator to assist in identifying a transaction uniquely. The trace number remains unchanged for all messages within a two-message exchange (for example, request/repeat and response)
    /// ISO 8583 bit 11.
    /// </summary>
    [IsoId("_ySq-mcWZEeiCfKAZkk6ZAQ")]
    [DisplayName("System Trace Audit Number")]
    [IsoXmlTag("SysTracAudtNb")]
    [IsoSimpleType(IsoSimpleType.Max12NumericText)]
    public required IsoMax12NumericText SystemTraceAuditNumber { get; init; } 
    
    /// <summary>
    /// Date and time expressed in UTC of the message as sent by the initiator.
    /// ISO 8583 bit 7
    /// </summary>
    [IsoId("_ySq-l8WZEeiCfKAZkk6ZAQ")]
    [DisplayName("Transmission Date Time")]
    [IsoXmlTag("TrnsmssnDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime TransmissionDateTime { get; init; } 
    
    /// <summary>
    /// A reference supplied by the system retaining the original source information and used to assist in locating that information or a copy thereof.
    /// ISO 8583 bit 37
    /// </summary>
    [IsoId("_ySq-m8WZEeiCfKAZkk6ZAQ")]
    [DisplayName("Retrieval Reference Number")]
    [IsoXmlTag("RtrvlRefNb")]
    [IsoSimpleType(IsoSimpleType.Exact12Text)]
    public IsoExact12Text? RetrievalReferenceNumber { get; init; } 
    
    /// <summary>
    /// Unique global identification structure used to match transactions throughout their lifecycle.
    /// ISO 8583:2003 bit 21
    /// </summary>
    [IsoId("_ySq-n8WZEeiCfKAZkk6ZAQ")]
    [DisplayName("Life Cycle Trace Identification Data")]
    [IsoXmlTag("LifeCyclTracIdData")]
    public TransactionLifeCycleIdentification2? LifeCycleTraceIdentificationData { get; init; } 
    
    
    #nullable disable
    
}
