// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Provides status reasons with regards to the cancellation of the payment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_CnW-wIEiEei51tn2YGQhvg")]
[Description(@"Provides status reasons with regards to the cancellation of the payment.")]
[DerivedFrom(typeof(PaymentCancellationStatusReasonCode))]
public enum PaymentCancellationStatusReason2Code
{
    /// <summary>
    /// Stop and recall request forwarded to processing/last agent and delivery acknowledgement received.
    /// Encoded/decoded by serializers as &quot;S004&quot;.
    /// </summary>
    [EnumMember(Value = "S004")]
    [IsoId("_N0SKMYEiEei51tn2YGQhvg")]
    [Description(@"Stop and recall request forwarded to processing/last agent and delivery acknowledgement received.")]
    DeliveryAcknowledgementReceived = PaymentCancellationStatusReasonCode.DeliveryAcknowledgementReceived, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Stop and recall request forwarded to processing/last agent but delivery acknowledgement not received.
    /// Encoded/decoded by serializers as &quot;S003&quot;.
    /// </summary>
    [EnumMember(Value = "S003")]
    [IsoId("_N45kcYEiEei51tn2YGQhvg")]
    [Description(@"Stop and recall request forwarded to processing/last agent but delivery acknowledgement not received.")]
    ForwardedToAgent = PaymentCancellationStatusReasonCode.ForwardedToAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment instruction stopped because the UETR was cancelled.
    /// Encoded/decoded by serializers as &quot;S002&quot;.
    /// </summary>
    [EnumMember(Value = "S002")]
    [IsoId("_OJj2oYEiEei51tn2YGQhvg")]
    [Description(@"Payment instruction stopped because the UETR was cancelled.")]
    PaymentStopped = PaymentCancellationStatusReasonCode.PaymentStopped, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Stop and recall request sent to the tracking system.
    /// Encoded/decoded by serializers as &quot;S000&quot;.
    /// </summary>
    [EnumMember(Value = "S000")]
    [IsoId("_ZnnG8YElEei51tn2YGQhvg")]
    [Description(@"Stop and recall request sent to the tracking system.")]
    SentToTrackingSystem = PaymentCancellationStatusReasonCode.SentToTrackingSystem, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Stop and recall request added to cancellation list.
    /// Encoded/decoded by serializers as &quot;S001&quot;.
    /// </summary>
    [EnumMember(Value = "S001")]
    [IsoId("_Zvf3oYElEei51tn2YGQhvg")]
    [Description(@"Stop and recall request added to cancellation list.")]
    AddedToCancellationList = PaymentCancellationStatusReasonCode.AddedToCancellationList, // same ordinal as derivation source for type conversions
    
}
