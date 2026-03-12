// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains the details of an invalid payment event.
/// </summary>
[IsoId("_TQLzHKJuEeaLbOzg6lYrCA")]
[DisplayName("Payment Event")]
public partial record PaymentEvent3
{
    #nullable enable
    
    /// <summary>
    /// Contains the unique end to end transaction reference of a payment.
    /// </summary>
    [IsoId("_xTJt0T77EeiJbZ2wCAV0-w")]
    [DisplayName("UETR")]
    [IsoXmlTag("UETR")]
    [IsoSimpleType(IsoSimpleType.UUIDv4Identifier)]
    public required IsoUUIDv4Identifier UETR { get; init; } 
    
    /// <summary>
    /// Specifies the business service agreed between the two MessagingEndpoints under which rules this business message is exchanged.
    /// Usage:
    /// To be used when there is a choice of processing services or processing service levels.
    /// </summary>
    [IsoId("__-SuwaJxEeaLbOzg6lYrCA")]
    [DisplayName("Business Service")]
    [IsoXmlTag("BizSvc")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? BusinessService { get; init; } 
    
    /// <summary>
    /// Indicates whether the requestor institution participates in the payment transaction identified by the unique end to end transaction reference identification  (UETR).
    /// </summary>
    [IsoId("_HNcdEaJyEeaLbOzg6lYrCA")]
    [DisplayName("Participant")]
    [IsoXmlTag("Ptcpt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator Participant { get; init; } 
    
    /// <summary>
    /// Reference assigned by the network when sending the payment.
    /// </summary>
    [IsoId("_GHjzEqJyEeaLbOzg6lYrCA")]
    [DisplayName("Network Reference")]
    [IsoXmlTag("NtwkRef")]
    [IsoSimpleType(IsoSimpleType.Max50Text)]
    [StringLength(maximumLength: 50 ,MinimumLength = 1)]
    public required IsoMax50Text NetworkReference { get; init; } 
    
    /// <summary>
    /// Identifies the original message name identifier to which the message refers.
    /// </summary>
    [IsoId("_GHjzE6JyEeaLbOzg6lYrCA")]
    [DisplayName("Message Name Identification")]
    [IsoXmlTag("MsgNmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text MessageNameIdentification { get; init; } 
    
    /// <summary>
    /// Contains a unique identification, as assigned by an instructing party for an instructed party, to unambiguously identify the instruction.
    /// Usage: The instruction identification is a point to point reference that can be used between the instructing party and the instructed party to refer to the individual instruction. It can be included in several messages related to the instruction.
    /// </summary>
    [IsoId("_eXdFk6JyEeaLbOzg6lYrCA")]
    [DisplayName("Instruction Identification")]
    [IsoXmlTag("InstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text InstructionIdentification { get; init; } 
    
    /// <summary>
    /// Identifies the the sending MessagingEndpoint that has created this business message for the receiving MessagingEndpoint that will process this business message.
    /// Usage:
    /// The sending MessagingEndpoint might be different from the sending address potentially contained in the transport header (as defined in the transport layer).
    /// </summary>
    [IsoId("_eXdFlKJyEeaLbOzg6lYrCA")]
    [DisplayName("From")]
    [IsoXmlTag("Fr")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    public required IsoAnyBICIdentifier From { get; init; } 
    
    /// <summary>
    /// Identifies the MessagingEndpoint designated by the sending MessagingEndpoint to be the recipient who will ultimately process this business message.
    /// Note the receiving MessagingEndpoint might be different from the receiving address potentially contained in the transport header (as defined in the transport layer).
    /// </summary>
    [IsoId("_eXdFlaJyEeaLbOzg6lYrCA")]
    [DisplayName("To")]
    [IsoXmlTag("To")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    public IsoAnyBICIdentifier? To { get; init; } 
    
    /// <summary>
    /// Specifies the reason why the event is invalid.
    /// </summary>
    [IsoId("_pF0swKJyEeaLbOzg6lYrCA")]
    [DisplayName("Invalidity Reason")]
    [IsoXmlTag("InvldtyRsn")]
    public required ExternalInvalidEventReason1Code InvalidityReason { get; init; } 
    
    
    #nullable disable
    
}
