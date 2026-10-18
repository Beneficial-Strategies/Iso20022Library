// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandateAcceptance4"/>
[IsoId("_acF8WR77EeSxevWRRWxNAg")]
[DisplayName("Mandate Acceptance")]
public partial record MandateAcceptance4
{
    /// <inheritdoc cref="IMandateAcceptance4.OriginalMessageInformation"/>
    [IsoId("_atcx8x77EeSxevWRRWxNAg")]
    [DisplayName("Original Message Information")]
    [IsoXmlTag("OrgnlMsgInf")]
    public OriginalMessageInformation1? OriginalMessageInformation { get; init; }

    /// <inheritdoc cref="IMandateAcceptance4.AcceptanceResult"/>
    [IsoId("_atcx9R77EeSxevWRRWxNAg")]
    [DisplayName("Acceptance Result")]
    [IsoXmlTag("AccptncRslt")]
    public required AcceptanceResult6 AcceptanceResult { get; init; }

    /// <inheritdoc cref="IMandateAcceptance4.OriginalMandate"/>
    [IsoId("_atcx9x77EeSxevWRRWxNAg")]
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    public required OriginalMandate3Choice_ OriginalMandate { get; init; }

    /// <inheritdoc cref="IMandateAcceptance4.SupplementaryData"/>
    [IsoId("_atcx-R77EeSxevWRRWxNAg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
