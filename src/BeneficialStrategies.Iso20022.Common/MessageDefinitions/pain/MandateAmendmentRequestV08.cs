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

/// <inheritdoc cref="IMandateAmendmentRequestV08"/>
[IsoId("_R3P4TzEZEe6kQ-WGAhcVPQ")]
[DisplayName("Mandate Amendment Request V08")]
public partial record MandateAmendmentRequestV08 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "pain.010.001.08";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MndtAmdmntReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pain.010.001.08";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <inheritdoc cref="IMandateAmendmentRequestV08.GroupHeader"/>
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    public required GroupHeader110 GroupHeader { get; init; }

    /// <inheritdoc cref="IMandateAmendmentRequestV08.SupplementaryData"/>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];

    /// <inheritdoc cref="IMandateAmendmentRequestV08.UnderlyingAmendmentDetails"/>
    [DisplayName("Underlying Amendment Details")]
    [IsoXmlTag("UndrlygAmdmntDtls")]
    public ValueList<MandateAmendment8> UnderlyingAmendmentDetails { get; init; } = [];
}
