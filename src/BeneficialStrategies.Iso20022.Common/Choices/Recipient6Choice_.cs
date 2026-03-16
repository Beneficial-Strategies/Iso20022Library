// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Transport key or key encryption key (KEK) for the recipient.
    /// </summary>
    [KnownType(typeof(Recipient6Choice.KeyTransport))]
    [KnownType(typeof(Recipient6Choice.KEK))]
    [KnownType(typeof(Recipient6Choice.KeyIdentifier))]
    [JsonDerivedType(typeof(Recipient6Choice.KeyTransport), nameof(Recipient6Choice.KeyTransport))]
    [JsonDerivedType(typeof(Recipient6Choice.KEK), nameof(Recipient6Choice.KEK))]
    [JsonDerivedType(
        typeof(Recipient6Choice.KeyIdentifier),
        nameof(Recipient6Choice.KeyIdentifier)
    )]
    [IsoId("__h4SMds2Eee9e6xduATmQg")]
    [DisplayName("Recipient 6 Choice")]
    public abstract record Recipient6Choice_ { }
}
