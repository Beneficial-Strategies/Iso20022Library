// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Digest computed on the identified data.
/// </summary>
[IsoId("_6ducAdtbEee9e6xduATmQg")]
[DisplayName("Digested Data")]
public record DigestedData5
{
    /// <summary>
    /// Version of the data structure.
    /// </summary>
    [IsoId("_6nUc4dtbEee9e6xduATmQg")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Version { get; init; }

    /// <summary>
    /// Identification of the digest algorithm.
    /// </summary>
    [IsoId("_6nUc49tbEee9e6xduATmQg")]
    [DisplayName("Digest Algorithm")]
    [IsoXmlTag("DgstAlgo")]
    public required AlgorithmIdentification21 DigestAlgorithm { get; init; }

    /// <summary>
    /// Data on which the digest is computed.
    /// </summary>
    [IsoId("_6nUc5dtbEee9e6xduATmQg")]
    [DisplayName("Encapsulated Content")]
    [IsoXmlTag("NcpsltdCntt")]
    public required EncapsulatedContent3 EncapsulatedContent { get; init; }

    /// <summary>
    /// Result of data-digesting process.
    /// </summary>
    [IsoId("_6nUc59tbEee9e6xduATmQg")]
    [DisplayName("Digest")]
    [IsoXmlTag("Dgst")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    public required IsoMax140Binary Digest { get; init; }
}
