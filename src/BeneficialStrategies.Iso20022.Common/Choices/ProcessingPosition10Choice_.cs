// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing position.
    /// </summary>
    [KnownType(typeof(ProcessingPosition10Choice.Code))]
    [KnownType(typeof(ProcessingPosition10Choice.Proprietary))]
    [JsonDerivedType(typeof(ProcessingPosition10Choice.Code),nameof(ProcessingPosition10Choice.Code))]
    [JsonDerivedType(typeof(ProcessingPosition10Choice.Proprietary),nameof(ProcessingPosition10Choice.Proprietary))]
    [IsoId("_chT0q5KQEeWHWpTQn1FFVg")]
    [DisplayName("Processing Position 10 Choice")]
    public abstract partial record ProcessingPosition10Choice_
    {
    }
}
