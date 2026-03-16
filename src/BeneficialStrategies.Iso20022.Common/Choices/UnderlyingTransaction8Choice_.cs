// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Underlying Transaction8Choice.
    /// </summary>
    [KnownType(typeof(UnderlyingTransaction8Choice.Initiation))]
    [KnownType(typeof(UnderlyingTransaction8Choice.Interbank))]
    [KnownType(typeof(UnderlyingTransaction8Choice.StatementEntry))]
    [JsonDerivedType(typeof(UnderlyingTransaction8Choice.Initiation),nameof(UnderlyingTransaction8Choice.Initiation))]
    [JsonDerivedType(typeof(UnderlyingTransaction8Choice.Interbank),nameof(UnderlyingTransaction8Choice.Interbank))]
    [JsonDerivedType(typeof(UnderlyingTransaction8Choice.StatementEntry),nameof(UnderlyingTransaction8Choice.StatementEntry))]
    [IsoId("_7j6B4TEsEe6GxLzpkVnWYg")]
    [DisplayName("Underlying Transaction8Choice")]
    public abstract partial record UnderlyingTransaction8Choice_
    {
    }
}
