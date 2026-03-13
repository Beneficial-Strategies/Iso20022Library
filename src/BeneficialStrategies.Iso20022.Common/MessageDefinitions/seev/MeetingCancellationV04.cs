// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;



namespace BeneficialStrategies.Iso20022.seev;

/// <summary>
/// This record is an implementation of the seev.002.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The MeetingCancellation message is sent by the party that sent the MeetingNotification message to the original receiver. It is sent to cancel the previous MeetingNotification message or to advise the cancellation of a meeting.
/// Usage
/// The MeetingCancellation message is used in two different situations.
/// First, it is used to cancel a previously sent MeetingNotification message. In this case, the MessageCancellation, the MeetingReference and the Reason building blocks need to be present.
/// Second, it is used to advise that the meeting is cancelled. In this case, only the MeetingReference and Reason building blocks need to be present.
/// </summary>
[Description(@"Scope|The MeetingCancellation message is sent by the party that sent the MeetingNotification message to the original receiver. It is sent to cancel the previous MeetingNotification message or to advise the cancellation of a meeting.|Usage|The MeetingCancellation message is used in two different situations.|First, it is used to cancel a previously sent MeetingNotification message. In this case, the MessageCancellation, the MeetingReference and the Reason building blocks need to be present.|Second, it is used to advise that the meeting is cancelled. In this case, only the MeetingReference and Reason building blocks need to be present.")]
[IsoId("_TlmIHtEwEd-BzquC8wXy7w_-1684108229")]
[DisplayName("Meeting Cancellation V")]
public partial record MeetingCancellationV04 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.002.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgCxl";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.002.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #nullable enable
    
    /// <summary>
    /// Identifies the cancellation message.
    /// </summary>
    [IsoId("_TlmIH9EwEd-BzquC8wXy7w_26118050")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required MessageIdentification1 Identification { get; init; } 
    
    /// <summary>
    /// Information indicating that the cancellation of a message previously sent is requested (and not the cancellation of the meeting).
    /// </summary>
    [IsoId("_TlmIINEwEd-BzquC8wXy7w_2019170750")]
    [DisplayName("Message Cancellation")]
    [IsoXmlTag("MsgCxl")]
    public AmendInformation1? MessageCancellation { get; init; } 
    
    /// <summary>
    /// Series of elements which allow to identify a meeting.
    /// </summary>
    [IsoId("_TlvSANEwEd-BzquC8wXy7w_-1689849520")]
    [DisplayName("Meeting Reference")]
    [IsoXmlTag("MtgRef")]
    public required MeetingReference5 MeetingReference { get; init; } 
    
    /// <summary>
    /// Party notifying the cancellation of the meeting.
    /// </summary>
    [IsoId("_TlvSAdEwEd-BzquC8wXy7w_-1235762251")]
    [DisplayName("Notifying Party")]
    [IsoXmlTag("NtifngPty")]
    public PartyIdentification9Choice_? NotifyingParty { get; init; } 
    
    /// <summary>
    /// Identifies the security for which the meeting was organised.
    /// </summary>
    [IsoId("_TlvSAtEwEd-BzquC8wXy7w_1987199986")]
    [DisplayName("Security")]
    [IsoXmlTag("Scty")]
    [MinLength(0)]
    [MaxLength(200)]
    public ValueList<SecurityPosition6> Security { get; init; } = [];
    
    /// <summary>
    /// Defines the justification for the cancellation.
    /// </summary>
    [IsoId("_TlvSA9EwEd-BzquC8wXy7w_-2140747415")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required MeetingCancellationReason2 Reason { get; init; } 
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_TlvSBNEwEd-BzquC8wXy7w_-628495307")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension2? Extension { get; init; } 
    
    
    #nullable disable
    
}


// Since MeetingCancellationV04Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MeetingCancellationV04.

