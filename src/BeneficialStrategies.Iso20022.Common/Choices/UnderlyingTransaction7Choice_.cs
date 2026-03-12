// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides details of the underlying transaction, on which the investigation is processed.
    /// </summary>
    [KnownType(typeof(UnderlyingTransaction7Choice.Initiation))]
    [KnownType(typeof(UnderlyingTransaction7Choice.Interbank))]
    [KnownType(typeof(UnderlyingTransaction7Choice.StatementEntry))]
    [JsonDerivedType(typeof(UnderlyingTransaction7Choice.Initiation),nameof(UnderlyingTransaction7Choice.Initiation))]
    [JsonDerivedType(typeof(UnderlyingTransaction7Choice.Interbank),nameof(UnderlyingTransaction7Choice.Interbank))]
    [JsonDerivedType(typeof(UnderlyingTransaction7Choice.StatementEntry),nameof(UnderlyingTransaction7Choice.StatementEntry))]
    [IsoId("_ef6I4dcZEeqRFcf2R4bPBw")]
    [DisplayName("Underlying Transaction 7 Choice")]
    public abstract partial record UnderlyingTransaction7Choice_
    {
    }
}
