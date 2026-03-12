// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Transport key or key encryption key (KEK) for the recipient.
    /// </summary>
    [KnownType(typeof(Recipient14Choice.KeyTransport))]
    [KnownType(typeof(Recipient14Choice.KEK))]
    [KnownType(typeof(Recipient14Choice.KeyIdentifier))]
    [JsonDerivedType(typeof(Recipient14Choice.KeyTransport),nameof(Recipient14Choice.KeyTransport))]
    [JsonDerivedType(typeof(Recipient14Choice.KEK),nameof(Recipient14Choice.KEK))]
    [JsonDerivedType(typeof(Recipient14Choice.KeyIdentifier),nameof(Recipient14Choice.KeyIdentifier))]
    [IsoId("_4LI2MXDEEe2MCaKO5AtGsA")]
    [DisplayName("Recipient 14 Choice")]
    public abstract partial record Recipient14Choice_
    {
    }
}
