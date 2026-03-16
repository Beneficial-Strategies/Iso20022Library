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
[IsoId("_Q-niZdp-Ed-ak6NoX_4Aeg_-1174778269")]
[DisplayName("Rate Name")]
public record RateName1
{
    /// <summary>
    /// Entity that assigns the identification.
    /// </summary>
    [IsoId("_Q-niZtp-Ed-ak6NoX_4Aeg_-1174778268")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.Max8Text)]
    [StringLength(maximumLength: 8, MinimumLength = 1)]
    public IsoMax8Text? Issuer { get; init; }

    /// <summary>
    /// Rate Name specifies the reference rate or basis rate on which a variable rate is based (ex: EONIA, EURIBOR, LIBOR, FEFUND, EURREPO).
    /// </summary>
    [IsoId("_Q-niZ9p-Ed-ak6NoX_4Aeg_-1174778267")]
    [DisplayName("Rate Name")]
    [IsoXmlTag("RateNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text RateName { get; init; }
}
