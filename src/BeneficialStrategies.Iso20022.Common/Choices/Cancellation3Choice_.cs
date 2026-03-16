// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between cancellation by transfer details or reference.
    /// </summary>
    [KnownType(typeof(Cancellation3Choice.CancellationByTransferInstructionDetails))]
    [KnownType(typeof(Cancellation3Choice.CancellationByReference))]
    [JsonDerivedType(
        typeof(Cancellation3Choice.CancellationByTransferInstructionDetails),
        nameof(Cancellation3Choice.CancellationByTransferInstructionDetails)
    )]
    [JsonDerivedType(
        typeof(Cancellation3Choice.CancellationByReference),
        nameof(Cancellation3Choice.CancellationByReference)
    )]
    [IsoId("_uMEusycZEeK33eWt3gq4Fg")]
    [DisplayName("Cancellation 3 Choice")]
    public abstract record Cancellation3Choice_ { }
}
