// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the frequency.
    /// </summary>
    [KnownType(typeof(Frequency19Choice.Code))]
    [KnownType(typeof(Frequency19Choice.Proprietary))]
    [JsonDerivedType(typeof(Frequency19Choice.Code),nameof(Frequency19Choice.Code))]
    [JsonDerivedType(typeof(Frequency19Choice.Proprietary),nameof(Frequency19Choice.Proprietary))]
    [IsoId("_L6yAgxdGEeK5g-3oYI0_9Q")]
    [DisplayName("Frequency 19 Choice")]
    public abstract partial record Frequency19Choice_
    {
    }
}
