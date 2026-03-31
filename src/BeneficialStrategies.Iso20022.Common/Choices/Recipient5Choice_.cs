// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identification of a cryptographic asymmetric key.
    /// </summary>
    [KnownType(typeof(Recipient5Choice.IssuerAndSerialNumber))]
    [KnownType(typeof(Recipient5Choice.KeyIdentifier))]
    [JsonDerivedType(
        typeof(Recipient5Choice.IssuerAndSerialNumber),
        nameof(Recipient5Choice.IssuerAndSerialNumber)
    )]
    [JsonDerivedType(
        typeof(Recipient5Choice.KeyIdentifier),
        nameof(Recipient5Choice.KeyIdentifier)
    )]
    [IsoId("_0DRU0Wi0EeS87LmvcA55sg")]
    [DisplayName("Recipient 5 Choice")]
    public abstract record Recipient5Choice_ { }
}
