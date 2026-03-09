// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Byte padding for a cypher block chaining mode encryption, if the padding is not implicit.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_zBfYoGi9EeS87LmvcA55sg")]
[Description(@"Byte padding for a cypher block chaining mode encryption, if the padding is not implicit.")]
[DerivedFrom(typeof(BytePaddingCode))]
public enum BytePadding1Code
{
    /// <summary>
    /// Message to encrypt is completed by a byte value containing the total number of added bytes.
    /// Encoded/decoded by serializers as &quot;LNGT&quot;.
    /// </summary>
    [EnumMember(Value = "LNGT")]
    [IsoId("_3sV-MWi9EeS87LmvcA55sg")]
    [Description(@"Message to encrypt is completed by a byte value containing the total number of added bytes.")]
    LengthPadding = BytePaddingCode.LengthPadding, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Message to encrypt is completed by one bit of value 1, followed by null bits until the encryption block length is reached.
    /// Encoded/decoded by serializers as &quot;NUL8&quot;.
    /// </summary>
    [EnumMember(Value = "NUL8")]
    [IsoId("_3x6asWi9EeS87LmvcA55sg")]
    [Description(@"Message to encrypt is completed by one bit of value 1, followed by null bits until the encryption block length is reached.")]
    Null80Padding = BytePaddingCode.Null80Padding, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Message to encrypt is completed by null byte values, the last byte containing the total number of added bytes.
    /// Encoded/decoded by serializers as &quot;NULG&quot;.
    /// </summary>
    [EnumMember(Value = "NULG")]
    [IsoId("_344lYWi9EeS87LmvcA55sg")]
    [Description(@"Message to encrypt is completed by null byte values, the last byte containing the total number of added bytes.")]
    NullLengthPadding = BytePaddingCode.NullLengthPadding, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Message to encrypt is completed by null bytes.
    /// Encoded/decoded by serializers as &quot;NULL&quot;.
    /// </summary>
    [EnumMember(Value = "NULL")]
    [IsoId("_3-_NYWi9EeS87LmvcA55sg")]
    [Description(@"Message to encrypt is completed by null bytes.")]
    NullPadding = BytePaddingCode.NullPadding, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Message to encrypt is completed by random value, the last byte containing the total number of added bytes.
    /// Encoded/decoded by serializers as &quot;RAND&quot;.
    /// </summary>
    [EnumMember(Value = "RAND")]
    [IsoId("_4Hdz8Wi9EeS87LmvcA55sg")]
    [Description(@"Message to encrypt is completed by random value, the last byte containing the total number of added bytes.")]
    RandomPadding = BytePaddingCode.RandomPadding, // same ordinal as derivation source for type conversions
    
}
