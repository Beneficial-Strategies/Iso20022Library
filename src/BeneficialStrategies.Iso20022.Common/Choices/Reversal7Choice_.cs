// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between reversal by reference or by reversal details.
    /// </summary>
    [KnownType(typeof(Reversal7Choice.Reference))]
    [KnownType(typeof(Reversal7Choice.TransferInConfirmationDetails))]
    [JsonDerivedType(typeof(Reversal7Choice.Reference), nameof(Reversal7Choice.Reference))]
    [JsonDerivedType(
        typeof(Reversal7Choice.TransferInConfirmationDetails),
        nameof(Reversal7Choice.TransferInConfirmationDetails)
    )]
    [IsoId("_23jIcCPvEeWQjryFgN2ITg")]
    [DisplayName("Reversal 7 Choice")]
    public abstract record Reversal7Choice_ { }
}
