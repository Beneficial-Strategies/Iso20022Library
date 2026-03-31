// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the place of safekeeping.
    /// </summary>
    [KnownType(typeof(SafekeepingPlaceFormatChoice.Identification))]
    [KnownType(typeof(SafekeepingPlaceFormatChoice.IdentificationAsDSS))]
    [KnownType(typeof(SafekeepingPlaceFormatChoice.IdentificationAsCountry))]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormatChoice.Identification),
        nameof(SafekeepingPlaceFormatChoice.Identification)
    )]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormatChoice.IdentificationAsDSS),
        nameof(SafekeepingPlaceFormatChoice.IdentificationAsDSS)
    )]
    [JsonDerivedType(
        typeof(SafekeepingPlaceFormatChoice.IdentificationAsCountry),
        nameof(SafekeepingPlaceFormatChoice.IdentificationAsCountry)
    )]
    [IsoId("_RB5f5Np-Ed-ak6NoX_4Aeg_-418949931")]
    [DisplayName("Safekeeping Place Format Choice")]
    public abstract record SafekeepingPlaceFormatChoice_ { }
}
