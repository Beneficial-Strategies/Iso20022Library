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
[IsoId("_WAiXsXJ9Ee299ZbWCkdR_w")]
[DisplayName("Content Information Type")]
public record ContentInformationType36
{
    /// <summary>
    /// Type of data protection.
    /// </summary>
    [IsoId("_WH4V0XJ9Ee299ZbWCkdR_w")]
    [DisplayName("Content Type")]
    [IsoXmlTag("CnttTp")]
    public required ContentType2Code ContentType { get; init; }

    /// <summary>
    /// Data protection by a message authentication code (MAC).
    /// </summary>
    [IsoId("_WH4V03J9Ee299ZbWCkdR_w")]
    [DisplayName("Authenticated Data")]
    [IsoXmlTag("AuthntcdData")]
    public required AuthenticatedData9 AuthenticatedData { get; init; }
}
