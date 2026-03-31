// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between reversal by reference or by reversal details.
    /// </summary>
    [KnownType(typeof(Reversal1Choice.Reference))]
    [KnownType(typeof(Reversal1Choice.TransferOutConfirmationDetails))]
    [JsonDerivedType(typeof(Reversal1Choice.Reference), nameof(Reversal1Choice.Reference))]
    [JsonDerivedType(
        typeof(Reversal1Choice.TransferOutConfirmationDetails),
        nameof(Reversal1Choice.TransferOutConfirmationDetails)
    )]
    [IsoId("_PyuB4xg3EeK-_89we2b-bA")]
    [DisplayName("Reversal 1 Choice")]
    public abstract record Reversal1Choice_ { }
}
