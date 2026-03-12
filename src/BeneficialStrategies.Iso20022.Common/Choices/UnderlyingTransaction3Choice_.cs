// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the details of the underlying transaction on which the investigation is processed.
    /// </summary>
    [KnownType(typeof(UnderlyingTransaction3Choice.Initiation))]
    [KnownType(typeof(UnderlyingTransaction3Choice.Interbank))]
    [KnownType(typeof(UnderlyingTransaction3Choice.StatementEntry))]
    [JsonDerivedType(typeof(UnderlyingTransaction3Choice.Initiation),nameof(UnderlyingTransaction3Choice.Initiation))]
    [JsonDerivedType(typeof(UnderlyingTransaction3Choice.Interbank),nameof(UnderlyingTransaction3Choice.Interbank))]
    [JsonDerivedType(typeof(UnderlyingTransaction3Choice.StatementEntry),nameof(UnderlyingTransaction3Choice.StatementEntry))]
    [IsoId("_Xq7UAWXpEeap-P22vGV91g")]
    [DisplayName("Underlying Transaction 3 Choice")]
    public abstract partial record UnderlyingTransaction3Choice_
    {
    }
}
