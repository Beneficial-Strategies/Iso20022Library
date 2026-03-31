// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of references used to reference a previous transaction.
    /// </summary>
    [KnownType(typeof(References62Choice.PreviousReference))]
    [KnownType(typeof(References62Choice.OtherReference))]
    [JsonDerivedType(
        typeof(References62Choice.PreviousReference),
        nameof(References62Choice.PreviousReference)
    )]
    [JsonDerivedType(
        typeof(References62Choice.OtherReference),
        nameof(References62Choice.OtherReference)
    )]
    [IsoId("_UvMkUUg9Eea8pJjypp-yMQ")]
    [DisplayName("References 62 Choice")]
    public abstract record References62Choice_ { }
}
