// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code and a proprietary code to specify the reason why the instruction/event has a pending status.
    /// </summary>
    [KnownType(typeof(PendingReason55Choice.Code))]
    [KnownType(typeof(PendingReason55Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason55Choice.Code),nameof(PendingReason55Choice.Code))]
    [JsonDerivedType(typeof(PendingReason55Choice.Proprietary),nameof(PendingReason55Choice.Proprietary))]
    [IsoId("_SzjgqwVREeqjd8n6wD9JVw")]
    [DisplayName("Pending Reason 55 Choice")]
    public abstract partial record PendingReason55Choice_
    {
    }
}
