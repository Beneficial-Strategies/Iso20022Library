// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines a cryptographic digest algorithm and value.
/// </summary>
[IsoId("_OTgzMjQw-AOSNFX-8224494")]
[DisplayName("Algorithm And Digest")]
public record AlgorithmAndDigest1
{
    /// <summary>
    /// Digest algorithm used to create the digest.
    /// </summary>
    [IsoId("_OTgzMjcy-AOSNFX-8224496")]
    [DisplayName("Digest Algorithm")]
    [IsoXmlTag("DgstAlgo")]
    public required Algorithm5Code DigestAlgorithm { get; init; }

    /// <summary>
    /// Result of data-digesting process.
    /// </summary>
    [IsoId("_OTgzMjcz-AOSNFX-8224496")]
    [DisplayName("Digest")]
    [IsoXmlTag("Dgst")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public required IsoMax140Text Digest { get; init; }
}
