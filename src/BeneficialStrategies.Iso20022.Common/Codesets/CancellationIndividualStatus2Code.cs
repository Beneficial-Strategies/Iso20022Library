// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a cancellation request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_uylVsBylEeispO42NVVLrw")]
[Description(@"Specifies the status of a cancellation request.")]
[DerivedFrom(typeof(PaymentStatusCode))]
public enum CancellationIndividualStatus2Code
{
    /// <summary>
    /// Payment is cancelled.
    /// Encoded/decoded by serializers as &quot;CNCL&quot;.
    /// </summary>
    [EnumMember(Value = "CNCL")]
    [IsoId("_835qkhylEeispO42NVVLrw")]
    [Description(@"Payment is cancelled.")]
    PaymentCancelled = PaymentStatusCode.PaymentCancelled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation request is pending.
    /// Encoded/decoded by serializers as &quot;PDCR&quot;.
    /// </summary>
    [EnumMember(Value = "PDCR")]
    [IsoId("_-fhIohylEeispO42NVVLrw")]
    [Description(@"Cancellation request is pending.")]
    PendingCancellationRequest = PaymentStatusCode.PendingCancellationRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation request is rejected
    /// Encoded/decoded by serializers as &quot;RJCR&quot;.
    /// </summary>
    [EnumMember(Value = "RJCR")]
    [IsoId("_cSYZwYZ4EeiMm4lwapNmDA")]
    [Description(@"Cancellation request is rejected")]
    RejectedCancellationRequest = PaymentStatusCode.RejectedCancellationRequest, // same ordinal as derivation source for type conversions
    
}
