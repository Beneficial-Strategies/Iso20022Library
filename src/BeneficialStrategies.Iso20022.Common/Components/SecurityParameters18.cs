// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters related to the security of software application and application protocol.
/// </summary>
[IsoId("_ryErUbZ5EfCUZfsQO4rYeA")]
[DisplayName("Security Parameters18")]
public record SecurityParameters18
{
    /// <summary>
    /// Cryptographic key used to protect the key download.
    /// </summary>
    [IsoId("_ryErVbZ5EfCUZfsQO4rYeA")]
    [DisplayName("Key")]
    [IsoXmlTag("Key")]
    public CryptographicKey21? Key { get; init; }

    /// <summary>
    /// Element containing the signature.
    /// </summary>
    [IsoId("_ryErWbZ5EfCUZfsQO4rYeA")]
    [DisplayName("Signature Choice")]
    [IsoXmlTag("SgntrChc")]
    public ATMSignature3Choice_? SignatureChoice_ { get; init; }

    /// <summary>
    /// Ordered certificate chain of the asymmetric key encryption key, starting with the ATM certificate.
    /// </summary>
    [IsoId("_ryErXbZ5EfCUZfsQO4rYeA")]
    [DisplayName("Certificate")]
    [IsoXmlTag("Cert")]
    public SimpleValueList<IsoMax5000Binary> Certificate { get; init; } = [];

    /// <summary>
    /// Random value from the ATM to avoid message replay.
    /// </summary>
    [IsoId("_ryErYbZ5EfCUZfsQO4rYeA")]
    [DisplayName("ATM Challenge")]
    [IsoXmlTag("ATMChllng")]
    public IsoMax140Binary? ATMChallenge { get; init; }

    /// <summary>
    /// Requested key for downloading, depending on the key hierarchy used by the host.
    /// </summary>
    [IsoId("_ryErZbZ5EfCUZfsQO4rYeA")]
    [DisplayName("Requested Key")]
    [IsoXmlTag("ReqdKey")]
    public IsoMax35Text? RequestedKey { get; init; }
}
