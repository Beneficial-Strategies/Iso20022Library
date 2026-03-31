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
[IsoId("_KpedcTF5EeO118ZQJgaQSQ")]
[DisplayName("Content Information Type")]
public record ContentInformationType8
{
    /// <summary>
    /// Type of data protection.
    /// </summary>
    [IsoId("_K5_lsTF5EeO118ZQJgaQSQ")]
    [DisplayName("Content Type")]
    [IsoXmlTag("CnttTp")]
    public required ContentType1Code ContentType { get; init; }

    /// <summary>
    /// Data protection by a message authentication code (MAC).
    /// </summary>
    [IsoId("_K5_lszF5EeO118ZQJgaQSQ")]
    [DisplayName("Authenticated Data")]
    [IsoXmlTag("AuthntcdData")]
    public ValueList<AuthenticatedData3> AuthenticatedData { get; init; } = [];
}
