// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for a frequency, for example, the frequency of delivery of a statement.
    /// </summary>
    [KnownType(typeof(Frequency34Choice.Code))]
    [KnownType(typeof(Frequency34Choice.Proprietary))]
    [JsonDerivedType(typeof(Frequency34Choice.Code),nameof(Frequency34Choice.Code))]
    [JsonDerivedType(typeof(Frequency34Choice.Proprietary),nameof(Frequency34Choice.Proprietary))]
    [IsoId("_5ePNP5NLEeWGlc8L7oPDIg")]
    [DisplayName("Frequency 34 Choice")]
    public abstract partial record Frequency34Choice_
    {
    }
}
