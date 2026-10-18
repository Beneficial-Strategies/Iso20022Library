// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandateCancellation2"/>
[IsoId("_tlX48lkyEeGeoaLUQk__nA_1031601865")]
[DisplayName("Mandate Cancellation")]
public partial record MandateCancellation2
{
    /// <inheritdoc cref="IMandateCancellation2.OriginalMessageInformation"/>
    [IsoId("_tlX481kyEeGeoaLUQk__nA_-257428226")]
    [DisplayName("Original Message Information")]
    [IsoXmlTag("OrgnlMsgInf")]
    public OriginalMessageInformation1? OriginalMessageInformation { get; init; }

    /// <inheritdoc cref="IMandateCancellation2.CancellationReason"/>
    [IsoId("_tlX49FkyEeGeoaLUQk__nA_503336927")]
    [DisplayName("Cancellation Reason")]
    [IsoXmlTag("CxlRsn")]
    public required PaymentCancellationReason1 CancellationReason { get; init; }

    /// <inheritdoc cref="IMandateCancellation2.OriginalMandate"/>
    [IsoId("_tlhp8FkyEeGeoaLUQk__nA_33260517")]
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    public required OriginalMandate2Choice_ OriginalMandate { get; init; }
}
