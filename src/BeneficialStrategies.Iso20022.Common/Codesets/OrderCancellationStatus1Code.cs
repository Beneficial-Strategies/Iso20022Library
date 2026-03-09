// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the current status of the order cancellation request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aQbsB9p-Ed-ak6NoX_4Aeg_-1213962080")]
[Description(@"Specifies the current status of the order cancellation request.")]
[DerivedFrom(typeof(OrderCancellationStatusCode))]
public enum OrderCancellationStatus1Code
{
    /// <summary>
    /// Order cancellation request has been sent to the next party, eg, the next intermediary.
    /// Encoded/decoded by serializers as &quot;STNP&quot;.
    /// </summary>
    [EnumMember(Value = "STNP")]
    [IsoId("_aQk18Np-Ed-ak6NoX_4Aeg_-1213961837")]
    [Description(@"Order cancellation request has been sent to the next party, eg, the next intermediary.")]
    SentToNextParty = OrderCancellationStatusCode.SentToNextParty, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Order cancellation request is pending, The order cancellation request has been received but this does not indicate the order has been cancelled.
    /// Encoded/decoded by serializers as &quot;CANP&quot;.
    /// </summary>
    [EnumMember(Value = "CANP")]
    [IsoId("_aQk18dp-Ed-ak6NoX_4Aeg_-1213961821")]
    [Description(@"Order cancellation request is pending, The order cancellation request has been received but this does not indicate the order has been cancelled.")]
    CancellationPending = OrderCancellationStatusCode.CancellationPending, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Status of the order cancellation request is completed. The cancellation request has been accepted and processed; the order has been cancelled.
    /// Encoded/decoded by serializers as &quot;CAND&quot;.
    /// </summary>
    [EnumMember(Value = "CAND")]
    [IsoId("_aQk18tp-Ed-ak6NoX_4Aeg_288864191")]
    [Description(@"Status of the order cancellation request is completed. The cancellation request has been accepted and processed; the order has been cancelled.")]
    CancellationCompleted = OrderCancellationStatusCode.CancellationCompleted, // same ordinal as derivation source for type conversions
    
}
