// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandateCancellation5"/>
[IsoId("_dBASSUjwEeaVLL5QKJ4f-A")]
[DisplayName("Mandate Cancellation")]
public partial record MandateCancellation5
{
    /// <inheritdoc cref="IMandateCancellation5.OriginalMessageInformation"/>
    [IsoId("_dJ36Q0jwEeaVLL5QKJ4f-A")]
    [DisplayName("Original Message Information")]
    [IsoXmlTag("OrgnlMsgInf")]
    public OriginalMessageInformation1? OriginalMessageInformation { get; init; }

    /// <inheritdoc cref="IMandateCancellation5.CancellationReason"/>
    [IsoId("_dJ36RUjwEeaVLL5QKJ4f-A")]
    [DisplayName("Cancellation Reason")]
    [IsoXmlTag("CxlRsn")]
    public required PaymentCancellationReason1 CancellationReason { get; init; }

    /// <inheritdoc cref="IMandateCancellation5.OriginalMandate"/>
    [IsoId("_dJ36R0jwEeaVLL5QKJ4f-A")]
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    public required OriginalMandate4Choice_ OriginalMandate { get; init; }

    /// <inheritdoc cref="IMandateCancellation5.SupplementaryData"/>
    [IsoId("_dJ36SUjwEeaVLL5QKJ4f-A")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
