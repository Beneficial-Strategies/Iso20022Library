// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a percentage rate or a rate name.
    /// </summary>
    [KnownType(typeof(RateOrName2Choice.Rate))]
    [KnownType(typeof(RateOrName2Choice.RateName))]
    [JsonDerivedType(typeof(RateOrName2Choice.Rate),nameof(RateOrName2Choice.Rate))]
    [JsonDerivedType(typeof(RateOrName2Choice.RateName),nameof(RateOrName2Choice.RateName))]
    [IsoId("_XO3Ydtp-Ed-ak6NoX_4Aeg_-1773453138")]
    [DisplayName("Rate Or Name 2 Choice")]
    public abstract partial record RateOrName2Choice_
    {
    }
}
