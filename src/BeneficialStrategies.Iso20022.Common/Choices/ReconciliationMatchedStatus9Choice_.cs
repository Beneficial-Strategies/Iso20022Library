// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Data to be reconciled.
    /// </summary>
    [KnownType(typeof(ReconciliationMatchedStatus9Choice.Matched))]
    [KnownType(typeof(ReconciliationMatchedStatus9Choice.NotMatched))]
    [JsonDerivedType(
        typeof(ReconciliationMatchedStatus9Choice.Matched),
        nameof(ReconciliationMatchedStatus9Choice.Matched)
    )]
    [JsonDerivedType(
        typeof(ReconciliationMatchedStatus9Choice.NotMatched),
        nameof(ReconciliationMatchedStatus9Choice.NotMatched)
    )]
    [IsoId("_Av6qZcK3EeuFNp8LZAnorg")]
    [DisplayName("Reconciliation Matched Status 9 Choice")]
    public abstract record ReconciliationMatchedStatus9Choice_ { }
}
