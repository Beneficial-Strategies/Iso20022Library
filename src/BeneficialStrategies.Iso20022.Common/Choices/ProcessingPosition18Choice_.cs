// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing position.
    /// </summary>
    [KnownType(typeof(ProcessingPosition18Choice.Code))]
    [KnownType(typeof(ProcessingPosition18Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingPosition18Choice.Code),nameof(ProcessingPosition18Choice.Code))]
    [JsonDerivedType(typeof(ProcessingPosition18Choice.Proprietary),nameof(ProcessingPosition18Choice.Proprietary))]
    [IsoId("_6GWWc5NLEeWGlc8L7oPDIg")]
    [DisplayName("Processing Position 18 Choice")]
    public abstract partial record ProcessingPosition18Choice_
    {
    }
}
