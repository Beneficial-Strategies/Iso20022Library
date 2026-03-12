// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a pending status reason.
    /// </summary>
    [KnownType(typeof(PendingStatusReason1Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatusReason1Choice.Reason))]
    [JsonDerivedType(typeof(PendingStatusReason1Choice.NoSpecifiedReason),nameof(PendingStatusReason1Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingStatusReason1Choice.Reason),nameof(PendingStatusReason1Choice.Reason))]
    [IsoId("_xW80EUzAEeafiMTDrtSnyw")]
    [DisplayName("Pending Status Reason 1 Choice")]
    public abstract partial record PendingStatusReason1Choice_
    {
    }
}
