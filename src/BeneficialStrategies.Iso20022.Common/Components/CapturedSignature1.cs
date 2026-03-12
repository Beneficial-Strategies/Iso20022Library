// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides all information related to a handwritten signature capture.
/// </summary>
[IsoId("_dY9X8NxGEeioifFt1dhnJA")]
[DisplayName("Captured Signature")]
public partial record CapturedSignature1
{
    #nullable enable
    
    /// <summary>
    /// Format of the image.
    /// </summary>
    [IsoId("_loZekNxGEeioifFt1dhnJA")]
    [DisplayName("Image Format")]
    [IsoXmlTag("ImgFrmt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text ImageFormat { get; init; } 
    
    /// <summary>
    /// Data of the image.
    /// </summary>
    [IsoId("_pfhhINxGEeioifFt1dhnJA")]
    [DisplayName("Image Data")]
    [IsoXmlTag("ImgData")]
    [IsoSimpleType(IsoSimpleType.Max2MBBinary)]
    public IsoMax2MBBinary? ImageData { get; init; } 
    
    /// <summary>
    /// URL or name of the image.
    /// </summary>
    [IsoId("_tOK9INxGEeioifFt1dhnJA")]
    [DisplayName("Image Reference")]
    [IsoXmlTag("ImgRef")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500 ,MinimumLength = 1)]
    public IsoMax500Text? ImageReference { get; init; } 
    
    /// <summary>
    /// Additional information for the image.
    /// </summary>
    [IsoId("_xdePINxGEeioifFt1dhnJA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
