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
[IsoId("_lCc_AIr4EeSvuOJS0mmL0g")]
[DisplayName("ATM Security Context")]
public record ATMSecurityContext1
{
    /// <summary>
    /// Key exchange security scheme in activation on the ATM for the host manager.
    /// </summary>
    [IsoId("_dul6YIr5EeSvuOJS0mmL0g")]
    [DisplayName("Current Security Scheme")]
    [IsoXmlTag("CurSctySchme")]
    public required ATMSecurityScheme1Code CurrentSecurityScheme { get; init; }

    /// <summary>
    /// Key exchange security schemes implemented in the hardware security module of the ATM.
    /// </summary>
    [IsoId("_ydPTsIr5EeSvuOJS0mmL0g")]
    [DisplayName("Security Scheme Capabilities")]
    [IsoXmlTag("SctySchmeCpblties")]
    public SimpleValueList<ATMSecurityScheme2Code> SecuritySchemeCapabilities { get; init; } = [];

    /// <summary>
    /// Hardware security module of the ATM.
    /// </summary>
    [IsoId("_Ay-DIIr6EeSvuOJS0mmL0g")]
    [DisplayName("Security Device")]
    [IsoXmlTag("SctyDvc")]
    public required ATMSecurityDevice1 SecurityDevice { get; init; }

    /// <summary>
    /// Cryptographic keys stored in the hardware security module of the ATM.
    /// </summary>
    [IsoId("_AYkRYItCEeSxlKlAGYErFg")]
    [DisplayName("Key")]
    [IsoXmlTag("Key")]
    public ValueList<CryptographicKey7> Key { get; init; } = [];

    /// <summary>
    /// Random value from the host provided during a previous exchange.
    /// </summary>
    [IsoId("_D54KEItEEeSxlKlAGYErFg")]
    [DisplayName("Host Challenge")]
    [IsoXmlTag("HstChllng")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    public IsoMax140Binary? HostChallenge { get; init; }
}
