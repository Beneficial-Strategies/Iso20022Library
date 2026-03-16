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
[IsoId("_eO2UIQioEeKn9O5oyej_zw")]
[DisplayName("Enveloped Data")]
public record EnvelopedData2
{
    /// <summary>
    /// Version of the data structure.
    /// </summary>
    [IsoId("_ebDkIQioEeKn9O5oyej_zw")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Version { get; init; }

    /// <summary>
    /// Transport key or key encryption key (KEK) identification for the recipient.
    /// </summary>
    [IsoId("_ebDkJQioEeKn9O5oyej_zw")]
    [DisplayName("Recipient")]
    [IsoXmlTag("Rcpt")]
    public ValueList<Recipient2Choice_> Recipient { get; init; } = [];

    // ID for the above is _ebDkJQioEeKn9O5oyej_zw

    /// <summary>
    /// Encrypted data with an encryption key.
    /// </summary>
    [IsoId("_ebDkKQioEeKn9O5oyej_zw")]
    [DisplayName("Encrypted Content")]
    [IsoXmlTag("NcrptdCntt")]
    public required EncryptedContent2 EncryptedContent { get; init; }
}
