// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identification of a cryptographic asymmetric key.
    /// </summary>
    [KnownType(typeof(Recipient12Choice.IssuerAndSerialNumber))]
    [KnownType(typeof(Recipient12Choice.KeyIdentifier))]
    [JsonDerivedType(
        typeof(Recipient12Choice.IssuerAndSerialNumber),
        nameof(Recipient12Choice.IssuerAndSerialNumber)
    )]
    [JsonDerivedType(
        typeof(Recipient12Choice.KeyIdentifier),
        nameof(Recipient12Choice.KeyIdentifier)
    )]
    [IsoId("_TGwEoVFKEeyApZmLzm74zA")]
    [DisplayName("Recipient 12 Choice")]
    public abstract record Recipient12Choice_ { }
}
