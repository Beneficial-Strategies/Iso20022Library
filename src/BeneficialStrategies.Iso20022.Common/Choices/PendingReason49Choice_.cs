// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code and a proprietary code to specify the reason why the instruction/event has a pending status.
    /// </summary>
    [KnownType(typeof(PendingReason49Choice.Code))]
    [KnownType(typeof(PendingReason49Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason49Choice.Code),nameof(PendingReason49Choice.Code))]
    [JsonDerivedType(typeof(PendingReason49Choice.Proprietary),nameof(PendingReason49Choice.Proprietary))]
    [IsoId("_kov6v5wsEeazcsnODTksnQ")]
    [DisplayName("Pending Reason 49 Choice")]
    public abstract partial record PendingReason49Choice_
    {
    }
}
