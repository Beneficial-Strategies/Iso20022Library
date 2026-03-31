// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Transport key or key encryption key (KEK) for the recipient.
    /// </summary>
    [KnownType(typeof(Recipient4Choice.KeyTransport))]
    [KnownType(typeof(Recipient4Choice.KEK))]
    [KnownType(typeof(Recipient4Choice.KeyIdentifier))]
    [JsonDerivedType(typeof(Recipient4Choice.KeyTransport), nameof(Recipient4Choice.KeyTransport))]
    [JsonDerivedType(typeof(Recipient4Choice.KEK), nameof(Recipient4Choice.KEK))]
    [JsonDerivedType(
        typeof(Recipient4Choice.KeyIdentifier),
        nameof(Recipient4Choice.KeyIdentifier)
    )]
    [IsoId("_NoPZUWi0EeS87LmvcA55sg")]
    [DisplayName("Recipient 4 Choice")]
    public abstract record Recipient4Choice_ { }
}
