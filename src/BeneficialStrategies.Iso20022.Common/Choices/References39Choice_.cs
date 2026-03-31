// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of references used to reference a previous transaction.
    /// </summary>
    [KnownType(typeof(References39Choice.PreviousReference))]
    [KnownType(typeof(References39Choice.OtherReference))]
    [JsonDerivedType(
        typeof(References39Choice.PreviousReference),
        nameof(References39Choice.PreviousReference)
    )]
    [JsonDerivedType(
        typeof(References39Choice.OtherReference),
        nameof(References39Choice.OtherReference)
    )]
    [IsoId("_Qc5n0R6lEeOolf0-cMYhrw")]
    [DisplayName("References 39 Choice")]
    public abstract record References39Choice_ { }
}
