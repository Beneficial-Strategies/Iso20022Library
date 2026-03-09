// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Returned when a request for cancellation cannot be executed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_p8qMgB09EeiYoZGjIMHr2A")]
[Description(@"Returned when a request for cancellation cannot be executed.")]
[DerivedFrom(typeof(PaymentCancellationRejectionCode))]
public enum PaymentCancellationRejection3Code
{
    /// <summary>
    /// Reported when the cancellation cannot be accepted because of an agent refuses to cancel.
    /// Encoded/decoded by serializers as &quot;AGNT&quot;.
    /// </summary>
    [EnumMember(Value = "AGNT")]
    [IsoId("_xpmqER09EeiYoZGjIMHr2A")]
    [Description(@"Reported when the cancellation cannot be accepted because of an agent refuses to cancel.")]
    AgentDecision = PaymentCancellationRejectionCode.AgentDecision, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation not accepted as the transaction has already been returned.
    /// Encoded/decoded by serializers as &quot;ARDT&quot;.
    /// </summary>
    [EnumMember(Value = "ARDT")]
    [IsoId("_xv44Qh09EeiYoZGjIMHr2A")]
    [Description(@"Cancellation not accepted as the transaction has already been returned.")]
    AlreadyReturned = PaymentCancellationRejectionCode.AlreadyReturned, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation indemnity is required.
    /// Encoded/decoded by serializers as &quot;INDM&quot;.
    /// </summary>
    [EnumMember(Value = "INDM")]
    [IsoId("_x3zeIR09EeiYoZGjIMHr2A")]
    [Description(@"Cancellation indemnity is required.")]
    CancellationIndemnityRequired = PaymentCancellationRejectionCode.CancellationIndemnityRequired, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account number specified has been closed on the receiver’s books.
    /// Encoded/decoded by serializers as &quot;AC04&quot;.
    /// </summary>
    [EnumMember(Value = "AC04")]
    [IsoId("_x_dlUR09EeiYoZGjIMHr2A")]
    [Description(@"Account number specified has been closed on the receiver’s books.")]
    ClosedAccountNumber = PaymentCancellationRejectionCode.ClosedAccountNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reported when the cancellation cannot be accepted because of a customer decision (Creditor).
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_yGmvIh09EeiYoZGjIMHr2A")]
    [Description(@"Reported when the cancellation cannot be accepted because of a customer decision (Creditor).")]
    CustomerDecision = PaymentCancellationRejectionCode.CustomerDecision, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amount of funds available to cover specified message amount is insufficient.
    /// Encoded/decoded by serializers as &quot;AM04&quot;.
    /// </summary>
    [EnumMember(Value = "AM04")]
    [IsoId("_yNidkh09EeiYoZGjIMHr2A")]
    [Description(@"Amount of funds available to cover specified message amount is insufficient.")]
    InsufficientFunds = PaymentCancellationRejectionCode.InsufficientFunds, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reported when the cancellation cannot be accepted because of regulatory rules.
    /// Encoded/decoded by serializers as &quot;LEGL&quot;.
    /// </summary>
    [EnumMember(Value = "LEGL")]
    [IsoId("_yU-iUh09EeiYoZGjIMHr2A")]
    [Description(@"Reported when the cancellation cannot be accepted because of regulatory rules.")]
    LegalDecision = PaymentCancellationRejectionCode.LegalDecision, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// No response from beneficiary (to the cancellation request).
    /// Encoded/decoded by serializers as &quot;NOAS&quot;.
    /// </summary>
    [EnumMember(Value = "NOAS")]
    [IsoId("_yZ--Ih09EeiYoZGjIMHr2A")]
    [Description(@"No response from beneficiary (to the cancellation request).")]
    NoAnswerFromCustomer = PaymentCancellationRejectionCode.NoAnswerFromCustomer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Original transaction (subject to cancellation) never received.
    /// Encoded/decoded by serializers as &quot;NOOR&quot;.
    /// </summary>
    [EnumMember(Value = "NOOR")]
    [IsoId("_yewwch09EeiYoZGjIMHr2A")]
    [Description(@"Original transaction (subject to cancellation) never received.")]
    NoOriginalTransactionReceived = PaymentCancellationRejectionCode.NoOriginalTransactionReceived, // same ordinal as derivation source for type conversions
    
}
