// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Status to define the completeness of information contained in the notification.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Vp_FU9p-Ed-ak6NoX_4Aeg_-86852675")]
[Description(@"Status to define the completeness of information contained in the notification.")]
[DerivedFrom(typeof(NotificationStatusCode))]
public enum NotificationStatus1Code
{
    /// <summary>
    /// The notification contains all the details.
    /// Encoded/decoded by serializers as &quot;COMP&quot;.
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_Vp_FVNp-Ed-ak6NoX_4Aeg_218831864")]
    [Description(@"The notification contains all the details.")]
    Complete = NotificationStatusCode.Complete, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Notification may not contain complete details, however, the occurrence of the event has been confirmed by the issuer or other official source.
    /// Encoded/decoded by serializers as &quot;PREC&quot;.
    /// </summary>
    [EnumMember(Value = "PREC")]
    [IsoId("_Vp_FVdp-Ed-ak6NoX_4Aeg_232685128")]
    [Description(@"Notification may not contain complete details, however, the occurrence of the event has been confirmed by the issuer or other official source.")]
    PreliminaryEventConfirmed = NotificationStatusCode.PreliminaryEventConfirmed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Notification may not contain complete details as the occurrence of the event has not been confirmed by the issuer or other official source at the time the notification was sent.
    /// Encoded/decoded by serializers as &quot;PREU&quot;.
    /// </summary>
    [EnumMember(Value = "PREU")]
    [IsoId("_Vp_FVtp-Ed-ak6NoX_4Aeg_288094847")]
    [Description(@"Notification may not contain complete details as the occurrence of the event has not been confirmed by the issuer or other official source at the time the notification was sent.")]
    PreliminaryEventUnconfirmed = NotificationStatusCode.PreliminaryEventUnconfirmed, // same ordinal as derivation source for type conversions
    
}
