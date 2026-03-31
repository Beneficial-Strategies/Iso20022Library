// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Local Address1.
/// </summary>
[IsoId("_xYnCUZkFEe6Qpd-x8YgzaA")]
[DisplayName("Local Address1")]
public record LocalAddress1
{
    /// <summary>
    /// Address Line1.
    /// </summary>
    [DisplayName("Address Line1")]
    [IsoXmlTag("AdrLine1")]
    public IsoMax200Text? AddressLine1 { get; init; }

    /// <summary>
    /// Address Line2.
    /// </summary>
    [DisplayName("Address Line2")]
    [IsoXmlTag("AdrLine2")]
    public IsoMax200Text? AddressLine2 { get; init; }

    /// <summary>
    /// Building Number.
    /// </summary>
    [DisplayName("Building Number")]
    [IsoXmlTag("BldgNb")]
    public IsoMax35Text? BuildingNumber { get; init; }

    /// <summary>
    /// Country Sub Division Major Name.
    /// </summary>
    [DisplayName("Country Sub Division Major Name")]
    [IsoXmlTag("CtrySubDvsnMjrNm")]
    public IsoMax100Text? CountrySubDivisionMajorName { get; init; }

    /// <summary>
    /// Country Sub Division Minor Name.
    /// </summary>
    [DisplayName("Country Sub Division Minor Name")]
    [IsoXmlTag("CtrySubDvsnMnrNm")]
    public IsoMax100Text? CountrySubDivisionMinorName { get; init; }

    /// <summary>
    /// Postal Code.
    /// </summary>
    [DisplayName("Postal Code")]
    [IsoXmlTag("PstlCd")]
    public IsoMax35Text? PostalCode { get; init; }

    /// <summary>
    /// Street Name.
    /// </summary>
    [DisplayName("Street Name")]
    [IsoXmlTag("StrtNm")]
    public IsoMax200Text? StreetName { get; init; }

    /// <summary>
    /// Town Name.
    /// </summary>
    [DisplayName("Town Name")]
    [IsoXmlTag("TwnNm")]
    public IsoMax100Text? TownName { get; init; }
}
