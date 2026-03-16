// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Transport key or key encryption key (KEK) for the recipient.
    /// </summary>
    [KnownType(typeof(Recipient7Choice.KeyTransport))]
    [KnownType(typeof(Recipient7Choice.KEK))]
    [KnownType(typeof(Recipient7Choice.KeyIdentifier))]
    [JsonDerivedType(typeof(Recipient7Choice.KeyTransport), nameof(Recipient7Choice.KeyTransport))]
    [JsonDerivedType(typeof(Recipient7Choice.KEK), nameof(Recipient7Choice.KEK))]
    [JsonDerivedType(
        typeof(Recipient7Choice.KeyIdentifier),
        nameof(Recipient7Choice.KeyIdentifier)
    )]
    [IsoId("__A-bsaRbEeeWXKXf3KjtmQ")]
    [DisplayName("Recipient 7 Choice")]
    public abstract record Recipient7Choice_ { }
}
