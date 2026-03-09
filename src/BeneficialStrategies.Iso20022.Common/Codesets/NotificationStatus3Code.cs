// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of the notification in a coded form.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aN5VYdp-Ed-ak6NoX_4Aeg_-298790564")]
[Description(@"Specifies the status of the notification in a coded form.")]
[DerivedFrom(typeof(NotificationToReceiveStatusCode))]
public enum NotificationStatus3Code
{
    /// <summary>
    /// Event(s) as described in the notification to receive occurred but details are different.
    /// Encoded/decoded by serializers as &quot;RCBD&quot;.
    /// </summary>
    [EnumMember(Value = "RCBD")]
    [IsoId("_aN5VYtp-Ed-ak6NoX_4Aeg_410470248")]
    [Description(@"Event(s) as described in the notification to receive occurred but details are different.")]
    ReceivedButDifferent = NotificationToReceiveStatusCode.ReceivedButDifferent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event(s) as described in the notification to receive occurred.
    /// Encoded/decoded by serializers as &quot;RCVD&quot;.
    /// </summary>
    [EnumMember(Value = "RCVD")]
    [IsoId("_aN5VY9p-Ed-ak6NoX_4Aeg_410470266")]
    [Description(@"Event(s) as described in the notification to receive occurred.")]
    Received = NotificationToReceiveStatusCode.Received, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event(s) as described in the notification to receive did not occur.
    /// Encoded/decoded by serializers as &quot;NRCD&quot;.
    /// </summary>
    [EnumMember(Value = "NRCD")]
    [IsoId("_aN5VZNp-Ed-ak6NoX_4Aeg_410470291")]
    [Description(@"Event(s) as described in the notification to receive did not occur.")]
    NotReceived = NotificationToReceiveStatusCode.NotReceived, // same ordinal as derivation source for type conversions
    
}
