// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of Barcode coding.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1dJHwNuYEeiB5uLfkg9ZJA")]
[Description(@"Type of Barcode coding.")]
[Derivations(typeof(BarcodeType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<BarcodeTypeCode>))]
#endif
public enum BarcodeTypeCode
{
    /// <summary>
    /// Barcode encoded according to the EAN8 standard.
    /// Encoded/decoded by serializers as &quot;EAN8&quot;.
    /// </summary>
    [EnumMember(Value = "EAN8")]
    [IsoId("_QG8Q4NuZEeiB5uLfkg9ZJA")]
    [Description(@"Barcode encoded according to the EAN8 standard.")]
    BarcodeEncodedAsEAN8,

    /// <summary>
    /// Barcode encoded according to the EAN13 standard.
    /// Encoded/decoded by serializers as &quot;EA13&quot;.
    /// </summary>
    [EnumMember(Value = "EA13")]
    [IsoId("_VyLVYNuZEeiB5uLfkg9ZJA")]
    [Description(@"Barcode encoded according to the EAN13 standard.")]
    BarcodeEncodedAsEA13,

    /// <summary>
    /// Barcode encoded according to the Code 39 standard.
    /// Encoded/decoded by serializers as &quot;C039&quot;.
    /// </summary>
    [EnumMember(Value = "C039")]
    [IsoId("_ZRfU4NuZEeiB5uLfkg9ZJA")]
    [Description(@"Barcode encoded according to the Code 39 standard.")]
    BarcodeEncodedAsCode39,

    /// <summary>
    /// Barcode encoded according to the UPCA standard.
    /// Encoded/decoded by serializers as &quot;UPCA&quot;.
    /// </summary>
    [EnumMember(Value = "UPCA")]
    [IsoId("_dcmDYNuZEeiB5uLfkg9ZJA")]
    [Description(@"Barcode encoded according to the UPCA standard.")]
    BarcodeEncodedAsUPCA,

    /// <summary>
    /// Barcode encoded according to the Code 25 standard.
    /// Encoded/decoded by serializers as &quot;C025&quot;.
    /// </summary>
    [EnumMember(Value = "C025")]
    [IsoId("_hhElcNuZEeiB5uLfkg9ZJA")]
    [Description(@"Barcode encoded according to the Code 25 standard.")]
    BarcodeEncodedAsCode25,

    /// <summary>
    /// Barcode encoded according to the Code 128 standard.
    /// Encoded/decoded by serializers as &quot;C128&quot;.
    /// </summary>
    [EnumMember(Value = "C128")]
    [IsoId("_laFeYNuZEeiB5uLfkg9ZJA")]
    [Description(@"Barcode encoded according to the Code 128 standard.")]
    BarcodeEncodedAsCode128,

    /// <summary>
    /// Barcode encoded according to the PDF417 standard.
    /// Encoded/decoded by serializers as &quot;P417&quot;.
    /// </summary>
    [EnumMember(Value = "P417")]
    [IsoId("_oyYP4NuZEeiB5uLfkg9ZJA")]
    [Description(@"Barcode encoded according to the PDF417 standard.")]
    BarcodeEncodedAsPDF417,

    /// <summary>
    /// Barcode encoded according to the 2Dimensions Quick Response Code Standard.
    /// Encoded/decoded by serializers as &quot;COQR&quot;.
    /// </summary>
    [EnumMember(Value = "COQR")]
    [IsoId("_sx0g8NuZEeiB5uLfkg9ZJA")]
    [Description(@"Barcode encoded according to the 2Dimensions Quick Response Code Standard.")]
    BarcodeEncodedAs2DQRCode,
}
