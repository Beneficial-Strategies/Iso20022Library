// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the pending reason.
    /// </summary>
    [KnownType(typeof(PendingReason3Choice.Code))]
    [KnownType(typeof(PendingReason3Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason3Choice.Code), nameof(PendingReason3Choice.Code))]
    [JsonDerivedType(
        typeof(PendingReason3Choice.Proprietary),
        nameof(PendingReason3Choice.Proprietary)
    )]
    [IsoId("_UYBuM9p-Ed-ak6NoX_4Aeg_-707074176")]
    [DisplayName("Pending Reason 3 Choice")]
    public abstract record PendingReason3Choice_ { }
}
