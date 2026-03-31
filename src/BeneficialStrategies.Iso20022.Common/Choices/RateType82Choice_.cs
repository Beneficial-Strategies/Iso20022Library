// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify a rate type.
    /// </summary>
    [KnownType(typeof(RateType82Choice.Code))]
    [KnownType(typeof(RateType82Choice.Proprietary))]
    [JsonDerivedType(typeof(RateType82Choice.Code), nameof(RateType82Choice.Code))]
    [JsonDerivedType(typeof(RateType82Choice.Proprietary), nameof(RateType82Choice.Proprietary))]
    [IsoId("_-lv7cwVSEeqjd8n6wD9JVw")]
    [DisplayName("Rate Type 82 Choice")]
    public abstract record RateType82Choice_ { }
}
