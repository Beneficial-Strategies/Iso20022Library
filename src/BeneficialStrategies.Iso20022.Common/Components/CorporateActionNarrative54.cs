// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information such as the taxation conditions.
/// </summary>
[IsoId("_p4YplTi7Eeydid5dcNPKvg")]
[DisplayName("Corporate Action Narrative")]
public record CorporateActionNarrative54
{
    /// <summary>
    /// Provides the entity making the offer and is different from the issuing company.
    /// </summary>
    [IsoId("_p4YpmTi7Eeydid5dcNPKvg")]
    [DisplayName("Offeror")]
    [IsoXmlTag("Offerr")]
    public UpdatedAdditionalInformation6? Offeror { get; init; }

    /// <summary>
    /// Provides the new name of a company following a name change.
    /// </summary>
    [IsoId("_p4YpoTi7Eeydid5dcNPKvg")]
    [DisplayName("New Company Name")]
    [IsoXmlTag("NewCpnyNm")]
    public UpdatedAdditionalInformation6? NewCompanyName { get; init; }

    /// <summary>
    /// Provides the web address published for the event, that is, the address for the Universal Resource Locator (URL), for example, used over the www (HTTP) service.
    /// </summary>
    [IsoId("_p4YpqTi7Eeydid5dcNPKvg")]
    [DisplayName("URL Address")]
    [IsoXmlTag("URLAdr")]
    public UpdatedURLlnformation5? URLAddress { get; init; }

    /// <summary>
    /// Provides web address of an account servicer (or of a service provider) that contains information solely intended for the immediate account holder to enable or facilitate event processing between parties.
    /// </summary>
    [IsoId("_p4YpsTi7Eeydid5dcNPKvg")]
    [DisplayName("Event Processing Web Site Address")]
    [IsoXmlTag("EvtPrcgWebSiteAdr")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINZMax2048Text)]
    [StringLength(maximumLength: 2048, MinimumLength = 1)]
    public IsoRestrictedFINZMax2048Text? EventProcessingWebSiteAddress { get; init; }
}
