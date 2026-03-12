// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for a frequency, for example, a payment frequency.
    /// </summary>
    [KnownType(typeof(Frequency27Choice.Code))]
    [KnownType(typeof(Frequency27Choice.Proprietary))]
    [JsonDerivedType(typeof(Frequency27Choice.Code),nameof(Frequency27Choice.Code))]
    [JsonDerivedType(typeof(Frequency27Choice.Proprietary),nameof(Frequency27Choice.Proprietary))]
    [IsoId("_5NZ7g5NLEeWGlc8L7oPDIg")]
    [DisplayName("Frequency 27 Choice")]
    public abstract partial record Frequency27Choice_
    {
    }
}
