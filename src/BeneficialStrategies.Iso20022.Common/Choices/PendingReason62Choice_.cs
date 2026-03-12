// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code and a proprietary code to specify the reason why the instruction/event has a pending status.
    /// </summary>
    [KnownType(typeof(PendingReason62Choice.Code))]
    [KnownType(typeof(PendingReason62Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason62Choice.Code),nameof(PendingReason62Choice.Code))]
    [JsonDerivedType(typeof(PendingReason62Choice.Proprietary),nameof(PendingReason62Choice.Proprietary))]
    [IsoId("_LVbm8xnzEeyroI8qKgB7Mg")]
    [DisplayName("Pending Reason 62 Choice")]
    public abstract partial record PendingReason62Choice_
    {
    }
}
