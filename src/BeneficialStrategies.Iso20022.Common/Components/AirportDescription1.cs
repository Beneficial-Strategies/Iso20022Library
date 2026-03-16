// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies an airport by its location and by its name.
/// </summary>
[IsoId("_SsSlINp-Ed-ak6NoX_4Aeg_-1395385132")]
[DisplayName("Airport Description")]
public record AirportDescription1
{
    /// <summary>
    /// Identifies the town where the airport is located. For example: London.
    /// </summary>
    [IsoId("_SsSlIdp-Ed-ak6NoX_4Aeg_-1352905988")]
    [DisplayName("Town")]
    [IsoXmlTag("Twn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Town { get; init; }

    /// <summary>
    /// Identifies the airport by its name. For example: Heathrow.
    /// </summary>
    [IsoId("_SsSlItp-Ed-ak6NoX_4Aeg_-1308575071")]
    [DisplayName("Airport Name")]
    [IsoXmlTag("AirprtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AirportName { get; init; }
}
