// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if the occurrence of the event contained in the notification is confirmed or unconfirmed. Details of the event can be complete or incomplete.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aN5VZdp-Ed-ak6NoX_4Aeg_-927913400")]
[Description(
    @"Specifies if the occurrence of the event contained in the notification is confirmed or unconfirmed. Details of the event can be complete or incomplete."
)]
[Derivations(typeof(NotificationStatus2Code))]
public enum NotificationStatusCode
{
    /// <summary>
    /// The notification contains all the details.
    /// Encoded/decoded by serializers as &quot;COMP&quot;.
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_aN5VZtp-Ed-ak6NoX_4Aeg_-2057646880")]
    [Description(@"The notification contains all the details.")]
    Complete,

    /// <summary>
    /// Notification may not contain complete details, however, the occurrence of the event has been confirmed by the issuer or other official source.
    /// Encoded/decoded by serializers as &quot;PREC&quot;.
    /// </summary>
    [EnumMember(Value = "PREC")]
    [IsoId("_aN5VZ9p-Ed-ak6NoX_4Aeg_-1569105629")]
    [Description(
        @"Notification may not contain complete details, however, the occurrence of the event has been confirmed by the issuer or other official source."
    )]
    PreliminaryEventConfirmed,

    /// <summary>
    /// Notification may not contain complete details as the occurrence of the event has not been confirmed by the issuer or other official source at the time the notification was sent.
    /// Encoded/decoded by serializers as &quot;PREU&quot;.
    /// </summary>
    [EnumMember(Value = "PREU")]
    [IsoId("_aN5VaNp-Ed-ak6NoX_4Aeg_-313114775")]
    [Description(
        @"Notification may not contain complete details as the occurrence of the event has not been confirmed by the issuer or other official source at the time the notification was sent."
    )]
    PreliminaryEventUnconfirmed,

    /// <summary>
    /// Notification may not contain complete details, however, the occurrence of the event has been confirmed by the issuer or other official source.
    /// Encoded/decoded by serializers as &quot;ECON&quot;.
    /// </summary>
    [EnumMember(Value = "ECON")]
    [IsoId("_aODGYNp-Ed-ak6NoX_4Aeg_373949805")]
    [Description(
        @"Notification may not contain complete details, however, the occurrence of the event has been confirmed by the issuer or other official source."
    )]
    EventConfirmed,

    /// <summary>
    /// The occurrence of the event has not been confirmed by the issuer or other official source at the time the notification was sent.
    /// Encoded/decoded by serializers as &quot;EUNC&quot;.
    /// </summary>
    [EnumMember(Value = "EUNC")]
    [IsoId("_aODGYdp-Ed-ak6NoX_4Aeg_377642934")]
    [Description(
        @"The occurrence of the event has not been confirmed by the issuer or other official source at the time the notification was sent."
    )]
    EventUnconfirmed,
}
