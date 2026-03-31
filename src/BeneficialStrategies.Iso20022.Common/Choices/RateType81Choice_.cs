// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify a rate type.
    /// </summary>
    [KnownType(typeof(RateType81Choice.Code))]
    [KnownType(typeof(RateType81Choice.Proprietary))]
    [JsonDerivedType(typeof(RateType81Choice.Code), nameof(RateType81Choice.Code))]
    [JsonDerivedType(typeof(RateType81Choice.Proprietary), nameof(RateType81Choice.Proprietary))]
    [IsoId("_-lkiHAVSEeqjd8n6wD9JVw")]
    [DisplayName("Rate Type 81 Choice")]
    public abstract record RateType81Choice_ { }
}
