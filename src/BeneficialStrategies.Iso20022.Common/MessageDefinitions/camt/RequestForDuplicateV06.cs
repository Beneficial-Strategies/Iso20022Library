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

namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// This record is an implementation of the camt.033.001.06 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The RequestForDuplicate message is sent by the case assignee to the case creator or case assigner.
/// This message is used to request a copy of the original payment instruction considered in the case.
/// Usage
/// The RequestForDuplicate message:
/// - must be answered with a Duplicate message;
/// - must be used when a case assignee requests a copy of the original payment instruction. This occurs, for example, when the case assignee cannot trace the payment instruction based on the elements mentioned in the case assignment message;
/// - covers one and only one instruction at a time. If several payment instruction copies are needed by the case assignee, then multiple RequestForDuplicate messages must be sent
/// - must be used exclusively between the case assignee and its case creator/case assigner.
/// </summary>
[Description(
    @"Scope|The RequestForDuplicate message is sent by the case assignee to the case creator or case assigner.|This message is used to request a copy of the original payment instruction considered in the case.|Usage|The RequestForDuplicate message:|- must be answered with a Duplicate message;|- must be used when a case assignee requests a copy of the original payment instruction. This occurs, for example, when the case assignee cannot trace the payment instruction based on the elements mentioned in the case assignment message;|- covers one and only one instruction at a time. If several payment instruction copies are needed by the case assignee, then multiple RequestForDuplicate messages must be sent|- must be used exclusively between the case assignee and its case creator/case assigner."
)]
[IsoId("_eX_OpW2PEei3KuUgpx7Xcw")]
[DisplayName("Request For Duplicate V")]
public record RequestForDuplicateV06 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.033.001.06";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ReqForDplct";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.033.001.06";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Identifies the assignment of an investigation case from an assigner to an assignee.
    /// Usage: The assigner must be the sender of this confirmation and the assignee must be the receiver.
    /// </summary>
    [IsoId("_eX_Op22PEei3KuUgpx7Xcw")]
    [DisplayName("Assignment")]
    [IsoXmlTag("Assgnmt")]
    public required CaseAssignment5 Assignment { get; init; }

    /// <summary>
    /// Identifies the investigation case.
    /// </summary>
    [IsoId("_eX_OqW2PEei3KuUgpx7Xcw")]
    [DisplayName("Case")]
    [IsoXmlTag("Case")]
    public Case5? Case { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_eX_Oq22PEei3KuUgpx7Xcw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since RequestForDuplicateV06Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to RequestForDuplicateV06.
