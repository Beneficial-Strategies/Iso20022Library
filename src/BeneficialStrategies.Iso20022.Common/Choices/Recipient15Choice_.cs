// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Recipient15Choice.
    /// </summary>
    [KnownType(typeof(Recipient15Choice.KEK))]
    [KnownType(typeof(Recipient15Choice.KeyIdentifier))]
    [KnownType(typeof(Recipient15Choice.KeyTransport))]
    [JsonDerivedType(typeof(Recipient15Choice.KEK),nameof(Recipient15Choice.KEK))]
    [JsonDerivedType(typeof(Recipient15Choice.KeyIdentifier),nameof(Recipient15Choice.KeyIdentifier))]
    [JsonDerivedType(typeof(Recipient15Choice.KeyTransport),nameof(Recipient15Choice.KeyTransport))]
    [IsoId("_bTfzcY-QEe6oobnCtR50kw")]
    [DisplayName("Recipient15Choice")]
    public abstract partial record Recipient15Choice_
    {
    }
}
