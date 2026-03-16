// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Pending Reason69Choice.
    /// </summary>
    [KnownType(typeof(PendingReason69Choice.Code))]
    [KnownType(typeof(PendingReason69Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason69Choice.Code),nameof(PendingReason69Choice.Code))]
    [JsonDerivedType(typeof(PendingReason69Choice.Proprietary),nameof(PendingReason69Choice.Proprietary))]
    [IsoId("_x2VKkYcSEe-U27oWwgmhCQ")]
    [DisplayName("Pending Reason69Choice")]
    public abstract partial record PendingReason69Choice_
    {
    }
}
