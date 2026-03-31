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
[IsoId("_lLfC8QvFEeKzJ69IWwzB9Q")]
[DisplayName("Content Information Type")]
public record ContentInformationType4
{
    /// <summary>
    /// Type of data protection.
    /// </summary>
    [IsoId("_lW8FAQvFEeKzJ69IWwzB9Q")]
    [DisplayName("Content Type")]
    [IsoXmlTag("CnttTp")]
    public required ContentType1Code ContentType { get; init; }

    /// <summary>
    /// Data protection by encryption, with a session key.
    /// </summary>
    [IsoId("_lW8FBQvFEeKzJ69IWwzB9Q")]
    [DisplayName("Enveloped Data")]
    [IsoXmlTag("EnvlpdData")]
    public EnvelopedData2? EnvelopedData { get; init; }

    /// <summary>
    /// Data protection by a message authentication code (MAC).
    /// </summary>
    [IsoId("_lW8FCQvFEeKzJ69IWwzB9Q")]
    [DisplayName("Authenticated Data")]
    [IsoXmlTag("AuthntcdData")]
    public AuthenticatedData2? AuthenticatedData { get; init; }

    /// <summary>
    /// Data protected by digital signatures.
    /// </summary>
    [IsoId("_lW8FDQvFEeKzJ69IWwzB9Q")]
    [DisplayName("Signed Data")]
    [IsoXmlTag("SgndData")]
    public SignedData2? SignedData { get; init; }

    /// <summary>
    /// Data protected by a digest.
    /// </summary>
    [IsoId("_lW8FEQvFEeKzJ69IWwzB9Q")]
    [DisplayName("Digested Data")]
    [IsoXmlTag("DgstdData")]
    public DigestedData2? DigestedData { get; init; }

    /// <summary>
    /// Data protection by encryption with a previously exchanged key identified by a name.
    /// </summary>
    [IsoId("_lW8FFQvFEeKzJ69IWwzB9Q")]
    [DisplayName("Named Key Encrypted Data")]
    [IsoXmlTag("NmdKeyNcrptdData")]
    public NamedKeyEncryptedData2? NamedKeyEncryptedData { get; init; }
}
