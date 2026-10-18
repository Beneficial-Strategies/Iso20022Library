// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandateSuspension4"/>
[IsoId("_4Q5KQTEyEe6g-ffJsqGiSA")]
[DisplayName("Mandate Suspension4")]
public partial record MandateSuspension4
{
    /// <inheritdoc cref="IMandateSuspension4.OriginalMandate"/>
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    public required OriginalMandate10Choice_ OriginalMandate { get; init; }

    /// <inheritdoc cref="IMandateSuspension4.OriginalMessageInformation"/>
    [DisplayName("Original Message Information")]
    [IsoXmlTag("OrgnlMsgInf")]
    public OriginalMessageInformation1? OriginalMessageInformation { get; init; }

    /// <inheritdoc cref="IMandateSuspension4.SupplementaryData"/>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];

    /// <inheritdoc cref="IMandateSuspension4.SuspensionReason"/>
    [DisplayName("Suspension Reason")]
    [IsoXmlTag("SspnsnRsn")]
    public required MandateSuspensionReason3 SuspensionReason { get; init; }

    /// <inheritdoc cref="IMandateSuspension4.SuspensionRequestIdentification"/>
    [DisplayName("Suspension Request Identification")]
    [IsoXmlTag("SspnsnReqId")]
    public required IsoMax35Text SuspensionRequestIdentification { get; init; }
}
