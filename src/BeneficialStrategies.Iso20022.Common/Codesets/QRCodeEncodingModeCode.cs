// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Encoding Mode of Quick Response Code.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Lg9HwNuaEeiB5uLfkg9ZJA")]
[Description(@"Encoding Mode of Quick Response Code.")]
[Derivations(typeof(QRCodeEncodingMode1Code))]
public enum QRCodeEncodingModeCode
{
    /// <summary>
    /// Numeric value provided in Barcode field.
    /// Encoded/decoded by serializers as &quot;NUME&quot;.
    /// </summary>
    [EnumMember(Value = "NUME")]
    [IsoId("_P-7H4NuaEeiB5uLfkg9ZJA")]
    [Description(@"Numeric value provided in Barcode field.")]
    Numeric,
    
    /// <summary>
    /// Alphanumeric value provided in Barcode field.
    /// Encoded/decoded by serializers as &quot;ALFA&quot;.
    /// </summary>
    [EnumMember(Value = "ALFA")]
    [IsoId("_TEhm4NuaEeiB5uLfkg9ZJA")]
    [Description(@"Alphanumeric value provided in Barcode field.")]
    Alphanumeric,
    
    /// <summary>
    /// Binary value provided in Quick Response Code Binary Value.
    /// Encoded/decoded by serializers as &quot;BINA&quot;.
    /// </summary>
    [EnumMember(Value = "BINA")]
    [IsoId("_W1ZQcNuaEeiB5uLfkg9ZJA")]
    [Description(@"Binary value provided in Quick Response Code Binary Value.")]
    Binary,
    
    /// <summary>
    /// Kanji value provided in Quick Response Code Binary Value.
    /// Encoded/decoded by serializers as &quot;KANJ&quot;.
    /// </summary>
    [EnumMember(Value = "KANJ")]
    [IsoId("_aEJEYNuaEeiB5uLfkg9ZJA")]
    [Description(@"Kanji value provided in Quick Response Code Binary Value.")]
    Kanji,
    
}
