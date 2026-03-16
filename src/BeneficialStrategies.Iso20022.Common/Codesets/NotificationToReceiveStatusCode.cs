// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether or not the event as mentioned in the notification occurred. Details of the event can be different from the details as per notification.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aODGYtp-Ed-ak6NoX_4Aeg_1172047099")]
[Description(
    @"Specifies whether or not the event as mentioned in the notification occurred. Details of the event can be different from the details as per notification."
)]
[Derivations(typeof(NotificationStatus3Code))]
public enum NotificationToReceiveStatusCode
{
    /// <summary>
    /// Event(s) as described in the notification to receive occurred but details are different.
    /// Encoded/decoded by serializers as &quot;RCBD&quot;.
    /// </summary>
    [EnumMember(Value = "RCBD")]
    [IsoId("_aODGY9p-Ed-ak6NoX_4Aeg_1172047117")]
    [Description(
        @"Event(s) as described in the notification to receive occurred but details are different."
    )]
    ReceivedButDifferent,

    /// <summary>
    /// Event(s) as described in the notification to receive occurred.
    /// Encoded/decoded by serializers as &quot;RCVD&quot;.
    /// </summary>
    [EnumMember(Value = "RCVD")]
    [IsoId("_aODGZNp-Ed-ak6NoX_4Aeg_1172047143")]
    [Description(@"Event(s) as described in the notification to receive occurred.")]
    Received,

    /// <summary>
    /// Event(s) as described in the notification to receive did not occur.
    /// Encoded/decoded by serializers as &quot;NRCD&quot;.
    /// </summary>
    [EnumMember(Value = "NRCD")]
    [IsoId("_aODGZdp-Ed-ak6NoX_4Aeg_1172047219")]
    [Description(@"Event(s) as described in the notification to receive did not occur.")]
    NotReceived,
}
