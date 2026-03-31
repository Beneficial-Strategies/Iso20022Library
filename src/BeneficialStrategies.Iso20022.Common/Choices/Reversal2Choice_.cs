// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between reversal by reference or by reversal details.
    /// </summary>
    [KnownType(typeof(Reversal2Choice.Reference))]
    [KnownType(typeof(Reversal2Choice.TransferInConfirmationDetails))]
    [JsonDerivedType(typeof(Reversal2Choice.Reference), nameof(Reversal2Choice.Reference))]
    [JsonDerivedType(
        typeof(Reversal2Choice.TransferInConfirmationDetails),
        nameof(Reversal2Choice.TransferInConfirmationDetails)
    )]
    [IsoId("_PsjTARg4EeK-_89we2b-bA")]
    [DisplayName("Reversal 2 Choice")]
    public abstract record Reversal2Choice_ { }
}
