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
[IsoId("__DJZ4dtZEee9e6xduATmQg")]
[DisplayName("Content Information Type")]
public record ContentInformationType18
{
    /// <summary>
    /// Type of data protection.
    /// </summary>
    [IsoId("__MFTcdtZEee9e6xduATmQg")]
    [DisplayName("Content Type")]
    [IsoXmlTag("CnttTp")]
    public required ContentType2Code ContentType { get; init; }

    /// <summary>
    /// Data protection by a message authentication code (MAC).
    /// </summary>
    [IsoId("__MFTc9tZEee9e6xduATmQg")]
    [DisplayName("Authenticated Data")]
    [IsoXmlTag("AuthntcdData")]
    public AuthenticatedData5? AuthenticatedData { get; init; }

    /// <summary>
    /// Data protected by a digital signatures.
    /// </summary>
    [IsoId("__MFTddtZEee9e6xduATmQg")]
    [DisplayName("Signed Data")]
    [IsoXmlTag("SgndData")]
    public SignedData5? SignedData { get; init; }
}
