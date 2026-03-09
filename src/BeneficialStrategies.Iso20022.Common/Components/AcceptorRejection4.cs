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
[IsoId("_MZve4YPcEeSgq87JnUGd8A")]
[DisplayName("Acceptor Rejection")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AcceptorRejection4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AcceptorRejection4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AcceptorRejection4( RejectReason1Code reqRejectReason )
    {
        RejectReason = reqRejectReason;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reject reason of the message.
    /// </summary>
    [IsoId("_Mmjy4YPcEeSgq87JnUGd8A")]
    [DisplayName("Reject Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RjctRsn")]
    #endif
    [IsoXmlTag("RjctRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RejectReason1Code RejectReason { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RejectReason1Code RejectReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RejectReason1Code RejectReason { get; init; } 
    #else
    public RejectReason1Code RejectReason { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed description of an error that caused the rejection for further analysis.
    /// </summary>
    [IsoId("_q1SJYIPeEeS-ibzJaEIoIQ")]
    [DisplayName("Error Reporting")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ErrRptg")]
    #endif
    [IsoXmlTag("ErrRptg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ErrorReporting1? ErrorReporting { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ErrorReporting1? ErrorReporting { get; init; } 
    #else
    public ErrorReporting1? ErrorReporting { get; set; } 
    #endif
    
    /// <summary>
    /// Original request that caused the party to reject it.
    /// </summary>
    [IsoId("_Mmjy5YPcEeSgq87JnUGd8A")]
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
