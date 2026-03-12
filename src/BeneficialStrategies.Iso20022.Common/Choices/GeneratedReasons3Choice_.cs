// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the generated reason.
    /// </summary>
    [KnownType(typeof(GeneratedReasons3Choice.Code))]
    [KnownType(typeof(GeneratedReasons3Choice.Proprietary))]
    [JsonDerivedType(typeof(GeneratedReasons3Choice.Code),nameof(GeneratedReasons3Choice.Code))]
    [JsonDerivedType(typeof(GeneratedReasons3Choice.Proprietary),nameof(GeneratedReasons3Choice.Proprietary))]
    [IsoId("_C2YFzSRhEeO8sskhVI3IDA")]
    [DisplayName("Generated Reasons 3 Choice")]
    public abstract partial record GeneratedReasons3Choice_
    {
    }
}
