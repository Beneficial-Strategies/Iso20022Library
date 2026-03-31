// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Encrypted Content8.
/// </summary>
[IsoId("_NRzUIXdDEe6YlIMyoxWMJA")]
[DisplayName("Encrypted Content8")]
public record EncryptedContent8
{
    /// <summary>
    /// Content Encryption Algorithm.
    /// </summary>
    [DisplayName("Content Encryption Algorithm")]
    [IsoXmlTag("CnttNcrptnAlgo")]
    public required AlgorithmIdentification25 ContentEncryptionAlgorithm { get; init; }

    /// <summary>
    /// Content Type.
    /// </summary>
    [DisplayName("Content Type")]
    [IsoXmlTag("CnttTp")]
    public required ContentType2Code ContentType { get; init; }

    /// <summary>
    /// Encrypted Data Element.
    /// </summary>
    [DisplayName("Encrypted Data Element")]
    [IsoXmlTag("NcrptdDataElmt")]
    public ValueList<EncryptedDataElement2> EncryptedDataElement { get; init; } = [];
}
