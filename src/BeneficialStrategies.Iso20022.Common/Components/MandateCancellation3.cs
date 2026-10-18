// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandateCancellation3"/>
[IsoId("_pxt2sSmfEeKdFJmzhTDOvQ")]
[DisplayName("Mandate Cancellation")]
public partial record MandateCancellation3
{
    /// <inheritdoc cref="IMandateCancellation3.OriginalMessageInformation"/>
    [IsoId("_qFr7lSmfEeKdFJmzhTDOvQ")]
    [DisplayName("Original Message Information")]
    [IsoXmlTag("OrgnlMsgInf")]
    public OriginalMessageInformation1? OriginalMessageInformation { get; init; }

    /// <inheritdoc cref="IMandateCancellation3.CancellationReason"/>
    [IsoId("_qFr7mSmfEeKdFJmzhTDOvQ")]
    [DisplayName("Cancellation Reason")]
    [IsoXmlTag("CxlRsn")]
    public required PaymentCancellationReason1 CancellationReason { get; init; }

    /// <inheritdoc cref="IMandateCancellation3.OriginalMandate"/>
    [IsoId("_qFr7nSmfEeKdFJmzhTDOvQ")]
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    public required OriginalMandate2Choice_ OriginalMandate { get; init; }

    /// <inheritdoc cref="IMandateCancellation3.SupplementaryData"/>
    [IsoId("_qXHp1imfEeKdFJmzhTDOvQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
