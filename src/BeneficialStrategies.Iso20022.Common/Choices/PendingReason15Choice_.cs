// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the pending reason.
    /// </summary>
    [KnownType(typeof(PendingReason15Choice.Code))]
    [KnownType(typeof(PendingReason15Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason15Choice.Code),nameof(PendingReason15Choice.Code))]
    [JsonDerivedType(typeof(PendingReason15Choice.Proprietary),nameof(PendingReason15Choice.Proprietary))]
    [IsoId("_Qg1iRf41EeClUvPNHKL9Zw")]
    [DisplayName("Pending Reason 15 Choice")]
    public abstract partial record PendingReason15Choice_
    {
    }
}
