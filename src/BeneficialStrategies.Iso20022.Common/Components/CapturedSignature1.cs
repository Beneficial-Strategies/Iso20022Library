// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides all information related to a handwritten signature capture.
/// </summary>
[IsoId("_dY9X8NxGEeioifFt1dhnJA")]
[DisplayName("Captured Signature")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CapturedSignature1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CapturedSignature1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CapturedSignature1( System.String reqImageFormat )
    {
        ImageFormat = reqImageFormat;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Format of the image.
    /// </summary>
    [IsoId("_loZekNxGEeioifFt1dhnJA")]
    [DisplayName("Image Format")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ImgFrmt")]
    #endif
    [IsoXmlTag("ImgFrmt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text ImageFormat { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ImageFormat { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ImageFormat { get; init; } 
    #else
    public System.String ImageFormat { get; set; } 
    #endif
    
    /// <summary>
    /// Data of the image.
    /// </summary>
    [IsoId("_pfhhINxGEeioifFt1dhnJA")]
    [DisplayName("Image Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ImgData")]
    #endif
    [IsoXmlTag("ImgData")]
    [IsoSimpleType(IsoSimpleType.Max2MBBinary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax2MBBinary? ImageData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? ImageData { get; init; } 
    #else
    public System.Byte[]? ImageData { get; set; } 
    #endif
    
    /// <summary>
    /// URL or name of the image.
    /// </summary>
    [IsoId("_tOK9INxGEeioifFt1dhnJA")]
    [DisplayName("Image Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ImgRef")]
    #endif
    [IsoXmlTag("ImgRef")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax500Text? ImageReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ImageReference { get; init; } 
    #else
    public System.String? ImageReference { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information for the image.
    /// </summary>
    [IsoId("_xdePINxGEeioifFt1dhnJA")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalInformation { get; init; } 
    #else
    public System.String? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
