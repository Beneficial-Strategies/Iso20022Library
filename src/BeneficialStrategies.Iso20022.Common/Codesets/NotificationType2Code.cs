// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of notification.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hl_zUK7wEemG7MmivSuE5g")]
[Description(@"Specifies a type of notification.")]
[DerivedFrom(typeof(CorporateActionNotificationTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<NotificationType2Code>))]
#endif
public enum NotificationType2Code
{
    /// <summary>
    /// New notification.
    /// Encoded/decoded by serializers as &quot;NEWM&quot;.
    /// </summary>
    [EnumMember(Value = "NEWM")]
    [IsoId("_sC4o8a7wEemG7MmivSuE5g")]
    [Description(@"New notification.")]
    New = CorporateActionNotificationTypeCode.New, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Notification replacing a previously sent notification.
    /// Encoded/decoded by serializers as &quot;REPL&quot;.
    /// </summary>
    [EnumMember(Value = "REPL")]
    [IsoId("_sP-pwq7wEemG7MmivSuE5g")]
    [Description(@"Notification replacing a previously sent notification.")]
    Replacement = CorporateActionNotificationTypeCode.Replacement, // same ordinal as derivation source for type conversions
}
