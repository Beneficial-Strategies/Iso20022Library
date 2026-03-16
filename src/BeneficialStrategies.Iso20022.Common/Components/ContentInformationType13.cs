// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// General cryptographic message syntax (CMS) containing data. protected by a MAC or a digital signature.
/// </summary>
[IsoId("_R_tFoYreEeSvuOJS0mmL0g")]
[DisplayName("Content Information Type")]
public record ContentInformationType13
{
    /// <summary>
    /// Type of data protection.
    /// </summary>
    [IsoId("_SMhZoYreEeSvuOJS0mmL0g")]
    [DisplayName("Content Type")]
    [IsoXmlTag("CnttTp")]
    public required ContentType2Code ContentType { get; init; }

    /// <summary>
    /// Data protection by a message authentication code (MAC).
    /// </summary>
    [IsoId("_SMhZpYreEeSvuOJS0mmL0g")]
    [DisplayName("Authenticated Data")]
    [IsoXmlTag("AuthntcdData")]
    public AuthenticatedData4? AuthenticatedData { get; init; }

    /// <summary>
    /// Data protected by a digital signatures.
    /// </summary>
    [IsoId("_SMhZp4reEeSvuOJS0mmL0g")]
    [DisplayName("Signed Data")]
    [IsoXmlTag("SgndData")]
    public SignedData4? SignedData { get; init; }
}
