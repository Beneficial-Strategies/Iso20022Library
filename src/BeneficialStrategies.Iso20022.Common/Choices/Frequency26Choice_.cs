// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for a frequency, for example, the frequency of delivery of a statement.
    /// </summary>
    [KnownType(typeof(Frequency26Choice.Code))]
    [KnownType(typeof(Frequency26Choice.Proprietary))]
    [JsonDerivedType(typeof(Frequency26Choice.Code), nameof(Frequency26Choice.Code))]
    [JsonDerivedType(typeof(Frequency26Choice.Proprietary), nameof(Frequency26Choice.Proprietary))]
    [IsoId("_cfq1s5KQEeWHWpTQn1FFVg")]
    [DisplayName("Frequency 26 Choice")]
    public abstract record Frequency26Choice_ { }
}
