// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for the rejection of a cancellation, as published in an external payment cancellation rejection code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_qcZCgYluEeePr-EGJjGYzQ")]
[Description(@"Specifies the reason for the rejection of a cancellation, as published in an external payment cancellation rejection code set.|External code sets can be downloaded from www.iso20022.org.")]
[Derivations(typeof(ExternalPaymentCancellationRejection1Code))]
public enum ExternalPaymentCancellationRejectionCode
{
    /// <summary>
    /// Account number specified has been closed on the receiver’s books.
    /// Encoded/decoded by serializers as &quot;AC04&quot;.
    /// </summary>
    [EnumMember(Value = "AC04")]
    [IsoId("_ubqEQPRYEeuLhpyIdtJzwg")]
    [Description(@"Account number specified has been closed on the receiver’s books.")]
    ClosedAccountNumber,
    
    /// <summary>
    /// Reported when the cancellation request cannot be processed because customer has not yet provided the debit authority on its account.
    /// Encoded/decoded by serializers as &quot;ADAC&quot;.
    /// </summary>
    [EnumMember(Value = "ADAC")]
    [IsoId("_ubqEQ_RYEeuLhpyIdtJzwg")]
    [Description(@"Reported when the cancellation request cannot be processed because customer has not yet provided the debit authority on its account.")]
    AwaitingDebitAuthorityFromCustomer,
    
    /// <summary>
    /// Reported when the cancellation cannot be accepted because of an agent refuses to cancel.
    /// Encoded/decoded by serializers as &quot;AGNT&quot;.
    /// </summary>
    [EnumMember(Value = "AGNT")]
    [IsoId("_ubqERvRYEeuLhpyIdtJzwg")]
    [Description(@"Reported when the cancellation cannot be accepted because of an agent refuses to cancel.")]
    AgentDecision,
    
    /// <summary>
    /// Amount of funds available to cover specified message amount is insufficient.
    /// Encoded/decoded by serializers as &quot;AM04&quot;.
    /// </summary>
    [EnumMember(Value = "AM04")]
    [IsoId("_ubqESfRYEeuLhpyIdtJzwg")]
    [Description(@"Amount of funds available to cover specified message amount is insufficient.")]
    InsufficientFunds,
    
    /// <summary>
    /// Cancellation not accepted as the transaction has already been returned.
    /// Encoded/decoded by serializers as &quot;ARDT&quot;.
    /// </summary>
    [EnumMember(Value = "ARDT")]
    [IsoId("_ubqETPRYEeuLhpyIdtJzwg")]
    [Description(@"Cancellation not accepted as the transaction has already been returned.")]
    AlreadyReturned,
    
    /// <summary>
    /// Reported when the cancellation request cannot be processed because no reply has been  received yet from the receiver of the request message.
    /// Encoded/decoded by serializers as &quot;ARPL&quot;.
    /// </summary>
    [EnumMember(Value = "ARPL")]
    [IsoId("_ubzOMPRYEeuLhpyIdtJzwg")]
    [Description(@"Reported when the cancellation request cannot be processed because no reply has been  received yet from the receiver of the request message.")]
    AwaitinReply,
    
    /// <summary>
    /// Reported when the cancellation cannot be accepted because of a customer decision (Creditor).
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_ubzOM_RYEeuLhpyIdtJzwg")]
    [Description(@"Reported when the cancellation cannot be accepted because of a customer decision (Creditor).")]
    CustomerDecision,
    
    /// <summary>
    /// Reported when the cancellation cannot be accepted because of regulatory rules.
    /// Encoded/decoded by serializers as &quot;LEGL&quot;.
    /// </summary>
    [EnumMember(Value = "LEGL")]
    [IsoId("_ub8_MPRYEeuLhpyIdtJzwg")]
    [Description(@"Reported when the cancellation cannot be accepted because of regulatory rules.")]
    LegalDecision,
    
    /// <summary>
    /// Reason is provided as narrative information in the additional reason information.
    /// Encoded/decoded by serializers as &quot;NARR&quot;.
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("_ub8_M_RYEeuLhpyIdtJzwg")]
    [Description(@"Reason is provided as narrative information in the additional reason information.")]
    Narrative,
    
    /// <summary>
    /// No response from beneficiary (to the cancellation request).
    /// Encoded/decoded by serializers as &quot;NOAS&quot;.
    /// </summary>
    [EnumMember(Value = "NOAS")]
    [IsoId("_ucGJIPRYEeuLhpyIdtJzwg")]
    [Description(@"No response from beneficiary (to the cancellation request).")]
    NoAnswerFromCustomer,
    
    /// <summary>
    /// Original transaction (subject to cancellation) never received.
    /// Encoded/decoded by serializers as &quot;NOOR&quot;.
    /// </summary>
    [EnumMember(Value = "NOOR")]
    [IsoId("_ucGJI_RYEeuLhpyIdtJzwg")]
    [Description(@"Original transaction (subject to cancellation) never received.")]
    NoOriginalTransactionReceived,
    
    /// <summary>
    /// Reported when the cancellation request cannot be accepted because the payment instruction has been passed to the next agent.
    /// Encoded/decoded by serializers as &quot;PTNA&quot;.
    /// </summary>
    [EnumMember(Value = "PTNA")]
    [IsoId("_ucGJJvRYEeuLhpyIdtJzwg")]
    [Description(@"Reported when the cancellation request cannot be accepted because the payment instruction has been passed to the next agent.")]
    PassedToTheNextAgent,
    
    /// <summary>
    /// Reported when authority is required by the Creditor to return the payment.
    /// Encoded/decoded by serializers as &quot;RQDA&quot;.
    /// </summary>
    [EnumMember(Value = "RQDA")]
    [IsoId("_ucGJKfRYEeuLhpyIdtJzwg")]
    [Description(@"Reported when authority is required by the Creditor to return the payment.")]
    RequestingDebitAuthority,
    
    /// <summary>
    /// Reported when the cancellation request cannot be processed because the sequence referred to in the request is not valid.
    /// Encoded/decoded by serializers as &quot;WSEQ&quot;.
    /// </summary>
    [EnumMember(Value = "WSEQ")]
    [IsoId("_ucP6IPRYEeuLhpyIdtJzwg")]
    [Description(@"Reported when the cancellation request cannot be processed because the sequence referred to in the request is not valid.")]
    WrongSequence,
    
    /// <summary>
    /// Complementing a Pending or Reject Status. Payment cancellation request cannot be accepted until an indemnity agreement is established.
    /// Encoded/decoded by serializers as &quot;IDMN&quot;.
    /// </summary>
    [EnumMember(Value = "IDMN")]
    [IsoId("_frG9IATXEey95qpfbNuEwg")]
    [Description(@"Complementing a Pending or Reject Status. Payment cancellation request cannot be accepted until an indemnity agreement is established.")]
    CancellationIndemnityRequired,
    
    /// <summary>
    /// Request-to-pay has already been cancelled.
    /// Encoded/decoded by serializers as &quot;ACLR&quot;.
    /// </summary>
    [EnumMember(Value = "ACLR")]
    [IsoId("_j3JKMFD-Eey6cYDbEubNXg")]
    [Description(@"Request-to-pay has already been cancelled.")]
    AlreadyCancelledRTP,
    
    /// <summary>
    /// Request-to-pay Expiry Date and Time has already passed.
    /// Encoded/decoded by serializers as &quot;AEXR&quot;.
    /// </summary>
    [EnumMember(Value = "AEXR")]
    [IsoId("_slfaYFD-Eey6cYDbEubNXg")]
    [Description(@"Request-to-pay Expiry Date and Time has already passed.")]
    AlreadyExpiredRTP,
    
    /// <summary>
    /// Request-to-pay has already been refused by the Debtor.
    /// Encoded/decoded by serializers as &quot;ARFR&quot;.
    /// </summary>
    [EnumMember(Value = "ARFR")]
    [IsoId("_yQMTYFD-Eey6cYDbEubNXg")]
    [Description(@"Request-to-pay has already been refused by the Debtor.")]
    AlreadyRefusedRTP,
    
    /// <summary>
    /// Request-to-pay has already been rejected.
    /// Encoded/decoded by serializers as &quot;ARJR&quot;.
    /// </summary>
    [EnumMember(Value = "ARJR")]
    [IsoId("_5mekcFD-Eey6cYDbEubNXg")]
    [Description(@"Request-to-pay has already been rejected.")]
    AlreadyRejectedRTP,
    
    /// <summary>
    /// Payment related to the request-to-pay has already been transmitted for execution.
    /// Encoded/decoded by serializers as &quot;PATE&quot;.
    /// </summary>
    [EnumMember(Value = "PATE")]
    [IsoId("_ELATIFD_Eey6cYDbEubNXg")]
    [Description(@"Payment related to the request-to-pay has already been transmitted for execution.")]
    PaymentAlreadyTransmittedExecution,
    
    /// <summary>
    /// Request for cancellation of the request-to-pay has already been rejected.
    /// Encoded/decoded by serializers as &quot;RCAR&quot;.
    /// </summary>
    [EnumMember(Value = "RCAR")]
    [IsoId("_NCAJAFD_Eey6cYDbEubNXg")]
    [Description(@"Request for cancellation of the request-to-pay has already been rejected.")]
    RfCAlreadyRejected,
    
    /// <summary>
    /// Request for cancellation of the request-to-pay has never been received.
    /// Encoded/decoded by serializers as &quot;RCNR&quot;.
    /// </summary>
    [EnumMember(Value = "RCNR")]
    [IsoId("_ZP4bIFD_Eey6cYDbEubNXg")]
    [Description(@"Request for cancellation of the request-to-pay has never been received.")]
    RfCNeverReceived,
    
    /// <summary>
    /// Request for cancellation of the request-to-pay has already been received and processed.
    /// Encoded/decoded by serializers as &quot;RCPR&quot;.
    /// </summary>
    [EnumMember(Value = "RCPR")]
    [IsoId("_lN0z0FD_Eey6cYDbEubNXg")]
    [Description(@"Request for cancellation of the request-to-pay has already been received and processed.")]
    RfCReceivedAndProcessed,
    
    /// <summary>
    /// Regulatory Reason.
    /// Encoded/decoded by serializers as &quot;RR04&quot;.
    /// </summary>
    [EnumMember(Value = "RR04")]
    [IsoId("_sBF3YFD_Eey6cYDbEubNXg")]
    [Description(@"Regulatory Reason.")]
    RegulatoryReason,
    
    /// <summary>
    /// Request-to-pay is unknown.
    /// Encoded/decoded by serializers as &quot;URTP&quot;.
    /// </summary>
    [EnumMember(Value = "URTP")]
    [IsoId("_0ldFIFD_Eey6cYDbEubNXg")]
    [Description(@"Request-to-pay is unknown.")]
    UnknownRTP,
    
}
