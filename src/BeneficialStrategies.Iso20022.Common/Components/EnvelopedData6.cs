// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Encrypted data with encryption key.
/// </summary>
[IsoId("_AweZUaQuEeeWXKXf3KjtmQ")]
[DisplayName("Enveloped Data")]
public record EnvelopedData6
{
    /// <summary>
    /// Version of the data structure.
    /// </summary>
    [IsoId("_A7ogcaQuEeeWXKXf3KjtmQ")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Version { get; init; }

    /// <summary>
    /// Session key or identification of the protection key used by the recipient.
    /// </summary>
    [IsoId("_A7ogc6QuEeeWXKXf3KjtmQ")]
    [DisplayName("Recipient")]
    [IsoXmlTag("Rcpt")]
    public ValueList<Recipient7Choice_> Recipient { get; init; } = [];

    // ID for the above is _A7ogc6QuEeeWXKXf3KjtmQ

    /// <summary>
    /// Encrypted data with an encryption key.
    /// </summary>
    [IsoId("_P_dJcP_jEeiDc7RC4MJZbA")]
    [DisplayName("Encrypted Content")]
    [IsoXmlTag("NcrptdCntt")]
    public EncryptedContent5? EncryptedContent { get; init; }
}
