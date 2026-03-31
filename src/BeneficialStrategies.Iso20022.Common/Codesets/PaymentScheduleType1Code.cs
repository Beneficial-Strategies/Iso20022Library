// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a payment schedule type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_y3zBIAqPEeWqX7rjSIiMuQ")]
[Description(@"Specifies a payment schedule type.")]
[DerivedFrom(typeof(PaymentScheduleTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<PaymentScheduleType1Code>))]
#endif
public enum PaymentScheduleType1Code
{
    /// <summary>
    /// Payment schedule is defined as per contract.
    /// Encoded/decoded by serializers as &quot;CNTR&quot;.
    /// </summary>
    [EnumMember(Value = "CNTR")]
    [IsoId("_0Cn1gQqPEeWqX7rjSIiMuQ")]
    [Description(@"Payment schedule is defined as per contract.")]
    Contract = PaymentScheduleTypeCode.Contract, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment schedule is estimated.
    /// Encoded/decoded by serializers as &quot;ESTM&quot;.
    /// </summary>
    [EnumMember(Value = "ESTM")]
    [IsoId("_0H1FoQqPEeWqX7rjSIiMuQ")]
    [Description(@"Payment schedule is estimated.")]
    Estimated = PaymentScheduleTypeCode.Estimated, // same ordinal as derivation source for type conversions
}
