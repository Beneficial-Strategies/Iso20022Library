// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Alternate identification for a party using an identification type, a country code and a text field.
/// </summary>
[IsoId("_OSYeMa3pEfCN-rGCydxGUA")]
[DisplayName("Alternate Party Identification12")]
public record AlternatePartyIdentification12
{
    /// <summary>
    /// Specifies the type of alternate identification of the party identified.
    /// </summary>
    [IsoId("_OYnpFa3pEfCN-rGCydxGUA")]
    [DisplayName("Identification Type")]
    [IsoXmlTag("IdTp")]
    public required IdentificationType42Choice_ IdentificationType { get; init; }

    /// <summary>
    /// Country in which a person resides (the place of a person's home). In the case of a company, it is the country from which the affairs of that company are directed.
    /// </summary>
    [IsoId("_OYoQIK3pEfCN-rGCydxGUA")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public required CountryCode Country { get; init; }

    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    [IsoId("_OYoQLK3pEfCN-rGCydxGUA")]
    [DisplayName("Alternate Identification")]
    [IsoXmlTag("AltrnId")]
    public required IsoMax35Text AlternateIdentification { get; init; }

    /// <summary>
    /// Legal entity identification of the party.
    /// </summary>
    [IsoId("_PdXqoa3pEfCN-rGCydxGUA")]
    [DisplayName("LEI")]
    [IsoXmlTag("LEI")]
    public IsoLEIIdentifier? LEI { get; init; }
}
