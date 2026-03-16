// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Digested Data6.
/// </summary>
[IsoId("_LN0U4Y-GEe6oobnCtR50kw")]
[DisplayName("Digested Data6")]
public partial record DigestedData6
{
    #nullable enable

    /// <summary>
    /// Digest.
    /// </summary>
    [DisplayName("Digest")]
    [IsoXmlTag("Dgst")]
    public required IsoMax140Binary Digest { get; init; } 

    /// <summary>
    /// Digest Algorithm.
    /// </summary>
    [DisplayName("Digest Algorithm")]
    [IsoXmlTag("DgstAlgo")]
    public required AlgorithmIdentification36 DigestAlgorithm { get; init; } 

    /// <summary>
    /// Encapsulated Content.
    /// </summary>
    [DisplayName("Encapsulated Content")]
    [IsoXmlTag("NcpsltdCntt")]
    public required EncapsulatedContent3 EncapsulatedContent { get; init; } 

    /// <summary>
    /// Version.
    /// </summary>
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    public IsoNumber? Version { get; init; } 

    
    #nullable disable
    
}
