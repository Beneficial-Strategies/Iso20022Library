// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Provides status reasons with regards to the cancellation of the payment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_rUlXoIEoEei51tn2YGQhvg")]
[Description(@"Provides status reasons with regards to the cancellation of the payment.")]
[DerivedFrom(typeof(PaymentCancellationStatusReasonCode))]
public enum PaymentCancellationStatusReason3Code
{
    /// <summary>
    /// Stop and recall request forwarded to processing/last agent but delivery acknowledgement not received.
    /// Encoded/decoded by serializers as &quot;S003&quot;.
    /// </summary>
    [EnumMember(Value = "S003")]
    [IsoId("_tomosYEoEei51tn2YGQhvg")]
    [Description(@"Stop and recall request forwarded to processing/last agent but delivery acknowledgement not received.")]
    ForwardedToAgent = PaymentCancellationStatusReasonCode.ForwardedToAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Stop and recall request forwarded to processing/last agent and delivery acknowledgement received.
    /// Encoded/decoded by serializers as &quot;S004&quot;.
    /// </summary>
    [EnumMember(Value = "S004")]
    [IsoId("_txPAQYEoEei51tn2YGQhvg")]
    [Description(@"Stop and recall request forwarded to processing/last agent and delivery acknowledgement received.")]
    DeliveryAcknowledgementReceived = PaymentCancellationStatusReasonCode.DeliveryAcknowledgementReceived, // same ordinal as derivation source for type conversions
    
}
