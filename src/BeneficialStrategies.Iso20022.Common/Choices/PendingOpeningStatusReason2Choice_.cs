// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for pending account opening reason code.
    /// </summary>
    [KnownType(typeof(PendingOpeningStatusReason2Choice.Code))]
    [KnownType(typeof(PendingOpeningStatusReason2Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingOpeningStatusReason2Choice.Code),nameof(PendingOpeningStatusReason2Choice.Code))]
    [JsonDerivedType(typeof(PendingOpeningStatusReason2Choice.Proprietary),nameof(PendingOpeningStatusReason2Choice.Proprietary))]
    [IsoId("_xDGacWCJEeabZtzjEVWYCQ")]
    [DisplayName("Pending Opening Status Reason 2 Choice")]
    public abstract partial record PendingOpeningStatusReason2Choice_
    {
    }
}
