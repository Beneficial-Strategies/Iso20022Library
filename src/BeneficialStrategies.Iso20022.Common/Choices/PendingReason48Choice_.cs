// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code and a proprietary code to specify the reason why the instruction/event has a pending status.
    /// </summary>
    [KnownType(typeof(PendingReason48Choice.Code))]
    [KnownType(typeof(PendingReason48Choice.Proprietary))]
    [JsonDerivedType(typeof(PendingReason48Choice.Code), nameof(PendingReason48Choice.Code))]
    [JsonDerivedType(
        typeof(PendingReason48Choice.Proprietary),
        nameof(PendingReason48Choice.Proprietary)
    )]
    [IsoId("_SfAJ04lsEeavwKddCbm3hg")]
    [DisplayName("Pending Reason 48 Choice")]
    public abstract record PendingReason48Choice_ { }
}
