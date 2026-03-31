// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify a rate type.
    /// </summary>
    [KnownType(typeof(RateType44Choice.Code))]
    [KnownType(typeof(RateType44Choice.Proprietary))]
    [JsonDerivedType(typeof(RateType44Choice.Code), nameof(RateType44Choice.Code))]
    [JsonDerivedType(typeof(RateType44Choice.Proprietary), nameof(RateType44Choice.Proprietary))]
    [IsoId("_cj9gPZKQEeWHWpTQn1FFVg")]
    [DisplayName("Rate Type 44 Choice")]
    public abstract record RateType44Choice_ { }
}
