// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the pending reason.
    /// </summary>
    [KnownType(typeof(PendingReason16Choice.Code))]
    [KnownType(typeof(PendingReason16Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason16Choice.Code), nameof(PendingReason16Choice.Code))]
    [JsonDerivedType(
        typeof(PendingReason16Choice.Proprietary),
        nameof(PendingReason16Choice.Proprietary)
    )]
    [IsoId("_mz-NT_41EeClUvPNHKL9Zw")]
    [DisplayName("Pending Reason 16 Choice")]
    public abstract record PendingReason16Choice_ { }
}
