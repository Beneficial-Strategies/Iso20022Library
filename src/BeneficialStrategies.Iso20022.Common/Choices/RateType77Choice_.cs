// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify a rate type.
    /// </summary>
    [KnownType(typeof(RateType77Choice.Code))]
    [KnownType(typeof(RateType77Choice.Proprietary))]
    [JsonDerivedType(typeof(RateType77Choice.Code), nameof(RateType77Choice.Code))]
    [JsonDerivedType(typeof(RateType77Choice.Proprietary), nameof(RateType77Choice.Proprietary))]
    [IsoId("_OzSoLeXsEemEj48jhmlA0Q")]
    [DisplayName("Rate Type 77 Choice")]
    public abstract record RateType77Choice_ { }
}
