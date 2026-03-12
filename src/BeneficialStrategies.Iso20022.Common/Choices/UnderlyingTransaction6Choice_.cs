// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides details of the underlying transaction, on which the investigation is processed.
    /// </summary>
    [KnownType(typeof(UnderlyingTransaction6Choice.Initiation))]
    [KnownType(typeof(UnderlyingTransaction6Choice.Interbank))]
    [KnownType(typeof(UnderlyingTransaction6Choice.StatementEntry))]
    [JsonDerivedType(typeof(UnderlyingTransaction6Choice.Initiation),nameof(UnderlyingTransaction6Choice.Initiation))]
    [JsonDerivedType(typeof(UnderlyingTransaction6Choice.Interbank),nameof(UnderlyingTransaction6Choice.Interbank))]
    [JsonDerivedType(typeof(UnderlyingTransaction6Choice.StatementEntry),nameof(UnderlyingTransaction6Choice.StatementEntry))]
    [IsoId("_xBEjS8loEem0vqvvoqYsqQ")]
    [DisplayName("Underlying Transaction 6 Choice")]
    public abstract partial record UnderlyingTransaction6Choice_
    {
    }
}
