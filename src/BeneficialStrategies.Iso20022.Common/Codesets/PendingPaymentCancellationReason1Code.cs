// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Provides the reason as to why a payment cancellation request is pending.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_BIXosB0_EeiYoZGjIMHr2A")]
[Description(@"Provides the reason as to why a payment cancellation request is pending.")]
[DerivedFrom(typeof(PendingPaymentCancellationReasonCode))]
public enum PendingPaymentCancellationReason1Code
{
    /// <summary>
    /// Cancellation indemnity is required. 
    /// Encoded/decoded by serializers as &quot;INDM&quot;.
    /// </summary>
    [EnumMember(Value = "INDM")]
    [IsoId("_DXz7wR0_EeiYoZGjIMHr2A")]
    [Description(@"Cancellation indemnity is required. |")]
    CancellationIndemnityRequired = PendingPaymentCancellationReasonCode.CancellationIndemnityRequired, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The cancellation has been forwarded to the next agent in the payment chain.
    /// Encoded/decoded by serializers as &quot;PTNA&quot;.
    /// </summary>
    [EnumMember(Value = "PTNA")]
    [IsoId("_Dfnz8h0_EeiYoZGjIMHr2A")]
    [Description(@"The cancellation has been forwarded to the next agent in the payment chain.")]
    PassedToNextAgent = PendingPaymentCancellationReasonCode.PassedToNextAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Creditor authorisation is required to return the payment.
    /// Encoded/decoded by serializers as &quot;RQDA&quot;.
    /// </summary>
    [EnumMember(Value = "RQDA")]
    [IsoId("_Dmi7Uh0_EeiYoZGjIMHr2A")]
    [Description(@"Creditor authorisation is required to return the payment.")]
    RequestedDebitAuthority = PendingPaymentCancellationReasonCode.RequestedDebitAuthority, // same ordinal as derivation source for type conversions
    
}
