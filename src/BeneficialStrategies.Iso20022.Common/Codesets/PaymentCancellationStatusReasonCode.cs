// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Provides status reasons with regards to the cancellation of the payment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_OnEtsB04EeiYoZGjIMHr2A")]
[Description(@"Provides status reasons with regards to the cancellation of the payment.")]
[Derivations(typeof(PaymentCancellationStatusReason3Code),typeof(PaymentCancellationStatusReason2Code))]
public enum PaymentCancellationStatusReasonCode
{
    /// <summary>
    /// Stop and recall request forwarded to processing/last agent but delivery acknowledgement not received.
    /// Encoded/decoded by serializers as &quot;S003&quot;.
    /// </summary>
    [EnumMember(Value = "S003")]
    [IsoId("_eKFIkB04EeiYoZGjIMHr2A")]
    [Description(@"Stop and recall request forwarded to processing/last agent but delivery acknowledgement not received.")]
    ForwardedToAgent,
    
    /// <summary>
    /// Stop and recall request forwarded to processing/last agent and delivery acknowledgement received.
    /// Encoded/decoded by serializers as &quot;S004&quot;.
    /// </summary>
    [EnumMember(Value = "S004")]
    [IsoId("_g-vokR04EeiYoZGjIMHr2A")]
    [Description(@"Stop and recall request forwarded to processing/last agent and delivery acknowledgement received.")]
    DeliveryAcknowledgementReceived,
    
    /// <summary>
    /// Payment instruction stopped because the UETR was cancelled.
    /// Encoded/decoded by serializers as &quot;S002&quot;.
    /// </summary>
    [EnumMember(Value = "S002")]
    [IsoId("_Nk17gD4wEei1cqDe0mKAOg")]
    [Description(@"Payment instruction stopped because the UETR was cancelled.")]
    PaymentStopped,
    
    /// <summary>
    /// Stop and recall request sent to the tracking system.
    /// Encoded/decoded by serializers as &quot;S000&quot;.
    /// </summary>
    [EnumMember(Value = "S000")]
    [IsoId("_zr5ksIEkEei51tn2YGQhvg")]
    [Description(@"Stop and recall request sent to the tracking system.")]
    SentToTrackingSystem,
    
    /// <summary>
    /// Stop and recall request added to cancellation list.
    /// Encoded/decoded by serializers as &quot;S001&quot;.
    /// </summary>
    [EnumMember(Value = "S001")]
    [IsoId("_EDHqwIElEei51tn2YGQhvg")]
    [Description(@"Stop and recall request added to cancellation list.")]
    AddedToCancellationList,
    
}
