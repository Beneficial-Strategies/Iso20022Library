// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Data to be reconciled.
    /// </summary>
    [KnownType(typeof(ReconciliationMatchedStatus6Choice.Matched))]
    [KnownType(typeof(ReconciliationMatchedStatus6Choice.NotMatched))]
    [JsonDerivedType(typeof(ReconciliationMatchedStatus6Choice.Matched),nameof(ReconciliationMatchedStatus6Choice.Matched))]
    [JsonDerivedType(typeof(ReconciliationMatchedStatus6Choice.NotMatched),nameof(ReconciliationMatchedStatus6Choice.NotMatched))]
    [IsoId("_C1J2hf_oEemm3skPVSMJQg")]
    [DisplayName("Reconciliation Matched Status 6 Choice")]
    public abstract partial record ReconciliationMatchedStatus6Choice_
    {
    }
}
