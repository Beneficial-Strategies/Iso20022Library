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

namespace BeneficialStrategies.Iso20022.pain;

/// <inheritdoc cref="IMandateAcceptanceReportV07"/>
[Description(
    @"Scope|The MandateAcceptanceReport message is sent from the agent of the receiver (debtor or creditor) of the MandateRequest message (initiation, amendment or cancellation) to the agent of the initiator of the MandateRequest message (debtor or creditor).|A MandateAcceptanceReport message is used to confirm the acceptance or rejection of a MandateRequest message. Where acceptance is part of the full process flow, a MandateRequest message only becomes valid after a confirmation of acceptance is received through a MandateAcceptanceReport message from the agent of the receiver.|Usage|The MandateAcceptanceReport message can contain one or more confirmation(s) of acceptance or rejection of a specific Mandate Request.|The messages can be exchanged between debtor agent and creditor agent and between debtor agent and debtor and creditor agent and creditor.|The MandateAcceptanceReport message can be used in domestic and cross-border scenarios."
)]
[IsoId("_rUYODdcBEeq_l4BJLVUF2Q")]
[DisplayName("Mandate Acceptance Report V")]
public partial record MandateAcceptanceReportV07 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "pain.012.001.07";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MndtAccptncRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pain.012.001.07";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <inheritdoc cref="IMandateAcceptanceReportV07.GroupHeader"/>
    [IsoId("_rUYOF9cBEeq_l4BJLVUF2Q")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    public required GroupHeader80 GroupHeader { get; init; }

    /// <inheritdoc cref="IMandateAcceptanceReportV07.UnderlyingAcceptanceDetails"/>
    [IsoId("_rUYOGdcBEeq_l4BJLVUF2Q")]
    [DisplayName("Underlying Acceptance Details")]
    [IsoXmlTag("UndrlygAccptncDtls")]
    public required MandateAcceptance7 UnderlyingAcceptanceDetails { get; init; }

    /// <inheritdoc cref="IMandateAcceptanceReportV07.SupplementaryData"/>
    [IsoId("_rUYOG9cBEeq_l4BJLVUF2Q")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
