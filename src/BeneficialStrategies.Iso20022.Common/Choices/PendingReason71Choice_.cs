// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Pending Reason71Choice.
    /// </summary>
    [KnownType(typeof(PendingReason71Choice.Code))]
    [KnownType(typeof(PendingReason71Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason71Choice.Code),nameof(PendingReason71Choice.Code))]
    [JsonDerivedType(typeof(PendingReason71Choice.Proprietary),nameof(PendingReason71Choice.Proprietary))]
    [IsoId("_jWq6L5t3Ee-wQIOX0djF2w")]
    [DisplayName("Pending Reason71Choice")]
    public abstract partial record PendingReason71Choice_
    {
    }
}
