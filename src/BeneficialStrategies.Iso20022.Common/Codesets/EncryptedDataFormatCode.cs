// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Format used to encrypt the data.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_lupawAHwEeiJObvChJn-OA")]
[Description(@"Format used to encrypt the data.")]
[Derivations(typeof(EncryptedDataFormat1Code))]
public enum EncryptedDataFormatCode
{
    /// <summary>
    /// ASCII Format.
    /// Encoded/decoded by serializers as &quot;ASCI&quot;.
    /// </summary>
    [EnumMember(Value = "ASCI")]
    [IsoId("_xUSBIAHwEeiJObvChJn-OA")]
    [Description(@"ASCII Format.")]
    ASCII,

    /// <summary>
    /// HEX Format.
    /// Encoded/decoded by serializers as &quot;HEXF&quot;.
    /// </summary>
    [EnumMember(Value = "HEXF")]
    [IsoId("_33X6sAHwEeiJObvChJn-OA")]
    [Description(@"HEX Format.")]
    HEX,

    /// <summary>
    /// Binary format.
    /// Encoded/decoded by serializers as &quot;BINF&quot;.
    /// </summary>
    [EnumMember(Value = "BINF")]
    [IsoId("_FUVPEAHxEeiJObvChJn-OA")]
    [Description(@"Binary format.")]
    Binary,

    /// <summary>
    /// Other format defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_VyY88AHxEeiJObvChJn-OA")]
    [Description(@"Other format defined at national level.")]
    OtherNational,

    /// <summary>
    /// Other type of format defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_a5ZTAAHxEeiJObvChJn-OA")]
    [Description(@"Other type of format defined at private level.")]
    OtherPrivate,

    /// <summary>
    /// EBCDIC format.
    /// Encoded/decoded by serializers as &quot;EBCD&quot;.
    /// </summary>
    [EnumMember(Value = "EBCD")]
    [IsoId("_V0-sAAHzEeiJObvChJn-OA")]
    [Description(@"EBCDIC format.")]
    EBCDIC,
}
