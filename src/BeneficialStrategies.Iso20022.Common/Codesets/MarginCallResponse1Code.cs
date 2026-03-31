// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the margin call request was sent on a non valuation day or was received after notification time.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Yc8VJtp-Ed-ak6NoX_4Aeg_-352735605")]
[Description(
    @"Specifies whether the margin call request was sent on a non valuation day or was received after notification time."
)]
[DerivedFrom(typeof(MarginCallResponseCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<MarginCallResponse1Code>))]
#endif
public enum MarginCallResponse1Code
{
    /// <summary>
    /// Indicates that the margin call request was sent on a non valuation day.
    /// Encoded/decoded by serializers as &quot;NVDA&quot;.
    /// </summary>
    [EnumMember(Value = "NVDA")]
    [IsoId("_Yc8VJ9p-Ed-ak6NoX_4Aeg_661474467")]
    [Description(@"Indicates that the margin call request was sent on a non valuation day.")]
    NonValuationDay = MarginCallResponseCode.NonValuationDay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates that the margin call request was sent after the notification time.
    /// Encoded/decoded by serializers as &quot;RANT&quot;.
    /// </summary>
    [EnumMember(Value = "RANT")]
    [IsoId("_Yc8VKNp-Ed-ak6NoX_4Aeg_-631136566")]
    [Description(@"Indicates that the margin call request was sent after the notification time.")]
    ReceivedAfterNotificationTime = MarginCallResponseCode.ReceivedAfterNotificationTime, // same ordinal as derivation source for type conversions
}
