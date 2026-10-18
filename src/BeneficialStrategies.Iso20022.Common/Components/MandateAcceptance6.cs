// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandateAcceptance6"/>
[IsoId("_ZoVqAW49EeiU9cctagi5ow")]
[DisplayName("Mandate Acceptance")]
public partial record MandateAcceptance6
{
    /// <inheritdoc cref="IMandateAcceptance6.OriginalMessageInformation"/>
    [IsoId("_ZyBKdW49EeiU9cctagi5ow")]
    [DisplayName("Original Message Information")]
    [IsoXmlTag("OrgnlMsgInf")]
    public OriginalMessageInformation1? OriginalMessageInformation { get; init; }

    /// <inheritdoc cref="IMandateAcceptance6.AcceptanceResult"/>
    [IsoId("_ZyBKd249EeiU9cctagi5ow")]
    [DisplayName("Acceptance Result")]
    [IsoXmlTag("AccptncRslt")]
    public required AcceptanceResult6 AcceptanceResult { get; init; }

    /// <inheritdoc cref="IMandateAcceptance6.OriginalMandate"/>
    [IsoId("_ZyBKeW49EeiU9cctagi5ow")]
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    public OriginalMandate7Choice_? OriginalMandate { get; init; }

    /// <inheritdoc cref="IMandateAcceptance6.SupplementaryData"/>
    [IsoId("_ZyBKe249EeiU9cctagi5ow")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
