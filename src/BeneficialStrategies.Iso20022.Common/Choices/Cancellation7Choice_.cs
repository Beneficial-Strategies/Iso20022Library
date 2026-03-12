// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between cancellation by transfer details or reference.
    /// </summary>
    [KnownType(typeof(Cancellation7Choice.CancellationByTransferInstructionDetails))]
    [KnownType(typeof(Cancellation7Choice.CancellationByReference))]
    [JsonDerivedType(typeof(Cancellation7Choice.CancellationByTransferInstructionDetails),nameof(Cancellation7Choice.CancellationByTransferInstructionDetails))]
    [JsonDerivedType(typeof(Cancellation7Choice.CancellationByReference),nameof(Cancellation7Choice.CancellationByReference))]
    [IsoId("_lZHWSQgMEeSFYfyUKDXKaw")]
    [DisplayName("Cancellation 7 Choice")]
    public abstract partial record Cancellation7Choice_
    {
    }
}
