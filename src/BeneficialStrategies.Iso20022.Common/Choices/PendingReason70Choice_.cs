// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Pending Reason70Choice.
    /// </summary>
    [KnownType(typeof(PendingReason70Choice.Code))]
    [KnownType(typeof(PendingReason70Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason70Choice.Code), nameof(PendingReason70Choice.Code))]
    [JsonDerivedType(
        typeof(PendingReason70Choice.Proprietary),
        nameof(PendingReason70Choice.Proprietary)
    )]
    [IsoId("_spovw5B0Ee-COKgew96POA")]
    [DisplayName("Pending Reason70Choice")]
    public abstract record PendingReason70Choice_ { }
}
