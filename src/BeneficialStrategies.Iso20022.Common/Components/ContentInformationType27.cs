// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// General cryptographic message syntax (CMS) containing authenticated data.
/// </summary>
[IsoId("_2S4usS8lEeu125Ip9zFcsQ")]
[DisplayName("Content Information Type")]
public record ContentInformationType27
{
    /// <summary>
    /// Type of data protection.
    /// </summary>
    [IsoId("_2it6cS8lEeu125Ip9zFcsQ")]
    [DisplayName("Content Type")]
    [IsoXmlTag("CnttTp")]
    public required ContentType2Code ContentType { get; init; }

    /// <summary>
    /// Data protection by a message authentication code (MAC).
    /// </summary>
    [IsoId("_2it6cy8lEeu125Ip9zFcsQ")]
    [DisplayName("Authenticated Data")]
    [IsoXmlTag("AuthntcdData")]
    public required AuthenticatedData7 AuthenticatedData { get; init; }
}
