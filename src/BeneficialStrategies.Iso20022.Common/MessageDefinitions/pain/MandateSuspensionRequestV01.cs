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

/// <inheritdoc cref="IMandateSuspensionRequestV01"/>
[Description(
    @"Scope|The MandateSuspensionRequest message is sent by the initiator of the request to its agent. The initiator can either be the debtor, debtor agent, creditor or creditor agent.|A MandateSuspensionRequest message is used to request the suspension of an existing mandate until the suspension is lifted. |Usage|The MandateSuspensionRequest message can contain one or more suspension requests.|The messages can be exchanged between creditor and creditor agent or debtor and debtor agent and between creditor agent and debtor agent.|The MandateSuspensionRequest message can be used in domestic and cross-border scenarios.|"
)]
[IsoId("_0HNCMH5lEea7cqFPsAF3tQ")]
[DisplayName("Mandate Suspension Request V")]
public partial record MandateSuspensionRequestV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "pain.018.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MndtSspnsnReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pain.018.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <inheritdoc cref="IMandateSuspensionRequestV01.GroupHeader"/>
    [IsoId("_SNAisH5nEea7cqFPsAF3tQ")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    public required GroupHeader47 GroupHeader { get; init; }

    /// <inheritdoc cref="IMandateSuspensionRequestV01.UnderlyingSuspensionDetails"/>
    [IsoId("_ka8SwH5nEea7cqFPsAF3tQ")]
    [DisplayName("Underlying Suspension Details")]
    [IsoXmlTag("UndrlygSspnsnDtls")]
    public required MandateSuspension1 UnderlyingSuspensionDetails { get; init; }

    /// <inheritdoc cref="IMandateSuspensionRequestV01.SupplementaryData"/>
    [IsoId("_yoO34H5nEea7cqFPsAF3tQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
