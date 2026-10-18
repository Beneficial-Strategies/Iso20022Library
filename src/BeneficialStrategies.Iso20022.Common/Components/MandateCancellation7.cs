// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandateCancellation7"/>
[IsoId("_f5VZ8dcZEeqRFcf2R4bPBw")]
[DisplayName("Mandate Cancellation")]
public partial record MandateCancellation7
{
    /// <inheritdoc cref="IMandateCancellation7.OriginalMessageInformation"/>
    [IsoId("_f7c50dcZEeqRFcf2R4bPBw")]
    [DisplayName("Original Message Information")]
    [IsoXmlTag("OrgnlMsgInf")]
    public OriginalMessageInformation1? OriginalMessageInformation { get; init; }

    /// <inheritdoc cref="IMandateCancellation7.CancellationReason"/>
    [IsoId("_f7c509cZEeqRFcf2R4bPBw")]
    [DisplayName("Cancellation Reason")]
    [IsoXmlTag("CxlRsn")]
    public required MandateCancellationReason1 CancellationReason { get; init; }

    /// <inheritdoc cref="IMandateCancellation7.OriginalMandate"/>
    [IsoId("_f7c51dcZEeqRFcf2R4bPBw")]
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    public required OriginalMandate9Choice_ OriginalMandate { get; init; }

    /// <inheritdoc cref="IMandateCancellation7.SupplementaryData"/>
    [IsoId("_f7c519cZEeqRFcf2R4bPBw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
