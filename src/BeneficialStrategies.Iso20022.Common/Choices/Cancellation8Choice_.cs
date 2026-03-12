// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between cancellation by reference or by transfer details.
    /// </summary>
    [KnownType(typeof(Cancellation8Choice.References))]
    [KnownType(typeof(Cancellation8Choice.TransferOutDetails))]
    [JsonDerivedType(typeof(Cancellation8Choice.References),nameof(Cancellation8Choice.References))]
    [JsonDerivedType(typeof(Cancellation8Choice.TransferOutDetails),nameof(Cancellation8Choice.TransferOutDetails))]
    [IsoId("_gwr8oT8BEeSIqOPJHpnleA")]
    [DisplayName("Cancellation 8 Choice")]
    public abstract partial record Cancellation8Choice_
    {
    }
}
