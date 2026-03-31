// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// General cryptographic message syntax (CMS) containing encrypted data.
/// </summary>
[IsoId("_54ewQVFHEeyApZmLzm74zA")]
[DisplayName("Content Information Type")]
public record ContentInformationType32
{
    /// <summary>
    /// Type of data protection.
    /// </summary>
    [IsoId("_5-1P4VFHEeyApZmLzm74zA")]
    [DisplayName("Content Type")]
    [IsoXmlTag("CnttTp")]
    public required ContentType2Code ContentType { get; init; }

    /// <summary>
    /// Data protection by encryption or by a digital envelope, with an encryption key.
    /// </summary>
    [IsoId("_5-1P41FHEeyApZmLzm74zA")]
    [DisplayName("Enveloped Data")]
    [IsoXmlTag("EnvlpdData")]
    public required EnvelopedData9 EnvelopedData { get; init; }
}
