// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the cancellation processing status.
    /// </summary>
    [KnownType(typeof(CancellationReason39Choice.NoSpecifiedReason))]
    [KnownType(typeof(CancellationReason39Choice.Reason))]
    [JsonDerivedType(typeof(CancellationReason39Choice.NoSpecifiedReason),nameof(CancellationReason39Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(CancellationReason39Choice.Reason),nameof(CancellationReason39Choice.Reason))]
    [IsoId("_l0B_2Qd4Ee2fOITqoTnSLQ")]
    [DisplayName("Cancellation Reason 39 Choice")]
    public abstract partial record CancellationReason39Choice_
    {
    }
}
