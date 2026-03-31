// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the mandate to be cancelled.
/// </summary>
[IsoId("_tlX48lkyEeGeoaLUQk__nA_1031601865")]
[DisplayName("Mandate Cancellation")]
public record MandateCancellation2
{
    /// <summary>
    /// Provides information on the original message.
    /// </summary>
    [IsoId("_tlX481kyEeGeoaLUQk__nA_-257428226")]
    [DisplayName("Original Message Information")]
    [IsoXmlTag("OrgnlMsgInf")]
    public OriginalMessageInformation1? OriginalMessageInformation { get; init; }

    /// <summary>
    /// Provides detailed information on the cancellation reason.
    /// </summary>
    [IsoId("_tlX49FkyEeGeoaLUQk__nA_503336927")]
    [DisplayName("Cancellation Reason")]
    [IsoXmlTag("CxlRsn")]
    public required PaymentCancellationReason1 CancellationReason { get; init; }

    /// <summary>
    /// Provides the original mandate data.
    /// </summary>
    [IsoId("_tlhp8FkyEeGeoaLUQk__nA_33260517")]
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    public required OriginalMandate2Choice_ OriginalMandate { get; init; }
}
