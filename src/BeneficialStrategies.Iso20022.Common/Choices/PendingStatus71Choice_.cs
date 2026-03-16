// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Pending Status71Choice.
    /// </summary>
    [KnownType(typeof(PendingStatus71Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus71Choice.Reason))]
    [JsonDerivedType(
        typeof(PendingStatus71Choice.NoSpecifiedReason),
        nameof(PendingStatus71Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(PendingStatus71Choice.Reason), nameof(PendingStatus71Choice.Reason))]
    [IsoId("_HpclQWHeEe6yt_d72zQZeQ")]
    [DisplayName("Pending Status71Choice")]
    public abstract record PendingStatus71Choice_ { }
}
