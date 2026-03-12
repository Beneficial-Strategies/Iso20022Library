// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between references used to reference a previous transaction.
    /// </summary>
    [KnownType(typeof(References63Choice.PreviousReference))]
    [KnownType(typeof(References63Choice.OtherReference))]
    [JsonDerivedType(typeof(References63Choice.PreviousReference),nameof(References63Choice.PreviousReference))]
    [JsonDerivedType(typeof(References63Choice.OtherReference),nameof(References63Choice.OtherReference))]
    [IsoId("_buTXIYiiEeefvMoXmllHqg")]
    [DisplayName("References 63 Choice")]
    public abstract partial record References63Choice_
    {
    }
}
