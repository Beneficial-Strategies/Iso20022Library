// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.seev;

/// <summary>
/// This record is an implementation of the seev.008.001.09 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// </summary>
[IsoId("_d7xBO1xxEe6fgZt44_IqFA")]
[DisplayName("Meeting Result Dissemination V09")]
public record MeetingResultDisseminationV09 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.008.001.09";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgRsltDssmntn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.008.001.09";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Additional Information.
    /// </summary>
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public CommunicationAddress11? AdditionalInformation { get; init; }

    /// <summary>
    /// Meeting Reference.
    /// </summary>
    [DisplayName("Meeting Reference")]
    [IsoXmlTag("MtgRef")]
    public required MeetingReference10 MeetingReference { get; init; }

    /// <summary>
    /// Meeting Result Dissemination Identification.
    /// </summary>
    [DisplayName("Meeting Result Dissemination Identification")]
    [IsoXmlTag("MtgRsltDssmntnId")]
    public IsoMax35Text? MeetingResultDisseminationIdentification { get; init; }

    /// <summary>
    /// Meeting Results Dissemination Type.
    /// </summary>
    [DisplayName("Meeting Results Dissemination Type")]
    [IsoXmlTag("MtgRsltsDssmntnTp")]
    public required NotificationType2Code MeetingResultsDisseminationType { get; init; }

    /// <summary>
    /// Pagination.
    /// </summary>
    [DisplayName("Pagination")]
    [IsoXmlTag("Pgntn")]
    public Pagination1? Pagination { get; init; }

    /// <summary>
    /// Participation.
    /// </summary>
    [DisplayName("Participation")]
    [IsoXmlTag("Prtcptn")]
    public Participation5? Participation { get; init; }

    /// <summary>
    /// Previous Meeting Results Dissemination Identification.
    /// </summary>
    [DisplayName("Previous Meeting Results Dissemination Identification")]
    [IsoXmlTag("PrvsMtgRsltsDssmntnId")]
    public IsoMax35Text? PreviousMeetingResultsDisseminationIdentification { get; init; }

    /// <summary>
    /// Security.
    /// </summary>
    [DisplayName("Security")]
    [IsoXmlTag("Scty")]
    public required SecurityPosition19 Security { get; init; }

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];

    /// <summary>
    /// Vote Result.
    /// </summary>
    [DisplayName("Vote Result")]
    [IsoXmlTag("VoteRslt")]
    public required Vote20 VoteResult { get; init; }
}

// Since MeetingResultDisseminationV09Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MeetingResultDisseminationV09.
