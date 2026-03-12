// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Transport key or key encryption key (KEK) for the recipient.
    /// </summary>
    [KnownType(typeof(Recipient11Choice.KeyTransport))]
    [KnownType(typeof(Recipient11Choice.KEK))]
    [KnownType(typeof(Recipient11Choice.KeyIdentifier))]
    [JsonDerivedType(typeof(Recipient11Choice.KeyTransport),nameof(Recipient11Choice.KeyTransport))]
    [JsonDerivedType(typeof(Recipient11Choice.KEK),nameof(Recipient11Choice.KEK))]
    [JsonDerivedType(typeof(Recipient11Choice.KeyIdentifier),nameof(Recipient11Choice.KeyIdentifier))]
    [IsoId("_6nK84VE0EeyApZmLzm74zA")]
    [DisplayName("Recipient 11 Choice")]
    public abstract partial record Recipient11Choice_
    {
    }
}
