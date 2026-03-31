// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the cancellation reason.
    /// </summary>
    [KnownType(typeof(CancellationReason3Choice.Code))]
    [KnownType(typeof(CancellationReason3Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CancellationReason3Choice.Code),
        nameof(CancellationReason3Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CancellationReason3Choice.Proprietary),
        nameof(CancellationReason3Choice.Proprietary)
    )]
    [IsoId("_UXIWUtp-Ed-ak6NoX_4Aeg_1224525165")]
    [DisplayName("Cancellation Reason 3 Choice")]
    public abstract record CancellationReason3Choice_ { }
}
