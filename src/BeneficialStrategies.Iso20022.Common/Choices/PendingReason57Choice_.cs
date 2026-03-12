// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code and a proprietary code to specify the reason why the instruction/event has a pending status.
    /// </summary>
    [KnownType(typeof(PendingReason57Choice.Code))]
    [KnownType(typeof(PendingReason57Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason57Choice.Code),nameof(PendingReason57Choice.Code))]
    [JsonDerivedType(typeof(PendingReason57Choice.Proprietary),nameof(PendingReason57Choice.Proprietary))]
    [IsoId("_FxTUU-6KEeqc-LCjwLsUVg")]
    [DisplayName("Pending Reason 57 Choice")]
    public abstract partial record PendingReason57Choice_
    {
    }
}
