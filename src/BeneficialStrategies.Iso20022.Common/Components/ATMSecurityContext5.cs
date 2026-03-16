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
[IsoId("_VbtT4bTlEeeQy4o2AayYHg")]
[DisplayName("ATM Security Context")]
public record ATMSecurityContext5
{
    /// <summary>
    /// Key exchange security scheme in activation on the ATM for the host manager.
    /// </summary>
    [IsoId("_VkuF8bTlEeeQy4o2AayYHg")]
    [DisplayName("Current Security Scheme")]
    [IsoXmlTag("CurSctySchme")]
    public required ATMSecurityScheme3Code CurrentSecurityScheme { get; init; }

    /// <summary>
    /// Key exchange security schemes implemented in the hardware security module of the ATM.
    /// </summary>
    [IsoId("_VkuF87TlEeeQy4o2AayYHg")]
    [DisplayName("Security Scheme Capabilities")]
    [IsoXmlTag("SctySchmeCpblties")]
    public ATMSecurityScheme4Code? SecuritySchemeCapabilities { get; init; }

    /// <summary>
    /// Hardware security module of the ATM.
    /// </summary>
    [IsoId("_VkuF9bTlEeeQy4o2AayYHg")]
    [DisplayName("Security Device")]
    [IsoXmlTag("SctyDvc")]
    public required ATMSecurityDevice2 SecurityDevice { get; init; }

    /// <summary>
    /// Cryptographic keys stored in the hardware security module of the ATM.
    /// </summary>
    [IsoId("_VkuF97TlEeeQy4o2AayYHg")]
    [DisplayName("Key")]
    [IsoXmlTag("Key")]
    public CryptographicKey11? Key { get; init; }

    /// <summary>
    /// Random value from the host provided during a previous exchange.
    /// </summary>
    [IsoId("_VkuF-bTlEeeQy4o2AayYHg")]
    [DisplayName("Host Challenge")]
    [IsoXmlTag("HstChllng")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    public IsoMax140Binary? HostChallenge { get; init; }
}
