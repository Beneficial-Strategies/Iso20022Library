// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing position.
    /// </summary>
    [KnownType(typeof(ProcessingPosition8Choice.Code))]
    [KnownType(typeof(ProcessingPosition8Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingPosition8Choice.Code),nameof(ProcessingPosition8Choice.Code))]
    [JsonDerivedType(typeof(ProcessingPosition8Choice.Proprietary),nameof(ProcessingPosition8Choice.Proprietary))]
    [IsoId("_l5LCHTt4EeW638lNyHKv7A")]
    [DisplayName("Processing Position 8 Choice")]
    public abstract partial record ProcessingPosition8Choice_
    {
    }
}
