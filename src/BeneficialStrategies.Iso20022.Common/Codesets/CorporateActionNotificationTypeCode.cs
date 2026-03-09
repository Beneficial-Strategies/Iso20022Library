// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of notification.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bLJAw9p-Ed-ak6NoX_4Aeg_-765647150")]
[Description(@"Type of notification.")]
[Derivations(typeof(CorporateActionNotificationType1Code),typeof(CorporateActionNotificationType2Code),typeof(NotificationType3Code),typeof(NotificationType2Code))]
public enum CorporateActionNotificationTypeCode
{
    /// <summary>
    /// New notification.
    /// Encoded/decoded by serializers as &quot;NEWM&quot;.
    /// </summary>
    [EnumMember(Value = "NEWM")]
    [IsoId("_bLJAxNp-Ed-ak6NoX_4Aeg_-464577409")]
    [Description(@"New notification.")]
    New,
    
    /// <summary>
    /// Notification replacing a previously sent notification.
    /// Encoded/decoded by serializers as &quot;REPL&quot;.
    /// </summary>
    [EnumMember(Value = "REPL")]
    [IsoId("_bLJAxdp-Ed-ak6NoX_4Aeg_-379615464")]
    [Description(@"Notification replacing a previously sent notification.")]
    Replacement,
    
    /// <summary>
    /// Notification sent as a reminder of an event taking place.
    /// Encoded/decoded by serializers as &quot;RMDR&quot;.
    /// </summary>
    [EnumMember(Value = "RMDR")]
    [IsoId("_bLJAxtp-Ed-ak6NoX_4Aeg_-278951583")]
    [Description(@"Notification sent as a reminder of an event taking place.")]
    Reminder,
    
    /// <summary>
    /// Notification sent to void a previously sent notification due to the withdrawal of the event by the issuer.
    /// Encoded/decoded by serializers as &quot;WITH&quot;.
    /// </summary>
    [EnumMember(Value = "WITH")]
    [IsoId("_bLJAx9p-Ed-ak6NoX_4Aeg_53517418")]
    [Description(@"Notification sent to void a previously sent notification due to the withdrawal of the event by the issuer.")]
    Withrawal,
    
    /// <summary>
    /// Notification requesting the cancellation of a previously sent notification.
    /// Encoded/decoded by serializers as &quot;CANC&quot;.
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_bLJAyNp-Ed-ak6NoX_4Aeg_1834128888")]
    [Description(@"Notification requesting the cancellation of a previously sent notification.")]
    Cancellation,
    
    /// <summary>
    /// Cancellation due to a processing error.
    /// Encoded/decoded by serializers as &quot;PROC&quot;.
    /// </summary>
    [EnumMember(Value = "PROC")]
    [IsoId("_bLSxwNp-Ed-ak6NoX_4Aeg_168776981")]
    [Description(@"Cancellation due to a processing error.")]
    Processing,
    
}
