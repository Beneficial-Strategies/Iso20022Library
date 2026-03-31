// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a closure pending status reason.
    /// </summary>
    [KnownType(typeof(ClosurePendingStatusReason1Choice.NoSpecifiedReason))]
    [KnownType(typeof(ClosurePendingStatusReason1Choice.Reason))]
    [JsonDerivedType(
        typeof(ClosurePendingStatusReason1Choice.NoSpecifiedReason),
        nameof(ClosurePendingStatusReason1Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(ClosurePendingStatusReason1Choice.Reason),
        nameof(ClosurePendingStatusReason1Choice.Reason)
    )]
    [IsoId("_UW638WCLEeabZtzjEVWYCQ")]
    [DisplayName("Closure Pending Status Reason 1 Choice")]
    public abstract record ClosurePendingStatusReason1Choice_ { }
}
