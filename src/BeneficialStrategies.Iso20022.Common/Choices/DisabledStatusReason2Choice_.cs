// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a disabled reason code.
    /// </summary>
    [KnownType(typeof(DisabledStatusReason2Choice.Code))]
    [KnownType(typeof(DisabledStatusReason2Choice.Proprietary))]
    [JsonDerivedType(
        typeof(DisabledStatusReason2Choice.Code),
        nameof(DisabledStatusReason2Choice.Code)
    )]
    [JsonDerivedType(
        typeof(DisabledStatusReason2Choice.Proprietary),
        nameof(DisabledStatusReason2Choice.Proprietary)
    )]
    [IsoId("_hNiggUzAEeafiMTDrtSnyw")]
    [DisplayName("Disabled Status Reason 2 Choice")]
    public abstract record DisabledStatusReason2Choice_ { }
}
