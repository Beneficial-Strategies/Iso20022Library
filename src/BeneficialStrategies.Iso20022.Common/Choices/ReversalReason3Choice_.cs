// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reason for the reversal of the transaction.
    /// </summary>
    [KnownType(typeof(ReversalReason3Choice.Code))]
    [KnownType(typeof(ReversalReason3Choice.Proprietary))]
    [JsonDerivedType(typeof(ReversalReason3Choice.Code),nameof(ReversalReason3Choice.Code))]
    [JsonDerivedType(typeof(ReversalReason3Choice.Proprietary),nameof(ReversalReason3Choice.Proprietary))]
    [IsoId("_V8nGZdp-Ed-ak6NoX_4Aeg_-801418464")]
    [DisplayName("Reversal Reason 3 Choice")]
    public abstract partial record ReversalReason3Choice_
    {
    }
}
