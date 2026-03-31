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
[IsoId("_uSOuUCrHEeWRf8RNsvC5fQ")]
[DisplayName("Content Information Type")]
public record ContentInformationType15
{
    /// <summary>
    /// Type of data protection.
    /// </summary>
    [IsoId("_udKL8SrHEeWRf8RNsvC5fQ")]
    [DisplayName("Content Type")]
    [IsoXmlTag("CnttTp")]
    public required ContentType2Code ContentType { get; init; }

    /// <summary>
    /// Data protection by a message authentication code (MAC).
    /// </summary>
    [IsoId("_udKL8yrHEeWRf8RNsvC5fQ")]
    [DisplayName("Authenticated Data")]
    [IsoXmlTag("AuthntcdData")]
    public required AuthenticatedData4 AuthenticatedData { get; init; }
}
