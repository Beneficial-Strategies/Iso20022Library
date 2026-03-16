// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information that locates and identifies a specific address, as defined by postal services.
/// </summary>
[IsoId("_WNJcz9p-Ed-ak6NoX_4Aeg_-1885159655")]
[DisplayName("Postal Address")]
public record PostalAddress7
{
    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services, that is presented in free format text.
    /// </summary>
    [IsoId("_WNJc0Np-Ed-ak6NoX_4Aeg_-1885159532")]
    [DisplayName("Address Line")]
    [IsoXmlTag("AdrLine")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINMax35Text)]
    [MinLength(0)]
    [MaxLength(2)]
    public SimpleValueList<System.String> AddressLine { get; init; } = [];

    /// <summary>
    /// Identifier consisting of a group of letters and/or numbers that is added to a postal address to assist the sorting of mail.
    /// </summary>
    [IsoId("_WNTNwNp-Ed-ak6NoX_4Aeg_-1885159162")]
    [DisplayName("Post Code")]
    [IsoXmlTag("PstCd")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINMax8Text)]
    [StringLength(maximumLength: 8, MinimumLength = 1)]
    public IsoRestrictedFINMax8Text? PostCode { get; init; }

    /// <summary>
    /// Name of a built-up area, with defined boundaries, and a local government.
    /// </summary>
    [IsoId("_WNTNwdp-Ed-ak6NoX_4Aeg_-1885159101")]
    [DisplayName("Town Name")]
    [IsoXmlTag("TwnNm")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINMax23Text)]
    [StringLength(maximumLength: 23, MinimumLength = 1)]
    public IsoRestrictedFINMax23Text? TownName { get; init; }

    /// <summary>
    /// Nation with its own government.
    /// </summary>
    [IsoId("_WNTNwtp-Ed-ak6NoX_4Aeg_-1885159254")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public required CountryCode Country { get; init; }
}
