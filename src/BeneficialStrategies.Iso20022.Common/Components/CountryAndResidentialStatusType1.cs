// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Country and residential status.
/// </summary>
[IsoId("_SyG5QNp-Ed-ak6NoX_4Aeg_-1650490428")]
[DisplayName("Country And Residential Status Type")]
public record CountryAndResidentialStatusType1
{
    /// <summary>
    /// Country to which the residential status is applicable.
    /// </summary>
    [IsoId("_SyG5Qdp-Ed-ak6NoX_4Aeg_-1509192342")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public required CountryCode Country { get; init; }

    /// <summary>
    /// Residential status of an individual, for example, non-permanent resident.
    /// </summary>
    [IsoId("_SyG5Qtp-Ed-ak6NoX_4Aeg_-1065902149")]
    [DisplayName("Residential Status")]
    [IsoXmlTag("ResdtlSts")]
    public required ResidentialStatus1Code ResidentialStatus { get; init; }
}
