// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between cancellation by transfer details or reference.
    /// </summary>
    [KnownType(typeof(Cancellation11Choice.CancellationByTransferInstructionDetails))]
    [KnownType(typeof(Cancellation11Choice.CancellationByReference))]
    [JsonDerivedType(
        typeof(Cancellation11Choice.CancellationByTransferInstructionDetails),
        nameof(Cancellation11Choice.CancellationByTransferInstructionDetails)
    )]
    [JsonDerivedType(
        typeof(Cancellation11Choice.CancellationByReference),
        nameof(Cancellation11Choice.CancellationByReference)
    )]
    [IsoId("_8SMzVSPvEeWQjryFgN2ITg")]
    [DisplayName("Cancellation 11 Choice")]
    public abstract record Cancellation11Choice_ { }
}
