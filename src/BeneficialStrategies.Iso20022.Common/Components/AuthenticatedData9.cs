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
[IsoId("_ren_8XDHEe2MCaKO5AtGsA")]
[DisplayName("Authenticated Data")]
public record AuthenticatedData9
{
    /// <summary>
    /// Version of the data structure.
    /// </summary>
    [IsoId("_rlkVcXDHEe2MCaKO5AtGsA")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Version { get; init; }

    /// <summary>
    /// Session key or protection key identification used by the recipient.
    /// </summary>
    [IsoId("_rlkVc3DHEe2MCaKO5AtGsA")]
    [DisplayName("Recipient")]
    [IsoXmlTag("Rcpt")]
    public ValueList<Recipient14Choice_> Recipient { get; init; } = [];

    // ID for the above is _rlkVc3DHEe2MCaKO5AtGsA

    /// <summary>
    /// Algorithm to compute message authentication code (MAC).
    /// </summary>
    [IsoId("_rlkVdXDHEe2MCaKO5AtGsA")]
    [DisplayName("MAC Algorithm")]
    [IsoXmlTag("MACAlgo")]
    public required AlgorithmIdentification22 MACAlgorithm { get; init; }

    /// <summary>
    /// Data to authenticate.
    /// </summary>
    [IsoId("_rlkVd3DHEe2MCaKO5AtGsA")]
    [DisplayName("Encapsulated Content")]
    [IsoXmlTag("NcpsltdCntt")]
    public required EncapsulatedContent3 EncapsulatedContent { get; init; }

    /// <summary>
    /// Message authentication code value.
    /// </summary>
    [IsoId("_rlkVeXDHEe2MCaKO5AtGsA")]
    [DisplayName("MAC")]
    [IsoXmlTag("MAC")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    public required IsoMax140Binary MAC { get; init; }
}
