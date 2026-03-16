// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Address of a party expressed in a formal structure.
/// </summary>
[IsoId("_EIZxODgzEeKfZIj_SwVRwA")]
[DisplayName("Postal Address")]
public record PostalAddress12
{
    /// <summary>
    /// Name of a built-up area, with defined boundaries, and a local government.|.
    /// </summary>
    [IsoId("_EIZxPjgzEeKfZIj_SwVRwA")]
    [DisplayName("Town Name")]
    [IsoXmlTag("TwnNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TownName { get; init; }

    /// <summary>
    /// Identifies a subdivision of a country eg, state, region, county.
    /// </summary>
    [IsoId("_EIZxQTgzEeKfZIj_SwVRwA")]
    [DisplayName("Country Sub Division")]
    [IsoXmlTag("CtrySubDvsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CountrySubDivision { get; init; }

    /// <summary>
    /// Nation with its own government.
    /// </summary>
    [IsoId("_EIZxRDgzEeKfZIj_SwVRwA")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public required CountryCode Country { get; init; }
}
