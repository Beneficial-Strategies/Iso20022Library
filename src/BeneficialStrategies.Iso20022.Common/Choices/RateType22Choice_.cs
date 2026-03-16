// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify a rate type.
    /// </summary>
    [KnownType(typeof(RateType22Choice.Code))]
    [KnownType(typeof(RateType22Choice.Proprietary))]
    [JsonDerivedType(typeof(RateType22Choice.Code), nameof(RateType22Choice.Code))]
    [JsonDerivedType(typeof(RateType22Choice.Proprietary), nameof(RateType22Choice.Proprietary))]
    [IsoId("_kaL_IRLnEeKJ5uSjVyVvug")]
    [DisplayName("Rate Type 22 Choice")]
    public abstract record RateType22Choice_ { }
}
