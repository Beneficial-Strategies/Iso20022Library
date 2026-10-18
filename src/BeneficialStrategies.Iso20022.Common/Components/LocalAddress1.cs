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
    public Max200Text? AddressLine1 { get; init; }

    /// <summary>
    /// Address Line2.
    /// </summary>
    [DisplayName("Address Line2")]
    [IsoXmlTag("AdrLine2")]
    public Max200Text? AddressLine2 { get; init; }

    /// <summary>
    /// Building Number.
    /// </summary>
    [DisplayName("Building Number")]
    [IsoXmlTag("BldgNb")]
    public Max35Text? BuildingNumber { get; init; }

    /// <summary>
    /// Country Sub Division Major Name.
    /// </summary>
    [DisplayName("Country Sub Division Major Name")]
    [IsoXmlTag("CtrySubDvsnMjrNm")]
    public Max100Text? CountrySubDivisionMajorName { get; init; }

    /// <summary>
    /// Country Sub Division Minor Name.
    /// </summary>
    [DisplayName("Country Sub Division Minor Name")]
    [IsoXmlTag("CtrySubDvsnMnrNm")]
    public Max100Text? CountrySubDivisionMinorName { get; init; }

    /// <summary>
    /// Postal Code.
    /// </summary>
    [DisplayName("Postal Code")]
    [IsoXmlTag("PstlCd")]
    public Max35Text? PostalCode { get; init; }

    /// <summary>
    /// Street Name.
    /// </summary>
    [DisplayName("Street Name")]
    [IsoXmlTag("StrtNm")]
    public Max200Text? StreetName { get; init; }

    /// <summary>
    /// Town Name.
    /// </summary>
    [DisplayName("Town Name")]
    [IsoXmlTag("TwnNm")]
    public Max100Text? TownName { get; init; }
}
