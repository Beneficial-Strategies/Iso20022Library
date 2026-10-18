// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandateSuspension2"/>
[IsoId("_SaI98W49EeiU9cctagi5ow")]
[DisplayName("Mandate Suspension")]
public partial record MandateSuspension2
{
    /// <inheritdoc cref="IMandateSuspension2.SuspensionRequestIdentification"/>
    [IsoId("_Sk3nQW49EeiU9cctagi5ow")]
    [DisplayName("Suspension Request Identification")]
    [IsoXmlTag("SspnsnReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text SuspensionRequestIdentification { get; init; }

    /// <inheritdoc cref="IMandateSuspension2.OriginalMessageInformation"/>
    [IsoId("_Sk3nQ249EeiU9cctagi5ow")]
    [DisplayName("Original Message Information")]
    [IsoXmlTag("OrgnlMsgInf")]
    public OriginalMessageInformation1? OriginalMessageInformation { get; init; }

    /// <inheritdoc cref="IMandateSuspension2.SuspensionReason"/>
    [IsoId("_Sk3nRW49EeiU9cctagi5ow")]
    [DisplayName("Suspension Reason")]
    [IsoXmlTag("SspnsnRsn")]
    public required MandateSuspensionReason2 SuspensionReason { get; init; }

    /// <inheritdoc cref="IMandateSuspension2.OriginalMandate"/>
    [IsoId("_Sk3nR249EeiU9cctagi5ow")]
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    public required OriginalMandate6Choice_ OriginalMandate { get; init; }

    /// <inheritdoc cref="IMandateSuspension2.SupplementaryData"/>
    [IsoId("_Sk3nSW49EeiU9cctagi5ow")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
