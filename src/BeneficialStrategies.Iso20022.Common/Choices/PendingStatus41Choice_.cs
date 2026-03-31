// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason or no reason for the corporate action event processing pending status.
    /// </summary>
    [KnownType(typeof(PendingStatus41Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus41Choice.Reason))]
    [JsonDerivedType(
        typeof(PendingStatus41Choice.NoSpecifiedReason),
        nameof(PendingStatus41Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(PendingStatus41Choice.Reason), nameof(PendingStatus41Choice.Reason))]
    [IsoId("_tDTUwUGSEeWqy4niLuXETA")]
    [DisplayName("Pending Status 41 Choice")]
    public abstract record PendingStatus41Choice_ { }
}
