// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between reversal by reference or by reversal details.
    /// </summary>
    [KnownType(typeof(Reversal8Choice.References))]
    [KnownType(typeof(Reversal8Choice.TransferOutConfirmationDetails))]
    [JsonDerivedType(typeof(Reversal8Choice.References), nameof(Reversal8Choice.References))]
    [JsonDerivedType(
        typeof(Reversal8Choice.TransferOutConfirmationDetails),
        nameof(Reversal8Choice.TransferOutConfirmationDetails)
    )]
    [IsoId("_9pFttyPvEeWQjryFgN2ITg")]
    [DisplayName("Reversal 8 Choice")]
    public abstract record Reversal8Choice_ { }
}
