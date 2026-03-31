// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies how the holding is blocked.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_AFmrABKgEeKj15WxqwlXPw")]
[Description(@"Specifies how the holding is blocked.")]
[DerivedFrom(typeof(HoldingCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<Holding1Code>))]
#endif
public enum Holding1Code
{
    /// <summary>
    /// Certificate.
    /// Encoded/decoded by serializers as &quot;CERT&quot;.
    /// </summary>
    [EnumMember(Value = "CERT")]
    [IsoId("_HrQ00RKgEeKj15WxqwlXPw")]
    [Description(@"Certificate.")]
    Certificate = HoldingCode.Certificate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Non partial holding.
    /// Encoded/decoded by serializers as &quot;NPRH&quot;.
    /// </summary>
    [EnumMember(Value = "NPRH")]
    [IsoId("_H08VQRKgEeKj15WxqwlXPw")]
    [Description(@"Non partial holding.")]
    NonPartialHolding = HoldingCode.NonPartialHolding, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Partial holding.
    /// Encoded/decoded by serializers as &quot;PRTH&quot;.
    /// </summary>
    [EnumMember(Value = "PRTH")]
    [IsoId("_IBT9URKgEeKj15WxqwlXPw")]
    [Description(@"Partial holding.")]
    PartialHolding = HoldingCode.PartialHolding, // same ordinal as derivation source for type conversions
}
