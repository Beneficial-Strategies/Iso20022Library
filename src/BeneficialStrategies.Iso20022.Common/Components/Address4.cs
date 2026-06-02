// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Structured postal address.
/// </summary>
[IsoId("_5S1SQSRYEfCa6bxMAKEOKg")]
[DisplayName("Address4")]
public record Address4
{
    /// <summary>
    /// First line of information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [IsoId("_5VVzsSRYEfCa6bxMAKEOKg")]
    [DisplayName("Line1")]
    [IsoXmlTag("Line1")]
    public IsoMax99Text? Line1 { get; init; }

    /// <summary>
    /// Second line of information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [IsoId("_5VVzsyRYEfCa6bxMAKEOKg")]
    [DisplayName("Line2")]
    [IsoXmlTag("Line2")]
    public IsoMax99Text? Line2 { get; init; }

    /// <summary>
    /// Name of a street or thoroughfare.
    /// </summary>
    [IsoId("_5VVztSRYEfCa6bxMAKEOKg")]
    [DisplayName("Street Name")]
    [IsoXmlTag("StrtNm")]
    public IsoMax99Text? StreetName { get; init; }

    /// <summary>
    /// Number that identifies the position of a building on a street.
    /// </summary>
    [IsoId("_5VVztyRYEfCa6bxMAKEOKg")]
    [DisplayName("Building Number")]
    [IsoXmlTag("BldgNb")]
    public IsoMax16Text? BuildingNumber { get; init; }

    /// <summary>
    /// Identifier consisting of a group of letters and/or numbers that is added to a postal address to assist the sorting of mail.
    /// </summary>
    [IsoId("_5VVzuSRYEfCa6bxMAKEOKg")]
    [DisplayName("Postal Code")]
    [IsoXmlTag("PstlCd")]
    public IsoMax16Text? PostalCode { get; init; }

    /// <summary>
    /// Name of a built-up area, with defined boundaries, and a local government.
    /// </summary>
    [IsoId("_5VVzuyRYEfCa6bxMAKEOKg")]
    [DisplayName("Town Name")]
    [IsoXmlTag("TwnNm")]
    public IsoMax50Text? TownName { get; init; }

    /// <summary>
    /// Identifies a minor subdivision of a country, for instance county, prefecture.
    /// </summary>
    [IsoId("_5VVzvSRYEfCa6bxMAKEOKg")]
    [DisplayName("Country Sub Division Minor")]
    [IsoXmlTag("CtrySubDvsnMnr")]
    public ISOCountrySubDivisionCode? CountrySubDivisionMinor { get; init; }

    /// <summary>
    /// Identifies a major subdivision of a country, for instance state, province.
    /// </summary>
    [IsoId("_5VVzvyRYEfCa6bxMAKEOKg")]
    [DisplayName("Country Sub Division Major")]
    [IsoXmlTag("CtrySubDvsnMjr")]
    public ISOCountrySubDivisionCode? CountrySubDivisionMajor { get; init; }

    /// <summary>
    /// Name of a major subdivision of a country, for instance county, prefecture.
    /// </summary>
    [IsoId("_5VVzwSRYEfCa6bxMAKEOKg")]
    [DisplayName("Country Sub Division Major Name")]
    [IsoXmlTag("CtrySubDvsnMjrNm")]
    public IsoMax50Text? CountrySubDivisionMajorName { get; init; }

    /// <summary>
    /// Name of a minor subdivision of a country, for instance county, prefecture.
    /// </summary>
    [IsoId("_5VVzwyRYEfCa6bxMAKEOKg")]
    [DisplayName("Country Sub Division Minor Name")]
    [IsoXmlTag("CtrySubDvsnMnrNm")]
    public IsoMax50Text? CountrySubDivisionMinorName { get; init; }

    /// <summary>
    /// Nation with its own government occupying a particular territory.
    /// </summary>
    [IsoId("_5VVzxSRYEfCa6bxMAKEOKg")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public ISOMax3ACountryCode? Country { get; init; }

    /// <summary>
    /// Location of the acceptor in latitude/longitude decimal degrees.
    /// </summary>
    [IsoId("_ACqnUSRZEfCa6bxMAKEOKg")]
    [DisplayName("Geographic Location")]
    [IsoXmlTag("GeogcLctn")]
    public IsoGeographicPointInDecimalDegreesText? GeographicLocation { get; init; }
}
