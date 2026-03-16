// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of the reason.
    /// </summary>
    [KnownType(typeof(BlockedReason1Choice.Reason))]
    [KnownType(typeof(BlockedReason1Choice.Proprietary))]
    [JsonDerivedType(typeof(BlockedReason1Choice.Reason), nameof(BlockedReason1Choice.Reason))]
    [JsonDerivedType(
        typeof(BlockedReason1Choice.Proprietary),
        nameof(BlockedReason1Choice.Proprietary)
    )]
    [IsoId("_WFqMcxHdEeKVqeHljBM1MQ")]
    [DisplayName("Blocked Reason 1 Choice")]
    public abstract record BlockedReason1Choice_ { }
}
