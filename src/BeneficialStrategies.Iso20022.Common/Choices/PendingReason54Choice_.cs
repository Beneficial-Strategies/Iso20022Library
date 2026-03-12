// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code and a proprietary code to specify the reason why the instruction/event has a pending status.
    /// </summary>
    [KnownType(typeof(PendingReason54Choice.Code))]
    [KnownType(typeof(PendingReason54Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason54Choice.Code),nameof(PendingReason54Choice.Code))]
    [JsonDerivedType(typeof(PendingReason54Choice.Proprietary),nameof(PendingReason54Choice.Proprietary))]
    [IsoId("_tHUrU-aEEemtTOaHuc_63w")]
    [DisplayName("Pending Reason 54 Choice")]
    public abstract partial record PendingReason54Choice_
    {
    }
}
