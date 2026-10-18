// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandateCancellation4"/>
[IsoId("_d7WRbx77EeSxevWRRWxNAg")]
[DisplayName("Mandate Cancellation")]
public partial record MandateCancellation4
{
    /// <inheritdoc cref="IMandateCancellation4.OriginalMessageInformation"/>
    [IsoId("_eMUskx77EeSxevWRRWxNAg")]
    [DisplayName("Original Message Information")]
    [IsoXmlTag("OrgnlMsgInf")]
    public OriginalMessageInformation1? OriginalMessageInformation { get; init; }

    /// <inheritdoc cref="IMandateCancellation4.CancellationReason"/>
    [IsoId("_eMUslR77EeSxevWRRWxNAg")]
    [DisplayName("Cancellation Reason")]
    [IsoXmlTag("CxlRsn")]
    public required PaymentCancellationReason1 CancellationReason { get; init; }

    /// <inheritdoc cref="IMandateCancellation4.OriginalMandate"/>
    [IsoId("_eMUslx77EeSxevWRRWxNAg")]
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    public required OriginalMandate3Choice_ OriginalMandate { get; init; }

    /// <inheritdoc cref="IMandateCancellation4.SupplementaryData"/>
    [IsoId("_eMUsmR77EeSxevWRRWxNAg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
