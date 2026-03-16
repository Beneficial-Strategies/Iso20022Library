// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for a frequency, for example, the frequency of delivery of a statement.
    /// </summary>
    [KnownType(typeof(Frequency25Choice.Code))]
    [KnownType(typeof(Frequency25Choice.Proprietary))]
    [JsonDerivedType(typeof(Frequency25Choice.Code), nameof(Frequency25Choice.Code))]
    [JsonDerivedType(typeof(Frequency25Choice.Proprietary), nameof(Frequency25Choice.Proprietary))]
    [IsoId("_bo7ZATeNEeWm5uvLSn0jEw")]
    [DisplayName("Frequency 25 Choice")]
    public abstract record Frequency25Choice_ { }
}
