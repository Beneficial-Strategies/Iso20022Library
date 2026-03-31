// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for a suspended status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Vk6_Ktp-Ed-ak6NoX_4Aeg_397035063")]
[Description(@"Specifies the reason for a suspended status.")]
[DerivedFrom(typeof(SuspendedStatusReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<SuspendedStatusReason2Code>))]
#endif
public enum SuspendedStatusReason2Code
{
    /// <summary>
    /// There is a suspension of pricing. The order will stay on the books until the next pricing.
    /// Encoded/decoded by serializers as &quot;PRIC&quot;.
    /// </summary>
    [EnumMember(Value = "PRIC")]
    [IsoId("_VlEJENp-Ed-ak6NoX_4Aeg_453368006")]
    [Description(
        @"There is a suspension of pricing. The order will stay on the books until the next pricing."
    )]
    PriceSuspension = SuspendedStatusReasonCode.PriceSuspension, // same ordinal as derivation source for type conversions

    /// <summary>
    /// There is a fund overflow.
    /// Encoded/decoded by serializers as &quot;FLOW&quot;.
    /// </summary>
    [EnumMember(Value = "FLOW")]
    [IsoId("_VlEJEdp-Ed-ak6NoX_4Aeg_469993316")]
    [Description(@"There is a fund overflow.")]
    Overflow = SuspendedStatusReasonCode.Overflow, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Another reason for the status suspended.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_VlEJEtp-Ed-ak6NoX_4Aeg_100672757")]
    [Description(@"Another reason for the status suspended.")]
    Other = SuspendedStatusReasonCode.Other, // same ordinal as derivation source for type conversions
}
