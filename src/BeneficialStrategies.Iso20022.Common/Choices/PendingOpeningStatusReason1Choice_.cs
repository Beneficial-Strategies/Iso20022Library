// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a pending account opening status reason.
    /// </summary>
    [KnownType(typeof(PendingOpeningStatusReason1Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingOpeningStatusReason1Choice.Reason))]
    [JsonDerivedType(
        typeof(PendingOpeningStatusReason1Choice.NoSpecifiedReason),
        nameof(PendingOpeningStatusReason1Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(PendingOpeningStatusReason1Choice.Reason),
        nameof(PendingOpeningStatusReason1Choice.Reason)
    )]
    [IsoId("_gh55AWCJEeabZtzjEVWYCQ")]
    [DisplayName("Pending Opening Status Reason 1 Choice")]
    public abstract record PendingOpeningStatusReason1Choice_ { }
}
