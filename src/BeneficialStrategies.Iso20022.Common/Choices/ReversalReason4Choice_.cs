// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the reason for the reversal of the transaction.
    /// </summary>
    [KnownType(typeof(ReversalReason4Choice.Code))]
    [KnownType(typeof(ReversalReason4Choice.Proprietary))]
    [JsonDerivedType(typeof(ReversalReason4Choice.Code),nameof(ReversalReason4Choice.Code))]
    [JsonDerivedType(typeof(ReversalReason4Choice.Proprietary),nameof(ReversalReason4Choice.Proprietary))]
    [IsoId("_TQ8xYNp-Ed-ak6NoX_4Aeg_-340627899")]
    [DisplayName("Reversal Reason 4 Choice")]
    public abstract partial record ReversalReason4Choice_
    {
    }
}
