// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the reason why the related instruction is cancelled, or the related cancellation request is executed.
    /// </summary>
    [KnownType(typeof(CancellationReason38Choice.Code))]
    [KnownType(typeof(CancellationReason38Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CancellationReason38Choice.Code),
        nameof(CancellationReason38Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CancellationReason38Choice.Proprietary),
        nameof(CancellationReason38Choice.Proprietary)
    )]
    [IsoId("_PYWmAOBOEeiVRbNQx5-Vhg")]
    [DisplayName("Cancellation Reason 38 Choice")]
    public abstract record CancellationReason38Choice_ { }
}
