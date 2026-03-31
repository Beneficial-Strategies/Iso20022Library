// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of notification cancellation request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bLJAwNp-Ed-ak6NoX_4Aeg_746682206")]
[Description(@"Type of notification cancellation request.")]
[DerivedFrom(typeof(CorporateActionNotificationTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CorporateActionNotificationType2Code>))]
#endif
public enum CorporateActionNotificationType2Code
{
    /// <summary>
    /// Notification sent to void a previously sent notification due to the withdrawal of the event by the issuer.
    /// Encoded/decoded by serializers as &quot;WITH&quot;.
    /// </summary>
    [EnumMember(Value = "WITH")]
    [IsoId("_bLJAwdp-Ed-ak6NoX_4Aeg_746682216")]
    [Description(
        @"Notification sent to void a previously sent notification due to the withdrawal of the event by the issuer."
    )]
    Withrawal = CorporateActionNotificationTypeCode.Withrawal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Notification requesting the cancellation of a previously sent notification.
    /// Encoded/decoded by serializers as &quot;CANC&quot;.
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_bLJAwtp-Ed-ak6NoX_4Aeg_746682237")]
    [Description(@"Notification requesting the cancellation of a previously sent notification.")]
    Cancellation = CorporateActionNotificationTypeCode.Cancellation, // same ordinal as derivation source for type conversions
}
