// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between reversal by reference or by reversal details.
    /// </summary>
    [KnownType(typeof(Reversal5Choice.References))]
    [KnownType(typeof(Reversal5Choice.TransferOutConfirmationDetails))]
    [JsonDerivedType(typeof(Reversal5Choice.References),nameof(Reversal5Choice.References))]
    [JsonDerivedType(typeof(Reversal5Choice.TransferOutConfirmationDetails),nameof(Reversal5Choice.TransferOutConfirmationDetails))]
    [IsoId("_eQwWkz8BEeSIqOPJHpnleA")]
    [DisplayName("Reversal 5 Choice")]
    public abstract partial record Reversal5Choice_
    {
    }
}
