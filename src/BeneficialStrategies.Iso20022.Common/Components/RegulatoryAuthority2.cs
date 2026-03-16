// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Entity requiring the regulatory reporting information.
/// </summary>
[IsoId("_Pc3bxNp-Ed-ak6NoX_4Aeg_-1526379440")]
[DisplayName("Regulatory Authority")]
public record RegulatoryAuthority2
{
    /// <summary>
    /// Name of the entity requiring the regulatory reporting information.
    /// </summary>
    [IsoId("_Pc3bxdp-Ed-ak6NoX_4Aeg_-1526379192")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? Name { get; init; }

    /// <summary>
    /// Country of the entity that requires the regulatory reporting information.
    /// </summary>
    [IsoId("_Pc3bxtp-Ed-ak6NoX_4Aeg_-1526379191")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public CountryCode? Country { get; init; }
}
