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
[IsoId("_x_GLtx9REeuFz_FaCzCLgQ")]
[DisplayName("Corporate Action Narrative")]
public record CorporateActionNarrative47
{
    /// <summary>
    /// Provides the entity making the offer and is different from the issuing company.
    /// </summary>
    [IsoId("_x_GLux9REeuFz_FaCzCLgQ")]
    [DisplayName("Offeror")]
    [IsoXmlTag("Offerr")]
    public UpdatedAdditionalInformation6? Offeror { get; init; }

    /// <summary>
    /// Provides the new name of a company following a name change.
    /// </summary>
    [IsoId("_x_GLwx9REeuFz_FaCzCLgQ")]
    [DisplayName("New Company Name")]
    [IsoXmlTag("NewCpnyNm")]
    public UpdatedAdditionalInformation6? NewCompanyName { get; init; }

    /// <summary>
    /// Provides the web address published for the event, that is, the address for the Universal Resource Locator (URL), for example, used over the www (HTTP) service.
    /// </summary>
    [IsoId("_x_GLyx9REeuFz_FaCzCLgQ")]
    [DisplayName("URL Address")]
    [IsoXmlTag("URLAdr")]
    public UpdatedURLlnformation5? URLAddress { get; init; }
}
