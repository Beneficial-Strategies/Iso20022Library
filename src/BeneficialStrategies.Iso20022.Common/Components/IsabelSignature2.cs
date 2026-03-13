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
[IsoId("_Z-CoUKA3EeWiJt5KdX5iuQ")]
[DisplayName("Isabel Signature")]
public partial record IsabelSignature2
{
    #nullable enable
    
    /// <summary>
    /// Common signature elements applicable to all signature records.
    /// </summary>
    [IsoId("_LLcEwKA5EeWiJt5KdX5iuQ")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required IsabelSignatureHash1 Header { get; init; } 
    
    /// <summary>
    /// Individual record of the file signature.
    /// </summary>
    [IsoId("_M8gZwKA5EeWiJt5KdX5iuQ")]
    [DisplayName("Record")]
    [IsoXmlTag("Rcrd")]
    [MinLength(1)]
    [MaxLength(5)]
    public ValueList<IsabelSignatureRecord1> Record { get; init; } = [];
    
    /// <summary>
    /// Random data related to the signature.
    /// </summary>
    [IsoId("_PbEG4KA5EeWiJt5KdX5iuQ")]
    [DisplayName("Random Block")]
    [IsoXmlTag("RandBlck")]
    [IsoSimpleType(IsoSimpleType.Max64Text)]
    [StringLength(maximumLength: 64 ,MinimumLength = 1)]
    public required IsoMax64Text RandomBlock { get; init; } 
    
    
    #nullable disable
    
}
