// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between cancellation by reference or by transfer details.
    /// </summary>
    [KnownType(typeof(Cancellation4Choice.References))]
    [KnownType(typeof(Cancellation4Choice.TransferOutDetails))]
    [JsonDerivedType(typeof(Cancellation4Choice.References),nameof(Cancellation4Choice.References))]
    [JsonDerivedType(typeof(Cancellation4Choice.TransferOutDetails),nameof(Cancellation4Choice.TransferOutDetails))]
    [IsoId("_d8mKoRXzEeOBE-jZfcm4KQ")]
    [DisplayName("Cancellation 4 Choice")]
    public abstract partial record Cancellation4Choice_
    {
    }
}
