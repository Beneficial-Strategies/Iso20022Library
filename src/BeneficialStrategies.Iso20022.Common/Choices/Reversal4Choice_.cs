// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between reversal by reference or by reversal details.
    /// </summary>
    [KnownType(typeof(Reversal4Choice.Reference))]
    [KnownType(typeof(Reversal4Choice.TransferInConfirmationDetails))]
    [JsonDerivedType(typeof(Reversal4Choice.Reference),nameof(Reversal4Choice.Reference))]
    [JsonDerivedType(typeof(Reversal4Choice.TransferInConfirmationDetails),nameof(Reversal4Choice.TransferInConfirmationDetails))]
    [IsoId("_PslE0RX3EeOBE-jZfcm4KQ")]
    [DisplayName("Reversal 4 Choice")]
    public abstract partial record Reversal4Choice_
    {
    }
}
