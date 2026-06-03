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
    [IsoId("_ryErVbZ5EfCUZfsQO4rYeA")]
    [DisplayName("Key")]
    [IsoXmlTag("Key")]
    public CryptographicKey21? Key { get; init; }

    [IsoId("_ryErWbZ5EfCUZfsQO4rYeA")]
    [DisplayName("Signature Choice")]
    [IsoXmlTag("SgntrChc")]
    public ATMSignature3Choice? SignatureChoice { get; init; }

    [IsoId("_ryErXbZ5EfCUZfsQO4rYeA")]
    [DisplayName("Certificate")]
    [IsoXmlTag("Cert")]
    public SimpleValueList<IsoMax5000Binary> Certificate { get; init; } = [];

    [IsoId("_ryErYbZ5EfCUZfsQO4rYeA")]
    [DisplayName("ATM Challenge")]
    [IsoXmlTag("ATMChllng")]
    public IsoMax140Binary? ATMChallenge { get; init; }

    [IsoId("_ryErZbZ5EfCUZfsQO4rYeA")]
    [DisplayName("Requested Key")]
    [IsoXmlTag("ReqdKey")]
    public IsoMax35Text? RequestedKey { get; init; }
}
