// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a disabled status reason.
    /// </summary>
    [KnownType(typeof(DisabledStatusReason1Choice.NoSpecifiedReason))]
    [KnownType(typeof(DisabledStatusReason1Choice.Reason))]
    [JsonDerivedType(
        typeof(DisabledStatusReason1Choice.NoSpecifiedReason),
        nameof(DisabledStatusReason1Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(DisabledStatusReason1Choice.Reason),
        nameof(DisabledStatusReason1Choice.Reason)
    )]
    [IsoId("_RfDOYUzAEeafiMTDrtSnyw")]
    [DisplayName("Disabled Status Reason 1 Choice")]
    public abstract record DisabledStatusReason1Choice_ { }
}
