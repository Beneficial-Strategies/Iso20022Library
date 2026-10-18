// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandateAcceptance7"/>
[IsoId("_bOCIcdcZEeqRFcf2R4bPBw")]
[DisplayName("Mandate Acceptance")]
public partial record MandateAcceptance7
{
    /// <inheritdoc cref="IMandateAcceptance7.OriginalMessageInformation"/>
    [IsoId("_bPb2o9cZEeqRFcf2R4bPBw")]
    [DisplayName("Original Message Information")]
    [IsoXmlTag("OrgnlMsgInf")]
    public OriginalMessageInformation1? OriginalMessageInformation { get; init; }

    /// <inheritdoc cref="IMandateAcceptance7.AcceptanceResult"/>
    [IsoId("_bPb2pdcZEeqRFcf2R4bPBw")]
    [DisplayName("Acceptance Result")]
    [IsoXmlTag("AccptncRslt")]
    public required AcceptanceResult6 AcceptanceResult { get; init; }

    /// <inheritdoc cref="IMandateAcceptance7.OriginalMandate"/>
    [IsoId("_bPb2p9cZEeqRFcf2R4bPBw")]
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    public OriginalMandate8Choice_? OriginalMandate { get; init; }

    /// <inheritdoc cref="IMandateAcceptance7.SupplementaryData"/>
    [IsoId("_bPb2qdcZEeqRFcf2R4bPBw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
