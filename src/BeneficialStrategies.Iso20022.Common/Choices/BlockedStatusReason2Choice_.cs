// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a blocked status reason.
    /// </summary>
    [KnownType(typeof(BlockedStatusReason2Choice.NoSpecifiedReason))]
    [KnownType(typeof(BlockedStatusReason2Choice.Reason))]
    [JsonDerivedType(typeof(BlockedStatusReason2Choice.NoSpecifiedReason),nameof(BlockedStatusReason2Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(BlockedStatusReason2Choice.Reason),nameof(BlockedStatusReason2Choice.Reason))]
    [IsoId("_8TcccV1LEeagR5I1rq5oaw")]
    [DisplayName("Blocked Status Reason 2 Choice")]
    public abstract partial record BlockedStatusReason2Choice_
    {
    }
}
