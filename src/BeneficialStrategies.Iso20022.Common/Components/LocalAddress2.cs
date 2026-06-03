// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information that locates and identifies a specific address.
/// </summary>
[IsoId("_qW_LgT_XEfCQAqQ9lolFUg")]
[DisplayName("Local Address2")]
public record LocalAddress2
{
    /// <summary>
    /// First line of an address.
    /// </summary>
    [IsoId("_qXnMoT_XEfCQAqQ9lolFUg")]
    [DisplayName("Line1")]
    [IsoXmlTag("Line1")]
    public IsoMax200Text? Line1 { get; init; }

    /// <summary>
    /// Second line of an address.
    /// </summary>
    [IsoId("_qXnMpT_XEfCQAqQ9lolFUg")]
    [DisplayName("Line2")]
    [IsoXmlTag("Line2")]
    public IsoMax200Text? Line2 { get; init; }

    /// <summary>
    /// Name of a street or thoroughfare.
    /// </summary>
    [IsoId("_qXnMqT_XEfCQAqQ9lolFUg")]
    [DisplayName("Street Name")]
    [IsoXmlTag("StrtNm")]
    public IsoMax200Text? StreetName { get; init; }

    /// <summary>
    /// Number that identifies the position of a building on a street.
    /// </summary>
    [IsoId("_qXnMrT_XEfCQAqQ9lolFUg")]
    [DisplayName("Building Number")]
    [IsoXmlTag("BldgNb")]
    public IsoMax35Text? BuildingNumber { get; init; }

    /// <summary>
    /// Identifier consisting of a group of letters and/or numbers that is added to a postal address to assist the sorting of mail.
    /// </summary>
    [IsoId("_qXnMsT_XEfCQAqQ9lolFUg")]
    [DisplayName("Postal Code")]
    [IsoXmlTag("PstlCd")]
    public IsoMax35Text? PostalCode { get; init; }

    /// <summary>
    /// Name of a built-up area, with defined boundaries, and a local government.
    /// </summary>
    [IsoId("_qXnMtT_XEfCQAqQ9lolFUg")]
    [DisplayName("Town Name")]
    [IsoXmlTag("TwnNm")]
    public IsoMax100Text? TownName { get; init; }

    /// <summary>
    /// Identifies a subdivision of a country such as state, region, county.
    /// </summary>
    [IsoId("_qXnMuT_XEfCQAqQ9lolFUg")]
    [DisplayName("Country Sub Division Minor Name")]
    [IsoXmlTag("CtrySubDvsnMnrNm")]
    public IsoMax100Text? CountrySubDivisionMinorName { get; init; }

    /// <summary>
    /// Identifies a major subdivision of a country such as province, state, or territory.
    /// </summary>
    [IsoId("_qXnMvT_XEfCQAqQ9lolFUg")]
    [DisplayName("Country Sub Division Major Name")]
    [IsoXmlTag("CtrySubDvsnMjrNm")]
    public IsoMax100Text? CountrySubDivisionMajorName { get; init; }
}
