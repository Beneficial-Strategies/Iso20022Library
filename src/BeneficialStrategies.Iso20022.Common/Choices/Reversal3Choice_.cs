// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between reversal by reference or by reversal details.
    /// </summary>
    [KnownType(typeof(Reversal3Choice.References))]
    [KnownType(typeof(Reversal3Choice.TransferOutConfirmationDetails))]
    [JsonDerivedType(typeof(Reversal3Choice.References),nameof(Reversal3Choice.References))]
    [JsonDerivedType(typeof(Reversal3Choice.TransferOutConfirmationDetails),nameof(Reversal3Choice.TransferOutConfirmationDetails))]
    [IsoId("_QDN4oRX2EeOBE-jZfcm4KQ")]
    [DisplayName("Reversal 3 Choice")]
    public abstract partial record Reversal3Choice_
    {
    }
}
