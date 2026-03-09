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
[IsoId("_Svfw9wEcEeCQm6a_G2yO_w_1794621080")]
[DisplayName("Acceptor Rejection")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AcceptorRejection1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AcceptorRejection1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AcceptorRejection1( RejectReason1Code reqRejectReason )
    {
        RejectReason = reqRejectReason;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reject reason of the request or the advice.
    /// </summary>
    [IsoId("_Svfw-AEcEeCQm6a_G2yO_w_-144097158")]
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
    /// Additional information related to the reject of the exchange.
    /// </summary>
    [IsoId("_Svfw-QEcEeCQm6a_G2yO_w_-155195935")]
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
    [IsoId("_Svfw-gEcEeCQm6a_G2yO_w_-622814345")]
    [DisplayName("Message In Error")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgInErr")]
    #endif
    [IsoXmlTag("MsgInErr")]
    [IsoSimpleType(IsoSimpleType.Max5000Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax5000Binary? MessageInError { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? MessageInError { get; init; } 
    #else
    public System.Byte[]? MessageInError { get; set; } 
    #endif
    
    
    #nullable disable
    
}
