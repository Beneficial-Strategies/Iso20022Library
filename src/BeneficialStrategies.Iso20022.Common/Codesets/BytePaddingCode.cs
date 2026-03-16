// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Byte padding for a cypher block chaining mode encryption, if the padding is not implicit.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_NOnpUGi9EeS87LmvcA55sg")]
[Description(
    @"Byte padding for a cypher block chaining mode encryption, if the padding is not implicit."
)]
[Derivations(typeof(BytePadding1Code))]
public enum BytePaddingCode
{
    /// <summary>
    /// Message to encrypt is completed by a byte value containing the total number of added bytes.
    /// Encoded/decoded by serializers as &quot;LNGT&quot;.
    /// </summary>
    [EnumMember(Value = "LNGT")]
    [IsoId("_SKu-AGi9EeS87LmvcA55sg")]
    [Description(
        @"Message to encrypt is completed by a byte value containing the total number of added bytes."
    )]
    LengthPadding,

    /// <summary>
    /// Message to encrypt is completed by one bit of value 1, followed by null bits until the encryption block length is reached.
    /// Encoded/decoded by serializers as &quot;NUL8&quot;.
    /// </summary>
    [EnumMember(Value = "NUL8")]
    [IsoId("_XA738Gi9EeS87LmvcA55sg")]
    [Description(
        @"Message to encrypt is completed by one bit of value 1, followed by null bits until the encryption block length is reached."
    )]
    Null80Padding,

    /// <summary>
    /// Message to encrypt is completed by null byte values, the last byte containing the total number of added bytes.
    /// Encoded/decoded by serializers as &quot;NULG&quot;.
    /// </summary>
    [EnumMember(Value = "NULG")]
    [IsoId("_bkh-8Gi9EeS87LmvcA55sg")]
    [Description(
        @"Message to encrypt is completed by null byte values, the last byte containing the total number of added bytes."
    )]
    NullLengthPadding,

    /// <summary>
    /// Message to encrypt is completed by null bytes.
    /// Encoded/decoded by serializers as &quot;NULL&quot;.
    /// </summary>
    [EnumMember(Value = "NULL")]
    [IsoId("_lAGhgGi9EeS87LmvcA55sg")]
    [Description(@"Message to encrypt is completed by null bytes.")]
    NullPadding,

    /// <summary>
    /// Message to encrypt is completed by random value, the last byte containing the total number of added bytes.
    /// Encoded/decoded by serializers as &quot;RAND&quot;.
    /// </summary>
    [EnumMember(Value = "RAND")]
    [IsoId("_pMu6AGi9EeS87LmvcA55sg")]
    [Description(
        @"Message to encrypt is completed by random value, the last byte containing the total number of added bytes."
    )]
    RandomPadding,
}
