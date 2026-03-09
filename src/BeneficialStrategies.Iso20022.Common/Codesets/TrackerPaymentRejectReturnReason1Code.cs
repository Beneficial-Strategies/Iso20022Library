// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Provides the reason for a reject or a return status in the tracker.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1j8MAPrtEemIKt9hrQ9pJw")]
[Description(@"Provides the reason for a reject or a return status in the tracker.")]
[DerivedFrom(typeof(TrackerPaymentRejectReturnReasonCode))]
public enum TrackerPaymentRejectReturnReason1Code
{
    /// <summary>
    /// Return following a cancellation request.
    /// Encoded/decoded by serializers as &quot;FOCR&quot;.
    /// </summary>
    [EnumMember(Value = "FOCR")]
    [IsoId("_3ohS4frtEemIKt9hrQ9pJw")]
    [Description(@"Return following a cancellation request.")]
    FollowingCancellationRequest = TrackerPaymentRejectReturnReasonCode.FollowingCancellationRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identification of end customer is not consistent with associated account number. (formerly CreditorConsistency).
    /// Encoded/decoded by serializers as &quot;BE01&quot;.
    /// </summary>
    [EnumMember(Value = "BE01")]
    [IsoId("_31oh0frtEemIKt9hrQ9pJw")]
    [Description(@"Identification of end customer is not consistent with associated account number. (formerly CreditorConsistency).")]
    InconsistentWithEndCustomer = TrackerPaymentRejectReturnReasonCode.InconsistentWithEndCustomer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account number is invalid or missing
    /// Encoded/decoded by serializers as &quot;AC01&quot;.
    /// </summary>
    [EnumMember(Value = "AC01")]
    [IsoId("_3-fi4frtEemIKt9hrQ9pJw")]
    [Description(@"Account number is invalid or missing")]
    IncorrectAccountNumber = TrackerPaymentRejectReturnReasonCode.IncorrectAccountNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Routing code not valid for local clearing.
    /// Encoded/decoded by serializers as &quot;RC08&quot;.
    /// </summary>
    [EnumMember(Value = "RC08")]
    [IsoId("_4GdMEfrtEemIKt9hrQ9pJw")]
    [Description(@"Routing code not valid for local clearing.")]
    InvalidClearingSystemMemberIdentifier = TrackerPaymentRejectReturnReasonCode.InvalidClearingSystemMemberIdentifier, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Purpose is missing or invalid.
    /// Encoded/decoded by serializers as &quot;FF07&quot;.
    /// </summary>
    [EnumMember(Value = "FF07")]
    [IsoId("_4P-7gfrtEemIKt9hrQ9pJw")]
    [Description(@"Purpose is missing or invalid.")]
    InvalidPurpose = TrackerPaymentRejectReturnReasonCode.InvalidPurpose, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Specification of the creditor&apos;s name and/or address needed for regulatory requirements is insufficient or missing.
    /// Encoded/decoded by serializers as &quot;RR03&quot;.
    /// </summary>
    [EnumMember(Value = "RR03")]
    [IsoId("_4VUHcfrtEemIKt9hrQ9pJw")]
    [Description(@"Specification of the creditor's name and/or address needed for regulatory requirements is insufficient or missing.")]
    MissingCreditorNameOrAddress = TrackerPaymentRejectReturnReasonCode.MissingCreditorNameOrAddress, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Failed to contact beneficiary.
    /// Encoded/decoded by serializers as &quot;NOAS&quot;.
    /// </summary>
    [EnumMember(Value = "NOAS")]
    [IsoId("_4cV8gfrtEemIKt9hrQ9pJw")]
    [Description(@"Failed to contact beneficiary.")]
    NoAnswerFromCustomer = TrackerPaymentRejectReturnReasonCode.NoAnswerFromCustomer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reason has not been specified by agent.
    /// Encoded/decoded by serializers as &quot;MS03&quot;.
    /// </summary>
    [EnumMember(Value = "MS03")]
    [IsoId("_4lkxAfrtEemIKt9hrQ9pJw")]
    [Description(@"Reason has not been specified by agent.")]
    NotSpecifiedReasonAgentGenerated = TrackerPaymentRejectReturnReasonCode.NotSpecifiedReasonAgentGenerated, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Regulatory or Central Bank Reporting information missing, incomplete or invalid.
    /// Encoded/decoded by serializers as &quot;RR05&quot;.
    /// </summary>
    [EnumMember(Value = "RR05")]
    [IsoId("_4sMWYfrtEemIKt9hrQ9pJw")]
    [Description(@"Regulatory or Central Bank Reporting information missing, incomplete or invalid.")]
    RegulatoryInformationInvalid = TrackerPaymentRejectReturnReasonCode.RegulatoryInformationInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// At request of creditor.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_4xdQ4frtEemIKt9hrQ9pJw")]
    [Description(@"At request of creditor.")]
    RequestedByCustomer = TrackerPaymentRejectReturnReasonCode.RequestedByCustomer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Below limit.
    /// Encoded/decoded by serializers as &quot;AM06&quot;.
    /// </summary>
    [EnumMember(Value = "AM06")]
    [IsoId("_5O73EfrtEemIKt9hrQ9pJw")]
    [Description(@"Below limit.")]
    AmountTooLow = TrackerPaymentRejectReturnReasonCode.AmountTooLow, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bank identifier code specified in the message has an incorrect format (formerly IncorrectFormatForRoutingCode).
    /// Encoded/decoded by serializers as &quot;RC01&quot;.
    /// </summary>
    [EnumMember(Value = "RC01")]
    [IsoId("_5VOsUfrtEemIKt9hrQ9pJw")]
    [Description(@"Bank identifier code specified in the message has an incorrect format (formerly IncorrectFormatForRoutingCode).")]
    BankIdentifierIncorrect = TrackerPaymentRejectReturnReasonCode.BankIdentifierIncorrect, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account specified is blocked, prohibiting posting of transactions against it.
    /// Encoded/decoded by serializers as &quot;AC06&quot;.
    /// </summary>
    [EnumMember(Value = "AC06")]
    [IsoId("_5Z8NMfrtEemIKt9hrQ9pJw")]
    [Description(@"Account specified is blocked, prohibiting posting of transactions against it.")]
    BlockedAccount = TrackerPaymentRejectReturnReasonCode.BlockedAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account number specified has been closed on the bank of account&apos;s books.
    /// Encoded/decoded by serializers as &quot;AC04&quot;.
    /// </summary>
    [EnumMember(Value = "AC04")]
    [IsoId("_5f8ukfrtEemIKt9hrQ9pJw")]
    [Description(@"Account number specified has been closed on the bank of account's books.")]
    ClosedAccountNumber = TrackerPaymentRejectReturnReasonCode.ClosedAccountNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment is a duplicate of another payment.
    /// Encoded/decoded by serializers as &quot;DUPL&quot;.
    /// </summary>
    [EnumMember(Value = "DUPL")]
    [IsoId("_5m5rIfrtEemIKt9hrQ9pJw")]
    [Description(@"Payment is a duplicate of another payment.")]
    Duplication = TrackerPaymentRejectReturnReasonCode.Duplication, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Credit to the creditor&apos;s account is pending as status Originator is waiting for funds provided via a cover.
    /// Encoded/decoded by serializers as &quot;G004&quot;.
    /// </summary>
    [EnumMember(Value = "G004")]
    [IsoId("_qzu8YRd2EeqIn-BjQjNcxg")]
    [Description(@"Credit to the creditor's account is pending as status Originator is waiting for funds provided via a cover.")]
    CreditPendingFunds = TrackerPaymentRejectReturnReasonCode.CreditPendingFunds, // same ordinal as derivation source for type conversions
    
}
