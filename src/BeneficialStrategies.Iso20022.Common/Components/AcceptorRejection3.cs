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
/// Reject of an exchange.
/// </summary>
[IsoId("_G5i8sWp1EeSMqvBfBY1c9A")]
[DisplayName("Acceptor Rejection")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AcceptorRejection3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AcceptorRejection3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AcceptorRejection3( RejectReason2Code reqRejectReason )
    {
        RejectReason = reqRejectReason;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reject reason of the request or the advice.
    /// </summary>
    [IsoId("_HGEVwWp1EeSMqvBfBY1c9A")]
    [DisplayName("Reject Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RjctRsn")]
    #endif
    [IsoXmlTag("RjctRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RejectReason2Code RejectReason { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RejectReason2Code RejectReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RejectReason2Code RejectReason { get; init; } 
    #else
    public RejectReason2Code RejectReason { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information related to the reject of the exchange.
    /// </summary>
    [IsoId("_HGEVw2p1EeSMqvBfBY1c9A")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax500Text? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalInformation { get; init; } 
    #else
    public System.String? AdditionalInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Original request that caused the recipient party to reject it.
    /// </summary>
    [IsoId("_HGEVxWp1EeSMqvBfBY1c9A")]
    [DisplayName("Message In Error")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgInErr")]
    #endif
    [IsoXmlTag("MsgInErr")]
    [IsoSimpleType(IsoSimpleType.Max100KBinary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax100KBinary? MessageInError { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? MessageInError { get; init; } 
    #else
    public System.Byte[]? MessageInError { get; set; } 
    #endif
    
    
    #nullable disable
    
}
