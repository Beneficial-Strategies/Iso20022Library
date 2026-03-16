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
[IsoId("_LcnkgVW-EeOlEMHvp-ipJg")]
[DisplayName("Digested Data")]
public record DigestedData3
{
    /// <summary>
    /// Version of the data structure.
    /// </summary>
    [IsoId("_LnfXwVW-EeOlEMHvp-ipJg")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Version { get; init; }

    /// <summary>
    /// Identification of a digest algorithm.
    /// </summary>
    [IsoId("_LnfXw1W-EeOlEMHvp-ipJg")]
    [DisplayName("Digest Algorithm")]
    [IsoXmlTag("DgstAlgo")]
    public ValueList<AlgorithmIdentification5> DigestAlgorithm { get; init; } = [];

    // ID for the above is _LnfXw1W-EeOlEMHvp-ipJg

    /// <summary>
    /// Data on which the digest is computed.
    /// </summary>
    [IsoId("_LnfXxVW-EeOlEMHvp-ipJg")]
    [DisplayName("Encapsulated Content")]
    [IsoXmlTag("NcpsltdCntt")]
    public required EncapsulatedContent2 EncapsulatedContent { get; init; }

    /// <summary>
    /// Result of data-digesting process.
    /// </summary>
    [IsoId("_LnfXx1W-EeOlEMHvp-ipJg")]
    [DisplayName("Digest")]
    [IsoXmlTag("Dgst")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public required IsoMax140Text Digest { get; init; }
}
