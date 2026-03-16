// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Format used for encrypted data.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_f43y0AHzEeiJObvChJn-OA")]
[Description(@"Format used for encrypted data.")]
[DerivedFrom(typeof(EncryptedDataFormatCode))]
public enum EncryptedDataFormat1Code
{
    /// <summary>
    /// ASCII Format.
    /// Encoded/decoded by serializers as &quot;ASCI&quot;.
    /// </summary>
    [EnumMember(Value = "ASCI")]
    [IsoId("_kQkL0QHzEeiJObvChJn-OA")]
    [Description(@"ASCII Format.")]
    ASCII = EncryptedDataFormatCode.ASCII, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Binary format.
    /// Encoded/decoded by serializers as &quot;BINF&quot;.
    /// </summary>
    [EnumMember(Value = "BINF")]
    [IsoId("_kd9HkgHzEeiJObvChJn-OA")]
    [Description(@"Binary format.")]
    Binary = EncryptedDataFormatCode.Binary, // same ordinal as derivation source for type conversions

    /// <summary>
    /// EBCDIC format.
    /// Encoded/decoded by serializers as &quot;EBCD&quot;.
    /// </summary>
    [EnumMember(Value = "EBCD")]
    [IsoId("_kryvQgHzEeiJObvChJn-OA")]
    [Description(@"EBCDIC format.")]
    EBCDIC = EncryptedDataFormatCode.EBCDIC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// HEX Format.
    /// Encoded/decoded by serializers as &quot;HEXF&quot;.
    /// </summary>
    [EnumMember(Value = "HEXF")]
    [IsoId("_k-1AAgHzEeiJObvChJn-OA")]
    [Description(@"HEX Format.")]
    HEX = EncryptedDataFormatCode.HEX, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other format defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_lNtJggHzEeiJObvChJn-OA")]
    [Description(@"Other format defined at national level.")]
    OtherNational = EncryptedDataFormatCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other type of format defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_lb_dIgHzEeiJObvChJn-OA")]
    [Description(@"Other type of format defined at private level.")]
    OtherPrivate = EncryptedDataFormatCode.OtherPrivate, // same ordinal as derivation source for type conversions
}
