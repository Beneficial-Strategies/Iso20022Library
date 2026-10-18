// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandateAcceptance2"/>
[IsoId("_tlE-AFkyEeGeoaLUQk__nA_1609524877")]
[DisplayName("Mandate Acceptance")]
public partial record MandateAcceptance2
{
    /// <inheritdoc cref="IMandateAcceptance2.OriginalMessageInformation"/>
    [IsoId("_tlE-AVkyEeGeoaLUQk__nA_320494786")]
    [DisplayName("Original Message Information")]
    [IsoXmlTag("OrgnlMsgInf")]
    public OriginalMessageInformation1? OriginalMessageInformation { get; init; }

    /// <inheritdoc cref="IMandateAcceptance2.AcceptanceResult"/>
    [IsoId("_tlE-AlkyEeGeoaLUQk__nA_-149581624")]
    [DisplayName("Acceptance Result")]
    [IsoXmlTag("AccptncRslt")]
    public required AcceptanceResult6 AcceptanceResult { get; init; }

    /// <inheritdoc cref="IMandateAcceptance2.OriginalMandate"/>
    [IsoId("_tlOvAFkyEeGeoaLUQk__nA_1149455238")]
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    public required OriginalMandate2Choice_ OriginalMandate { get; init; }
}
