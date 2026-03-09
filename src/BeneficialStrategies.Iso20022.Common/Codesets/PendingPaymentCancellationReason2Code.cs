// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Provides the reason as to why a payment cancellation request is pending.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_37XkMCCMEei5H9PsIMzTkw")]
[Description(@"Provides the reason as to why a payment cancellation request is pending.")]
[DerivedFrom(typeof(PendingPaymentCancellationReasonCode))]
public enum PendingPaymentCancellationReason2Code
{
    /// <summary>
    /// Cancellation indemnity is required. 
    /// Encoded/decoded by serializers as &quot;INDM&quot;.
    /// </summary>
    [EnumMember(Value = "INDM")]
    [IsoId("_8g490SCMEei5H9PsIMzTkw")]
    [Description(@"Cancellation indemnity is required. |")]
    CancellationIndemnityRequired = PendingPaymentCancellationReasonCode.CancellationIndemnityRequired, // same ordinal as derivation source for type conversions
    
}
