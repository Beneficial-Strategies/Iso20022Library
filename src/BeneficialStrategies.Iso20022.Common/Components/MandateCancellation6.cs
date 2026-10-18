// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandateCancellation6"/>
[IsoId("_HJg-T249EeiU9cctagi5ow")]
[DisplayName("Mandate Cancellation")]
public partial record MandateCancellation6
{
    /// <inheritdoc cref="IMandateCancellation6.OriginalMessageInformation"/>
    [IsoId("_HSwZ0249EeiU9cctagi5ow")]
    [DisplayName("Original Message Information")]
    [IsoXmlTag("OrgnlMsgInf")]
    public OriginalMessageInformation1? OriginalMessageInformation { get; init; }

    /// <inheritdoc cref="IMandateCancellation6.CancellationReason"/>
    [IsoId("_HSwZ1W49EeiU9cctagi5ow")]
    [DisplayName("Cancellation Reason")]
    [IsoXmlTag("CxlRsn")]
    public required MandateCancellationReason1 CancellationReason { get; init; }

    /// <inheritdoc cref="IMandateCancellation6.OriginalMandate"/>
    [IsoId("_HSwZ1249EeiU9cctagi5ow")]
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    public required OriginalMandate6Choice_ OriginalMandate { get; init; }

    /// <inheritdoc cref="IMandateCancellation6.SupplementaryData"/>
    [IsoId("_HSwZ2W49EeiU9cctagi5ow")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
