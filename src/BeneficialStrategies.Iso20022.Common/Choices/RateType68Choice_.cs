// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify a rate type.
    /// </summary>
    [KnownType(typeof(RateType68Choice.Code))]
    [KnownType(typeof(RateType68Choice.Proprietary))]
    [JsonDerivedType(typeof(RateType68Choice.Code),nameof(RateType68Choice.Code))]
    [JsonDerivedType(typeof(RateType68Choice.Proprietary),nameof(RateType68Choice.Proprietary))]
    [IsoId("_zZQ3nZb7Eee8S7xwGG7Veg")]
    [DisplayName("Rate Type 68 Choice")]
    public abstract partial record RateType68Choice_
    {
    }
}
