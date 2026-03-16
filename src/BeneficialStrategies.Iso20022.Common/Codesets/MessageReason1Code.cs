// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Reason to send an card acquirer to issuer message.
/// It corresponds to ISO 8583, field number 25 for the version 93, and 9 for the version 2003.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_76pfcHs5EeSTS7uHCe8FPQ")]
[Description(
    @"Reason to send an card acquirer to issuer message.|It corresponds to ISO 8583, field number 25 for the version 93, and 9 for the version 2003."
)]
[DerivedFrom(typeof(MessageReasonCode))]
public enum MessageReason1Code
{
    /// <summary>
    /// Stand-in processing at the acquirer&apos;s option.
    /// Encoded/decoded by serializers as &quot;ASTD&quot;.
    /// </summary>
    [EnumMember(Value = "ASTD")]
    [IsoId("_-hPuQXs5EeSTS7uHCe8FPQ")]
    [Description(@"Stand-in processing at the acquirer's option.")]
    AcquirerStandin = MessageReasonCode.AcquirerStandin, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount inconsistent between request and response.
    /// Encoded/decoded by serializers as &quot;AMNT&quot;.
    /// </summary>
    [EnumMember(Value = "AMNT")]
    [IsoId("_-q29Q3s5EeSTS7uHCe8FPQ")]
    [Description(@"Amount inconsistent between request and response.")]
    AmountInconsistency = MessageReasonCode.AmountInconsistency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card acceptor forced to be online.
    /// Encoded/decoded by serializers as &quot;ASPC&quot;.
    /// </summary>
    [EnumMember(Value = "ASPC")]
    [IsoId("_-0uD43s5EeSTS7uHCe8FPQ")]
    [Description(@"Card acceptor forced to be online.")]
    CardAcceptorSuspicious = MessageReasonCode.CardAcceptorSuspicious, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Integrated circuit card declines the transaction after the authorisation.
    /// Encoded/decoded by serializers as &quot;CDCL&quot;.
    /// </summary>
    [EnumMember(Value = "CDCL")]
    [IsoId("_-6bDQXs5EeSTS7uHCe8FPQ")]
    [Description(@"Integrated circuit card declines the transaction after the authorisation.")]
    CardDeclined = MessageReasonCode.CardDeclined, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction performed offline by the card.
    /// Encoded/decoded by serializers as &quot;COFF&quot;.
    /// </summary>
    [EnumMember(Value = "COFF")]
    [IsoId("__AIps3s5EeSTS7uHCe8FPQ")]
    [Description(@"Transaction performed offline by the card.")]
    CardProcessed = MessageReasonCode.CardProcessed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Random online decided by the card.
    /// Encoded/decoded by serializers as &quot;CRND&quot;.
    /// </summary>
    [EnumMember(Value = "CRND")]
    [IsoId("__GJyIXs5EeSTS7uHCe8FPQ")]
    [Description(@"Random online decided by the card.")]
    CardRandomSelection = MessageReasonCode.CardRandomSelection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card left by the cardholder.
    /// Encoded/decoded by serializers as &quot;CRTN&quot;.
    /// </summary>
    [EnumMember(Value = "CRTN")]
    [IsoId("__TOk03s5EeSTS7uHCe8FPQ")]
    [Description(@"Card left by the cardholder.")]
    CardRetained = MessageReasonCode.CardRetained, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card cannot process offline the transaction.
    /// Encoded/decoded by serializers as &quot;CUNB&quot;.
    /// </summary>
    [EnumMember(Value = "CUNB")]
    [IsoId("__U2VcXs5EeSTS7uHCe8FPQ")]
    [Description(@"Card cannot process offline the transaction.")]
    CardUnableToProcess = MessageReasonCode.CardUnableToProcess, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Customer cancellation, for example removing the chip card after sending the authorisation, but before the end of the transaction.
    /// Encoded/decoded by serializers as &quot;CCAN&quot;.
    /// </summary>
    [EnumMember(Value = "CCAN")]
    [IsoId("__bwOs3s5EeSTS7uHCe8FPQ")]
    [Description(
        @"Customer cancellation, for example removing the chip card after sending the authorisation, but before the end of the transaction."
    )]
    CustomerCancel = MessageReasonCode.CustomerCancel, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Deactivated key must be replaced.
    /// Encoded/decoded by serializers as &quot;KDAC&quot;.
    /// </summary>
    [EnumMember(Value = "KDAC")]
    [IsoId("__j4P8Xs5EeSTS7uHCe8FPQ")]
    [Description(@"Deactivated key must be replaced.")]
    DeactivatedKey = MessageReasonCode.DeactivatedKey, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Response message was invalid (for example a problem of format or security).
    /// Encoded/decoded by serializers as &quot;ERRP&quot;.
    /// </summary>
    [EnumMember(Value = "ERRP")]
    [IsoId("__p4KQXs5EeSTS7uHCe8FPQ")]
    [Description(@"Response message was invalid (for example a problem of format or security).")]
    ErrorInResponse = MessageReasonCode.ErrorInResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction above or under the floor limit.
    /// Encoded/decoded by serializers as &quot;FLRL&quot;.
    /// </summary>
    [EnumMember(Value = "FLRL")]
    [IsoId("__yzcw3s5EeSTS7uHCe8FPQ")]
    [Description(@"Transaction above or under the floor limit.")]
    FloorLimit = MessageReasonCode.FloorLimit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Verification of the key has failed.
    /// Encoded/decoded by serializers as &quot;KINV&quot;.
    /// </summary>
    [EnumMember(Value = "KINV")]
    [IsoId("__-uY4Xs5EeSTS7uHCe8FPQ")]
    [Description(@"Verification of the key has failed.")]
    InvalidVerification = MessageReasonCode.InvalidVerification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Issuer signed off.
    /// Encoded/decoded by serializers as &quot;ISGN&quot;.
    /// </summary>
    [EnumMember(Value = "ISGN")]
    [IsoId("_AHprY3s6EeSTS7uHCe8FPQ")]
    [Description(@"Issuer signed off.")]
    IssuerSignedOff = MessageReasonCode.IssuerSignedOff, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Stand-in processing at the issuer&apos;s option.
    /// Encoded/decoded by serializers as &quot;ISTD&quot;.
    /// </summary>
    [EnumMember(Value = "ISTD")]
    [IsoId("_AMjZgXs6EeSTS7uHCe8FPQ")]
    [Description(@"Stand-in processing at the issuer's option.")]
    IssuerStandin = MessageReasonCode.IssuerStandin, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Issuer timed out on request.
    /// Encoded/decoded by serializers as &quot;ITIM&quot;.
    /// </summary>
    [EnumMember(Value = "ITIM")]
    [IsoId("_AWtbE3s6EeSTS7uHCe8FPQ")]
    [Description(@"Issuer timed out on request.")]
    IssuerTimeout = MessageReasonCode.IssuerTimeout, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Issuer unavailable.
    /// Encoded/decoded by serializers as &quot;IUNV&quot;.
    /// </summary>
    [EnumMember(Value = "IUNV")]
    [IsoId("_Ahxbk3s6EeSTS7uHCe8FPQ")]
    [Description(@"Issuer unavailable.")]
    IssuerUnavailable = MessageReasonCode.IssuerUnavailable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// End of key life cycle.
    /// Encoded/decoded by serializers as &quot;ENDK&quot;.
    /// </summary>
    [EnumMember(Value = "ENDK")]
    [IsoId("_At-rk3s6EeSTS7uHCe8FPQ")]
    [Description(@"End of key life cycle.")]
    LifeCycleEnd = MessageReasonCode.LifeCycleEnd, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Suspected malfunction (for example card reader defect, or printer out of order).
    /// Encoded/decoded by serializers as &quot;MLFC&quot;.
    /// </summary>
    [EnumMember(Value = "MLFC")]
    [IsoId("_AzzmwXs6EeSTS7uHCe8FPQ")]
    [Description(
        @"Suspected malfunction (for example card reader defect, or printer out of order)."
    )]
    Malfunction = MessageReasonCode.Malfunction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Offline authorisation declined the transaction.
    /// Encoded/decoded by serializers as &quot;FDCL&quot;.
    /// </summary>
    [EnumMember(Value = "FDCL")]
    [IsoId("_A-l6cns6EeSTS7uHCe8FPQ")]
    [Description(@"Offline authorisation declined the transaction.")]
    OfflineDeclined = MessageReasonCode.OfflineDeclined, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Online authorisation declined the transaction.
    /// Encoded/decoded by serializers as &quot;NDCL&quot;.
    /// </summary>
    [EnumMember(Value = "NDCL")]
    [IsoId("_BKqnk3s6EeSTS7uHCe8FPQ")]
    [Description(@"Online authorisation declined the transaction.")]
    OnLineDeclined = MessageReasonCode.OnLineDeclined, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Forced online by card acceptor, terminal, card, or the issuer.
    /// Encoded/decoded by serializers as &quot;FORC&quot;.
    /// </summary>
    [EnumMember(Value = "FORC")]
    [IsoId("_BVjo83s6EeSTS7uHCe8FPQ")]
    [Description(@"Forced online by card acceptor, terminal, card, or the issuer.")]
    OnlineForced = MessageReasonCode.OnlineForced, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Keys not synchronised.
    /// Encoded/decoded by serializers as &quot;KSYN&quot;.
    /// </summary>
    [EnumMember(Value = "KSYN")]
    [IsoId("_BgSSQ3s6EeSTS7uHCe8FPQ")]
    [Description(@"Keys not synchronised.")]
    OutOfSynchronisation = MessageReasonCode.OutOfSynchronisation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cardholder did not take the presented items.
    /// Encoded/decoded by serializers as &quot;UDSP&quot;.
    /// </summary>
    [EnumMember(Value = "UDSP")]
    [IsoId("_B9Kbg3s6EeSTS7uHCe8FPQ")]
    [Description(@"Cardholder did not take the presented items.")]
    UncompleteDispense = MessageReasonCode.UncompleteDispense, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unable to send the message.
    /// Encoded/decoded by serializers as &quot;USND&quot;.
    /// </summary>
    [EnumMember(Value = "USND")]
    [IsoId("_CI7moXs6EeSTS7uHCe8FPQ")]
    [Description(@"Unable to send the message.")]
    UnableToSend = MessageReasonCode.UnableToSend, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card acceptor device unable to complete transaction after the authorisation response (for example, the written signature invalid).
    /// Encoded/decoded by serializers as &quot;UCMP&quot;.
    /// </summary>
    [EnumMember(Value = "UCMP")]
    [IsoId("_CPs9AXs6EeSTS7uHCe8FPQ")]
    [Description(
        @"Card acceptor device unable to complete transaction after the authorisation response (for example, the written signature invalid)."
    )]
    UnableToComplete = MessageReasonCode.UnableToComplete, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Response to the authorisation received too late.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_CbbE03s6EeSTS7uHCe8FPQ")]
    [Description(@"Response to the authorisation received too late.")]
    TooLateResponse = MessageReasonCode.TooLateResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Waiting for response from the receiver, or no response was received (for example connection release before receiving the response).
    /// Encoded/decoded by serializers as &quot;TIMO&quot;.
    /// </summary>
    [EnumMember(Value = "TIMO")]
    [IsoId("_CjifA3s6EeSTS7uHCe8FPQ")]
    [Description(
        @"Waiting for response from the receiver, or no response was received (for example connection release before receiving the response)."
    )]
    TimeOut = MessageReasonCode.TimeOut, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Terminal cannot process offline the transaction.
    /// Encoded/decoded by serializers as &quot;TUNB&quot;.
    /// </summary>
    [EnumMember(Value = "TUNB")]
    [IsoId("_CpeH4Xs6EeSTS7uHCe8FPQ")]
    [Description(@"Terminal cannot process offline the transaction.")]
    TerminalUnableToProcess = MessageReasonCode.TerminalUnableToProcess, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Random online decided by the terminal.
    /// Encoded/decoded by serializers as &quot;TRND&quot;.
    /// </summary>
    [EnumMember(Value = "TRND")]
    [IsoId("_CwhyIXs6EeSTS7uHCe8FPQ")]
    [Description(@"Random online decided by the terminal.")]
    TerminalRandomSelection = MessageReasonCode.TerminalRandomSelection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction performed offline by the terminal.
    /// Encoded/decoded by serializers as &quot;TOFF&quot;.
    /// </summary>
    [EnumMember(Value = "TOFF")]
    [IsoId("_C7azg3s6EeSTS7uHCe8FPQ")]
    [Description(@"Transaction performed offline by the terminal.")]
    TerminalProcessed = MessageReasonCode.TerminalProcessed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card transaction failed because the merchant suspected a fraud.
    /// Encoded/decoded by serializers as &quot;SUSP&quot;.
    /// </summary>
    [EnumMember(Value = "SUSP")]
    [IsoId("_DHaoI3s6EeSTS7uHCe8FPQ")]
    [Description(@"Card transaction failed because the merchant suspected a fraud.")]
    SuspectedFraud = MessageReasonCode.SuspectedFraud, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Security reasons.
    /// Encoded/decoded by serializers as &quot;KSEC&quot;.
    /// </summary>
    [EnumMember(Value = "KSEC")]
    [IsoId("_DSNi4ns6EeSTS7uHCe8FPQ")]
    [Description(@"Security reasons.")]
    SecurityReason = MessageReasonCode.SecurityReason, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Receiver unavailable.
    /// Encoded/decoded by serializers as &quot;RUNV&quot;.
    /// </summary>
    [EnumMember(Value = "RUNV")]
    [IsoId("_DZVekns6EeSTS7uHCe8FPQ")]
    [Description(@"Receiver unavailable.")]
    ReceiverUnavailable = MessageReasonCode.ReceiverUnavailable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Receiver timed out on request.
    /// Encoded/decoded by serializers as &quot;RTIM&quot;.
    /// </summary>
    [EnumMember(Value = "RTIM")]
    [IsoId("_DgQl8Xs6EeSTS7uHCe8FPQ")]
    [Description(@"Receiver timed out on request.")]
    ReceiverTimeout = MessageReasonCode.ReceiverTimeout, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Stand-in processing at the receiver&apos;s option.
    /// Encoded/decoded by serializers as &quot;RSTD&quot;.
    /// </summary>
    [EnumMember(Value = "RSTD")]
    [IsoId("_DrFV43s6EeSTS7uHCe8FPQ")]
    [Description(@"Stand-in processing at the receiver's option.")]
    ReceiverStandin = MessageReasonCode.ReceiverStandin, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Receiver signed off.
    /// Encoded/decoded by serializers as &quot;RSGN&quot;.
    /// </summary>
    [EnumMember(Value = "RSGN")]
    [IsoId("_DxITgXs6EeSTS7uHCe8FPQ")]
    [Description(@"Receiver signed off.")]
    ReceiverSignedOff = MessageReasonCode.ReceiverSignedOff, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Partial reversal.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_D9DPo3s6EeSTS7uHCe8FPQ")]
    [Description(@"Partial reversal.")]
    PartiallyCompleted = MessageReasonCode.PartiallyCompleted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Inconsistency between the items deposited and their declared value.
    /// Encoded/decoded by serializers as &quot;IDPS&quot;.
    /// </summary>
    [EnumMember(Value = "IDPS")]
    [IsoId("_5XbO8X1dEemWqr5azFRqdA")]
    [Description(@"Inconsistency between the items deposited and their declared value.")]
    InconsistentDeposit = MessageReasonCode.InconsistentDeposit, // same ordinal as derivation source for type conversions
}
