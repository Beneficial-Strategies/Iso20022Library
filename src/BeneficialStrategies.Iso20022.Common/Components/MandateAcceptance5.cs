// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandateAcceptance5"/>
[IsoId("_dJ36S0jwEeaVLL5QKJ4f-A")]
[DisplayName("Mandate Acceptance")]
public partial record MandateAcceptance5
{
    /// <inheritdoc cref="IMandateAcceptance5.OriginalMessageInformation"/>
    [IsoId("_dTODg0jwEeaVLL5QKJ4f-A")]
    [DisplayName("Original Message Information")]
    [IsoXmlTag("OrgnlMsgInf")]
    public OriginalMessageInformation1? OriginalMessageInformation { get; init; }

    /// <inheritdoc cref="IMandateAcceptance5.AcceptanceResult"/>
    [IsoId("_dTODhUjwEeaVLL5QKJ4f-A")]
    [DisplayName("Acceptance Result")]
    [IsoXmlTag("AccptncRslt")]
    public required AcceptanceResult6 AcceptanceResult { get; init; }

    /// <inheritdoc cref="IMandateAcceptance5.OriginalMandate"/>
    [IsoId("_dTODh0jwEeaVLL5QKJ4f-A")]
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    public OriginalMandate5Choice_? OriginalMandate { get; init; }

    /// <inheritdoc cref="IMandateAcceptance5.SupplementaryData"/>
    [IsoId("_dTODiUjwEeaVLL5QKJ4f-A")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
