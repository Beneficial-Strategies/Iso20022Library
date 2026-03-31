// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the proceeds of the event will be distributed on a rolling basis rather than on a specific date.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hyWl0QCpEeGbSb1IG15gpQ")]
[Description(
    @"Specifies whether the proceeds of the event will be distributed on a rolling basis rather than on a specific date."
)]
[DerivedFrom(typeof(DistributionTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<DistributionType2Code>))]
#endif
public enum DistributionType2Code
{
    /// <summary>
    /// Event will have a number of acceptance and payment dates until further announcement by the Issuer or its agent.
    /// Encoded/decoded by serializers as &quot;ROLL&quot;.
    /// </summary>
    [EnumMember(Value = "ROLL")]
    [IsoId("_hyWl1wCpEeGbSb1IG15gpQ")]
    [Description(
        @"Event will have a number of acceptance and payment dates until further announcement by the Issuer or its agent."
    )]
    RollingBasis = DistributionTypeCode.RollingBasis, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Interim payment.
    /// Encoded/decoded by serializers as &quot;INTE&quot;.
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_iKy7BgCpEeGbSb1IG15gpQ")]
    [Description(@"Interim payment.")]
    Interim = DistributionTypeCode.Interim, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Final payment.
    /// Encoded/decoded by serializers as &quot;FINL&quot;.
    /// </summary>
    [EnumMember(Value = "FINL")]
    [IsoId("_iN7HhgCpEeGbSb1IG15gpQ")]
    [Description(@"Final payment.")]
    Final = DistributionTypeCode.Final, // same ordinal as derivation source for type conversions
}
