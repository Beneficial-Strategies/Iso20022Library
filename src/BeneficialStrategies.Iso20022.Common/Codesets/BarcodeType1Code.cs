// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of BarCode coding.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_yIRoQNuZEeiB5uLfkg9ZJA")]
[Description(@"Type of BarCode coding.")]
[DerivedFrom(typeof(BarcodeTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<BarcodeType1Code>))]
#endif
public enum BarcodeType1Code
{
    /// <summary>
    /// Barcode encoded according to the 2Dimensions Quick Response Code Standard.
    /// Encoded/decoded by serializers as &quot;COQR&quot;.
    /// </summary>
    [EnumMember(Value = "COQR")]
    [IsoId("_0H1FMduZEeiB5uLfkg9ZJA")]
    [Description(@"Barcode encoded according to the 2Dimensions Quick Response Code Standard.")]
    BarcodeEncodedAs2DQRCode = BarcodeTypeCode.BarcodeEncodedAs2DQRCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Barcode encoded according to the Code 128 standard.
    /// Encoded/decoded by serializers as &quot;C128&quot;.
    /// </summary>
    [EnumMember(Value = "C128")]
    [IsoId("_0L5s4duZEeiB5uLfkg9ZJA")]
    [Description(@"Barcode encoded according to the Code 128 standard.")]
    BarcodeEncodedAsCode128 = BarcodeTypeCode.BarcodeEncodedAsCode128, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Barcode encoded according to the Code 25 standard.
    /// Encoded/decoded by serializers as &quot;C025&quot;.
    /// </summary>
    [EnumMember(Value = "C025")]
    [IsoId("_0Pz8gduZEeiB5uLfkg9ZJA")]
    [Description(@"Barcode encoded according to the Code 25 standard.")]
    BarcodeEncodedAsCode25 = BarcodeTypeCode.BarcodeEncodedAsCode25, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Barcode encoded according to the Code 39 standard.
    /// Encoded/decoded by serializers as &quot;C039&quot;.
    /// </summary>
    [EnumMember(Value = "C039")]
    [IsoId("_0TuMIduZEeiB5uLfkg9ZJA")]
    [Description(@"Barcode encoded according to the Code 39 standard.")]
    BarcodeEncodedAsCode39 = BarcodeTypeCode.BarcodeEncodedAsCode39, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Barcode encoded according to the EAN13 standard.
    /// Encoded/decoded by serializers as &quot;EA13&quot;.
    /// </summary>
    [EnumMember(Value = "EA13")]
    [IsoId("_0XfR0duZEeiB5uLfkg9ZJA")]
    [Description(@"Barcode encoded according to the EAN13 standard.")]
    BarcodeEncodedAsEA13 = BarcodeTypeCode.BarcodeEncodedAsEA13, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Barcode encoded according to the EAN8 standard.
    /// Encoded/decoded by serializers as &quot;EAN8&quot;.
    /// </summary>
    [EnumMember(Value = "EAN8")]
    [IsoId("_0d1KYduZEeiB5uLfkg9ZJA")]
    [Description(@"Barcode encoded according to the EAN8 standard.")]
    BarcodeEncodedAsEAN8 = BarcodeTypeCode.BarcodeEncodedAsEAN8, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Barcode encoded according to the PDF417 standard.
    /// Encoded/decoded by serializers as &quot;P417&quot;.
    /// </summary>
    [EnumMember(Value = "P417")]
    [IsoId("_0h0SgduZEeiB5uLfkg9ZJA")]
    [Description(@"Barcode encoded according to the PDF417 standard.")]
    BarcodeEncodedAsPDF417 = BarcodeTypeCode.BarcodeEncodedAsPDF417, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Barcode encoded according to the UPCA standard.
    /// Encoded/decoded by serializers as &quot;UPCA&quot;.
    /// </summary>
    [EnumMember(Value = "UPCA")]
    [IsoId("_0mNqUduZEeiB5uLfkg9ZJA")]
    [Description(@"Barcode encoded according to the UPCA standard.")]
    BarcodeEncodedAsUPCA = BarcodeTypeCode.BarcodeEncodedAsUPCA, // same ordinal as derivation source for type conversions
}
