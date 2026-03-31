// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Rate name specifies the reference rate or basis rate on which a variable rate is based (ex: EONIA, EURIBOR, LIBOR, FEFUND, EURREPO).
/// </summary>
[IsoId("_XO3Yc9p-Ed-ak6NoX_4Aeg_1105016861")]
[DisplayName("Rate Name")]
public record RateName2
{
    /// <summary>
    /// Entity that assigns the identification.
    /// </summary>
    [IsoId("_XO3YdNp-Ed-ak6NoX_4Aeg_-5894558")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax8Text)]
    [StringLength(maximumLength: 8, MinimumLength = 1)]
    public IsoRestrictedFINXMax8Text? Issuer { get; init; }

    /// <summary>
    /// Rate Name specifies the reference rate or basis rate on which a variable rate is based (ex: EONIA, EURIBOR, LIBOR, FEFUND, EURREPO).
    /// </summary>
    [IsoId("_XO3Yddp-Ed-ak6NoX_4Aeg_-2000039264")]
    [DisplayName("Rate Name")]
    [IsoXmlTag("RateNm")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax24Text)]
    [StringLength(maximumLength: 24, MinimumLength = 1)]
    public required IsoRestrictedFINXMax24Text RateName { get; init; }
}
