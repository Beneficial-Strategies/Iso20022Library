// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Transport key or key encryption key (KEK) for the recipient.
    /// </summary>
    [KnownType(typeof(Recipient8Choice.KeyTransport))]
    [KnownType(typeof(Recipient8Choice.KEK))]
    [KnownType(typeof(Recipient8Choice.KeyIdentifier))]
    [JsonDerivedType(typeof(Recipient8Choice.KeyTransport),nameof(Recipient8Choice.KeyTransport))]
    [JsonDerivedType(typeof(Recipient8Choice.KEK),nameof(Recipient8Choice.KEK))]
    [JsonDerivedType(typeof(Recipient8Choice.KeyIdentifier),nameof(Recipient8Choice.KeyIdentifier))]
    [IsoId("_D5gIcQxqEeqdx6buGpCCQw")]
    [DisplayName("Recipient 8 Choice")]
    public abstract partial record Recipient8Choice_
    {
    }
}
