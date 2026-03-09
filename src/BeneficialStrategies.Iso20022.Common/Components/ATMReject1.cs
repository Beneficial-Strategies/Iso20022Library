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
/// Information related to the reject of a message from an ATM or an ATM manager.
/// </summary>
[IsoId("_rjtNsIrFEeSRwL6n4K9igA")]
[DisplayName("ATM Reject")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMReject1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ATMReject1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMReject1( RejectReason1Code reqRejectReason )
    {
        RejectReason = reqRejectReason;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the entity sending the reject message.
    /// </summary>
    [IsoId("_80CtEIrFEeSRwL6n4K9igA")]
    [DisplayName("Reject Initiator Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RjctInitrId")]
    #endif
    [IsoXmlTag("RjctInitrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? RejectInitiatorIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RejectInitiatorIdentification { get; init; } 
    #else
    public System.String? RejectInitiatorIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// High level information allowing the sender of a request or an advice to know the types of error, and handle them accordingly.
    /// </summary>
    [IsoId("_CHSIUIrGEeSRwL6n4K9igA")]
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
    /// Additional information related to the sending of a reject message in response to a request or an advice.
    /// For logging purpose, in order to allow further analysis, statistics and deferred processing on the success or the failure of the request processing.
    /// </summary>
    [IsoId("_HEH1wIrGEeSRwL6n4K9igA")]
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
    /// Maintenance command to perform on the ATM.
    /// </summary>
    [IsoId("_MCaUsIrGEeSRwL6n4K9igA")]
    [DisplayName("Command")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cmd")]
    #endif
    [IsoXmlTag("Cmd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMCommand1? Command { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMCommand1? Command { get; init; } 
    #else
    public ATMCommand1? Command { get; set; } 
    #endif
    
    /// <summary>
    /// Received message that has been rejected.
    /// </summary>
    [IsoId("_QYLbEIrGEeSRwL6n4K9igA")]
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
