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
[IsoId("_AgT7cdtaEee9e6xduATmQg")]
[DisplayName("Content Information Type")]
public record ContentInformationType19
{
    /// <summary>
    /// Type of data protection.
    /// </summary>
    [IsoId("_ApGrEdtaEee9e6xduATmQg")]
    [DisplayName("Content Type")]
    [IsoXmlTag("CnttTp")]
    public required ContentType2Code ContentType { get; init; }

    /// <summary>
    /// Data protection by encryption, with a session key.
    /// </summary>
    [IsoId("_ApGrE9taEee9e6xduATmQg")]
    [DisplayName("Enveloped Data")]
    [IsoXmlTag("EnvlpdData")]
    public EnvelopedData5? EnvelopedData { get; init; }

    /// <summary>
    /// Data protection by a message authentication code (MAC).
    /// </summary>
    [IsoId("_ApGrFdtaEee9e6xduATmQg")]
    [DisplayName("Authenticated Data")]
    [IsoXmlTag("AuthntcdData")]
    public AuthenticatedData5? AuthenticatedData { get; init; }

    /// <summary>
    /// Data protected by a digital signatures.
    /// </summary>
    [IsoId("_ApGrF9taEee9e6xduATmQg")]
    [DisplayName("Signed Data")]
    [IsoXmlTag("SgndData")]
    public SignedData5? SignedData { get; init; }

    /// <summary>
    /// Data protected by a digest.
    /// </summary>
    [IsoId("_ApGrGdtaEee9e6xduATmQg")]
    [DisplayName("Digested Data")]
    [IsoXmlTag("DgstdData")]
    public DigestedData5? DigestedData { get; init; }
}
