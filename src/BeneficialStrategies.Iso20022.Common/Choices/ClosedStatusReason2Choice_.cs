// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a closed reason code.
    /// </summary>
    [KnownType(typeof(ClosedStatusReason2Choice.Code))]
    [KnownType(typeof(ClosedStatusReason2Choice.Proprietary))]
    [JsonDerivedType(typeof(ClosedStatusReason2Choice.Code),nameof(ClosedStatusReason2Choice.Code))]
    [JsonDerivedType(typeof(ClosedStatusReason2Choice.Proprietary),nameof(ClosedStatusReason2Choice.Proprietary))]
    [IsoId("_k4eZ0UzDEeafiMTDrtSnyw")]
    [DisplayName("Closed Status Reason 2 Choice")]
    public abstract partial record ClosedStatusReason2Choice_
    {
    }
}
