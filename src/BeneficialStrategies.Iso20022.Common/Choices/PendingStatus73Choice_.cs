// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Pending Status73Choice.
    /// </summary>
    [KnownType(typeof(PendingStatus73Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus73Choice.Reason))]
    [JsonDerivedType(
        typeof(PendingStatus73Choice.NoSpecifiedReason),
        nameof(PendingStatus73Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(PendingStatus73Choice.Reason), nameof(PendingStatus73Choice.Reason))]
    [IsoId("_xoLZ24cSEe-U27oWwgmhCQ")]
    [DisplayName("Pending Status73Choice")]
    public abstract record PendingStatus73Choice_ { }
}
