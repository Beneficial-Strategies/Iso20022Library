// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a drawdown status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_InkecFKjEeiSDqv62fL07g")]
[Description(@"Specifies a drawdown status.")]
[DerivedFrom(typeof(DrawdownStatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<DrawdownStatus1Code>))]
#endif
public enum DrawdownStatus1Code
{
    /// <summary>
    /// Pension is fully in drawdown.
    /// Encoded/decoded by serializers as &quot;FULL&quot;.
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("_KDEMEVKjEeiSDqv62fL07g")]
    [Description(@"Pension is fully in drawdown.")]
    Full = DrawdownStatusCode.Full, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pension is not in drawdown.
    /// Encoded/decoded by serializers as &quot;NONE&quot;.
    /// </summary>
    [EnumMember(Value = "NONE")]
    [IsoId("_KIthEVKjEeiSDqv62fL07g")]
    [Description(@"Pension is not in drawdown.")]
    None = DrawdownStatusCode.None, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pension is in partial drawdown.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_KNesUVKjEeiSDqv62fL07g")]
    [Description(@"Pension is in partial drawdown.")]
    Partial = DrawdownStatusCode.Partial, // same ordinal as derivation source for type conversions
}
