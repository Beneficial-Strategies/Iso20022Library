// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of notification.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_u-L_cK7PEemG7MmivSuE5g")]
[Description(@"Specifies a type of notification.")]
[DerivedFrom(typeof(CorporateActionNotificationTypeCode))]
public enum NotificationType3Code
{
    /// <summary>
    /// New notification.
    /// Encoded/decoded by serializers as &quot;NEWM&quot;.
    /// </summary>
    [EnumMember(Value = "NEWM")]
    [IsoId("_1FTusa7PEemG7MmivSuE5g")]
    [Description(@"New notification.")]
    New = CorporateActionNotificationTypeCode.New, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Notification replacing a previously sent notification.
    /// Encoded/decoded by serializers as &quot;REPL&quot;.
    /// </summary>
    [EnumMember(Value = "REPL")]
    [IsoId("_1SZvgq7PEemG7MmivSuE5g")]
    [Description(@"Notification replacing a previously sent notification.")]
    Replacement = CorporateActionNotificationTypeCode.Replacement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Notification sent as a reminder of an event taking place.
    /// Encoded/decoded by serializers as &quot;RMDR&quot;.
    /// </summary>
    [EnumMember(Value = "RMDR")]
    [IsoId("_1avMIq7PEemG7MmivSuE5g")]
    [Description(@"Notification sent as a reminder of an event taking place.")]
    Reminder = CorporateActionNotificationTypeCode.Reminder, // same ordinal as derivation source for type conversions
    
}
