// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Transport key or key encryption key (KEK) for the recipient.
    /// </summary>
    [KnownType(typeof(Recipient3Choice.KeyTransport))]
    [KnownType(typeof(Recipient3Choice.KEK))]
    [KnownType(typeof(Recipient3Choice.KeyIdentifier))]
    [JsonDerivedType(typeof(Recipient3Choice.KeyTransport),nameof(Recipient3Choice.KeyTransport))]
    [JsonDerivedType(typeof(Recipient3Choice.KEK),nameof(Recipient3Choice.KEK))]
    [JsonDerivedType(typeof(Recipient3Choice.KeyIdentifier),nameof(Recipient3Choice.KeyIdentifier))]
    [IsoId("_k-l58S9eEeOlZIh7PImd0A")]
    [DisplayName("Recipient 3 Choice")]
    public abstract partial record Recipient3Choice_
    {
    }
}
