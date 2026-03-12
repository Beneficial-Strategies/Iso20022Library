// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for pending reason code.
    /// </summary>
    [KnownType(typeof(PendingStatusReason2Choice.Code))]
    [KnownType(typeof(PendingStatusReason2Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingStatusReason2Choice.Code),nameof(PendingStatusReason2Choice.Code))]
    [JsonDerivedType(typeof(PendingStatusReason2Choice.Proprietary),nameof(PendingStatusReason2Choice.Proprietary))]
    [IsoId("_ttEt4UzBEeafiMTDrtSnyw")]
    [DisplayName("Pending Status Reason 2 Choice")]
    public abstract partial record PendingStatusReason2Choice_
    {
    }
}
