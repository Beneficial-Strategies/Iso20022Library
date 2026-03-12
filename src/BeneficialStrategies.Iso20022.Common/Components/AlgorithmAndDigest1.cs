// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines a cryptographic digest algorithm and value.
/// </summary>
[IsoId("_OTgzMjQw-AOSNFX-8224494")]
[DisplayName("Algorithm And Digest")]
public partial record AlgorithmAndDigest1
{
    #nullable enable
    
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
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public required IsoMax140Text Digest { get; init; } 
    
    
    #nullable disable
    
}
