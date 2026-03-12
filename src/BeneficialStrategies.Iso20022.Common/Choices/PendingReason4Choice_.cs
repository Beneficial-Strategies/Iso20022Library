// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code and a proprietary code to specify the reason why the instruction/event has a pending status.
    /// </summary>
    [KnownType(typeof(PendingReason4Choice.Code))]
    [KnownType(typeof(PendingReason4Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason4Choice.Code),nameof(PendingReason4Choice.Code))]
    [JsonDerivedType(typeof(PendingReason4Choice.Proprietary),nameof(PendingReason4Choice.Proprietary))]
    [IsoId("_QxqEdtp-Ed-ak6NoX_4Aeg_-271238773")]
    [DisplayName("Pending Reason 4 Choice")]
    public abstract partial record PendingReason4Choice_
    {
    }
}
