// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Reason to send an card acquirer to issuer message.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_xKIOEHs3EeSTS7uHCe8FPQ")]
[Description(@"Reason to send an card acquirer to issuer message.")]
[Derivations(typeof(MessageReason1Code),typeof(MessageReason2Code))]
public enum MessageReasonCode
{
    /// <summary>
    /// Stand-in processing at the acquirer&apos;s option.
    /// Encoded/decoded by serializers as &quot;ASTD&quot;.
    /// </summary>
    [EnumMember(Value = "ASTD")]
    [IsoId("_22EdMHs3EeSTS7uHCe8FPQ")]
    [Description(@"Stand-in processing at the acquirer's option.")]
    AcquirerStandin,
    
    /// <summary>
    /// Amount inconsistent between request and response.
    /// Encoded/decoded by serializers as &quot;AMNT&quot;.
    /// </summary>
    [EnumMember(Value = "AMNT")]
    [IsoId("_9Aq-QHs3EeSTS7uHCe8FPQ")]
    [Description(@"Amount inconsistent between request and response.")]
    AmountInconsistency,
    
    /// <summary>
    /// Card acceptor forced to be online.
    /// Encoded/decoded by serializers as &quot;ASPC&quot;.
    /// </summary>
    [EnumMember(Value = "ASPC")]
    [IsoId("___8LwHs3EeSTS7uHCe8FPQ")]
    [Description(@"Card acceptor forced to be online.")]
    CardAcceptorSuspicious,
    
    /// <summary>
    /// Integrated circuit card declines the transaction after the authorisation.
    /// Encoded/decoded by serializers as &quot;CDCL&quot;.
    /// </summary>
    [EnumMember(Value = "CDCL")]
    [IsoId("_CtbFsHs4EeSTS7uHCe8FPQ")]
    [Description(@"Integrated circuit card declines the transaction after the authorisation.")]
    CardDeclined,
    
    /// <summary>
    /// Transaction performed offline by the card.
    /// Encoded/decoded by serializers as &quot;COFF&quot;.
    /// </summary>
    [EnumMember(Value = "COFF")]
    [IsoId("_F07pMHs4EeSTS7uHCe8FPQ")]
    [Description(@"Transaction performed offline by the card.")]
    CardProcessed,
    
    /// <summary>
    /// Random online decided by the card.
    /// Encoded/decoded by serializers as &quot;CRND&quot;.
    /// </summary>
    [EnumMember(Value = "CRND")]
    [IsoId("_IVwnMHs4EeSTS7uHCe8FPQ")]
    [Description(@"Random online decided by the card.")]
    CardRandomSelection,
    
    /// <summary>
    /// Card left by the cardholder.
    /// Encoded/decoded by serializers as &quot;CRTN&quot;.
    /// </summary>
    [EnumMember(Value = "CRTN")]
    [IsoId("_LNjTsHs4EeSTS7uHCe8FPQ")]
    [Description(@"Card left by the cardholder.")]
    CardRetained,
    
    /// <summary>
    /// Card cannot process offline the transaction.
    /// Encoded/decoded by serializers as &quot;CUNB&quot;.
    /// </summary>
    [EnumMember(Value = "CUNB")]
    [IsoId("_NmcdsHs4EeSTS7uHCe8FPQ")]
    [Description(@"Card cannot process offline the transaction.")]
    CardUnableToProcess,
    
    /// <summary>
    /// Customer cancellation, for example removing the chip card after sending the authorisation, but before the end of the transaction.
    /// Encoded/decoded by serializers as &quot;CCAN&quot;.
    /// </summary>
    [EnumMember(Value = "CCAN")]
    [IsoId("_Q8OGsHs4EeSTS7uHCe8FPQ")]
    [Description(@"Customer cancellation, for example removing the chip card after sending the authorisation, but before the end of the transaction.")]
    CustomerCancel,
    
    /// <summary>
    /// Deactivated key must be replaced.
    /// Encoded/decoded by serializers as &quot;KDAC&quot;.
    /// </summary>
    [EnumMember(Value = "KDAC")]
    [IsoId("_TvvXMHs4EeSTS7uHCe8FPQ")]
    [Description(@"Deactivated key must be replaced.")]
    DeactivatedKey,
    
    /// <summary>
    /// Response message was invalid (for example a problem of format or security).
    /// Encoded/decoded by serializers as &quot;ERRP&quot;.
    /// </summary>
    [EnumMember(Value = "ERRP")]
    [IsoId("_XES4MHs4EeSTS7uHCe8FPQ")]
    [Description(@"Response message was invalid (for example a problem of format or security).")]
    ErrorInResponse,
    
    /// <summary>
    /// Transaction above or under the floor limit.
    /// Encoded/decoded by serializers as &quot;FLRL&quot;.
    /// </summary>
    [EnumMember(Value = "FLRL")]
    [IsoId("_ZmlOwHs4EeSTS7uHCe8FPQ")]
    [Description(@"Transaction above or under the floor limit.")]
    FloorLimit,
    
    /// <summary>
    /// Inconsistency between the items deposited and their declared value.
    /// Encoded/decoded by serializers as &quot;IDPS&quot;.
    /// </summary>
    [EnumMember(Value = "IDPS")]
    [IsoId("_ckVZUHs4EeSTS7uHCe8FPQ")]
    [Description(@"Inconsistency between the items deposited and their declared value.")]
    InconsistentDeposit,
    
    /// <summary>
    /// Verification of the key has failed.
    /// Encoded/decoded by serializers as &quot;KINV&quot;.
    /// </summary>
    [EnumMember(Value = "KINV")]
    [IsoId("_f-vqsHs4EeSTS7uHCe8FPQ")]
    [Description(@"Verification of the key has failed.")]
    InvalidVerification,
    
    /// <summary>
    /// Issuer signed off.
    /// Encoded/decoded by serializers as &quot;ISGN&quot;.
    /// </summary>
    [EnumMember(Value = "ISGN")]
    [IsoId("_i88hMHs4EeSTS7uHCe8FPQ")]
    [Description(@"Issuer signed off.")]
    IssuerSignedOff,
    
    /// <summary>
    /// Stand-in processing at the issuer&apos;s option.
    /// Encoded/decoded by serializers as &quot;ISTD&quot;.
    /// </summary>
    [EnumMember(Value = "ISTD")]
    [IsoId("_mmtdMHs4EeSTS7uHCe8FPQ")]
    [Description(@"Stand-in processing at the issuer's option.")]
    IssuerStandin,
    
    /// <summary>
    /// Issuer timed out on request.
    /// Encoded/decoded by serializers as &quot;ITIM&quot;.
    /// </summary>
    [EnumMember(Value = "ITIM")]
    [IsoId("_qsPvMHs4EeSTS7uHCe8FPQ")]
    [Description(@"Issuer timed out on request.")]
    IssuerTimeout,
    
    /// <summary>
    /// Issuer unavailable.
    /// Encoded/decoded by serializers as &quot;IUNV&quot;.
    /// </summary>
    [EnumMember(Value = "IUNV")]
    [IsoId("_wJrBMHs4EeSTS7uHCe8FPQ")]
    [Description(@"Issuer unavailable.")]
    IssuerUnavailable,
    
    /// <summary>
    /// End of key life cycle.
    /// Encoded/decoded by serializers as &quot;ENDK&quot;.
    /// </summary>
    [EnumMember(Value = "ENDK")]
    [IsoId("_zGHkMHs4EeSTS7uHCe8FPQ")]
    [Description(@"End of key life cycle.")]
    LifeCycleEnd,
    
    /// <summary>
    /// Suspected malfunction (for example card reader defect, or printer out of order).
    /// Encoded/decoded by serializers as &quot;MLFC&quot;.
    /// </summary>
    [EnumMember(Value = "MLFC")]
    [IsoId("_1r1CMHs4EeSTS7uHCe8FPQ")]
    [Description(@"Suspected malfunction (for example card reader defect, or printer out of order).")]
    Malfunction,
    
    /// <summary>
    /// Offline authorisation declined the transaction.
    /// Encoded/decoded by serializers as &quot;FDCL&quot;.
    /// </summary>
    [EnumMember(Value = "FDCL")]
    [IsoId("_6dL4YHs4EeSTS7uHCe8FPQ")]
    [Description(@"Offline authorisation declined the transaction.")]
    OfflineDeclined,
    
    /// <summary>
    /// Online authorisation declined the transaction.
    /// Encoded/decoded by serializers as &quot;NDCL&quot;.
    /// </summary>
    [EnumMember(Value = "NDCL")]
    [IsoId("_-mOKUHs4EeSTS7uHCe8FPQ")]
    [Description(@"Online authorisation declined the transaction.")]
    OnLineDeclined,
    
    /// <summary>
    /// Forced online by card acceptor, terminal, card, or the issuer.
    /// Encoded/decoded by serializers as &quot;FORC&quot;.
    /// </summary>
    [EnumMember(Value = "FORC")]
    [IsoId("_BKjIQHs5EeSTS7uHCe8FPQ")]
    [Description(@"Forced online by card acceptor, terminal, card, or the issuer.")]
    OnlineForced,
    
    /// <summary>
    /// Keys not synchronised.
    /// Encoded/decoded by serializers as &quot;KSYN&quot;.
    /// </summary>
    [EnumMember(Value = "KSYN")]
    [IsoId("_ERS2wHs5EeSTS7uHCe8FPQ")]
    [Description(@"Keys not synchronised.")]
    OutOfSynchronisation,
    
    /// <summary>
    /// Partial reversal.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_HkGEQHs5EeSTS7uHCe8FPQ")]
    [Description(@"Partial reversal.")]
    PartiallyCompleted,
    
    /// <summary>
    /// Receiver signed off.
    /// Encoded/decoded by serializers as &quot;RSGN&quot;.
    /// </summary>
    [EnumMember(Value = "RSGN")]
    [IsoId("_MZKVwHs5EeSTS7uHCe8FPQ")]
    [Description(@"Receiver signed off.")]
    ReceiverSignedOff,
    
    /// <summary>
    /// Stand-in processing at the receiver&apos;s option.
    /// Encoded/decoded by serializers as &quot;RSTD&quot;.
    /// </summary>
    [EnumMember(Value = "RSTD")]
    [IsoId("_O5Ps4Hs5EeSTS7uHCe8FPQ")]
    [Description(@"Stand-in processing at the receiver's option.")]
    ReceiverStandin,
    
    /// <summary>
    /// Receiver timed out on request.
    /// Encoded/decoded by serializers as &quot;RTIM&quot;.
    /// </summary>
    [EnumMember(Value = "RTIM")]
    [IsoId("_Sup4MHs5EeSTS7uHCe8FPQ")]
    [Description(@"Receiver timed out on request.")]
    ReceiverTimeout,
    
    /// <summary>
    /// Receiver unavailable.
    /// Encoded/decoded by serializers as &quot;RUNV&quot;.
    /// </summary>
    [EnumMember(Value = "RUNV")]
    [IsoId("_WkycQHs5EeSTS7uHCe8FPQ")]
    [Description(@"Receiver unavailable.")]
    ReceiverUnavailable,
    
    /// <summary>
    /// Security reasons.
    /// Encoded/decoded by serializers as &quot;KSEC&quot;.
    /// </summary>
    [EnumMember(Value = "KSEC")]
    [IsoId("_Z-XnMHs5EeSTS7uHCe8FPQ")]
    [Description(@"Security reasons.")]
    SecurityReason,
    
    /// <summary>
    /// Card transaction failed because the merchant suspected a fraud.
    /// Encoded/decoded by serializers as &quot;SUSP&quot;.
    /// </summary>
    [EnumMember(Value = "SUSP")]
    [IsoId("_cuOfsHs5EeSTS7uHCe8FPQ")]
    [Description(@"Card transaction failed because the merchant suspected a fraud.")]
    SuspectedFraud,
    
    /// <summary>
    /// Transaction performed offline by the terminal.
    /// Encoded/decoded by serializers as &quot;TOFF&quot;.
    /// </summary>
    [EnumMember(Value = "TOFF")]
    [IsoId("_f_CwMHs5EeSTS7uHCe8FPQ")]
    [Description(@"Transaction performed offline by the terminal.")]
    TerminalProcessed,
    
    /// <summary>
    /// Random online decided by the terminal.
    /// Encoded/decoded by serializers as &quot;TRND&quot;.
    /// </summary>
    [EnumMember(Value = "TRND")]
    [IsoId("_ijFaQHs5EeSTS7uHCe8FPQ")]
    [Description(@"Random online decided by the terminal.")]
    TerminalRandomSelection,
    
    /// <summary>
    /// Terminal cannot process offline the transaction.
    /// Encoded/decoded by serializers as &quot;TUNB&quot;.
    /// </summary>
    [EnumMember(Value = "TUNB")]
    [IsoId("_liX14Hs5EeSTS7uHCe8FPQ")]
    [Description(@"Terminal cannot process offline the transaction.")]
    TerminalUnableToProcess,
    
    /// <summary>
    /// Waiting for response from the receiver, or no response was received (for example connection release before receiving the response).
    /// Encoded/decoded by serializers as &quot;TIMO&quot;.
    /// </summary>
    [EnumMember(Value = "TIMO")]
    [IsoId("_oFFDMHs5EeSTS7uHCe8FPQ")]
    [Description(@"Waiting for response from the receiver, or no response was received (for example connection release before receiving the response).")]
    TimeOut,
    
    /// <summary>
    /// Response to the authorisation received too late.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_sXIuQHs5EeSTS7uHCe8FPQ")]
    [Description(@"Response to the authorisation received too late.")]
    TooLateResponse,
    
    /// <summary>
    /// Card acceptor device unable to complete transaction after the authorisation response (for example, the written signature invalid).
    /// Encoded/decoded by serializers as &quot;UCMP&quot;.
    /// </summary>
    [EnumMember(Value = "UCMP")]
    [IsoId("_vEeeQHs5EeSTS7uHCe8FPQ")]
    [Description(@"Card acceptor device unable to complete transaction after the authorisation response (for example, the written signature invalid).")]
    UnableToComplete,
    
    /// <summary>
    /// Unable to send the message.
    /// Encoded/decoded by serializers as &quot;USND&quot;.
    /// </summary>
    [EnumMember(Value = "USND")]
    [IsoId("_zHuRQHs5EeSTS7uHCe8FPQ")]
    [Description(@"Unable to send the message.")]
    UnableToSend,
    
    /// <summary>
    /// Cardholder did not take the presented items.
    /// Encoded/decoded by serializers as &quot;UDSP&quot;.
    /// </summary>
    [EnumMember(Value = "UDSP")]
    [IsoId("_11vWsHs5EeSTS7uHCe8FPQ")]
    [Description(@"Cardholder did not take the presented items.")]
    UncompleteDispense,
    
    /// <summary>
    /// Acceptor is in legal liquidation.
    /// Encoded/decoded by serializers as &quot;ACLQ&quot;.
    /// </summary>
    [EnumMember(Value = "ACLQ")]
    [IsoId("_U1AqwHyIEemHsOqJOzMVfg")]
    [Description(@"Acceptor is in legal liquidation.")]
    AcceptorLiquidation,
    
    /// <summary>
    /// Account number not registered.
    /// Encoded/decoded by serializers as &quot;ANOF&quot;.
    /// </summary>
    [EnumMember(Value = "ANOF")]
    [IsoId("_U1AqwXyIEemHsOqJOzMVfg")]
    [Description(@"Account number not registered.")]
    AccountNotOnFile,
    
    /// <summary>
    /// Addition error
    /// Encoded/decoded by serializers as &quot;ADER&quot;.
    /// </summary>
    [EnumMember(Value = "ADER")]
    [IsoId("_U1AqwnyIEemHsOqJOzMVfg")]
    [Description(@"Addition error")]
    AdditionError,
    
    /// <summary>
    /// Advance lodging deposit.
    /// Encoded/decoded by serializers as &quot;ADLD&quot;.
    /// </summary>
    [EnumMember(Value = "ADLD")]
    [IsoId("_U1Aqw3yIEemHsOqJOzMVfg")]
    [Description(@"Advance lodging deposit.")]
    AdvanceLodgingDeposit,
    
    /// <summary>
    /// Alteration of amount.
    /// Encoded/decoded by serializers as &quot;ALAT&quot;.
    /// </summary>
    [EnumMember(Value = "ALAT")]
    [IsoId("_U1AqxHyIEemHsOqJOzMVfg")]
    [Description(@"Alteration of amount.")]
    AmountAlteration,
    
    /// <summary>
    /// Dispute on the amount.
    /// Encoded/decoded by serializers as &quot;AMDT&quot;.
    /// </summary>
    [EnumMember(Value = "AMDT")]
    [IsoId("_U1AqxXyIEemHsOqJOzMVfg")]
    [Description(@"Dispute on the amount.")]
    AmountDispute,
    
    /// <summary>
    /// ATM dispute
    /// Encoded/decoded by serializers as &quot;ATMD&quot;.
    /// </summary>
    [EnumMember(Value = "ATMD")]
    [IsoId("_U1AqxnyIEemHsOqJOzMVfg")]
    [Description(@"ATM dispute")]
    ATMDispute,
    
    /// <summary>
    /// ATM malfunction correction
    /// Encoded/decoded by serializers as &quot;ATMC&quot;.
    /// </summary>
    [EnumMember(Value = "ATMC")]
    [IsoId("_U1Aqx3yIEemHsOqJOzMVfg")]
    [Description(@"ATM malfunction correction")]
    ATMMalfunctionCorrection,
    
    /// <summary>
    /// Requested or required authorisation not obtained.
    /// Encoded/decoded by serializers as &quot;AUNO&quot;.
    /// </summary>
    [EnumMember(Value = "AUNO")]
    [IsoId("_U1AqyHyIEemHsOqJOzMVfg")]
    [Description(@"Requested or required authorisation not obtained.")]
    AuthorisationNotObtained,
    
    /// <summary>
    /// Recurring cancelled transaction.
    /// Encoded/decoded by serializers as &quot;CNRC&quot;.
    /// </summary>
    [EnumMember(Value = "CNRC")]
    [IsoId("_U1AqyXyIEemHsOqJOzMVfg")]
    [Description(@"Recurring cancelled transaction.")]
    CancelledRecurring,
    
    /// <summary>
    /// Reservation cancelled.
    /// Encoded/decoded by serializers as &quot;CNRV&quot;.
    /// </summary>
    [EnumMember(Value = "CNRV")]
    [IsoId("_U1AqynyIEemHsOqJOzMVfg")]
    [Description(@"Reservation cancelled.")]
    CancelledReservation,
    
    /// <summary>
    /// Card activated transaction by phone.
    /// Encoded/decoded by serializers as &quot;CRDA&quot;.
    /// </summary>
    [EnumMember(Value = "CRDA")]
    [IsoId("_U1Aqy3yIEemHsOqJOzMVfg")]
    [Description(@"Card activated transaction by phone.")]
    CardActivatedTransaction,
    
    /// <summary>
    /// Cardholder dispute.
    /// Encoded/decoded by serializers as &quot;CHDT&quot;.
    /// </summary>
    [EnumMember(Value = "CHDT")]
    [IsoId("_U1AqzHyIEemHsOqJOzMVfg")]
    [Description(@"Cardholder dispute.")]
    CardholderDispute,
    
    /// <summary>
    /// Invalid card or card expired.
    /// Encoded/decoded by serializers as &quot;CDNV&quot;.
    /// </summary>
    [EnumMember(Value = "CDNV")]
    [IsoId("_U1AqzXyIEemHsOqJOzMVfg")]
    [Description(@"Invalid card or card expired.")]
    CardNotValid,
    
    /// <summary>
    /// Other national type of reason.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_U1AqznyIEemHsOqJOzMVfg")]
    [Description(@"Other national type of reason.")]
    OtherNational,
    
    /// <summary>
    /// Other private type of reason.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_U1Aqz3yIEemHsOqJOzMVfg")]
    [Description(@"Other private type of reason.")]
    OtherPrivate,
    
    /// <summary>
    /// Liability shift due to use of chip.
    /// Encoded/decoded by serializers as &quot;CHLS&quot;.
    /// </summary>
    [EnumMember(Value = "CHLS")]
    [IsoId("_w2TLMnyIEemHsOqJOzMVfg")]
    [Description(@"Liability shift due to use of chip.")]
    ChipLiabilityShift,
    
    /// <summary>
    /// Counterfeit transaction, magnetic stripe fraud
    /// Encoded/decoded by serializers as &quot;COUT&quot;.
    /// </summary>
    [EnumMember(Value = "COUT")]
    [IsoId("_w2TLM3yIEemHsOqJOzMVfg")]
    [Description(@"Counterfeit transaction, magnetic stripe fraud")]
    CounterfeitTransaction,
    
    /// <summary>
    /// Credit not processed.
    /// Encoded/decoded by serializers as &quot;CRNP&quot;.
    /// </summary>
    [EnumMember(Value = "CRNP")]
    [IsoId("_w2TLNHyIEemHsOqJOzMVfg")]
    [Description(@"Credit not processed.")]
    CreditNotProcessed,
    
    /// <summary>
    /// Credit posted as purchased.
    /// Encoded/decoded by serializers as &quot;CRPP&quot;.
    /// </summary>
    [EnumMember(Value = "CRPP")]
    [IsoId("_w2TLNXyIEemHsOqJOzMVfg")]
    [Description(@"Credit posted as purchased.")]
    CreditPostedAsPurchased,
    
    /// <summary>
    /// No valid currency code provided for the transaction.
    /// Encoded/decoded by serializers as &quot;CCNP&quot;.
    /// </summary>
    [EnumMember(Value = "CCNP")]
    [IsoId("_w2TLNnyIEemHsOqJOzMVfg")]
    [Description(@"No valid currency code provided for the transaction.")]
    CurrencyCodeNotProvided,
    
    /// <summary>
    /// Currency not provided for the transaction.
    /// Encoded/decoded by serializers as &quot;CUNP&quot;.
    /// </summary>
    [EnumMember(Value = "CUNP")]
    [IsoId("_w2TLN3yIEemHsOqJOzMVfg")]
    [Description(@"Currency not provided for the transaction.")]
    CurrencyNotProvided,
    
    /// <summary>
    /// Merchandise was defective.
    /// Encoded/decoded by serializers as &quot;DFMD&quot;.
    /// </summary>
    [EnumMember(Value = "DFMD")]
    [IsoId("_w2TLOHyIEemHsOqJOzMVfg")]
    [Description(@"Merchandise was defective.")]
    DefectiveMerchandise,
    
    /// <summary>
    /// Domestic dispute.
    /// Encoded/decoded by serializers as &quot;DMDP&quot;.
    /// </summary>
    [EnumMember(Value = "DMDP")]
    [IsoId("_w2TLOXyIEemHsOqJOzMVfg")]
    [Description(@"Domestic dispute.")]
    DomesticDispute,
    
    /// <summary>
    /// Duplicate processing.
    /// Encoded/decoded by serializers as &quot;DUPR&quot;.
    /// </summary>
    [EnumMember(Value = "DUPR")]
    [IsoId("_w2TLOnyIEemHsOqJOzMVfg")]
    [Description(@"Duplicate processing.")]
    DuplicateProcessing,
    
    /// <summary>
    /// Earlier warning bulletin protection.
    /// Encoded/decoded by serializers as &quot;EAWG&quot;.
    /// </summary>
    [EnumMember(Value = "EAWG")]
    [IsoId("_w2TLO3yIEemHsOqJOzMVfg")]
    [Description(@"Earlier warning bulletin protection.")]
    EarlierWarning,
    
    /// <summary>
    /// Envelope deposited was empty.
    /// Encoded/decoded by serializers as &quot;EMDE&quot;.
    /// </summary>
    [EnumMember(Value = "EMDE")]
    [IsoId("_w2TLPHyIEemHsOqJOzMVfg")]
    [Description(@"Envelope deposited was empty.")]
    EmptyDepositEnvelope,
    
    /// <summary>
    /// Exceeds floor limit, not authorised - a fraudulent transaction.
    /// Encoded/decoded by serializers as &quot;EXFL&quot;.
    /// </summary>
    [EnumMember(Value = "EXFL")]
    [IsoId("_w2TLPXyIEemHsOqJOzMVfg")]
    [Description(@"Exceeds floor limit, not authorised - a fraudulent transaction.")]
    ExceedsFloorLimit,
    
    /// <summary>
    /// Card was expired.
    /// Encoded/decoded by serializers as &quot;EXCD&quot;.
    /// </summary>
    [EnumMember(Value = "EXCD")]
    [IsoId("_w2TLPnyIEemHsOqJOzMVfg")]
    [Description(@"Card was expired.")]
    ExpiredCard,
    
    /// <summary>
    /// Chargeback contains a valid reference.
    /// Encoded/decoded by serializers as &quot;VDCB&quot;.
    /// </summary>
    [EnumMember(Value = "VDCB")]
    [IsoId("_w2TLP3yIEemHsOqJOzMVfg")]
    [Description(@"Chargeback contains a valid reference.")]
    ValidChargeback,
    
    /// <summary>
    /// The transaction was forced.
    /// Encoded/decoded by serializers as &quot;FDTX&quot;.
    /// </summary>
    [EnumMember(Value = "FDTX")]
    [IsoId("_7ZbLvnyIEemHsOqJOzMVfg")]
    [Description(@"The transaction was forced.")]
    ForcedTransaction,
    
    /// <summary>
    /// Foreign deposit which was counterfeited.
    /// Encoded/decoded by serializers as &quot;FCDP&quot;.
    /// </summary>
    [EnumMember(Value = "FCDP")]
    [IsoId("_7ZbLv3yIEemHsOqJOzMVfg")]
    [Description(@"Foreign deposit which was counterfeited.")]
    ForeignCounterfeitDeposit,
    
    /// <summary>
    /// Fraudulent processing of a transaction.
    /// Encoded/decoded by serializers as &quot;FDPG&quot;.
    /// </summary>
    [EnumMember(Value = "FDPG")]
    [IsoId("_7ZbLwHyIEemHsOqJOzMVfg")]
    [Description(@"Fraudulent processing of a transaction.")]
    FraudulentProcessing,
    
    /// <summary>
    /// Goods or services were actually not provided.
    /// Encoded/decoded by serializers as &quot;GSNP&quot;.
    /// </summary>
    [EnumMember(Value = "GSNP")]
    [IsoId("_7ZbLwXyIEemHsOqJOzMVfg")]
    [Description(@"Goods or services were actually not provided.")]
    GoodsServicesNotProvided,
    
    /// <summary>
    /// Documentation received was illegible.
    /// Encoded/decoded by serializers as &quot;ILDT&quot;.
    /// </summary>
    [EnumMember(Value = "ILDT")]
    [IsoId("_7ZbLwnyIEemHsOqJOzMVfg")]
    [Description(@"Documentation received was illegible.")]
    IllegibleDocumentation,
    
    /// <summary>
    /// Information ineligible or missing.
    /// Encoded/decoded by serializers as &quot;IMIN&quot;.
    /// </summary>
    [EnumMember(Value = "IMIN")]
    [IsoId("_7ZbLxHyIEemHsOqJOzMVfg")]
    [Description(@"Information ineligible or missing.")]
    IneligibleOrMissingInfo,
    
    /// <summary>
    /// Transaction not eligible.
    /// Encoded/decoded by serializers as &quot;INTX&quot;.
    /// </summary>
    [EnumMember(Value = "INTX")]
    [IsoId("_7ZbLxXyIEemHsOqJOzMVfg")]
    [Description(@"Transaction not eligible.")]
    IneligibleTransaction,
    
    /// <summary>
    /// Requested transaction information not received.
    /// Encoded/decoded by serializers as &quot;INRV&quot;.
    /// </summary>
    [EnumMember(Value = "INRV")]
    [IsoId("_7ZbLxnyIEemHsOqJOzMVfg")]
    [Description(@"Requested transaction information not received.")]
    InformationNotReceived,
    
    /// <summary>
    /// Dispute about an instalment.
    /// Encoded/decoded by serializers as &quot;INSD&quot;.
    /// </summary>
    [EnumMember(Value = "INSD")]
    [IsoId("_7ZbLx3yIEemHsOqJOzMVfg")]
    [Description(@"Dispute about an instalment.")]
    InstalmentDispute,
    
    /// <summary>
    /// Acceptor suspended or deactivated
    /// Encoded/decoded by serializers as &quot;INVA&quot;.
    /// </summary>
    [EnumMember(Value = "INVA")]
    [IsoId("_7ZbLyHyIEemHsOqJOzMVfg")]
    [Description(@"Acceptor suspended or deactivated")]
    InvalidAcceptor,
    
    /// <summary>
    /// Invalid acquirer&apos;s reference number on representment, information was not received or was nor required.
    /// Encoded/decoded by serializers as &quot;INAR&quot;.
    /// </summary>
    [EnumMember(Value = "INAR")]
    [IsoId("_7ZbLyXyIEemHsOqJOzMVfg")]
    [Description(@"Invalid acquirer's reference number on representment, information was not received or was nor required.")]
    InvalidAcquirerReference,
    
    /// <summary>
    /// Documentation received was incomplete or invalid.
    /// Encoded/decoded by serializers as &quot;INDC&quot;.
    /// </summary>
    [EnumMember(Value = "INDC")]
    [IsoId("_7ZbLynyIEemHsOqJOzMVfg")]
    [Description(@"Documentation received was incomplete or invalid.")]
    InvalidDocumentation,
    
    /// <summary>
    /// Invalid acquirer&apos;s reference number on representment. Information was received.
    /// Encoded/decoded by serializers as &quot;IROR&quot;.
    /// </summary>
    [EnumMember(Value = "IROR")]
    [IsoId("_7ZbLy3yIEemHsOqJOzMVfg")]
    [Description(@"Invalid acquirer's reference number on representment. Information was received.")]
    InvalidReferenceOnRepresentment,
    
    /// <summary>
    /// Late presentment.
    /// Encoded/decoded by serializers as &quot;LTPR&quot;.
    /// </summary>
    [EnumMember(Value = "LTPR")]
    [IsoId("_Ff_MDXyJEemHsOqJOzMVfg")]
    [Description(@"Late presentment.")]
    LatePresentment,
    
    /// <summary>
    /// Imprint missing.
    /// Encoded/decoded by serializers as &quot;MISI&quot;.
    /// </summary>
    [EnumMember(Value = "MISI")]
    [IsoId("_Ff_MDnyJEemHsOqJOzMVfg")]
    [Description(@"Imprint missing.")]
    MissingImprint,
    
    /// <summary>
    /// Signature missing.
    /// Encoded/decoded by serializers as &quot;MISS&quot;.
    /// </summary>
    [EnumMember(Value = "MISS")]
    [IsoId("_Ff_MD3yJEemHsOqJOzMVfg")]
    [Description(@"Signature missing.")]
    MissingSignature,
    
    /// <summary>
    /// No cardholder authorisation.
    /// Encoded/decoded by serializers as &quot;NAUT&quot;.
    /// </summary>
    [EnumMember(Value = "NAUT")]
    [IsoId("_Ff_MEHyJEemHsOqJOzMVfg")]
    [Description(@"No cardholder authorisation.")]
    NoAuthorisation,
    
    /// <summary>
    /// Deposit was not exclusively made of cash.
    /// Encoded/decoded by serializers as &quot;NCDO&quot;.
    /// </summary>
    [EnumMember(Value = "NCDO")]
    [IsoId("_Ff_MEXyJEemHsOqJOzMVfg")]
    [Description(@"Deposit was not exclusively made of cash.")]
    NonCashDepositOnly,
    
    /// <summary>
    /// Non possession of card.
    /// Encoded/decoded by serializers as &quot;NPOC&quot;.
    /// </summary>
    [EnumMember(Value = "NPOC")]
    [IsoId("_Ff_MEnyJEemHsOqJOzMVfg")]
    [Description(@"Non possession of card.")]
    NonPossessionOfCard,
    
    /// <summary>
    /// Non receipt of cash
    /// Encoded/decoded by serializers as &quot;NROC&quot;.
    /// </summary>
    [EnumMember(Value = "NROC")]
    [IsoId("_Ff_ME3yJEemHsOqJOzMVfg")]
    [Description(@"Non receipt of cash")]
    NonReceiptOfCash,
    
    /// <summary>
    /// Non receipt of required documentation to support representment.
    /// Encoded/decoded by serializers as &quot;NROD&quot;.
    /// </summary>
    [EnumMember(Value = "NROD")]
    [IsoId("_Ff_MFHyJEemHsOqJOzMVfg")]
    [Description(@"Non receipt of required documentation to support representment.")]
    NonReceiptOfDocumentation,
    
    /// <summary>
    /// Non receipt of merchandise.
    /// Encoded/decoded by serializers as &quot;NROM&quot;.
    /// </summary>
    [EnumMember(Value = "NROM")]
    [IsoId("_Ff_MFXyJEemHsOqJOzMVfg")]
    [Description(@"Non receipt of merchandise.")]
    NonReceiptOfMerchandise,
    
    /// <summary>
    /// No show.
    /// Encoded/decoded by serializers as &quot;NOSH&quot;.
    /// </summary>
    [EnumMember(Value = "NOSH")]
    [IsoId("_Ff_MFnyJEemHsOqJOzMVfg")]
    [Description(@"No show.")]
    NoShow,
    
    /// <summary>
    /// The transaction was not allowed for the type of card.
    /// Encoded/decoded by serializers as &quot;NAFC&quot;.
    /// </summary>
    [EnumMember(Value = "NAFC")]
    [IsoId("_Ff_MF3yJEemHsOqJOzMVfg")]
    [Description(@"The transaction was not allowed for the type of card.")]
    NotAllowedForCard,
    
    /// <summary>
    /// Transaction that was not allowed.
    /// Encoded/decoded by serializers as &quot;NATX&quot;.
    /// </summary>
    [EnumMember(Value = "NATX")]
    [IsoId("_Ff_MGHyJEemHsOqJOzMVfg")]
    [Description(@"Transaction that was not allowed.")]
    NotAllowedTransaction,
    
    /// <summary>
    /// Not as described documentation or information.
    /// Encoded/decoded by serializers as &quot;NASD&quot;.
    /// </summary>
    [EnumMember(Value = "NASD")]
    [IsoId("_Ff_MGXyJEemHsOqJOzMVfg")]
    [Description(@"Not as described documentation or information.")]
    NotAsDescribed,
    
    /// <summary>
    /// Liability shift applying on PIN.
    /// Encoded/decoded by serializers as &quot;PINL&quot;.
    /// </summary>
    [EnumMember(Value = "PINL")]
    [IsoId("_Q6mOInyJEemHsOqJOzMVfg")]
    [Description(@"Liability shift applying on PIN.")]
    PINLiabilityShift,
    
    /// <summary>
    /// PIN was not verified
    /// Encoded/decoded by serializers as &quot;PINV&quot;.
    /// </summary>
    [EnumMember(Value = "PINV")]
    [IsoId("_Q6mOI3yJEemHsOqJOzMVfg")]
    [Description(@"PIN was not verified")]
    PINNotVerified,
    
    /// <summary>
    /// Potential fraud
    /// Encoded/decoded by serializers as &quot;PTFR&quot;.
    /// </summary>
    [EnumMember(Value = "PTFR")]
    [IsoId("_Q6mOJHyJEemHsOqJOzMVfg")]
    [Description(@"Potential fraud")]
    PotentialFraud,
    
    /// <summary>
    /// Error of processing.
    /// Encoded/decoded by serializers as &quot;PRER&quot;.
    /// </summary>
    [EnumMember(Value = "PRER")]
    [IsoId("_Q6mOJXyJEemHsOqJOzMVfg")]
    [Description(@"Error of processing.")]
    ProcessingError,
    
    /// <summary>
    /// Processing of domestic transaction violated rules.
    /// Encoded/decoded by serializers as &quot;PRVD&quot;.
    /// </summary>
    [EnumMember(Value = "PRVD")]
    [IsoId("_Q6mOJnyJEemHsOqJOzMVfg")]
    [Description(@"Processing of domestic transaction violated rules.")]
    ProcessingViolationDomestic,
    
    /// <summary>
    /// Card acceptor activity is questionable.
    /// Encoded/decoded by serializers as &quot;QUCA&quot;.
    /// </summary>
    [EnumMember(Value = "QUCA")]
    [IsoId("_Q6mOJ3yJEemHsOqJOzMVfg")]
    [Description(@"Card acceptor activity is questionable.")]
    QuestionableAcceptor,
    
    /// <summary>
    /// Questionable merchant.
    /// Encoded/decoded by serializers as &quot;QUMT&quot;.
    /// </summary>
    [EnumMember(Value = "QUMT")]
    [IsoId("_Q6mOKHyJEemHsOqJOzMVfg")]
    [Description(@"Questionable merchant.")]
    QuestionableMerchant,
    
    /// <summary>
    /// Receipt was not received
    /// Encoded/decoded by serializers as &quot;RCNR&quot;.
    /// </summary>
    [EnumMember(Value = "RCNR")]
    [IsoId("_Q6mOKXyJEemHsOqJOzMVfg")]
    [Description(@"Receipt was not received")]
    ReceiptNotReceived,
    
    /// <summary>
    /// Correction on representment.
    /// Encoded/decoded by serializers as &quot;RPTC&quot;.
    /// </summary>
    [EnumMember(Value = "RPTC")]
    [IsoId("_Q6mOKnyJEemHsOqJOzMVfg")]
    [Description(@"Correction on representment.")]
    RepresentmentCorrection,
    
    /// <summary>
    /// Item that was returned.
    /// Encoded/decoded by serializers as &quot;RETI&quot;.
    /// </summary>
    [EnumMember(Value = "RETI")]
    [IsoId("_Q6mOK3yJEemHsOqJOzMVfg")]
    [Description(@"Item that was returned.")]
    ReturnedItem,
    
    /// <summary>
    /// Service was not rendered.
    /// Encoded/decoded by serializers as &quot;SVNR&quot;.
    /// </summary>
    [EnumMember(Value = "SVNR")]
    [IsoId("_Q6mOLHyJEemHsOqJOzMVfg")]
    [Description(@"Service was not rendered.")]
    ServiceNotRendered,
    
    /// <summary>
    /// Error of settlement.
    /// Encoded/decoded by serializers as &quot;STLE&quot;.
    /// </summary>
    [EnumMember(Value = "STLE")]
    [IsoId("_Q6mOLXyJEemHsOqJOzMVfg")]
    [Description(@"Error of settlement.")]
    SettlementError,
    
    /// <summary>
    /// Transaction amount differs.
    /// Encoded/decoded by serializers as &quot;TXAD&quot;.
    /// </summary>
    [EnumMember(Value = "TXAD")]
    [IsoId("_Q6mOLnyJEemHsOqJOzMVfg")]
    [Description(@"Transaction amount differs.")]
    TransactionAmountDiffers,
    
    /// <summary>
    /// Transaction exceeds limited amount.
    /// Encoded/decoded by serializers as &quot;TXEA&quot;.
    /// </summary>
    [EnumMember(Value = "TXEA")]
    [IsoId("_Q6mOL3yJEemHsOqJOzMVfg")]
    [Description(@"Transaction exceeds limited amount.")]
    TransactionExceedsAmount,
    
    /// <summary>
    /// Warning bulletin file.
    /// Encoded/decoded by serializers as &quot;WNBF&quot;.
    /// </summary>
    [EnumMember(Value = "WNBF")]
    [IsoId("_Q6mOMHyJEemHsOqJOzMVfg")]
    [Description(@"Warning bulletin file.")]
    WarningBulletinFile,
    
    /// <summary>
    /// Wrong amount was keyed in.
    /// Encoded/decoded by serializers as &quot;WRAK&quot;.
    /// </summary>
    [EnumMember(Value = "WRAK")]
    [IsoId("_Q6mOMXyJEemHsOqJOzMVfg")]
    [Description(@"Wrong amount was keyed in.")]
    WrongAmountKeyed,
    
    /// <summary>
    /// Counterfeit card.
    /// Encoded/decoded by serializers as &quot;COCD&quot;.
    /// </summary>
    [EnumMember(Value = "COCD")]
    [IsoId("_XdiWtXyJEemHsOqJOzMVfg")]
    [Description(@"Counterfeit card.")]
    CounterfeitCard,
    
    /// <summary>
    /// Card that was lost.
    /// Encoded/decoded by serializers as &quot;LTCD&quot;.
    /// </summary>
    [EnumMember(Value = "LTCD")]
    [IsoId("_XdiWtnyJEemHsOqJOzMVfg")]
    [Description(@"Card that was lost.")]
    LostCard,
    
    /// <summary>
    /// Other reason to send a message.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_XdiWt3yJEemHsOqJOzMVfg")]
    [Description(@"Other reason to send a message.")]
    Other,
    
    /// <summary>
    /// Card that was stolen.
    /// Encoded/decoded by serializers as &quot;STCD&quot;.
    /// </summary>
    [EnumMember(Value = "STCD")]
    [IsoId("_XdiWuHyJEemHsOqJOzMVfg")]
    [Description(@"Card that was stolen.")]
    StolenCard,
    
    /// <summary>
    /// Card was not delivered.
    /// Encoded/decoded by serializers as &quot;UNCD&quot;.
    /// </summary>
    [EnumMember(Value = "UNCD")]
    [IsoId("_XdiWuXyJEemHsOqJOzMVfg")]
    [Description(@"Card was not delivered.")]
    UndeliveredCard,
    
}
