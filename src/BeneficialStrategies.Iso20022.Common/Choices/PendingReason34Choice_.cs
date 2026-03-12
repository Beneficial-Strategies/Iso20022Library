// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code and a proprietary code to specify the reason why the instruction/event has a pending status.
    /// </summary>
    [KnownType(typeof(PendingReason34Choice.Code))]
    [KnownType(typeof(PendingReason34Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason34Choice.Code),nameof(PendingReason34Choice.Code))]
    [JsonDerivedType(typeof(PendingReason34Choice.Proprietary),nameof(PendingReason34Choice.Proprietary))]
    [IsoId("_cel4S5KQEeWHWpTQn1FFVg")]
    [DisplayName("Pending Reason 34 Choice")]
    public abstract partial record PendingReason34Choice_
    {
    }
}
