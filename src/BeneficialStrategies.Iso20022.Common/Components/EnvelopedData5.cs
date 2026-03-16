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
[IsoId("_EwI_cds6Eee9e6xduATmQg")]
[DisplayName("Enveloped Data")]
public record EnvelopedData5
{
    /// <summary>
    /// Version of the data structure.
    /// </summary>
    [IsoId("_E5K_ods6Eee9e6xduATmQg")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Version { get; init; }

    /// <summary>
    /// Provides certificates of the originator.
    /// </summary>
    [IsoId("__hOj8OCyEee83LAjB5Kqdw")]
    [DisplayName("Originator Information")]
    [IsoXmlTag("OrgtrInf")]
    public OriginatorInformation1? OriginatorInformation { get; init; }

    /// <summary>
    /// Session key or identification of the protection key used by the recipient.
    /// </summary>
    [IsoId("_E5K_o9s6Eee9e6xduATmQg")]
    [DisplayName("Recipient")]
    [IsoXmlTag("Rcpt")]
    public ValueList<Recipient6Choice_> Recipient { get; init; } = [];

    // ID for the above is _E5K_o9s6Eee9e6xduATmQg

    /// <summary>
    /// Data protection by encryption (digital envelope), with an encryption key.
    /// </summary>
    [IsoId("_E5K_pds6Eee9e6xduATmQg")]
    [DisplayName("Encrypted Content")]
    [IsoXmlTag("NcrptdCntt")]
    public EncryptedContent4? EncryptedContent { get; init; }
}
