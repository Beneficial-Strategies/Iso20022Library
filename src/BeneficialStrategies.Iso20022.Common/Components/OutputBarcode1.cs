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
/// Barcode content to display or print.
/// </summary>
[IsoId("_nC5EsNuYEeiB5uLfkg9ZJA")]
[DisplayName("Output Barcode")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OutputBarcode1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a OutputBarcode1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public OutputBarcode1( BarcodeType1Code reqBarcodeType,QRCodeEncodingMode1Code reqQRCodeEncodingMode )
    {
        BarcodeType = reqBarcodeType;
        QRCodeEncodingMode = reqQRCodeEncodingMode;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of Barcode coding.
    /// </summary>
    [IsoId("_t9ZYsNuYEeiB5uLfkg9ZJA")]
    [DisplayName("Barcode Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BrcdTp")]
    #endif
    [IsoXmlTag("BrcdTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BarcodeType1Code BarcodeType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BarcodeType1Code BarcodeType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BarcodeType1Code BarcodeType { get; init; } 
    #else
    public BarcodeType1Code BarcodeType { get; set; } 
    #endif
    
    /// <summary>
    /// Value with a Barcode coding.
    /// </summary>
    [IsoId("_8DNnYNuZEeiB5uLfkg9ZJA")]
    [DisplayName("Barcode Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BrcdVal")]
    #endif
    [IsoXmlTag("BrcdVal")]
    [IsoSimpleType(IsoSimpleType.Max8000Text)]
    [StringLength(maximumLength: 8000 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax8000Text? BarcodeValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BarcodeValue { get; init; } 
    #else
    public System.String? BarcodeValue { get; set; } 
    #endif
    
    /// <summary>
    /// Use for binary and Kanji Quick Respone Code.
    /// </summary>
    [IsoId("_AnMI4NuaEeiB5uLfkg9ZJA")]
    [DisplayName("QR Code Binary Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QRCdBinryVal")]
    #endif
    [IsoXmlTag("QRCdBinryVal")]
    [IsoSimpleType(IsoSimpleType.Max3000Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax3000Binary? QRCodeBinaryValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? QRCodeBinaryValue { get; init; } 
    #else
    public System.Byte[]? QRCodeBinaryValue { get; set; } 
    #endif
    
    /// <summary>
    /// Version of the Quick Response Code.
    /// </summary>
    [IsoId("_D9WMYNuaEeiB5uLfkg9ZJA")]
    [DisplayName("QR Code Version")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QRCdVrsn")]
    #endif
    [IsoXmlTag("QRCdVrsn")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax16Text? QRCodeVersion { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? QRCodeVersion { get; init; } 
    #else
    public System.String? QRCodeVersion { get; set; } 
    #endif
    
    /// <summary>
    /// Encoding Mode of Quick Response Code.
    /// </summary>
    [IsoId("_GSCy4NuaEeiB5uLfkg9ZJA")]
    [DisplayName("QR Code Encoding Mode")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QRCdNcodgMd")]
    #endif
    [IsoXmlTag("QRCdNcodgMd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required QRCodeEncodingMode1Code QRCodeEncodingMode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required QRCodeEncodingMode1Code QRCodeEncodingMode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QRCodeEncodingMode1Code QRCodeEncodingMode { get; init; } 
    #else
    public QRCodeEncodingMode1Code QRCodeEncodingMode { get; set; } 
    #endif
    
    /// <summary>
    /// Error Correction mode of Quick Response Code.
    /// </summary>
    [IsoId("_Tq0VYNubEeiB5uLfkg9ZJA")]
    [DisplayName("QR Code Error Correction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QRCdErrCrrctn")]
    #endif
    [IsoXmlTag("QRCdErrCrrctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QRCodeErrorCorrection1Code? QRCodeErrorCorrection { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QRCodeErrorCorrection1Code? QRCodeErrorCorrection { get; init; } 
    #else
    public QRCodeErrorCorrection1Code? QRCodeErrorCorrection { get; set; } 
    #endif
    
    
    #nullable disable
    
}
