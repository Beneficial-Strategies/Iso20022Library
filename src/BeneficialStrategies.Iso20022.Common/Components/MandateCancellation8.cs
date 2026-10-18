// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandateCancellation8"/>
[IsoId("_5ukCITEyEe6g-ffJsqGiSA")]
[DisplayName("Mandate Cancellation8")]
public partial record MandateCancellation8
{
    /// <inheritdoc cref="IMandateCancellation8.CancellationReason"/>
    [DisplayName("Cancellation Reason")]
    [IsoXmlTag("CxlRsn")]
    public required MandateCancellationReason2 CancellationReason { get; init; }

    /// <inheritdoc cref="IMandateCancellation8.OriginalMandate"/>
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    public required OriginalMandate10Choice_ OriginalMandate { get; init; }

    /// <inheritdoc cref="IMandateCancellation8.OriginalMessageInformation"/>
    [DisplayName("Original Message Information")]
    [IsoXmlTag("OrgnlMsgInf")]
    public OriginalMessageInformation1? OriginalMessageInformation { get; init; }

    /// <inheritdoc cref="IMandateCancellation8.SupplementaryData"/>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
