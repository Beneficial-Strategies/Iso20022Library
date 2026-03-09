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
/// Data related to the confirmed fraudulent transaction.
/// </summary>
[IsoId("_-RODYcsGEeuNe7RtB4qFHw")]
[DisplayName("Fraudulent Transaction Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FraudulentTransactionData2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Status of authorisation of the fraudulent transaction.
    /// </summary>
    [IsoId("_-WlEgcsGEeuNe7RtB4qFHw")]
    [DisplayName("Authorisation Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthstnSts")]
    #endif
    [IsoXmlTag("AuthstnSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AuthorisationStatus1? AuthorisationStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AuthorisationStatus1? AuthorisationStatus { get; init; } 
    #else
    public AuthorisationStatus1? AuthorisationStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the dispute if and when relevant.
    /// </summary>
    [IsoId("_-WlrkcsGEeuNe7RtB4qFHw")]
    [DisplayName("Dispute Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DsptDtls")]
    #endif
    [IsoXmlTag("DsptDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DisputeData2? DisputeDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DisputeData2? DisputeDetails { get; init; } 
    #else
    public DisputeData2? DisputeDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Reason for sending the message.
    /// The ISO 8583 maintenance agency (MA) manages this Message reason code list.
    /// </summary>
    [IsoId("_-Wlrk8sGEeuNe7RtB4qFHw")]
    [DisplayName("Message Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgRsn")]
    #endif
    [IsoXmlTag("MsgRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ISO8583MessageReasonCode? MessageReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? MessageReason { get; init; } 
    #else
    public string? MessageReason { get; set; } 
    #endif
    
    /// <summary>
    /// Supports message reason codes that are not defined  in external code list. 
    /// </summary>
    [IsoId("_-WlrlcsGEeuNe7RtB4qFHw")]
    [DisplayName("Alternate Message Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AltrnMsgRsn")]
    #endif
    [IsoXmlTag("AltrnMsgRsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AlternateMessageReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AlternateMessageReason { get; init; } 
    #else
    public System.String? AlternateMessageReason { get; set; } 
    #endif
    
    /// <summary>
    /// Complete or partial details of the original message identified as fraudulent.
    /// </summary>
    [IsoId("_-Wlrl8sGEeuNe7RtB4qFHw")]
    [DisplayName("Fraudulent Message")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrdlntMsg")]
    #endif
    [IsoXmlTag("FrdlntMsg")]
    [IsoSimpleType(IsoSimpleType.Max100KBinary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax100KBinary? FraudulentMessage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? FraudulentMessage { get; init; } 
    #else
    public System.Byte[]? FraudulentMessage { get; set; } 
    #endif
    
    
    #nullable disable
    
}
