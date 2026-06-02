// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to security commands.
/// </summary>
[IsoId("_HuPQsbZ5EfCUZfsQO4rYeA")]
[DisplayName("ATM Security Context6")]
public record ATMSecurityContext6
{
    /// <summary>
    /// Key exchange security scheme in activation on the ATM for the host manager.
    /// </summary>
    [IsoId("_HvJPobZ5EfCUZfsQO4rYeA")]
    [DisplayName("Current Security Scheme")]
    [IsoXmlTag("CurSctySchme")]
    public required ATMSecurityScheme3Code CurrentSecurityScheme { get; init; }

    /// <summary>
    /// Key exchange security schemes implemented in the hardware security module of the ATM.
    /// </summary>
    [IsoId("_HvJPo7Z5EfCUZfsQO4rYeA")]
    [DisplayName("Security Scheme Capabilities")]
    [IsoXmlTag("SctySchmeCpblties")]
    public SimpleValueList<ATMSecurityScheme4Code> SecuritySchemeCapabilities { get; init; } = [];

    /// <summary>
    /// Hardware security module of the ATM.
    /// </summary>
    [IsoId("_HvJPpbZ5EfCUZfsQO4rYeA")]
    [DisplayName("Security Device")]
    [IsoXmlTag("SctyDvc")]
    public required ATMSecurityDevice2 SecurityDevice { get; init; }

    /// <summary>
    /// Cryptographic keys stored in the hardware security module of the ATM.
    /// </summary>
    [IsoId("_HvJPp7Z5EfCUZfsQO4rYeA")]
    [DisplayName("Key")]
    [IsoXmlTag("Key")]
    public ValueList<CryptographicKey20> Key { get; init; } = [];

    /// <summary>
    /// Random value from the host provided during a previous exchange.
    /// </summary>
    [IsoId("_HvJPqbZ5EfCUZfsQO4rYeA")]
    [DisplayName("Host Challenge")]
    [IsoXmlTag("HstChllng")]
    public IsoMax140Binary? HostChallenge { get; init; }
}
