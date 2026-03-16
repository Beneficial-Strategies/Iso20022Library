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
[IsoId("_SwFm2gEcEeCQm6a_G2yO_w_1341928510")]
[DisplayName("Content Information Type")]
public record ContentInformationType1
{
    /// <summary>
    /// Type of data protection.
    /// </summary>
    [IsoId("_SwFm2wEcEeCQm6a_G2yO_w_1608351913")]
    [DisplayName("Content Type")]
    [IsoXmlTag("CnttTp")]
    public required ContentType1Code ContentType { get; init; }

    /// <summary>
    /// Data protection by encryption, with a session key.
    /// </summary>
    [IsoId("_SwFm3AEcEeCQm6a_G2yO_w_935621797")]
    [DisplayName("Enveloped Data")]
    [IsoXmlTag("EnvlpdData")]
    public EnvelopedData1? EnvelopedData { get; init; }

    /// <summary>
    /// Data protection by a message authentication code (MAC).
    /// </summary>
    [IsoId("_SwFm3QEcEeCQm6a_G2yO_w_-1683586438")]
    [DisplayName("Authenticated Data")]
    [IsoXmlTag("AuthntcdData")]
    public AuthenticatedData1? AuthenticatedData { get; init; }

    /// <summary>
    /// Data protected by digital signatures.
    /// </summary>
    [IsoId("_SwPX0AEcEeCQm6a_G2yO_w_51665286")]
    [DisplayName("Signed Data")]
    [IsoXmlTag("SgndData")]
    public SignedData1? SignedData { get; init; }

    /// <summary>
    /// Data protected by a digest.
    /// </summary>
    [IsoId("_SwPX0QEcEeCQm6a_G2yO_w_454252135")]
    [DisplayName("Digested Data")]
    [IsoXmlTag("DgstdData")]
    public DigestedData1? DigestedData { get; init; }

    /// <summary>
    /// Data protection by encryption with a previously exchanged key identified by a name.
    /// </summary>
    [IsoId("_SwPX0gEcEeCQm6a_G2yO_w_-1708037626")]
    [DisplayName("Named Key Encrypted Data")]
    [IsoXmlTag("NmdKeyNcrptdData")]
    public NamedKeyEncryptedData1? NamedKeyEncryptedData { get; init; }
}
