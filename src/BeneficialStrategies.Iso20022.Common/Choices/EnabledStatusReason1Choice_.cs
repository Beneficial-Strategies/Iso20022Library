// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for an enabled status reason.
    /// </summary>
    [KnownType(typeof(EnabledStatusReason1Choice.NoSpecifiedReason))]
    [KnownType(typeof(EnabledStatusReason1Choice.Reason))]
    [JsonDerivedType(
        typeof(EnabledStatusReason1Choice.NoSpecifiedReason),
        nameof(EnabledStatusReason1Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(EnabledStatusReason1Choice.Reason),
        nameof(EnabledStatusReason1Choice.Reason)
    )]
    [IsoId("_z9anYEy9EeafiMTDrtSnyw")]
    [DisplayName("Enabled Status Reason 1 Choice")]
    public abstract record EnabledStatusReason1Choice_ { }
}
