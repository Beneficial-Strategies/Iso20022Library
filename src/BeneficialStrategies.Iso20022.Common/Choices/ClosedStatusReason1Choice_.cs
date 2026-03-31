// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a closed status reason.
    /// </summary>
    [KnownType(typeof(ClosedStatusReason1Choice.NoSpecifiedReason))]
    [KnownType(typeof(ClosedStatusReason1Choice.Reason))]
    [JsonDerivedType(
        typeof(ClosedStatusReason1Choice.NoSpecifiedReason),
        nameof(ClosedStatusReason1Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(ClosedStatusReason1Choice.Reason),
        nameof(ClosedStatusReason1Choice.Reason)
    )]
    [IsoId("_UcK_cUzDEeafiMTDrtSnyw")]
    [DisplayName("Closed Status Reason 1 Choice")]
    public abstract record ClosedStatusReason1Choice_ { }
}
