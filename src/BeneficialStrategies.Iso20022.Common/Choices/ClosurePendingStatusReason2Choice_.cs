// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a closure pending reason code.
    /// </summary>
    [KnownType(typeof(ClosurePendingStatusReason2Choice.Code))]
    [KnownType(typeof(ClosurePendingStatusReason2Choice.Proprietary))]
    [JsonDerivedType(typeof(ClosurePendingStatusReason2Choice.Code),nameof(ClosurePendingStatusReason2Choice.Code))]
    [JsonDerivedType(typeof(ClosurePendingStatusReason2Choice.Proprietary),nameof(ClosurePendingStatusReason2Choice.Proprietary))]
    [IsoId("_8xEykWCLEeabZtzjEVWYCQ")]
    [DisplayName("Closure Pending Status Reason 2 Choice")]
    public abstract partial record ClosurePendingStatusReason2Choice_
    {
    }
}
