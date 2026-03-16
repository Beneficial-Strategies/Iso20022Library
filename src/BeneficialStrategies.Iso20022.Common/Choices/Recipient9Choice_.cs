// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identification of a cryptographic asymmetric key.
    /// </summary>
    [KnownType(typeof(Recipient9Choice.IssuerAndSerialNumber))]
    [KnownType(typeof(Recipient9Choice.KeyIdentifier))]
    [JsonDerivedType(
        typeof(Recipient9Choice.IssuerAndSerialNumber),
        nameof(Recipient9Choice.IssuerAndSerialNumber)
    )]
    [JsonDerivedType(
        typeof(Recipient9Choice.KeyIdentifier),
        nameof(Recipient9Choice.KeyIdentifier)
    )]
    [IsoId("_Mns78S8jEeu125Ip9zFcsQ")]
    [DisplayName("Recipient 9 Choice")]
    public abstract record Recipient9Choice_ { }
}
