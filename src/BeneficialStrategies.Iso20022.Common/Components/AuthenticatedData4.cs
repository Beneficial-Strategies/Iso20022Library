// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Message authentication code (MAC), computed on the data to protect with an encryption key.
/// </summary>
[IsoId("_lguGMGkIEeS7zPBpvm732w")]
[DisplayName("Authenticated Data")]
public record AuthenticatedData4
{
    /// <summary>
    /// Version of the data structure.
    /// </summary>
    [IsoId("_lty44WkIEeS7zPBpvm732w")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Version { get; init; }

    /// <summary>
    /// Session key or protection key identification used by the recipient.
    /// </summary>
    [IsoId("_lty442kIEeS7zPBpvm732w")]
    [DisplayName("Recipient")]
    [IsoXmlTag("Rcpt")]
    public ValueList<Recipient4Choice_> Recipient { get; init; } = [];

    // ID for the above is _lty442kIEeS7zPBpvm732w

    /// <summary>
    /// Algorithm to compute message authentication code (MAC).
    /// </summary>
    [IsoId("_lty45WkIEeS7zPBpvm732w")]
    [DisplayName("MAC Algorithm")]
    [IsoXmlTag("MACAlgo")]
    public required AlgorithmIdentification15 MACAlgorithm { get; init; }

    /// <summary>
    /// Data to authenticate.
    /// </summary>
    [IsoId("_lty452kIEeS7zPBpvm732w")]
    [DisplayName("Encapsulated Content")]
    [IsoXmlTag("NcpsltdCntt")]
    public required EncapsulatedContent3 EncapsulatedContent { get; init; }

    /// <summary>
    /// Message authentication code value.
    /// </summary>
    [IsoId("_lty46WkIEeS7zPBpvm732w")]
    [DisplayName("MAC")]
    [IsoXmlTag("MAC")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    public required IsoMax140Binary MAC { get; init; }
}
