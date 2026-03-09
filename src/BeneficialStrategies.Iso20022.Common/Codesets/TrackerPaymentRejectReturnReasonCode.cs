// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Provides the reason for a reject or a return status in the tracker.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_RcQMN_rtEemIKt9hrQ9pJw")]
[Description(@"Provides the reason for a reject or a return status in the tracker.")]
[Derivations(typeof(TrackerPaymentRejectReturnReason1Code))]
public enum TrackerPaymentRejectReturnReasonCode
{
    /// <summary>
    /// Account number is invalid or missing
    /// Encoded/decoded by serializers as &quot;AC01&quot;.
    /// </summary>
    [EnumMember(Value = "AC01")]
    [IsoId("_RcRaRvrtEemIKt9hrQ9pJw")]
    [Description(@"Account number is invalid or missing")]
    IncorrectAccountNumber,
    
    /// <summary>
    /// Account number specified has been closed on the bank of account&apos;s books.
    /// Encoded/decoded by serializers as &quot;AC04&quot;.
    /// </summary>
    [EnumMember(Value = "AC04")]
    [IsoId("_RcRaQvrtEemIKt9hrQ9pJw")]
    [Description(@"Account number specified has been closed on the bank of account's books.")]
    ClosedAccountNumber,
    
    /// <summary>
    /// Account specified is blocked, prohibiting posting of transactions against it.
    /// Encoded/decoded by serializers as &quot;AC06&quot;.
    /// </summary>
    [EnumMember(Value = "AC06")]
    [IsoId("_RcRaQ_rtEemIKt9hrQ9pJw")]
    [Description(@"Account specified is blocked, prohibiting posting of transactions against it.")]
    BlockedAccount,
    
    /// <summary>
    /// Identification of end customer is not consistent with associated account number. (formerly CreditorConsistency).
    /// Encoded/decoded by serializers as &quot;BE01&quot;.
    /// </summary>
    [EnumMember(Value = "BE01")]
    [IsoId("_RcQzNPrtEemIKt9hrQ9pJw")]
    [Description(@"Identification of end customer is not consistent with associated account number. (formerly CreditorConsistency).")]
    InconsistentWithEndCustomer,
    
    /// <summary>
    /// Failed to contact beneficiary.
    /// Encoded/decoded by serializers as &quot;NOAS&quot;.
    /// </summary>
    [EnumMember(Value = "NOAS")]
    [IsoId("_RcQzOvrtEemIKt9hrQ9pJw")]
    [Description(@"Failed to contact beneficiary.")]
    NoAnswerFromCustomer,
    
    /// <summary>
    /// Specification of the creditor&apos;s name and/or address needed for regulatory requirements is insufficient or missing.
    /// Encoded/decoded by serializers as &quot;RR03&quot;.
    /// </summary>
    [EnumMember(Value = "RR03")]
    [IsoId("_RcQzN_rtEemIKt9hrQ9pJw")]
    [Description(@"Specification of the creditor's name and/or address needed for regulatory requirements is insufficient or missing.")]
    MissingCreditorNameOrAddress,
    
    /// <summary>
    /// Purpose is missing or invalid.
    /// Encoded/decoded by serializers as &quot;FF07&quot;.
    /// </summary>
    [EnumMember(Value = "FF07")]
    [IsoId("_RcQzOfrtEemIKt9hrQ9pJw")]
    [Description(@"Purpose is missing or invalid.")]
    InvalidPurpose,
    
    /// <summary>
    /// Bank identifier code specified in the message has an incorrect format (formerly IncorrectFormatForRoutingCode).
    /// Encoded/decoded by serializers as &quot;RC01&quot;.
    /// </summary>
    [EnumMember(Value = "RC01")]
    [IsoId("_RcRaR_rtEemIKt9hrQ9pJw")]
    [Description(@"Bank identifier code specified in the message has an incorrect format (formerly IncorrectFormatForRoutingCode).")]
    BankIdentifierIncorrect,
    
    /// <summary>
    /// Routing code not valid for local clearing.
    /// Encoded/decoded by serializers as &quot;RC08&quot;.
    /// </summary>
    [EnumMember(Value = "RC08")]
    [IsoId("_RcQzPPrtEemIKt9hrQ9pJw")]
    [Description(@"Routing code not valid for local clearing.")]
    InvalidClearingSystemMemberIdentifier,
    
    /// <summary>
    /// Return following a cancellation request.
    /// Encoded/decoded by serializers as &quot;FOCR&quot;.
    /// </summary>
    [EnumMember(Value = "FOCR")]
    [IsoId("_RcRaQPrtEemIKt9hrQ9pJw")]
    [Description(@"Return following a cancellation request.")]
    FollowingCancellationRequest,
    
    /// <summary>
    /// Payment is a duplicate of another payment.
    /// Encoded/decoded by serializers as &quot;DUPL&quot;.
    /// </summary>
    [EnumMember(Value = "DUPL")]
    [IsoId("_RcQzO_rtEemIKt9hrQ9pJw")]
    [Description(@"Payment is a duplicate of another payment.")]
    Duplication,
    
    /// <summary>
    /// Regulatory or Central Bank Reporting information missing, incomplete or invalid.
    /// Encoded/decoded by serializers as &quot;RR05&quot;.
    /// </summary>
    [EnumMember(Value = "RR05")]
    [IsoId("_RcQzNfrtEemIKt9hrQ9pJw")]
    [Description(@"Regulatory or Central Bank Reporting information missing, incomplete or invalid.")]
    RegulatoryInformationInvalid,
    
    /// <summary>
    /// Below limit.
    /// Encoded/decoded by serializers as &quot;AM06&quot;.
    /// </summary>
    [EnumMember(Value = "AM06")]
    [IsoId("_RcQzM_rtEemIKt9hrQ9pJw")]
    [Description(@"Below limit.")]
    AmountTooLow,
    
    /// <summary>
    /// At request of creditor.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_RcRaRfrtEemIKt9hrQ9pJw")]
    [Description(@"At request of creditor.")]
    RequestedByCustomer,
    
    /// <summary>
    /// Reason has not been specified by agent.
    /// Encoded/decoded by serializers as &quot;MS03&quot;.
    /// </summary>
    [EnumMember(Value = "MS03")]
    [IsoId("_RcQzOPrtEemIKt9hrQ9pJw")]
    [Description(@"Reason has not been specified by agent.")]
    NotSpecifiedReasonAgentGenerated,
    
    /// <summary>
    /// The transaction processing cannot be completed the same day.
    /// Encoded/decoded by serializers as &quot;G002&quot;.
    /// </summary>
    [EnumMember(Value = "G002")]
    [IsoId("_XbGTxxd2EeqIn-BjQjNcxg")]
    [Description(@"The transaction processing cannot be completed the same day.")]
    CreditDebitNotConfirmed,
    
    /// <summary>
    /// In an FI to FI Customer Credit Transfer: Credit to creditor&apos;s account is pending receipt of required documents. The Status Originator has requested creditor to provide additional documentation.
    /// Encoded/decoded by serializers as &quot;G003&quot;.
    /// </summary>
    [EnumMember(Value = "G003")]
    [IsoId("_XbGTyBd2EeqIn-BjQjNcxg")]
    [Description(@"In an FI to FI Customer Credit Transfer: Credit to creditor's account is pending receipt of required documents. The Status Originator has requested creditor to provide additional documentation.")]
    CreditPendingDocuments,
    
    /// <summary>
    /// Credit to the creditor&apos;s account is pending as status Originator is waiting for funds provided via a cover.
    /// Encoded/decoded by serializers as &quot;G004&quot;.
    /// </summary>
    [EnumMember(Value = "G004")]
    [IsoId("_XbGTyRd2EeqIn-BjQjNcxg")]
    [Description(@"Credit to the creditor's account is pending as status Originator is waiting for funds provided via a cover.")]
    CreditPendingFunds,
    
    /// <summary>
    /// Credit Transfer has been delivered to creditor agent with transaction’s service obligations maintained.
    /// Encoded/decoded by serializers as &quot;G005&quot;.
    /// </summary>
    [EnumMember(Value = "G005")]
    [IsoId("_XbGTyhd2EeqIn-BjQjNcxg")]
    [Description(@"Credit Transfer has been delivered to creditor agent with transaction’s service obligations maintained.")]
    PaymentDeliveredAndSLAMaintained,
    
    /// <summary>
    /// Credit Transfer has been delivered to creditor agent where the transaction’s service obligations were no longer maintained.
    /// Encoded/decoded by serializers as &quot;G006&quot;.
    /// </summary>
    [EnumMember(Value = "G006")]
    [IsoId("_XbGTyxd2EeqIn-BjQjNcxg")]
    [Description(@"Credit Transfer has been delivered to creditor agent where the transaction’s service obligations were no longer maintained.")]
    PaymentDeliveredAndSLANoLongerMaintained,
    
    /// <summary>
    /// The Status Originator transferred the Credit Transfer to the next Agent or to a Market Infrastructure maintaining the transaction’s service obligations.
    /// Encoded/decoded by serializers as &quot;G000&quot;.
    /// </summary>
    [EnumMember(Value = "G000")]
    [IsoId("_XbGTzBd2EeqIn-BjQjNcxg")]
    [Description(@"The Status Originator transferred the Credit Transfer to the next Agent or to a Market Infrastructure maintaining the transaction’s service obligations.")]
    PaymentTransferredAndSLAMaintained,
    
    /// <summary>
    /// The Status Originator transferred the Credit Transfer to the next Agent or to a Market Infrastructure where the transaction’s service obligations may no longer be guaranteed.
    /// Encoded/decoded by serializers as &quot;G001&quot;.
    /// </summary>
    [EnumMember(Value = "G001")]
    [IsoId("_XbGTzRd2EeqIn-BjQjNcxg")]
    [Description(@"The Status Originator transferred the Credit Transfer to the next Agent or to a Market Infrastructure where the transaction’s service obligations may no longer be guaranteed.")]
    PaymentTransferredAndSLANoLongerMaintained,
    
}
