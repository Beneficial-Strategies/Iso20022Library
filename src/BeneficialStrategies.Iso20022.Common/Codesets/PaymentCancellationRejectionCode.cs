// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Returned when a request for cancellation cannot be executed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Zy7Qqdp-Ed-ak6NoX_4Aeg_1329401919")]
[Description(@"Returned when a request for cancellation cannot be executed.")]
[Derivations(typeof(PaymentCancellationRejection1Code),typeof(PaymentCancellationRejection2Code),typeof(PaymentCancellationRejection3Code))]
public enum PaymentCancellationRejectionCode
{
    /// <summary>
    /// Reported when the cancellation cannot be accepted because of regulatory rules.
    /// Encoded/decoded by serializers as &quot;LEGL&quot;.
    /// </summary>
    [EnumMember(Value = "LEGL")]
    [IsoId("_ZzFBoNp-Ed-ak6NoX_4Aeg_1672949066")]
    [Description(@"Reported when the cancellation cannot be accepted because of regulatory rules.")]
    LegalDecision,
    
    /// <summary>
    /// Reported when the cancellation cannot be accepted because of an agent refuses to cancel.
    /// Encoded/decoded by serializers as &quot;AGNT&quot;.
    /// </summary>
    [EnumMember(Value = "AGNT")]
    [IsoId("_ZzFBodp-Ed-ak6NoX_4Aeg_2099618581")]
    [Description(@"Reported when the cancellation cannot be accepted because of an agent refuses to cancel.")]
    AgentDecision,
    
    /// <summary>
    /// Reported when the cancellation cannot be accepted because of a customer decision (Creditor).
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_ZzFBotp-Ed-ak6NoX_4Aeg_-381003570")]
    [Description(@"Reported when the cancellation cannot be accepted because of a customer decision (Creditor).")]
    CustomerDecision,
    
    /// <summary>
    /// Cancellation not accepted as the transaction has already been returned.
    /// Encoded/decoded by serializers as &quot;ARDT&quot;.
    /// </summary>
    [EnumMember(Value = "ARDT")]
    [IsoId("_t8eKUFkyEeGeoaLUQk__nA_-529969479")]
    [Description(@"Cancellation not accepted as the transaction has already been returned.")]
    AlreadyReturned,
    
    /// <summary>
    /// No response from beneficiary (to the cancellation request).
    /// Encoded/decoded by serializers as &quot;NOAS&quot;.
    /// </summary>
    [EnumMember(Value = "NOAS")]
    [IsoId("_t8eKUVkyEeGeoaLUQk__nA_315136392")]
    [Description(@"No response from beneficiary (to the cancellation request).")]
    NoAnswerFromCustomer,
    
    /// <summary>
    /// Original transaction (subject to cancellation) never received.
    /// Encoded/decoded by serializers as &quot;NOOR&quot;.
    /// </summary>
    [EnumMember(Value = "NOOR")]
    [IsoId("_t8eKUlkyEeGeoaLUQk__nA_-543482748")]
    [Description(@"Original transaction (subject to cancellation) never received.")]
    NoOriginalTransactionReceived,
    
    /// <summary>
    /// Account number specified has been closed on the receiver’s books.
    /// Encoded/decoded by serializers as &quot;AC04&quot;.
    /// </summary>
    [EnumMember(Value = "AC04")]
    [IsoId("_t8eKU1kyEeGeoaLUQk__nA_-475259582")]
    [Description(@"Account number specified has been closed on the receiver’s books.")]
    ClosedAccountNumber,
    
    /// <summary>
    /// Amount of funds available to cover specified message amount is insufficient.
    /// Encoded/decoded by serializers as &quot;AM04&quot;.
    /// </summary>
    [EnumMember(Value = "AM04")]
    [IsoId("_t8eKVFkyEeGeoaLUQk__nA_1892589638")]
    [Description(@"Amount of funds available to cover specified message amount is insufficient.")]
    InsufficientFunds,
    
    /// <summary>
    /// Cancellation indemnity is required.
    /// Encoded/decoded by serializers as &quot;INDM&quot;.
    /// </summary>
    [EnumMember(Value = "INDM")]
    [IsoId("_YIF-sB09EeiYoZGjIMHr2A")]
    [Description(@"Cancellation indemnity is required.")]
    CancellationIndemnityRequired,
    
}
