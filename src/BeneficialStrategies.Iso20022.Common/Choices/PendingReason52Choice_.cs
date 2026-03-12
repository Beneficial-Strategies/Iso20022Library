// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the reason why a cancellation request sent for the related instruction is pending.
    /// </summary>
    [KnownType(typeof(PendingReason52Choice.Code))]
    [KnownType(typeof(PendingReason52Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason52Choice.Code),nameof(PendingReason52Choice.Code))]
    [JsonDerivedType(typeof(PendingReason52Choice.Proprietary),nameof(PendingReason52Choice.Proprietary))]
    [IsoId("_YmUaUOBiEeiVRbNQx5-Vhg")]
    [DisplayName("Pending Reason 52 Choice")]
    public abstract partial record PendingReason52Choice_
    {
    }
}
