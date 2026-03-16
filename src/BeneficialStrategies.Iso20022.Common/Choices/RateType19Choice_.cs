// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code and or a data source scheme to determine the rate.
    /// </summary>
    [KnownType(typeof(RateType19Choice.Code))]
    [KnownType(typeof(RateType19Choice.Proprietary))]
    [JsonDerivedType(typeof(RateType19Choice.Code), nameof(RateType19Choice.Code))]
    [JsonDerivedType(typeof(RateType19Choice.Proprietary), nameof(RateType19Choice.Proprietary))]
    [IsoId("_GOYbkNoqEeCWg-hsBVGrDA_-428849870")]
    [DisplayName("Rate Type 19 Choice")]
    public abstract record RateType19Choice_ { }
}
