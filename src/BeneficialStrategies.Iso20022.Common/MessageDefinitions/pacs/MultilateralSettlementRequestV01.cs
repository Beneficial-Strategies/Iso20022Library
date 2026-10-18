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

namespace BeneficialStrategies.Iso20022.pacs;

/// <inheritdoc cref="IMultilateralSettlementRequestV01"/>
[Description(
    @"The MultilateralSettlementRequest message is sent from an instructing agent to a market infrastructure to settle obligations between their participants using accounts held in a settlement service.||Usage: The MultilateralSettlementRequest message can contain one or more settlement instructions with multiple movements between accounts. By default, all movements present in an individual instruction shall be processed as a batch entry rather than a single entry per individual movement."
)]
[IsoId("_vsvOgQcYEeyTDbUIoCmuCw")]
[DisplayName("Multilateral Settlement Request V")]
public partial record MultilateralSettlementRequestV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "pacs.029.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MulSttlmReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pacs.029.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <inheritdoc cref="IMultilateralSettlementRequestV01.GroupHeader"/>
    [IsoId("_vsvOgwcYEeyTDbUIoCmuCw")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    public required GroupHeader104 GroupHeader { get; init; }

    /// <inheritdoc cref="IMultilateralSettlementRequestV01.SettlementRequest"/>
    [IsoId("_vsvOhQcYEeyTDbUIoCmuCw")]
    [DisplayName("Settlement Request")]
    [IsoXmlTag("SttlmReq")]
    public required MultilateralSettlementRequest2 SettlementRequest { get; init; }

    /// <inheritdoc cref="IMultilateralSettlementRequestV01.SupplementaryData"/>
    [IsoId("_vsvOhwcYEeyTDbUIoCmuCw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
