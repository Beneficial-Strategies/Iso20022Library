// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the pending reason.
    /// </summary>
    [KnownType(typeof(PendingReason63Choice.Code))]
    [KnownType(typeof(PendingReason63Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason63Choice.Code),nameof(PendingReason63Choice.Code))]
    [JsonDerivedType(typeof(PendingReason63Choice.Proprietary),nameof(PendingReason63Choice.Proprietary))]
    [IsoId("_d0YbsSW-EeygjNFjAlVoPA")]
    [DisplayName("Pending Reason 63 Choice")]
    public abstract partial record PendingReason63Choice_
    {
    }
}
