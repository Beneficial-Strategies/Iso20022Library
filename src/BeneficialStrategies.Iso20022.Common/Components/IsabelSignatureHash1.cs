// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the hash data for the file signature.
/// </summary>
[IsoId("_c4XEYKA3EeWiJt5KdX5iuQ")]
[DisplayName("Isabel Signature Hash")]
public partial record IsabelSignatureHash1
{
    #nullable enable
    
    /// <summary>
    /// Arbitrary block of data defined as a fixed-size bit string, the (cryptographic) hash value, that allows the detection of an accidental or intentional change to the data.
    /// </summary>
    [IsoId("_t71FoKMaEeWZDvWHgGXs7Q")]
    [DisplayName("Hash")]
    [IsoXmlTag("Hash")]
    [IsoSimpleType(IsoSimpleType.Max50Binary)]
    public required IsoMax50Binary Hash { get; init; } 
    
    /// <summary>
    /// Effective method for calculating the signature hash using a finite sequence of instructions.
    /// </summary>
    [IsoId("_QFeEcKMbEeWZDvWHgGXs7Q")]
    [DisplayName("Algorithm")]
    [IsoXmlTag("Algo")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    public required IsoMax105Text Algorithm { get; init; } 
    
    
    #nullable disable
    
}
