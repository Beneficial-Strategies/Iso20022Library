// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Encoding Mode of Quick Response Code.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_dB7rMNuaEeiB5uLfkg9ZJA")]
[Description(@"Encoding Mode of Quick Response Code.")]
[DerivedFrom(typeof(QRCodeEncodingModeCode))]
public enum QRCodeEncodingMode1Code
{
    /// <summary>
    /// Alphanumeric value provided in Barcode field.
    /// Encoded/decoded by serializers as &quot;ALFA&quot;.
    /// </summary>
    [EnumMember(Value = "ALFA")]
    [IsoId("_C2JMYdudEeiB5uLfkg9ZJA")]
    [Description(@"Alphanumeric value provided in Barcode field.")]
    Alphanumeric = QRCodeEncodingModeCode.Alphanumeric, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Binary value provided in Quick Response Code Binary Value.
    /// Encoded/decoded by serializers as &quot;BINA&quot;.
    /// </summary>
    [EnumMember(Value = "BINA")]
    [IsoId("_C6I7kdudEeiB5uLfkg9ZJA")]
    [Description(@"Binary value provided in Quick Response Code Binary Value.")]
    Binary = QRCodeEncodingModeCode.Binary, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Kanji value provided in Quick Response Code Binary Value.
    /// Encoded/decoded by serializers as &quot;KANJ&quot;.
    /// </summary>
    [EnumMember(Value = "KANJ")]
    [IsoId("_C-EZUdudEeiB5uLfkg9ZJA")]
    [Description(@"Kanji value provided in Quick Response Code Binary Value.")]
    Kanji = QRCodeEncodingModeCode.Kanji, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Numeric value provided in Barcode field.
    /// Encoded/decoded by serializers as &quot;NUME&quot;.
    /// </summary>
    [EnumMember(Value = "NUME")]
    [IsoId("_DCOgkdudEeiB5uLfkg9ZJA")]
    [Description(@"Numeric value provided in Barcode field.")]
    Numeric = QRCodeEncodingModeCode.Numeric, // same ordinal as derivation source for type conversions
}
