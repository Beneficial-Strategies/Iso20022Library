// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of rate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_uBQBEQCoEeGt2odvTAOpog")]
[Description(@"Specifies the type of rate.")]
[DerivedFrom(typeof(RateTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<RateType10Code>))]
#endif
public enum RateType10Code
{
    /// <summary>
    /// Any and all rate is sought.
    /// Encoded/decoded by serializers as &quot;ANYA&quot;.
    /// </summary>
    [EnumMember(Value = "ANYA")]
    [IsoId("_uBZyFQCoEeGt2odvTAOpog")]
    [Description(@"Any and all rate is sought.")]
    AnyAndAll = RateTypeCode.AnyAndAll, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rate is unknown by the sender or has not been established.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_wN7UAgCoEeGt2odvTAOpog")]
    [Description(@"Rate is unknown by the sender or has not been established.")]
    Unknown = RateTypeCode.Unknown, // same ordinal as derivation source for type conversions
}
