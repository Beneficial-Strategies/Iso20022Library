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
[IsoId("_4XQCke6MEeqc-LCjwLsUVg")]
[DisplayName("Corporate Action Narrative")]
public record CorporateActionNarrative44
{
    /// <summary>
    /// Provides the entity making the offer and is different from the issuing company.
    /// </summary>
    [IsoId("_4roXI-6MEeqc-LCjwLsUVg")]
    [DisplayName("Offeror")]
    [IsoXmlTag("Offerr")]
    public UpdatedAdditionalInformation3? Offeror { get; init; }

    /// <summary>
    /// Provides the new name of a company following a name change.
    /// </summary>
    [IsoId("_4roXK-6MEeqc-LCjwLsUVg")]
    [DisplayName("New Company Name")]
    [IsoXmlTag("NewCpnyNm")]
    public UpdatedAdditionalInformation3? NewCompanyName { get; init; }

    /// <summary>
    /// Provides the web address published for the event, that is, the address for the Universal Resource Locator (URL), for example, used over the www (HTTP) service.
    /// </summary>
    [IsoId("_4roXM-6MEeqc-LCjwLsUVg")]
    [DisplayName("URL Address")]
    [IsoXmlTag("URLAdr")]
    public UpdatedURLlnformation4? URLAddress { get; init; }
}
