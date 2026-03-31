// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify a rate type.
    /// </summary>
    [KnownType(typeof(RateType71Choice.Code))]
    [KnownType(typeof(RateType71Choice.Proprietary))]
    [JsonDerivedType(typeof(RateType71Choice.Code), nameof(RateType71Choice.Code))]
    [JsonDerivedType(typeof(RateType71Choice.Proprietary), nameof(RateType71Choice.Proprietary))]
    [IsoId("_SwgKzZb9Eee8S7xwGG7Veg")]
    [DisplayName("Rate Type 71 Choice")]
    public abstract record RateType71Choice_ { }
}
