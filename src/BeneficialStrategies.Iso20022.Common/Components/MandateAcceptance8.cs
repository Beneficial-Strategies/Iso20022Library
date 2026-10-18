// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandateAcceptance8"/>
[IsoId("_1f7egTEyEe6g-ffJsqGiSA")]
[DisplayName("Mandate Acceptance8")]
public partial record MandateAcceptance8
{
    /// <inheritdoc cref="IMandateAcceptance8.AcceptanceResult"/>
    [DisplayName("Acceptance Result")]
    [IsoXmlTag("AccptncRslt")]
    public required AcceptanceResult6 AcceptanceResult { get; init; }

    /// <inheritdoc cref="IMandateAcceptance8.OriginalMandate"/>
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    public OriginalMandate11Choice_? OriginalMandate { get; init; }

    /// <inheritdoc cref="IMandateAcceptance8.OriginalMessageInformation"/>
    [DisplayName("Original Message Information")]
    [IsoXmlTag("OrgnlMsgInf")]
    public OriginalMessageInformation1? OriginalMessageInformation { get; init; }

    /// <inheritdoc cref="IMandateAcceptance8.SupplementaryData"/>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
