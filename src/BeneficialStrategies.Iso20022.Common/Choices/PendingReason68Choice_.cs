// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Pending Reason68Choice.
    /// </summary>
    [KnownType(typeof(PendingReason68Choice.Code))]
    [KnownType(typeof(PendingReason68Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason68Choice.Code),nameof(PendingReason68Choice.Code))]
    [JsonDerivedType(typeof(PendingReason68Choice.Proprietary),nameof(PendingReason68Choice.Proprietary))]
    [IsoId("_UqcwpXSdEe6VWZz2tTgENw")]
    [DisplayName("Pending Reason68Choice")]
    public abstract partial record PendingReason68Choice_
    {
    }
}
