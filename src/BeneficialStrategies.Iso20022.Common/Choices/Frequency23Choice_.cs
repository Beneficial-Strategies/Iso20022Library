// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for a frequency, for example, a payment frequency.
    /// </summary>
    [KnownType(typeof(Frequency23Choice.Code))]
    [KnownType(typeof(Frequency23Choice.Proprietary))]
    [JsonDerivedType(typeof(Frequency23Choice.Code), nameof(Frequency23Choice.Code))]
    [JsonDerivedType(typeof(Frequency23Choice.Proprietary), nameof(Frequency23Choice.Proprietary))]
    [IsoId("_XpKWcTm_EeWV5sr121Fc8A")]
    [DisplayName("Frequency 23 Choice")]
    public abstract record Frequency23Choice_ { }
}
