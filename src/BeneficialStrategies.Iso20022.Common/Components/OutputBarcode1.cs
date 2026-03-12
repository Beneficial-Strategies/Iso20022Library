// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Barcode content to display or print.
/// </summary>
[IsoId("_nC5EsNuYEeiB5uLfkg9ZJA")]
[DisplayName("Output Barcode")]
public partial record OutputBarcode1
{
    #nullable enable
    
    /// <summary>
    /// Type of Barcode coding.
    /// </summary>
    [IsoId("_t9ZYsNuYEeiB5uLfkg9ZJA")]
    [DisplayName("Barcode Type")]
    [IsoXmlTag("BrcdTp")]
    public required BarcodeType1Code BarcodeType { get; init; } 
    
    /// <summary>
    /// Value with a Barcode coding.
    /// </summary>
    [IsoId("_8DNnYNuZEeiB5uLfkg9ZJA")]
    [DisplayName("Barcode Value")]
    [IsoXmlTag("BrcdVal")]
    [IsoSimpleType(IsoSimpleType.Max8000Text)]
    [StringLength(maximumLength: 8000 ,MinimumLength = 1)]
    public IsoMax8000Text? BarcodeValue { get; init; } 
    
    /// <summary>
    /// Use for binary and Kanji Quick Respone Code.
    /// </summary>
    [IsoId("_AnMI4NuaEeiB5uLfkg9ZJA")]
    [DisplayName("QR Code Binary Value")]
    [IsoXmlTag("QRCdBinryVal")]
    [IsoSimpleType(IsoSimpleType.Max3000Binary)]
    public IsoMax3000Binary? QRCodeBinaryValue { get; init; } 
    
    /// <summary>
    /// Version of the Quick Response Code.
    /// </summary>
    [IsoId("_D9WMYNuaEeiB5uLfkg9ZJA")]
    [DisplayName("QR Code Version")]
    [IsoXmlTag("QRCdVrsn")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    public IsoMax16Text? QRCodeVersion { get; init; } 
    
    /// <summary>
    /// Encoding Mode of Quick Response Code.
    /// </summary>
    [IsoId("_GSCy4NuaEeiB5uLfkg9ZJA")]
    [DisplayName("QR Code Encoding Mode")]
    [IsoXmlTag("QRCdNcodgMd")]
    public required QRCodeEncodingMode1Code QRCodeEncodingMode { get; init; } 
    
    /// <summary>
    /// Error Correction mode of Quick Response Code.
    /// </summary>
    [IsoId("_Tq0VYNubEeiB5uLfkg9ZJA")]
    [DisplayName("QR Code Error Correction")]
    [IsoXmlTag("QRCdErrCrrctn")]
    public QRCodeErrorCorrection1Code? QRCodeErrorCorrection { get; init; } 
    
    
    #nullable disable
    
}
