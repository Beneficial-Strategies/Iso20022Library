// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Status applying to the instruction cancellation request received.
    /// </summary>
    [KnownType(typeof(CancellationStatus27Choice.GlobalCancellationStatus))]
    [KnownType(typeof(CancellationStatus27Choice.DetailedCancellationStatus))]
    [JsonDerivedType(
        typeof(CancellationStatus27Choice.GlobalCancellationStatus),
        nameof(CancellationStatus27Choice.GlobalCancellationStatus)
    )]
    [JsonDerivedType(
        typeof(CancellationStatus27Choice.DetailedCancellationStatus),
        nameof(CancellationStatus27Choice.DetailedCancellationStatus)
    )]
    [IsoId("_xTJyQMT1Eem9aZlimxVUIw")]
    [DisplayName("Cancellation Status 27 Choice")]
    public abstract record CancellationStatus27Choice_ { }
}
