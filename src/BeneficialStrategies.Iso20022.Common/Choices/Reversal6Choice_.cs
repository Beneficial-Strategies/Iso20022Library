// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between reversal by reference or by reversal details.
    /// </summary>
    [KnownType(typeof(Reversal6Choice.Reference))]
    [KnownType(typeof(Reversal6Choice.TransferInConfirmationDetails))]
    [JsonDerivedType(typeof(Reversal6Choice.Reference),nameof(Reversal6Choice.Reference))]
    [JsonDerivedType(typeof(Reversal6Choice.TransferInConfirmationDetails),nameof(Reversal6Choice.TransferInConfirmationDetails))]
    [IsoId("_f7k5oT8BEeSIqOPJHpnleA")]
    [DisplayName("Reversal 6 Choice")]
    public abstract partial record Reversal6Choice_
    {
    }
}
