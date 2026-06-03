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
[IsoId("_ObBcUbZ6EfCUZfsQO4rYeA")]
[DisplayName("Security Parameters19")]
public record SecurityParameters19
{
    [IsoId("_ObBcVbZ6EfCUZfsQO4rYeA")]
    [DisplayName("Host Challenge")]
    [IsoXmlTag("HstChllng")]
    public IsoMax140Binary? HostChallenge { get; init; }

    [IsoId("_ObBcWbZ6EfCUZfsQO4rYeA")]
    [DisplayName("Key")]
    [IsoXmlTag("Key")]
    public ValueList<CryptographicKey21> Key { get; init; } = [];

    [IsoId("_ObBcXbZ6EfCUZfsQO4rYeA")]
    [DisplayName("Signature Choice")]
    [IsoXmlTag("SgntrChc")]
    public ATMSignature3Choice_? SignatureChoice_ { get; init; }
}
