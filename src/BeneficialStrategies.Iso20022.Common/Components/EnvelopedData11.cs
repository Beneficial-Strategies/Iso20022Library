// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Enveloped Data11.
/// </summary>
[IsoId("_6GT5AY-TEe6oobnCtR50kw")]
[DisplayName("Enveloped Data11")]
public record EnvelopedData11
{
    /// <summary>
    /// Encrypted Content.
    /// </summary>
    [DisplayName("Encrypted Content")]
    [IsoXmlTag("NcrptdCntt")]
    public EncryptedContent7? EncryptedContent { get; init; }

    /// <summary>
    /// Originator Information.
    /// </summary>
    [DisplayName("Originator Information")]
    [IsoXmlTag("OrgtrInf")]
    public OriginatorInformation1? OriginatorInformation { get; init; }

    /// <summary>
    /// Recipient.
    /// </summary>
    [DisplayName("Recipient")]
    [IsoXmlTag("Rcpt")]
    public ValueList<Recipient15Choice_> Recipient { get; init; } = [];

    /// <summary>
    /// Version.
    /// </summary>
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    public IsoNumber? Version { get; init; }
}
