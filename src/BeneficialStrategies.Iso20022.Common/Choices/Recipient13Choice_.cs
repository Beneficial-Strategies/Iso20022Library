// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identification of a cryptographic asymmetric key.
    /// </summary>
    [KnownType(typeof(Recipient13Choice.IssuerAndSerialNumber))]
    [KnownType(typeof(Recipient13Choice.SubjectKeyIdentifier))]
    [JsonDerivedType(
        typeof(Recipient13Choice.IssuerAndSerialNumber),
        nameof(Recipient13Choice.IssuerAndSerialNumber)
    )]
    [JsonDerivedType(
        typeof(Recipient13Choice.SubjectKeyIdentifier),
        nameof(Recipient13Choice.SubjectKeyIdentifier)
    )]
    [IsoId("_huWK8XDCEe2MCaKO5AtGsA")]
    [DisplayName("Recipient 13 Choice")]
    public abstract record Recipient13Choice_ { }
}
