// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between references used to reference a previous transaction.
    /// </summary>
    [KnownType(typeof(References68Choice.PreviousReference))]
    [KnownType(typeof(References68Choice.OtherReference))]
    [JsonDerivedType(
        typeof(References68Choice.PreviousReference),
        nameof(References68Choice.PreviousReference)
    )]
    [JsonDerivedType(
        typeof(References68Choice.OtherReference),
        nameof(References68Choice.OtherReference)
    )]
    [IsoId("_HBeuoZGrEem-9Y6mq5ZH3Q")]
    [DisplayName("References 68 Choice")]
    public abstract record References68Choice_ { }
}
