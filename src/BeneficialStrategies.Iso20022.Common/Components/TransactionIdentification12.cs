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
[IsoId("_yGEF8cWZEeiCfKAZkk6ZAQ")]
[DisplayName("Transaction Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransactionIdentification12
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransactionIdentification12 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransactionIdentification12( System.String reqSystemTraceAuditNumber,System.DateTime reqTransmissionDateTime )
    {
        SystemTraceAuditNumber = reqSystemTraceAuditNumber;
        TransmissionDateTime = reqTransmissionDateTime;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Number assigned by a transaction originator to assist in identifying a transaction uniquely. The trace number remains unchanged for all messages within a two-message exchange (for example, request/repeat and response)
    /// ISO 8583 bit 11.
    /// </summary>
    [IsoId("_ySq-mcWZEeiCfKAZkk6ZAQ")]
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
    /// Date and time expressed in UTC of the message as sent by the initiator.
    /// ISO 8583 bit 7
    /// </summary>
    [IsoId("_ySq-l8WZEeiCfKAZkk6ZAQ")]
    [DisplayName("Transmission Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrnsmssnDtTm")]
    #endif
    [IsoXmlTag("TrnsmssnDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime TransmissionDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime TransmissionDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime TransmissionDateTime { get; init; } 
    #else
    public System.DateTime TransmissionDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// A reference supplied by the system retaining the original source information and used to assist in locating that information or a copy thereof.
    /// ISO 8583 bit 37
    /// </summary>
    [IsoId("_ySq-m8WZEeiCfKAZkk6ZAQ")]
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
    /// Unique global identification structure used to match transactions throughout their lifecycle.
    /// ISO 8583:2003 bit 21
    /// </summary>
    [IsoId("_ySq-n8WZEeiCfKAZkk6ZAQ")]
    [DisplayName("Life Cycle Trace Identification Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LifeCyclTracIdData")]
    #endif
    [IsoXmlTag("LifeCyclTracIdData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionLifeCycleIdentification2? LifeCycleTraceIdentificationData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionLifeCycleIdentification2? LifeCycleTraceIdentificationData { get; init; } 
    #else
    public TransactionLifeCycleIdentification2? LifeCycleTraceIdentificationData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
