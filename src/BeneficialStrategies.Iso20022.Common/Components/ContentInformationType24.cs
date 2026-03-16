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
[IsoId("_GpvT8QuEEeqYM5yH99IYQw")]
[DisplayName("Content Information Type")]
public record ContentInformationType24
{
    /// <summary>
    /// Type of data protection.
    /// </summary>
    [IsoId("_G0HX8QuEEeqYM5yH99IYQw")]
    [DisplayName("Content Type")]
    [IsoXmlTag("CnttTp")]
    public required ContentType2Code ContentType { get; init; }

    /// <summary>
    /// Data protection by a message authentication code (MAC).
    /// </summary>
    [IsoId("_G0HX8wuEEeqYM5yH99IYQw")]
    [DisplayName("Authenticated Data")]
    [IsoXmlTag("AuthntcdData")]
    public required AuthenticatedData6 AuthenticatedData { get; init; }
}
