// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Provides the possible reasons why a payment is to be cancelled.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_nyEroB06EeiYoZGjIMHr2A")]
[Description(@"Provides the possible reasons why a payment is to be cancelled.")]
[DerivedFrom(typeof(TrackerCancellationReasonCode))]
public enum CancellationReason7Code
{
    /// <summary>
    /// Payment is a duplicate of another payment.
    /// Encoded/decoded by serializers as &quot;DUPL&quot;.
    /// </summary>
    [EnumMember(Value = "DUPL")]
    [IsoId("_9qJyMR06EeiYoZGjIMHr2A")]
    [Description(@"Payment is a duplicate of another payment.")]
    DuplicatePayment = TrackerCancellationReasonCode.DuplicatePayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Agent in the payment workflow is incorrect.
    /// Encoded/decoded by serializers as &quot;AGNT&quot;.
    /// </summary>
    [EnumMember(Value = "AGNT")]
    [IsoId("__9EQAh06EeiYoZGjIMHr2A")]
    [Description(@"Agent in the payment workflow is incorrect.")]
    IncorrectAgent = TrackerCancellationReasonCode.IncorrectAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Currency of the payment is incorrect.
    /// Encoded/decoded by serializers as &quot;CURR&quot;.
    /// </summary>
    [EnumMember(Value = "CURR")]
    [IsoId("_BB6_Qh07EeiYoZGjIMHr2A")]
    [Description(@"Currency of the payment is incorrect.")]
    IncorrectCurrency = TrackerCancellationReasonCode.IncorrectCurrency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation requested by the Debtor.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_Buhmkh07EeiYoZGjIMHr2A")]
    [Description(@"Cancellation requested by the Debtor.")]
    RequestedByCustomer = TrackerCancellationReasonCode.RequestedByCustomer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment is not justified.
    /// Encoded/decoded by serializers as &quot;UPAY&quot;.
    /// </summary>
    [EnumMember(Value = "UPAY")]
    [IsoId("_CiVpIR07EeiYoZGjIMHr2A")]
    [Description(@"Payment is not justified.")]
    UnduePayment = TrackerCancellationReasonCode.UnduePayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation requested because an investigation request has been received and no remediation is possible.
    /// Encoded/decoded by serializers as &quot;CUTA&quot;.
    /// </summary>
    [EnumMember(Value = "CUTA")]
    [IsoId("_DiYw4h07EeiYoZGjIMHr2A")]
    [Description(@"Cancellation requested because an investigation request has been received and no remediation is possible.")]
    CancelUponUnableToApply = TrackerCancellationReasonCode.CancelUponUnableToApply, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation requested following technical problems resulting in an erroneous transaction.
    /// Encoded/decoded by serializers as &quot;TECH&quot;.
    /// </summary>
    [EnumMember(Value = "TECH")]
    [IsoId("_Eae2gh07EeiYoZGjIMHr2A")]
    [Description(@"Cancellation requested following technical problems resulting in an erroneous transaction.")]
    TechnicalProblem = TrackerCancellationReasonCode.TechnicalProblem, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation requested following a transaction that was originated fraudulently. The use of the FraudulentOrigin code should be governed by jurisdictions.
    /// Encoded/decoded by serializers as &quot;FRAD&quot;.
    /// </summary>
    [EnumMember(Value = "FRAD")]
    [IsoId("_FP7Qwh07EeiYoZGjIMHr2A")]
    [Description(@"Cancellation requested following a transaction that was originated fraudulently. The use of the FraudulentOrigin code should be governed by jurisdictions.")]
    FraudulentOrigin = TrackerCancellationReasonCode.FraudulentOrigin, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cover payment has been cancelled or returned.
    /// Encoded/decoded by serializers as &quot;COVR&quot;.
    /// </summary>
    [EnumMember(Value = "COVR")]
    [IsoId("_GeZ2Eh07EeiYoZGjIMHr2A")]
    [Description(@"Cover payment has been cancelled or returned.")]
    CoverCancelledOrReturned = TrackerCancellationReasonCode.CoverCancelledOrReturned, // same ordinal as derivation source for type conversions
    
}
