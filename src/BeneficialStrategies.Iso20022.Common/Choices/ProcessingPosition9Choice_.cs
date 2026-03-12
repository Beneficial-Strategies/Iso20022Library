// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing position.
    /// </summary>
    [KnownType(typeof(ProcessingPosition9Choice.Code))]
    [KnownType(typeof(ProcessingPosition9Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingPosition9Choice.Code),nameof(ProcessingPosition9Choice.Code))]
    [JsonDerivedType(typeof(ProcessingPosition9Choice.Proprietary),nameof(ProcessingPosition9Choice.Proprietary))]
    [IsoId("_0qDbcWaxEeWZev0W8F756g")]
    [DisplayName("Processing Position 9 Choice")]
    public abstract partial record ProcessingPosition9Choice_
    {
    }
}
