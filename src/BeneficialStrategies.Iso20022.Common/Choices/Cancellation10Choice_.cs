// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between cancellation by reference or by transfer details.
    /// </summary>
    [KnownType(typeof(Cancellation10Choice.References))]
    [KnownType(typeof(Cancellation10Choice.TransferInDetails))]
    [JsonDerivedType(
        typeof(Cancellation10Choice.References),
        nameof(Cancellation10Choice.References)
    )]
    [JsonDerivedType(
        typeof(Cancellation10Choice.TransferInDetails),
        nameof(Cancellation10Choice.TransferInDetails)
    )]
    [IsoId("_4rvp9yPvEeWQjryFgN2ITg")]
    [DisplayName("Cancellation 10 Choice")]
    public abstract record Cancellation10Choice_ { }
}
