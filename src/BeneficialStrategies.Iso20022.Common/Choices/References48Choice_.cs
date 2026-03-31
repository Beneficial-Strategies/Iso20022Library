// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of references used to reference a previous transaction.
    /// </summary>
    [KnownType(typeof(References48Choice.PreviousReference))]
    [KnownType(typeof(References48Choice.OtherReference))]
    [JsonDerivedType(
        typeof(References48Choice.PreviousReference),
        nameof(References48Choice.PreviousReference)
    )]
    [JsonDerivedType(
        typeof(References48Choice.OtherReference),
        nameof(References48Choice.OtherReference)
    )]
    [IsoId("_dtj_USYrEeW_ZNn8gbfY7Q")]
    [DisplayName("References 48 Choice")]
    public abstract record References48Choice_ { }
}
