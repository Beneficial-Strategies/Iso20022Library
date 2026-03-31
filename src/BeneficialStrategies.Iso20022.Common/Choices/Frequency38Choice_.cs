// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the frequency.
    /// </summary>
    [KnownType(typeof(Frequency38Choice.Code))]
    [KnownType(typeof(Frequency38Choice.Proprietary))]
    [JsonDerivedType(typeof(Frequency38Choice.Code), nameof(Frequency38Choice.Code))]
    [JsonDerivedType(typeof(Frequency38Choice.Proprietary), nameof(Frequency38Choice.Proprietary))]
    [IsoId("_zRGl6TrwEeuD7rm9md9zvg")]
    [DisplayName("Frequency 38 Choice")]
    public abstract record Frequency38Choice_ { }
}
