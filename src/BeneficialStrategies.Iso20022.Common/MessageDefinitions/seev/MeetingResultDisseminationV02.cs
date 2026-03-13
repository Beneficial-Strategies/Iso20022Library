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
/// This record is an implementation of the seev.008.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An issuer, its agent or an intermediary sends the MeetingResultDissemination message to another intermediary, to a party holding the right to vote, to a registered security holder or to a beneficial holder to provide information on the voting results of a shareholders meeting.
/// Usage
/// The MeetingResultDissemination message is used to provide the vote results per resolution. It may also provide information on the level of participation.
/// This message is also used to notify an update or amendment to a previously sent MeetingResultDissemination message.
/// </summary>
[Description(@"Scope|An issuer, its agent or an intermediary sends the MeetingResultDissemination message to another intermediary, to a party holding the right to vote, to a registered security holder or to a beneficial holder to provide information on the voting results of a shareholders meeting.|Usage|The MeetingResultDissemination message is used to provide the vote results per resolution. It may also provide information on the level of participation.|This message is also used to notify an update or amendment to a previously sent MeetingResultDissemination message.")]
[IsoId("_Ts5C69EwEd-BzquC8wXy7w_762088787")]
[DisplayName("Meeting Result Dissemination V")]
public partial record MeetingResultDisseminationV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.008.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgRsltDssmntn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.008.001.02";
    
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
    /// Identifies the meeting dissemination notification message.
    /// </summary>
    [IsoId("_Ts5C7NEwEd-BzquC8wXy7w_-595761646")]
    [DisplayName("Meeting Result Dissemination Identification")]
    [IsoXmlTag("MtgRsltDssmntnId")]
    public required MessageIdentification1 MeetingResultDisseminationIdentification { get; init; } 
    
    /// <summary>
    /// Information specific to an amemdment.
    /// </summary>
    [IsoId("_Ts5C7dEwEd-BzquC8wXy7w_350846493")]
    [DisplayName("Amendment")]
    [IsoXmlTag("Amdmnt")]
    public AmendInformation2? Amendment { get; init; } 
    
    /// <summary>
    /// Series of elements which allow to identify a meeting.
    /// </summary>
    [IsoId("_TtCz4NEwEd-BzquC8wXy7w_762088836")]
    [DisplayName("Meeting Reference")]
    [IsoXmlTag("MtgRef")]
    public required MeetingReference3 MeetingReference { get; init; } 
    
    /// <summary>
    /// Party reporting the meeting results.
    /// </summary>
    [IsoId("_TtCz4dEwEd-BzquC8wXy7w_762088841")]
    [DisplayName("Reporting Party")]
    [IsoXmlTag("RptgPty")]
    public required PartyIdentification9Choice_ ReportingParty { get; init; } 
    
    /// <summary>
    /// Identifies the securities for which the meeting is organised.
    /// </summary>
    [IsoId("_TtCz4tEwEd-BzquC8wXy7w_762088866")]
    [DisplayName("Security")]
    [IsoXmlTag("Scty")]
    [MinLength(1)]
    [MaxLength(200)]
    public ValueList<SecurityPosition5> Security { get; init; } = [];
    
    /// <summary>
    /// Results per resolution.
    /// </summary>
    [IsoId("_TtCz49EwEd-BzquC8wXy7w_762088823")]
    [DisplayName("Vote Result")]
    [IsoXmlTag("VoteRslt")]
    [MinLength(1)]
    [MaxLength(200)]
    public ValueList<Vote5> VoteResult { get; init; } = [];
    
    /// <summary>
    /// Information about the participation to the voting process.
    /// </summary>
    [IsoId("_TtCz5NEwEd-BzquC8wXy7w_762088806")]
    [DisplayName("Participation")]
    [IsoXmlTag("Prtcptn")]
    public Participation2? Participation { get; init; } 
    
    /// <summary>
    /// Information on where additionnal information can be received.
    /// </summary>
    [IsoId("_TtCz5dEwEd-BzquC8wXy7w_762088789")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public CommunicationAddress4? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}


// Since MeetingResultDisseminationV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MeetingResultDisseminationV02.

