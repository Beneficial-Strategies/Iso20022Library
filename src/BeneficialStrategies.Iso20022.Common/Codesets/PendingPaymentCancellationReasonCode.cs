// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Provides the reason as to why a payment cancellation request is pending.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Rar2EB0-EeiYoZGjIMHr2A")]
[Description(@"Provides the reason as to why a payment cancellation request is pending.")]
[Derivations(typeof(PendingPaymentCancellationReason1Code),typeof(PendingPaymentCancellationReason2Code))]
public enum PendingPaymentCancellationReasonCode
{
    /// <summary>
    /// The cancellation has been forwarded to the next agent in the payment chain.
    /// Encoded/decoded by serializers as &quot;PTNA&quot;.
    /// </summary>
    [EnumMember(Value = "PTNA")]
    [IsoId("_aULmUB0-EeiYoZGjIMHr2A")]
    [Description(@"The cancellation has been forwarded to the next agent in the payment chain.")]
    PassedToNextAgent,
    
    /// <summary>
    /// Creditor authorisation is required to return the payment.
    /// Encoded/decoded by serializers as &quot;RQDA&quot;.
    /// </summary>
    [EnumMember(Value = "RQDA")]
    [IsoId("_kfp70B0-EeiYoZGjIMHr2A")]
    [Description(@"Creditor authorisation is required to return the payment.")]
    RequestedDebitAuthority,
    
    /// <summary>
    /// Cancellation indemnity is required. 
    /// Encoded/decoded by serializers as &quot;INDM&quot;.
    /// </summary>
    [EnumMember(Value = "INDM")]
    [IsoId("_1gtpEB0-EeiYoZGjIMHr2A")]
    [Description(@"Cancellation indemnity is required. |")]
    CancellationIndemnityRequired,
    
}
