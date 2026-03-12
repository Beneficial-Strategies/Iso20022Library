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
[IsoId("_7USsgWmSEeSkutXKrVpkCQ")]
[DisplayName("Digested Data")]
public partial record DigestedData4
{
    #nullable enable
    
    /// <summary>
    /// Version of the data structure.
    /// </summary>
    [IsoId("_7iIUMWmSEeSkutXKrVpkCQ")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Version { get; init; } 
    
    /// <summary>
    /// Identification of the digest algorithm.
    /// </summary>
    [IsoId("_7iIUM2mSEeSkutXKrVpkCQ")]
    [DisplayName("Digest Algorithm")]
    [IsoXmlTag("DgstAlgo")]
    public required AlgorithmIdentification16 DigestAlgorithm { get; init; } 
    
    /// <summary>
    /// Data on which the digest is computed.
    /// </summary>
    [IsoId("_7iIUNWmSEeSkutXKrVpkCQ")]
    [DisplayName("Encapsulated Content")]
    [IsoXmlTag("NcpsltdCntt")]
    public required EncapsulatedContent3 EncapsulatedContent { get; init; } 
    
    /// <summary>
    /// Result of data-digesting process.
    /// </summary>
    [IsoId("_7iIUN2mSEeSkutXKrVpkCQ")]
    [DisplayName("Digest")]
    [IsoXmlTag("Dgst")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    public required IsoMax140Binary Digest { get; init; } 
    
    
    #nullable disable
    
}
