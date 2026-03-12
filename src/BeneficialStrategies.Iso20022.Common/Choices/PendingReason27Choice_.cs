// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the pending reason.
    /// </summary>
    [KnownType(typeof(PendingReason27Choice.Code))]
    [KnownType(typeof(PendingReason27Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason27Choice.Code),nameof(PendingReason27Choice.Code))]
    [JsonDerivedType(typeof(PendingReason27Choice.Proprietary),nameof(PendingReason27Choice.Proprietary))]
    [IsoId("_i0sZwTqOEeWyoP0PbocV1Q")]
    [DisplayName("Pending Reason 27 Choice")]
    public abstract partial record PendingReason27Choice_
    {
    }
}
