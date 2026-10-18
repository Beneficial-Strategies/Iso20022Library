// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandateSuspension3"/>
[IsoId("_d-QNUdcZEeqRFcf2R4bPBw")]
[DisplayName("Mandate Suspension")]
public partial record MandateSuspension3
{
    /// <inheritdoc cref="IMandateSuspension3.SuspensionRequestIdentification"/>
    [IsoId("_d_uM8dcZEeqRFcf2R4bPBw")]
    [DisplayName("Suspension Request Identification")]
    [IsoXmlTag("SspnsnReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text SuspensionRequestIdentification { get; init; }

    /// <inheritdoc cref="IMandateSuspension3.OriginalMessageInformation"/>
    [IsoId("_d_uM89cZEeqRFcf2R4bPBw")]
    [DisplayName("Original Message Information")]
    [IsoXmlTag("OrgnlMsgInf")]
    public OriginalMessageInformation1? OriginalMessageInformation { get; init; }

    /// <inheritdoc cref="IMandateSuspension3.SuspensionReason"/>
    [IsoId("_d_uM9dcZEeqRFcf2R4bPBw")]
    [DisplayName("Suspension Reason")]
    [IsoXmlTag("SspnsnRsn")]
    public required MandateSuspensionReason2 SuspensionReason { get; init; }

    /// <inheritdoc cref="IMandateSuspension3.OriginalMandate"/>
    [IsoId("_d_uM99cZEeqRFcf2R4bPBw")]
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    public required OriginalMandate9Choice_ OriginalMandate { get; init; }

    /// <inheritdoc cref="IMandateSuspension3.SupplementaryData"/>
    [IsoId("_d_uM-dcZEeqRFcf2R4bPBw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
