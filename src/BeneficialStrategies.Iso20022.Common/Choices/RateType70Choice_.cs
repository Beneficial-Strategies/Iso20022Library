// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify a rate type.
    /// </summary>
    [KnownType(typeof(RateType70Choice.Code))]
    [KnownType(typeof(RateType70Choice.Proprietary))]
    [JsonDerivedType(typeof(RateType70Choice.Code), nameof(RateType70Choice.Code))]
    [JsonDerivedType(typeof(RateType70Choice.Proprietary), nameof(RateType70Choice.Proprietary))]
    [IsoId("_6gnfUZb8Eee8S7xwGG7Veg")]
    [DisplayName("Rate Type 70 Choice")]
    public abstract record RateType70Choice_ { }
}
