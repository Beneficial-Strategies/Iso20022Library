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
[IsoId("_o_L1ERN7EeKyONjZVQUqzg")]
[DisplayName("Corporate Action Narrative")]
public record CorporateActionNarrative24
{
    /// <summary>
    /// Provides the entity making the offer and is different from the issuing company.
    /// </summary>
    [IsoId("_pVPkpRN7EeKyONjZVQUqzg")]
    [DisplayName("Offeror")]
    [IsoXmlTag("Offerr")]
    public ValueList<UpdatedAdditionalInformation3> Offeror { get; init; } = [];

    /// <summary>
    /// Provides the new name of a company following a name change.
    /// </summary>
    [IsoId("_pVPkrxN7EeKyONjZVQUqzg")]
    [DisplayName("New Company Name")]
    [IsoXmlTag("NewCpnyNm")]
    public UpdatedAdditionalInformation3? NewCompanyName { get; init; }

    /// <summary>
    /// Provides the web address published for the event, that is, the address for the Universal Resource Locator (URL), for example, used over the www (HTTP) service.
    /// </summary>
    [IsoId("_pVPkvRN7EeKyONjZVQUqzg")]
    [DisplayName("URL Address")]
    [IsoXmlTag("URLAdr")]
    public UpdatedURLlnformation? URLAddress { get; init; }
}
