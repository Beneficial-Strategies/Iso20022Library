// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// General cryptographic message syntax (CMS) containing protected data.
/// </summary>
[IsoId("_ZSh2oTScEeOnFuyVSIQZKg")]
[DisplayName("Content Information Type")]
public record ContentInformationType9
{
    /// <summary>
    /// Type of data protection.
    /// </summary>
    [IsoId("_ZiTYATScEeOnFuyVSIQZKg")]
    [DisplayName("Content Type")]
    [IsoXmlTag("CnttTp")]
    public required ContentType1Code ContentType { get; init; }

    /// <summary>
    /// Data protection by encryption, with a session key.
    /// </summary>
    [IsoId("_ZiTYAzScEeOnFuyVSIQZKg")]
    [DisplayName("Enveloped Data")]
    [IsoXmlTag("EnvlpdData")]
    public EnvelopedData3? EnvelopedData { get; init; }

    /// <summary>
    /// Data protection by a message authentication code (MAC).
    /// </summary>
    [IsoId("_ZiTYBTScEeOnFuyVSIQZKg")]
    [DisplayName("Authenticated Data")]
    [IsoXmlTag("AuthntcdData")]
    public AuthenticatedData3? AuthenticatedData { get; init; }

    /// <summary>
    /// Data protected by digital signatures.
    /// </summary>
    [IsoId("_ZiTYBzScEeOnFuyVSIQZKg")]
    [DisplayName("Signed Data")]
    [IsoXmlTag("SgndData")]
    public SignedData3? SignedData { get; init; }

    /// <summary>
    /// Data protected by a digest.
    /// </summary>
    [IsoId("_ZiTYCTScEeOnFuyVSIQZKg")]
    [DisplayName("Digested Data")]
    [IsoXmlTag("DgstdData")]
    public DigestedData3? DigestedData { get; init; }
}
