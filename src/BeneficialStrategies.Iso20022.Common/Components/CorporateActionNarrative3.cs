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
[IsoId("_UMGyGdp-Ed-ak6NoX_4Aeg_804947111")]
[DisplayName("Corporate Action Narrative")]
public record CorporateActionNarrative3
{
    /// <summary>
    /// Provides the entity making the offer and is different from the issuing company.
    /// </summary>
    [IsoId("_UMGyGtp-Ed-ak6NoX_4Aeg_1018863277")]
    [DisplayName("Offeror")]
    [IsoXmlTag("Offerr")]
    public UpdatedAdditionalInformation3? Offeror { get; init; }

    /// <summary>
    /// Provides the new name of a company following a name change.
    /// </summary>
    [IsoId("_UMGyG9p-Ed-ak6NoX_4Aeg_1284571115")]
    [DisplayName("New Company Name")]
    [IsoXmlTag("NewCpnyNm")]
    public UpdatedAdditionalInformation3? NewCompanyName { get; init; }

    /// <summary>
    /// Provides the web address published for the event, that is, the address for the Universal Resource Locator (URL), for example, used over the www (HTTP) service.
    /// </summary>
    [IsoId("_UMQjENp-Ed-ak6NoX_4Aeg_399242966")]
    [DisplayName("URL Address")]
    [IsoXmlTag("URLAdr")]
    public UpdatedURLlnformation? URLAddress { get; init; }
}
