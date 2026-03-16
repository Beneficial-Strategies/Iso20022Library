// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acceptor parameters dedicated to a payment application of the point of interaction.
/// </summary>
[IsoId("_yOVVUTY7EeOYzMAJn8nuYA")]
[DisplayName("Application Parameters")]
public record ApplicationParameters3
{
    /// <summary>
    /// Identification of the payment application.
    /// </summary>
    [IsoId("_ydqKwTY7EeOYzMAJn8nuYA")]
    [DisplayName("Application Identification")]
    [IsoXmlTag("ApplId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text ApplicationIdentification { get; init; }

    /// <summary>
    /// Version of the payment application configuration parameters.
    /// </summary>
    [IsoId("_ydqKwzY7EeOYzMAJn8nuYA")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public required IsoMax16Text Version { get; init; }

    /// <summary>
    /// Configuration parameters used by the related payment application.
    /// </summary>
    [IsoId("_ydqKxTY7EeOYzMAJn8nuYA")]
    [DisplayName("Parameters")]
    [IsoXmlTag("Params")]
    public SimpleValueList<IsoMax100KBinary> Parameters { get; init; } = [];

    /// <summary>
    /// Sensitive parameters (sequence of parameters including the enveloppes) encrypted with a cryptographic key.
    /// </summary>
    [IsoId("_ydqKxzY7EeOYzMAJn8nuYA")]
    [DisplayName("Encrypted Parameters")]
    [IsoXmlTag("NcrptdParams")]
    public ContentInformationType7? EncryptedParameters { get; init; }
}
