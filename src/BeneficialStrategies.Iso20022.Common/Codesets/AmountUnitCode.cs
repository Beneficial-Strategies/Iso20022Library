// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Unit of a amount (for loyalty or account).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YOwqMNtlEeipuvJHTHIw9A")]
[Description(@"Unit of a amount (for loyalty or account).")]
[Derivations(typeof(AmountUnit1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AmountUnitCode>))]
#endif
public enum AmountUnitCode
{
    /// <summary>
    /// The amount is expressed in point.
    /// Encoded/decoded by serializers as &quot;POIN&quot;.
    /// </summary>
    [EnumMember(Value = "POIN")]
    [IsoId("_bvF9YNtlEeipuvJHTHIw9A")]
    [Description(@"The amount is expressed in point.")]
    Point,

    /// <summary>
    /// The amount is expressed in a monetary value in a currency.
    /// Encoded/decoded by serializers as &quot;MONE&quot;.
    /// </summary>
    [EnumMember(Value = "MONE")]
    [IsoId("_eaRKMNtlEeipuvJHTHIw9A")]
    [Description(@"The amount is expressed in a monetary value in a currency.")]
    Monetary,
}
