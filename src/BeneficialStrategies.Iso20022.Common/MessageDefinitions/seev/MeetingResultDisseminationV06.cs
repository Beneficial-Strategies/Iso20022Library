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
/// This record is an implementation of the seev.008.001.06 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The MeetingResultDissemination message is sent by an issuer, its agent or an intermediary to another intermediary, a party holding the right to vote, a registered security holder or to a beneficial holder to provide information on the voting results of a shareholders meeting.
/// Usage
/// The MeetingResultDissemination message is used to provide the vote results per resolution. It may also provide information on the level of participation.
/// This message is also used to notify an update or amendment to a previously sent MeetingResultDissemination message.
/// This message definition is intended for use with the Business Application Header.
/// </summary>
[Description(@"Scope|The MeetingResultDissemination message is sent by an issuer, its agent or an intermediary to another intermediary, a party holding the right to vote, a registered security holder or to a beneficial holder to provide information on the voting results of a shareholders meeting.|Usage|The MeetingResultDissemination message is used to provide the vote results per resolution. It may also provide information on the level of participation.|This message is also used to notify an update or amendment to a previously sent MeetingResultDissemination message.|This message definition is intended for use with the Business Application Header.")]
[IsoId("_yXBbtayREemMosWmlQ33EA")]
[DisplayName("Meeting Result Dissemination V")]
public partial record MeetingResultDisseminationV06 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.008.001.06";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgRsltDssmntn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.008.001.06";
    
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
    /// Type of dissemination report, that is, whether the report is new or a replacement.
    /// </summary>
    [IsoId("_5NVYVa-xEemJ1NnLPsTFaw")]
    [DisplayName("Meeting Results Dissemination Type")]
    [IsoXmlTag("MtgRsltsDssmntnTp")]
    public required NotificationType2Code MeetingResultsDisseminationType { get; init; } 
    
    /// <summary>
    /// Identification of the previously sent meeting result dissemination message.
    /// </summary>
    [IsoId("_5NVYVq-xEemJ1NnLPsTFaw")]
    [DisplayName("Previous Meeting Results Dissemination Identification")]
    [IsoXmlTag("PrvsMtgRsltsDssmntnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? PreviousMeetingResultsDisseminationIdentification { get; init; } 
    
    /// <summary>
    /// Set of elements that allow to identify unambiguously a meeting.
    /// </summary>
    [IsoId("_yXBbuayREemMosWmlQ33EA")]
    [DisplayName("Meeting Reference")]
    [IsoXmlTag("MtgRef")]
    public required MeetingReference8 MeetingReference { get; init; } 
    
    /// <summary>
    /// Securities for which the meeting is organised.
    /// </summary>
    [IsoId("_yXBbu6yREemMosWmlQ33EA")]
    [DisplayName("Security")]
    [IsoXmlTag("Scty")]
    [MinLength(1)]
    [MaxLength(200)]
    public ValueList<SecurityPosition10> Security { get; init; } = [];
    
    /// <summary>
    /// Results per resolution.
    /// </summary>
    [IsoId("_yXBbvayREemMosWmlQ33EA")]
    [DisplayName("Vote Result")]
    [IsoXmlTag("VoteRslt")]
    [MinLength(1)]
    [MaxLength(1000)]
    public ValueList<Vote12> VoteResult { get; init; } = [];
    
    /// <summary>
    /// Information about the participation to the voting process.
    /// </summary>
    [IsoId("_yXBbv6yREemMosWmlQ33EA")]
    [DisplayName("Participation")]
    [IsoXmlTag("Prtcptn")]
    public Participation5? Participation { get; init; } 
    
    /// <summary>
    /// Information on where additional information can be received.
    /// </summary>
    [IsoId("_yXBbwayREemMosWmlQ33EA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public CommunicationAddress11? AdditionalInformation { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_yXBbw6yREemMosWmlQ33EA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since MeetingResultDisseminationV06Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MeetingResultDisseminationV06.

