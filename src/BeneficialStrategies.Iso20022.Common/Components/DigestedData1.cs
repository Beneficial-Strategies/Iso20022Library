// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Digest computed on the identified data.
/// </summary>
[IsoId("_SwiSzgEcEeCQm6a_G2yO_w_-1031438550")]
[DisplayName("Digested Data")]
public partial record DigestedData1
{
    #nullable enable
    
    /// <summary>
    /// Version of the data structure.
    /// </summary>
    [IsoId("_SwsDwAEcEeCQm6a_G2yO_w_1578689395")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Version { get; init; } 
    
    /// <summary>
    /// Identification of a digest algorithm.
    /// </summary>
    [IsoId("_SwsDwQEcEeCQm6a_G2yO_w_1418159419")]
    [DisplayName("Digest Algorithm")]
    [IsoXmlTag("DgstAlgo")]
    public ValueList<AlgorithmIdentification1> DigestAlgorithm { get; init; } = [];
    // ID for the above is _SwsDwQEcEeCQm6a_G2yO_w_1418159419
    
    /// <summary>
    /// Data on which the digest is computed.
    /// </summary>
    [IsoId("_SwsDwgEcEeCQm6a_G2yO_w_32135630")]
    [DisplayName("Encapsulated Content")]
    [IsoXmlTag("NcpsltdCntt")]
    public required EncapsulatedContent1 EncapsulatedContent { get; init; } 
    
    /// <summary>
    /// Result of data-digesting process.
    /// </summary>
    [IsoId("_SwsDwwEcEeCQm6a_G2yO_w_1068869380")]
    [DisplayName("Digest")]
    [IsoXmlTag("Dgst")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public required IsoMax140Text Digest { get; init; } 
    
    
    #nullable disable
    
}
