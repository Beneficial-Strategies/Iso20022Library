// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Enveloped Data12.
/// </summary>
[IsoId("_9rcDQXdCEe6YlIMyoxWMJA")]
[DisplayName("Enveloped Data12")]
public record EnvelopedData12
{
    /// <summary>
    /// Encrypted Content.
    /// </summary>
    [DisplayName("Encrypted Content")]
    [IsoXmlTag("NcrptdCntt")]
    public EncryptedContent8? EncryptedContent { get; init; }

    /// <summary>
    /// Recipient.
    /// </summary>
    [DisplayName("Recipient")]
    [IsoXmlTag("Rcpt")]
    public ValueList<Recipient7Choice_> Recipient { get; init; } = [];

    /// <summary>
    /// Version.
    /// </summary>
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    public IsoNumber? Version { get; init; }
}
