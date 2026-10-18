// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandateSuspension1"/>
[IsoId("_IgCRoH5oEea7cqFPsAF3tQ")]
[DisplayName("Mandate Suspension")]
public partial record MandateSuspension1
{
    /// <inheritdoc cref="IMandateSuspension1.SuspensionRequestIdentification"/>
    [IsoId("_TNLMgJnBEeao_Z127E9uYg")]
    [DisplayName("Suspension Request Identification")]
    [IsoXmlTag("SspnsnReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text SuspensionRequestIdentification { get; init; }

    /// <inheritdoc cref="IMandateSuspension1.OriginalMessageInformation"/>
    [IsoId("_s3OtIH5oEea7cqFPsAF3tQ")]
    [DisplayName("Original Message Information")]
    [IsoXmlTag("OrgnlMsgInf")]
    public OriginalMessageInformation1? OriginalMessageInformation { get; init; }

    /// <inheritdoc cref="IMandateSuspension1.SuspensionReason"/>
    [IsoId("_w6-2cH5oEea7cqFPsAF3tQ")]
    [DisplayName("Suspension Reason")]
    [IsoXmlTag("SspnsnRsn")]
    public required MandateSuspensionReason1 SuspensionReason { get; init; }

    /// <inheritdoc cref="IMandateSuspension1.OriginalMandate"/>
    [IsoId("_CfZIYH5pEea7cqFPsAF3tQ")]
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    public required OriginalMandate4Choice_ OriginalMandate { get; init; }

    /// <inheritdoc cref="IMandateSuspension1.SupplementaryData"/>
    [IsoId("_H2d6wH5pEea7cqFPsAF3tQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
