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
[IsoId("_q8DG0VE_EeyApZmLzm74zA")]
[DisplayName("Content Information Type")]
public record ContentInformationType30
{
    /// <summary>
    /// Type of data protection.
    /// </summary>
    [IsoId("_rCTf0VE_EeyApZmLzm74zA")]
    [DisplayName("Content Type")]
    [IsoXmlTag("CnttTp")]
    public required ContentType2Code ContentType { get; init; }

    /// <summary>
    /// Data protection by encryption, with a session key.
    /// </summary>
    [IsoId("_rCTf01E_EeyApZmLzm74zA")]
    [DisplayName("Enveloped Data")]
    [IsoXmlTag("EnvlpdData")]
    public EnvelopedData9? EnvelopedData { get; init; }

    /// <summary>
    /// Data protection by a message authentication code (MAC).
    /// </summary>
    [IsoId("_rCTf1VE_EeyApZmLzm74zA")]
    [DisplayName("Authenticated Data")]
    [IsoXmlTag("AuthntcdData")]
    public AuthenticatedData8? AuthenticatedData { get; init; }

    /// <summary>
    /// Data protected by a digital signatures.
    /// </summary>
    [IsoId("_rCTf11E_EeyApZmLzm74zA")]
    [DisplayName("Signed Data")]
    [IsoXmlTag("SgndData")]
    public SignedData7? SignedData { get; init; }

    /// <summary>
    /// Data protected by a digest.
    /// </summary>
    [IsoId("_rCTf2VE_EeyApZmLzm74zA")]
    [DisplayName("Digested Data")]
    [IsoXmlTag("DgstdData")]
    public DigestedData5? DigestedData { get; init; }
}
