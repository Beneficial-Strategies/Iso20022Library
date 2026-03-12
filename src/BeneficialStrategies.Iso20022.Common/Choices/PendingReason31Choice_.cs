// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the pending reason.
    /// </summary>
    [KnownType(typeof(PendingReason31Choice.Code))]
    [KnownType(typeof(PendingReason31Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason31Choice.Code),nameof(PendingReason31Choice.Code))]
    [JsonDerivedType(typeof(PendingReason31Choice.Proprietary),nameof(PendingReason31Choice.Proprietary))]
    [IsoId("_qpuxgTw9EeW3QqUkIQtIUA")]
    [DisplayName("Pending Reason 31 Choice")]
    public abstract partial record PendingReason31Choice_
    {
    }
}
