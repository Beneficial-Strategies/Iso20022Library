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
/// Contains the details of an invalid payment event.
/// </summary>
[IsoId("_TQLzHKJuEeaLbOzg6lYrCA")]
[DisplayName("Payment Event")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentEvent3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PaymentEvent3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PaymentEvent3( System.String reqUETR,System.String reqParticipant,System.String reqNetworkReference,System.String reqMessageNameIdentification,System.String reqInstructionIdentification,System.String reqFrom,string reqInvalidityReason )
    {
        UETR = reqUETR;
        Participant = reqParticipant;
        NetworkReference = reqNetworkReference;
        MessageNameIdentification = reqMessageNameIdentification;
        InstructionIdentification = reqInstructionIdentification;
        From = reqFrom;
        InvalidityReason = reqInvalidityReason;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Contains the unique end to end transaction reference of a payment.
    /// </summary>
    [IsoId("_xTJt0T77EeiJbZ2wCAV0-w")]
    [DisplayName("UETR")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UETR")]
    #endif
    [IsoXmlTag("UETR")]
    [IsoSimpleType(IsoSimpleType.UUIDv4Identifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoUUIDv4Identifier UETR { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String UETR { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String UETR { get; init; } 
    #else
    public System.String UETR { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the business service agreed between the two MessagingEndpoints under which rules this business message is exchanged.
    /// Usage:
    /// To be used when there is a choice of processing services or processing service levels.
    /// </summary>
    [IsoId("__-SuwaJxEeaLbOzg6lYrCA")]
    [DisplayName("Business Service")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BizSvc")]
    #endif
    [IsoXmlTag("BizSvc")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? BusinessService { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BusinessService { get; init; } 
    #else
    public System.String? BusinessService { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the requestor institution participates in the payment transaction identified by the unique end to end transaction reference identification  (UETR).
    /// </summary>
    [IsoId("_HNcdEaJyEeaLbOzg6lYrCA")]
    [DisplayName("Participant")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ptcpt")]
    #endif
    [IsoXmlTag("Ptcpt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator Participant { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Participant { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Participant { get; init; } 
    #else
    public System.String Participant { get; set; } 
    #endif
    
    /// <summary>
    /// Reference assigned by the network when sending the payment.
    /// </summary>
    [IsoId("_GHjzEqJyEeaLbOzg6lYrCA")]
    [DisplayName("Network Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtwkRef")]
    #endif
    [IsoXmlTag("NtwkRef")]
    [IsoSimpleType(IsoSimpleType.Max50Text)]
    [StringLength(maximumLength: 50 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax50Text NetworkReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String NetworkReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String NetworkReference { get; init; } 
    #else
    public System.String NetworkReference { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the original message name identifier to which the message refers.
    /// </summary>
    [IsoId("_GHjzE6JyEeaLbOzg6lYrCA")]
    [DisplayName("Message Name Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgNmId")]
    #endif
    [IsoXmlTag("MsgNmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text MessageNameIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String MessageNameIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String MessageNameIdentification { get; init; } 
    #else
    public System.String MessageNameIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Contains a unique identification, as assigned by an instructing party for an instructed party, to unambiguously identify the instruction.
    /// Usage: The instruction identification is a point to point reference that can be used between the instructing party and the instructed party to refer to the individual instruction. It can be included in several messages related to the instruction.
    /// </summary>
    [IsoId("_eXdFk6JyEeaLbOzg6lYrCA")]
    [DisplayName("Instruction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrId")]
    #endif
    [IsoXmlTag("InstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text InstructionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String InstructionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String InstructionIdentification { get; init; } 
    #else
    public System.String InstructionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the the sending MessagingEndpoint that has created this business message for the receiving MessagingEndpoint that will process this business message.
    /// Usage:
    /// The sending MessagingEndpoint might be different from the sending address potentially contained in the transport header (as defined in the transport layer).
    /// </summary>
    [IsoId("_eXdFlKJyEeaLbOzg6lYrCA")]
    [DisplayName("From")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Fr")]
    #endif
    [IsoXmlTag("Fr")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoAnyBICIdentifier From { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String From { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String From { get; init; } 
    #else
    public System.String From { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the MessagingEndpoint designated by the sending MessagingEndpoint to be the recipient who will ultimately process this business message.
    /// Note the receiving MessagingEndpoint might be different from the receiving address potentially contained in the transport header (as defined in the transport layer).
    /// </summary>
    [IsoId("_eXdFlaJyEeaLbOzg6lYrCA")]
    [DisplayName("To")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="To")]
    #endif
    [IsoXmlTag("To")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoAnyBICIdentifier? To { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? To { get; init; } 
    #else
    public System.String? To { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the reason why the event is invalid.
    /// </summary>
    [IsoId("_pF0swKJyEeaLbOzg6lYrCA")]
    [DisplayName("Invalidity Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvldtyRsn")]
    #endif
    [IsoXmlTag("InvldtyRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalInvalidEventReason1Code InvalidityReason { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string InvalidityReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string InvalidityReason { get; init; } 
    #else
    public string InvalidityReason { get; set; } 
    #endif
    
    
    #nullable disable
    
}
