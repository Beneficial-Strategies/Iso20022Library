// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reason for the reversal of the transaction.
    /// </summary>
    [KnownType(typeof(ReversalReason1Choice.Code))]
    [KnownType(typeof(ReversalReason1Choice.Proprietary))]
    [JsonDerivedType(typeof(ReversalReason1Choice.Code), nameof(ReversalReason1Choice.Code))]
    [JsonDerivedType(
        typeof(ReversalReason1Choice.Proprietary),
        nameof(ReversalReason1Choice.Proprietary)
    )]
    [IsoId("_TPTyo9p-Ed-ak6NoX_4Aeg_672866376")]
    [DisplayName("Reversal Reason 1 Choice")]
    public abstract record ReversalReason1Choice_ { }
}
