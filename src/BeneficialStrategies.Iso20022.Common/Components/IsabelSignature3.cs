// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the signature of an Isabel file.
/// </summary>
[IsoId("_lknXcc_aEeWjSMe6YTKHlQ")]
[DisplayName("Isabel Signature")]
public partial record IsabelSignature3
{
    #nullable enable
    
    /// <summary>
    /// Common signature elements applicable to all signature records.
    /// </summary>
    [IsoId("_l1lLoc_aEeWjSMe6YTKHlQ")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required IsabelSignatureHash1 Header { get; init; } 
    
    /// <summary>
    /// Individual record of the file signature.
    /// </summary>
    [IsoId("_l1lLo8_aEeWjSMe6YTKHlQ")]
    [DisplayName("Record")]
    [IsoXmlTag("Rcrd")]
    [MinLength(1)]
    [MaxLength(5)]
    public ValueList<IsabelSignatureRecord2> Record { get; init; } = [];
    
    /// <summary>
    /// Random data related to the signature.
    /// </summary>
    [IsoId("_l1lLpc_aEeWjSMe6YTKHlQ")]
    [DisplayName("Random Block")]
    [IsoXmlTag("RandBlck")]
    [IsoSimpleType(IsoSimpleType.Max64Text)]
    [StringLength(maximumLength: 64 ,MinimumLength = 1)]
    public required IsoMax64Text RandomBlock { get; init; } 
    
    
    #nullable disable
    
}
