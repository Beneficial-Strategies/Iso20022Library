// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of notification advice.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bK_Pxdp-Ed-ak6NoX_4Aeg_724518589")]
[Description(@"Type of notification advice.")]
[DerivedFrom(typeof(CorporateActionNotificationTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CorporateActionNotificationType1Code>))]
#endif
public enum CorporateActionNotificationType1Code
{
    /// <summary>
    /// New notification.
    /// Encoded/decoded by serializers as &quot;NEWM&quot;.
    /// </summary>
    [EnumMember(Value = "NEWM")]
    [IsoId("_bK_Pxtp-Ed-ak6NoX_4Aeg_724518620")]
    [Description(@"New notification.")]
    New = CorporateActionNotificationTypeCode.New, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Notification replacing a previously sent notification.
    /// Encoded/decoded by serializers as &quot;REPL&quot;.
    /// </summary>
    [EnumMember(Value = "REPL")]
    [IsoId("_bK_Px9p-Ed-ak6NoX_4Aeg_724518628")]
    [Description(@"Notification replacing a previously sent notification.")]
    Replacement = CorporateActionNotificationTypeCode.Replacement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Notification sent as a reminder of an event taking place.
    /// Encoded/decoded by serializers as &quot;RMDR&quot;.
    /// </summary>
    [EnumMember(Value = "RMDR")]
    [IsoId("_bK_PyNp-Ed-ak6NoX_4Aeg_724518629")]
    [Description(@"Notification sent as a reminder of an event taking place.")]
    Reminder = CorporateActionNotificationTypeCode.Reminder, // same ordinal as derivation source for type conversions
}
