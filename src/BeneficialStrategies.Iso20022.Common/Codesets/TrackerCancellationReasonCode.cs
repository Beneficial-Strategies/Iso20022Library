// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for requesting the cancellation of a payment instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_fBcYDm_bEem2FPn3x9pfnw")]
[Description(@"Specifies the reason for requesting the cancellation of a payment instruction.")]
[Derivations(typeof(CancellationReason7Code))]
public enum TrackerCancellationReasonCode
{
    /// <summary>
    /// Payment is a duplicate of another payment.
    /// Encoded/decoded by serializers as &quot;DUPL&quot;.
    /// </summary>
    [EnumMember(Value = "DUPL")]
    [IsoId("_fBcYEW_bEem2FPn3x9pfnw")]
    [Description(@"Payment is a duplicate of another payment.")]
    DuplicatePayment,
    
    /// <summary>
    /// Agent in the payment workflow is incorrect.
    /// Encoded/decoded by serializers as &quot;AGNT&quot;.
    /// </summary>
    [EnumMember(Value = "AGNT")]
    [IsoId("_fBcYGW_bEem2FPn3x9pfnw")]
    [Description(@"Agent in the payment workflow is incorrect.")]
    IncorrectAgent,
    
    /// <summary>
    /// Currency of the payment is incorrect.
    /// Encoded/decoded by serializers as &quot;CURR&quot;.
    /// </summary>
    [EnumMember(Value = "CURR")]
    [IsoId("_fBcYGG_bEem2FPn3x9pfnw")]
    [Description(@"Currency of the payment is incorrect.")]
    IncorrectCurrency,
    
    /// <summary>
    /// Cancellation requested by the Debtor.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_fBcYFW_bEem2FPn3x9pfnw")]
    [Description(@"Cancellation requested by the Debtor.")]
    RequestedByCustomer,
    
    /// <summary>
    /// Payment is not justified.
    /// Encoded/decoded by serializers as &quot;UPAY&quot;.
    /// </summary>
    [EnumMember(Value = "UPAY")]
    [IsoId("_fBcYD2_bEem2FPn3x9pfnw")]
    [Description(@"Payment is not justified.")]
    UnduePayment,
    
    /// <summary>
    /// Payment is a suspicious payment.
    /// Encoded/decoded by serializers as &quot;SUSP&quot;.
    /// </summary>
    [EnumMember(Value = "SUSP")]
    [IsoId("_fBcYF2_bEem2FPn3x9pfnw")]
    [Description(@"Payment is a suspicious payment.")]
    SuspiciousPayment,
    
    /// <summary>
    /// Insufficient or incoherent details about the debtor with respect to regulatory requirements.
    /// Encoded/decoded by serializers as &quot;MM23&quot;.
    /// </summary>
    [EnumMember(Value = "MM23")]
    [IsoId("_fBcYG2_bEem2FPn3x9pfnw")]
    [Description(@"Insufficient or incoherent details about the debtor with respect to regulatory requirements.")]
    InsufficientDebtorDetails,
    
    /// <summary>
    /// Insufficient or incoherent details about the creditor with respect to regulatory requirements.
    /// Encoded/decoded by serializers as &quot;MM24&quot;.
    /// </summary>
    [EnumMember(Value = "MM24")]
    [IsoId("_fBcYGm_bEem2FPn3x9pfnw")]
    [Description(@"Insufficient or incoherent details about the creditor with respect to regulatory requirements.")]
    InsufficientCreditorDetails,
    
    /// <summary>
    /// Cancellation requested because an investigation request has been received and no remediation is possible.
    /// Encoded/decoded by serializers as &quot;CUTA&quot;.
    /// </summary>
    [EnumMember(Value = "CUTA")]
    [IsoId("_fBcYEm_bEem2FPn3x9pfnw")]
    [Description(@"Cancellation requested because an investigation request has been received and no remediation is possible.")]
    CancelUponUnableToApply,
    
    /// <summary>
    /// Cancellation requested following technical problems resulting in an erroneous transaction.
    /// Encoded/decoded by serializers as &quot;TECH&quot;.
    /// </summary>
    [EnumMember(Value = "TECH")]
    [IsoId("_fBcYFm_bEem2FPn3x9pfnw")]
    [Description(@"Cancellation requested following technical problems resulting in an erroneous transaction.")]
    TechnicalProblem,
    
    /// <summary>
    /// Cancellation requested following a transaction that was originated fraudulently. The use of the FraudulentOrigin code should be governed by jurisdictions.
    /// Encoded/decoded by serializers as &quot;FRAD&quot;.
    /// </summary>
    [EnumMember(Value = "FRAD")]
    [IsoId("_fBcYE2_bEem2FPn3x9pfnw")]
    [Description(@"Cancellation requested following a transaction that was originated fraudulently. The use of the FraudulentOrigin code should be governed by jurisdictions.")]
    FraudulentOrigin,
    
    /// <summary>
    /// Cover payment has been cancelled or returned.
    /// Encoded/decoded by serializers as &quot;COVR&quot;.
    /// </summary>
    [EnumMember(Value = "COVR")]
    [IsoId("_fBcYFG_bEem2FPn3x9pfnw")]
    [Description(@"Cover payment has been cancelled or returned.")]
    CoverCancelledOrReturned,
    
    /// <summary>
    /// Amount of the payment is incorrect.
    /// Encoded/decoded by serializers as &quot;AM09&quot;.
    /// </summary>
    [EnumMember(Value = "AM09")]
    [IsoId("_fBcYEG_bEem2FPn3x9pfnw")]
    [Description(@"Amount of the payment is incorrect.")]
    IncorrectAmount,
    
}
