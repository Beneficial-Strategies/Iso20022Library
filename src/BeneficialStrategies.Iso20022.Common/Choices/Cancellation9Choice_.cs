// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between cancellation by reference or by transfer details.
    /// </summary>
    [KnownType(typeof(Cancellation9Choice.References))]
    [KnownType(typeof(Cancellation9Choice.TransferInDetails))]
    [JsonDerivedType(typeof(Cancellation9Choice.References),nameof(Cancellation9Choice.References))]
    [JsonDerivedType(typeof(Cancellation9Choice.TransferInDetails),nameof(Cancellation9Choice.TransferInDetails))]
    [IsoId("_hl8wsT8BEeSIqOPJHpnleA")]
    [DisplayName("Cancellation 9 Choice")]
    public abstract partial record Cancellation9Choice_
    {
    }
}
