// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between cancellation by transfer details or reference.
    /// </summary>
    [KnownType(typeof(Cancellation6Choice.CancellationByTransferInstructionDetails))]
    [KnownType(typeof(Cancellation6Choice.CancellationByReference))]
    [JsonDerivedType(
        typeof(Cancellation6Choice.CancellationByTransferInstructionDetails),
        nameof(Cancellation6Choice.CancellationByTransferInstructionDetails)
    )]
    [JsonDerivedType(
        typeof(Cancellation6Choice.CancellationByReference),
        nameof(Cancellation6Choice.CancellationByReference)
    )]
    [IsoId("_rcvlURwnEeOIveEnnb_1-A")]
    [DisplayName("Cancellation 6 Choice")]
    public abstract record Cancellation6Choice_ { }
}
