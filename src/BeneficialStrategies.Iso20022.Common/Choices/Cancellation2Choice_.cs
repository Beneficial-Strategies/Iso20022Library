// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between cancellation by reference or by transfer details.
    /// </summary>
    [KnownType(typeof(Cancellation2Choice.Reference))]
    [KnownType(typeof(Cancellation2Choice.TransferInDetails))]
    [JsonDerivedType(typeof(Cancellation2Choice.Reference),nameof(Cancellation2Choice.Reference))]
    [JsonDerivedType(typeof(Cancellation2Choice.TransferInDetails),nameof(Cancellation2Choice.TransferInDetails))]
    [IsoId("_Nv8HQRg2EeK-_89we2b-bA")]
    [DisplayName("Cancellation 2 Choice")]
    public abstract partial record Cancellation2Choice_
    {
    }
}
