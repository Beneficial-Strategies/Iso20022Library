// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the mandate, which is being accepted.
/// </summary>
[IsoId("_tlE-AFkyEeGeoaLUQk__nA_1609524877")]
public interface IMandateAcceptance2 : IIsoComponent
{
    /// <summary>
    /// Provides information on the original message.
    /// </summary>
    [IsoId("_tlE-AVkyEeGeoaLUQk__nA_320494786")]
    [DisplayName("Original Message Information")]
    [IsoXmlTag("OrgnlMsgInf")]
    IOriginalMessageInformation1? OriginalMessageInformation { get; }

    /// <summary>
    /// Provides detailed information on the acceptance result.
    /// </summary>
    [IsoId("_tlE-AlkyEeGeoaLUQk__nA_-149581624")]
    [DisplayName("Acceptance Result")]
    [IsoXmlTag("AccptncRslt")]
    IAcceptanceResult6 AcceptanceResult { get; }

    /// <summary>
    /// Provides the original mandate data.
    /// </summary>
    [IsoId("_tlOvAFkyEeGeoaLUQk__nA_1149455238")]
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    IOriginalMandate2Choice OriginalMandate { get; }
}
