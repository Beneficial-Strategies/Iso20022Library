// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between cancellation by reference or by transfer details.
    /// </summary>
    [KnownType(typeof(Cancellation5Choice.References))]
    [KnownType(typeof(Cancellation5Choice.TransferInDetails))]
    [JsonDerivedType(
        typeof(Cancellation5Choice.References),
        nameof(Cancellation5Choice.References)
    )]
    [JsonDerivedType(
        typeof(Cancellation5Choice.TransferInDetails),
        nameof(Cancellation5Choice.TransferInDetails)
    )]
    [IsoId("_GO-y4RYAEeOBE-jZfcm4KQ")]
    [DisplayName("Cancellation 5 Choice")]
    public abstract record Cancellation5Choice_ { }
}
