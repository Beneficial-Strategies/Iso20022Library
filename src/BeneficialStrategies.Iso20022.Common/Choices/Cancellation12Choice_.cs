// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between cancellation by reference or by transfer details.
    /// </summary>
    [KnownType(typeof(Cancellation12Choice.References))]
    [KnownType(typeof(Cancellation12Choice.TransferOutDetails))]
    [JsonDerivedType(typeof(Cancellation12Choice.References),nameof(Cancellation12Choice.References))]
    [JsonDerivedType(typeof(Cancellation12Choice.TransferOutDetails),nameof(Cancellation12Choice.TransferOutDetails))]
    [IsoId("__8PcLSPvEeWQjryFgN2ITg")]
    [DisplayName("Cancellation 12 Choice")]
    public abstract partial record Cancellation12Choice_
    {
    }
}
