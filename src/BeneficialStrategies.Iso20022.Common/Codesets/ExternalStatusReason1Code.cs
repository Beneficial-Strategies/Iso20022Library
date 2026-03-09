// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status reason, as published in an external status reason code list.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_amolhtp-Ed-ak6NoX_4Aeg_1672970561")]
[Description(@"Specifies the status reason, as published in an external status reason code list.|External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalStatusReasonCode))]
public enum ExternalStatusReason1Code
{
    /// <summary>
    /// Clearing process aborted due to timeout.   
    /// Encoded/decoded by serializers as &quot;AB01&quot;.
    /// </summary>
    [EnumMember(Value = "AB01")]
    [IsoId("_t9aCBfRYEeuLhpyIdtJzwg")]
    [Description(@"Clearing process aborted due to timeout.   ")]
    AbortedClearingTimeout = ExternalStatusReasonCode.AbortedClearingTimeout, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Clearing process aborted due to a fatal error.   
    /// Encoded/decoded by serializers as &quot;AB02&quot;.
    /// </summary>
    [EnumMember(Value = "AB02")]
    [IsoId("_t9jzAvRYEeuLhpyIdtJzwg")]
    [Description(@"Clearing process aborted due to a fatal error.   ")]
    AbortedClearingFatalError = ExternalStatusReasonCode.AbortedClearingFatalError, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement aborted due to timeout.   
    /// Encoded/decoded by serializers as &quot;AB03&quot;.
    /// </summary>
    [EnumMember(Value = "AB03")]
    [IsoId("_t9jzBfRYEeuLhpyIdtJzwg")]
    [Description(@"Settlement aborted due to timeout.   ")]
    AbortedSettlementTimeout = ExternalStatusReasonCode.AbortedSettlementTimeout, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement process aborted due to a fatal error.   
    /// Encoded/decoded by serializers as &quot;AB04&quot;.
    /// </summary>
    [EnumMember(Value = "AB04")]
    [IsoId("_t9s88vRYEeuLhpyIdtJzwg")]
    [Description(@"Settlement process aborted due to a fatal error.   ")]
    AbortedSettlementFatalError = ExternalStatusReasonCode.AbortedSettlementFatalError, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction stopped due to timeout at the Creditor Agent.
    /// Encoded/decoded by serializers as &quot;AB05&quot;.
    /// </summary>
    [EnumMember(Value = "AB05")]
    [IsoId("_t9s89fRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction stopped due to timeout at the Creditor Agent.")]
    TimeoutCreditorAgent = ExternalStatusReasonCode.TimeoutCreditorAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction stopped due to timeout at the Instructed Agent.
    /// Encoded/decoded by serializers as &quot;AB06&quot;.
    /// </summary>
    [EnumMember(Value = "AB06")]
    [IsoId("_t9s8-PRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction stopped due to timeout at the Instructed Agent.")]
    TimeoutInstructedAgent = ExternalStatusReasonCode.TimeoutInstructedAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Agent of message is not online.|Generic usage if it cannot be determined who exactly is not online.
    /// Encoded/decoded by serializers as &quot;AB07&quot;.
    /// </summary>
    [EnumMember(Value = "AB07")]
    [IsoId("_t92t8vRYEeuLhpyIdtJzwg")]
    [Description(@"Agent of message is not online.|Generic usage if it cannot be determined who exactly is not online.")]
    OfflineAgent = ExternalStatusReasonCode.OfflineAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Creditor Agent is not online.
    /// Encoded/decoded by serializers as &quot;AB08&quot;.
    /// </summary>
    [EnumMember(Value = "AB08")]
    [IsoId("_t92t9fRYEeuLhpyIdtJzwg")]
    [Description(@"Creditor Agent is not online.")]
    OfflineCreditorAgent = ExternalStatusReasonCode.OfflineCreditorAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction stopped due to error at the Creditor Agent.
    /// Encoded/decoded by serializers as &quot;AB09&quot;.
    /// </summary>
    [EnumMember(Value = "AB09")]
    [IsoId("_t92t-PRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction stopped due to error at the Creditor Agent.")]
    ErrorCreditorAgent = ExternalStatusReasonCode.ErrorCreditorAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction stopped due to error at the Instructed Agent.
    /// Encoded/decoded by serializers as &quot;AB10&quot;.
    /// </summary>
    [EnumMember(Value = "AB10")]
    [IsoId("_t92t-_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction stopped due to error at the Instructed Agent.")]
    ErrorInstructedAgent = ExternalStatusReasonCode.ErrorInstructedAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction stopped due to timeout at the Debtor Agent.
    /// Encoded/decoded by serializers as &quot;AB11&quot;.
    /// </summary>
    [EnumMember(Value = "AB11")]
    [IsoId("_t92t_vRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction stopped due to timeout at the Debtor Agent.")]
    TimeoutDebtorAgent = ExternalStatusReasonCode.TimeoutDebtorAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account number is invalid or missing.   |
    /// Encoded/decoded by serializers as &quot;AC01&quot;.
    /// </summary>
    [EnumMember(Value = "AC01")]
    [IsoId("_t-Ae8vRYEeuLhpyIdtJzwg")]
    [Description(@"Account number is invalid or missing.   |")]
    IncorrectAccountNumber = ExternalStatusReasonCode.IncorrectAccountNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Debtor account number invalid or missing
    /// Encoded/decoded by serializers as &quot;AC02&quot;.
    /// </summary>
    [EnumMember(Value = "AC02")]
    [IsoId("_t-Ae9fRYEeuLhpyIdtJzwg")]
    [Description(@"Debtor account number invalid or missing")]
    InvalidDebtorAccountNumber = ExternalStatusReasonCode.InvalidDebtorAccountNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Creditor account number invalid or missing
    /// Encoded/decoded by serializers as &quot;AC03&quot;.
    /// </summary>
    [EnumMember(Value = "AC03")]
    [IsoId("_t-Jo4vRYEeuLhpyIdtJzwg")]
    [Description(@"Creditor account number invalid or missing")]
    InvalidCreditorAccountNumber = ExternalStatusReasonCode.InvalidCreditorAccountNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account number specified has been closed on the bank of account&apos;s books. 
    /// Encoded/decoded by serializers as &quot;AC04&quot;.
    /// </summary>
    [EnumMember(Value = "AC04")]
    [IsoId("_t-Jo5fRYEeuLhpyIdtJzwg")]
    [Description(@"Account number specified has been closed on the bank of account's books. ")]
    ClosedAccountNumber = ExternalStatusReasonCode.ClosedAccountNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Debtor account number closed
    /// Encoded/decoded by serializers as &quot;AC05&quot;.
    /// </summary>
    [EnumMember(Value = "AC05")]
    [IsoId("_t-Jo6PRYEeuLhpyIdtJzwg")]
    [Description(@"Debtor account number closed")]
    ClosedDebtorAccountNumber = ExternalStatusReasonCode.ClosedDebtorAccountNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account specified is blocked, prohibiting posting of transactions against it.
    /// Encoded/decoded by serializers as &quot;AC06&quot;.
    /// </summary>
    [EnumMember(Value = "AC06")]
    [IsoId("_t-Jo6_RYEeuLhpyIdtJzwg")]
    [Description(@"Account specified is blocked, prohibiting posting of transactions against it.")]
    BlockedAccount = ExternalStatusReasonCode.BlockedAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Creditor account number closed
    /// Encoded/decoded by serializers as &quot;AC07&quot;.
    /// </summary>
    [EnumMember(Value = "AC07")]
    [IsoId("_t-Jo7vRYEeuLhpyIdtJzwg")]
    [Description(@"Creditor account number closed")]
    ClosedCreditorAccountNumber = ExternalStatusReasonCode.ClosedCreditorAccountNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Branch code is invalid or missing
    /// Encoded/decoded by serializers as &quot;AC08&quot;.
    /// </summary>
    [EnumMember(Value = "AC08")]
    [IsoId("_t-TZ4vRYEeuLhpyIdtJzwg")]
    [Description(@"Branch code is invalid or missing")]
    InvalidBranchCode = ExternalStatusReasonCode.InvalidBranchCode, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account currency is invalid or missing
    /// Encoded/decoded by serializers as &quot;AC09&quot;.
    /// </summary>
    [EnumMember(Value = "AC09")]
    [IsoId("_t-TZ5fRYEeuLhpyIdtJzwg")]
    [Description(@"Account currency is invalid or missing")]
    InvalidAccountCurrency = ExternalStatusReasonCode.InvalidAccountCurrency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Debtor account currency is invalid or missing
    /// Encoded/decoded by serializers as &quot;AC10&quot;.
    /// </summary>
    [EnumMember(Value = "AC10")]
    [IsoId("_t-TZ6PRYEeuLhpyIdtJzwg")]
    [Description(@"Debtor account currency is invalid or missing")]
    InvalidDebtorAccountCurrency = ExternalStatusReasonCode.InvalidDebtorAccountCurrency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Creditor account currency is invalid or missing
    /// Encoded/decoded by serializers as &quot;AC11&quot;.
    /// </summary>
    [EnumMember(Value = "AC11")]
    [IsoId("_t-TZ6_RYEeuLhpyIdtJzwg")]
    [Description(@"Creditor account currency is invalid or missing")]
    InvalidCreditorAccountCurrency = ExternalStatusReasonCode.InvalidCreditorAccountCurrency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account type missing or invalid.|Generic usage if cannot specify between group and payment information levels
    /// Encoded/decoded by serializers as &quot;AC12&quot;.
    /// </summary>
    [EnumMember(Value = "AC12")]
    [IsoId("_t-TZ7vRYEeuLhpyIdtJzwg")]
    [Description(@"Account type missing or invalid.|Generic usage if cannot specify between group and payment information levels")]
    InvalidAccountType = ExternalStatusReasonCode.InvalidAccountType, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Debtor account type missing or invalid
    /// Encoded/decoded by serializers as &quot;AC13&quot;.
    /// </summary>
    [EnumMember(Value = "AC13")]
    [IsoId("_t-cj0vRYEeuLhpyIdtJzwg")]
    [Description(@"Debtor account type missing or invalid")]
    InvalidDebtorAccountType = ExternalStatusReasonCode.InvalidDebtorAccountType, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Creditor account type missing or invalid
    /// Encoded/decoded by serializers as &quot;AC14&quot;.
    /// </summary>
    [EnumMember(Value = "AC14")]
    [IsoId("_t-cj1fRYEeuLhpyIdtJzwg")]
    [Description(@"Creditor account type missing or invalid")]
    InvalidCreditorAccountType = ExternalStatusReasonCode.InvalidCreditorAccountType, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The account details for the counterparty have changed.
    /// Encoded/decoded by serializers as &quot;AC15&quot;.
    /// </summary>
    [EnumMember(Value = "AC15")]
    [IsoId("_t-cj2PRYEeuLhpyIdtJzwg")]
    [Description(@"The account details for the counterparty have changed.")]
    AccountDetailsChanged = ExternalStatusReasonCode.AccountDetailsChanged, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Credit or debit card number is invalid.
    /// Encoded/decoded by serializers as &quot;AC16&quot;.
    /// </summary>
    [EnumMember(Value = "AC16")]
    [IsoId("_t-cj2_RYEeuLhpyIdtJzwg")]
    [Description(@"Credit or debit card number is invalid.")]
    CardNumberInvalid = ExternalStatusReasonCode.CardNumberInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction forbidden on this type of account (formerly NoAgreement)
    /// Encoded/decoded by serializers as &quot;AG01&quot;.
    /// </summary>
    [EnumMember(Value = "AG01")]
    [IsoId("_t-cj3vRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction forbidden on this type of account (formerly NoAgreement)")]
    TransactionForbidden = ExternalStatusReasonCode.TransactionForbidden, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bank Operation code specified in the message is not valid for receiver
    /// Encoded/decoded by serializers as &quot;AG02&quot;.
    /// </summary>
    [EnumMember(Value = "AG02")]
    [IsoId("_t-mU0vRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Operation code specified in the message is not valid for receiver")]
    InvalidBankOperationCode = ExternalStatusReasonCode.InvalidBankOperationCode, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction type not supported/authorized on this account 
    /// Encoded/decoded by serializers as &quot;AG03&quot;.
    /// </summary>
    [EnumMember(Value = "AG03")]
    [IsoId("_t-mU1fRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction type not supported/authorized on this account ")]
    TransactionNotSupported = ExternalStatusReasonCode.TransactionNotSupported, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Agent country code is missing or invalid.|Generic usage if cannot specify between group and payment information levels.
    /// Encoded/decoded by serializers as &quot;AG04&quot;.
    /// </summary>
    [EnumMember(Value = "AG04")]
    [IsoId("_t-mU2PRYEeuLhpyIdtJzwg")]
    [Description(@"Agent country code is missing or invalid.|Generic usage if cannot specify between group and payment information levels.")]
    InvalidAgentCountry = ExternalStatusReasonCode.InvalidAgentCountry, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Debtor agent country code is missing or invalid
    /// Encoded/decoded by serializers as &quot;AG05&quot;.
    /// </summary>
    [EnumMember(Value = "AG05")]
    [IsoId("_t-mU2_RYEeuLhpyIdtJzwg")]
    [Description(@"Debtor agent country code is missing or invalid")]
    InvalidDebtorAgentCountry = ExternalStatusReasonCode.InvalidDebtorAgentCountry, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Creditor agent country code is missing or invalid
    /// Encoded/decoded by serializers as &quot;AG06&quot;.
    /// </summary>
    [EnumMember(Value = "AG06")]
    [IsoId("_t-mU3vRYEeuLhpyIdtJzwg")]
    [Description(@"Creditor agent country code is missing or invalid")]
    InvalidCreditorAgentCountry = ExternalStatusReasonCode.InvalidCreditorAgentCountry, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Debtor account cannot be debited for a generic reason.|Code value may be used in general purposes and as a replacement for AM04 if debtor bank does not reveal its customer&apos;s insufficient funds for privacy reasons
    /// Encoded/decoded by serializers as &quot;AG07&quot;.
    /// </summary>
    [EnumMember(Value = "AG07")]
    [IsoId("_t-wF0vRYEeuLhpyIdtJzwg")]
    [Description(@"Debtor account cannot be debited for a generic reason.|Code value may be used in general purposes and as a replacement for AM04 if debtor bank does not reveal its customer's insufficient funds for privacy reasons")]
    UnsuccesfulDirectDebit = ExternalStatusReasonCode.UnsuccesfulDirectDebit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction failed due to invalid or missing user or access right
    /// Encoded/decoded by serializers as &quot;AG08&quot;.
    /// </summary>
    [EnumMember(Value = "AG08")]
    [IsoId("_t-wF1fRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction failed due to invalid or missing user or access right")]
    InvalidAccessRights = ExternalStatusReasonCode.InvalidAccessRights, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Original payment never received.
    /// Encoded/decoded by serializers as &quot;AG09&quot;.
    /// </summary>
    [EnumMember(Value = "AG09")]
    [IsoId("_t-wF2PRYEeuLhpyIdtJzwg")]
    [Description(@"Original payment never received.")]
    PaymentNotReceived = ExternalStatusReasonCode.PaymentNotReceived, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Agent of message is suspended from the Real Time Payment system.|Generic usage if it cannot be determined who exactly is suspended.
    /// Encoded/decoded by serializers as &quot;AG10&quot;.
    /// </summary>
    [EnumMember(Value = "AG10")]
    [IsoId("_t-wF2_RYEeuLhpyIdtJzwg")]
    [Description(@"Agent of message is suspended from the Real Time Payment system.|Generic usage if it cannot be determined who exactly is suspended.")]
    AgentSuspended = ExternalStatusReasonCode.AgentSuspended, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Creditor Agent of message is suspended from the Real Time Payment system.
    /// Encoded/decoded by serializers as &quot;AG11&quot;.
    /// </summary>
    [EnumMember(Value = "AG11")]
    [IsoId("_t-wF3vRYEeuLhpyIdtJzwg")]
    [Description(@"Creditor Agent of message is suspended from the Real Time Payment system.")]
    CreditorAgentSuspended = ExternalStatusReasonCode.CreditorAgentSuspended, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment orders made by transferring funds from one account to another at the same financial institution (bank or payment institution) are not allowed.
    /// Encoded/decoded by serializers as &quot;AG12&quot;.
    /// </summary>
    [EnumMember(Value = "AG12")]
    [IsoId("_t-5PwvRYEeuLhpyIdtJzwg")]
    [Description(@"Payment orders made by transferring funds from one account to another at the same financial institution (bank or payment institution) are not allowed.")]
    NotAllowedBookTransfer = ExternalStatusReasonCode.NotAllowedBookTransfer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Returned payments derived from previously returned transactions are not allowed.
    /// Encoded/decoded by serializers as &quot;AG13&quot;.
    /// </summary>
    [EnumMember(Value = "AG13")]
    [IsoId("_t-5PxfRYEeuLhpyIdtJzwg")]
    [Description(@"Returned payments derived from previously returned transactions are not allowed.")]
    ForbiddenReturnPayment = ExternalStatusReasonCode.ForbiddenReturnPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Agent in the payment workflow is incorrect
    /// Encoded/decoded by serializers as &quot;AGNT&quot;.
    /// </summary>
    [EnumMember(Value = "AGNT")]
    [IsoId("_t_DAwvRYEeuLhpyIdtJzwg")]
    [Description(@"Agent in the payment workflow is incorrect")]
    IncorrectAgent = ExternalStatusReasonCode.IncorrectAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Specified message amount is equal to zero
    /// Encoded/decoded by serializers as &quot;AM01&quot;.
    /// </summary>
    [EnumMember(Value = "AM01")]
    [IsoId("_t_DAxfRYEeuLhpyIdtJzwg")]
    [Description(@"Specified message amount is equal to zero")]
    ZeroAmount = ExternalStatusReasonCode.ZeroAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Specific transaction/message amount is greater than allowed maximum
    /// Encoded/decoded by serializers as &quot;AM02&quot;.
    /// </summary>
    [EnumMember(Value = "AM02")]
    [IsoId("_t_DAyPRYEeuLhpyIdtJzwg")]
    [Description(@"Specific transaction/message amount is greater than allowed maximum")]
    NotAllowedAmount = ExternalStatusReasonCode.NotAllowedAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Specified message amount is an non processable currency outside of existing agreement
    /// Encoded/decoded by serializers as &quot;AM03&quot;.
    /// </summary>
    [EnumMember(Value = "AM03")]
    [IsoId("_t_DAy_RYEeuLhpyIdtJzwg")]
    [Description(@"Specified message amount is an non processable currency outside of existing agreement")]
    NotAllowedCurrency = ExternalStatusReasonCode.NotAllowedCurrency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amount of funds available to cover specified message amount is insufficient.
    /// Encoded/decoded by serializers as &quot;AM04&quot;.
    /// </summary>
    [EnumMember(Value = "AM04")]
    [IsoId("_t_MxwvRYEeuLhpyIdtJzwg")]
    [Description(@"Amount of funds available to cover specified message amount is insufficient.")]
    InsufficientFunds = ExternalStatusReasonCode.InsufficientFunds, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Duplication
    /// Encoded/decoded by serializers as &quot;AM05&quot;.
    /// </summary>
    [EnumMember(Value = "AM05")]
    [IsoId("_t_MxxfRYEeuLhpyIdtJzwg")]
    [Description(@"Duplication")]
    Duplication = ExternalStatusReasonCode.Duplication, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Specified transaction amount is less than agreed minimum.
    /// Encoded/decoded by serializers as &quot;AM06&quot;.
    /// </summary>
    [EnumMember(Value = "AM06")]
    [IsoId("_t_MxyPRYEeuLhpyIdtJzwg")]
    [Description(@"Specified transaction amount is less than agreed minimum.")]
    TooLowAmount = ExternalStatusReasonCode.TooLowAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amount specified in message has been blocked by regulatory authorities.
    /// Encoded/decoded by serializers as &quot;AM07&quot;.
    /// </summary>
    [EnumMember(Value = "AM07")]
    [IsoId("_t_V7svRYEeuLhpyIdtJzwg")]
    [Description(@"Amount specified in message has been blocked by regulatory authorities.")]
    BlockedAmount = ExternalStatusReasonCode.BlockedAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amount received is not the amount agreed or expected
    /// Encoded/decoded by serializers as &quot;AM09&quot;.
    /// </summary>
    [EnumMember(Value = "AM09")]
    [IsoId("_t_V7tfRYEeuLhpyIdtJzwg")]
    [Description(@"Amount received is not the amount agreed or expected")]
    WrongAmount = ExternalStatusReasonCode.WrongAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Sum of instructed amounts does not equal the control sum.
    /// Encoded/decoded by serializers as &quot;AM10&quot;.
    /// </summary>
    [EnumMember(Value = "AM10")]
    [IsoId("_t_V7uPRYEeuLhpyIdtJzwg")]
    [Description(@"Sum of instructed amounts does not equal the control sum.")]
    InvalidControlSum = ExternalStatusReasonCode.InvalidControlSum, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction currency is invalid or missing
    /// Encoded/decoded by serializers as &quot;AM11&quot;.
    /// </summary>
    [EnumMember(Value = "AM11")]
    [IsoId("_t_V7u_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction currency is invalid or missing")]
    InvalidTransactionCurrency = ExternalStatusReasonCode.InvalidTransactionCurrency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amount is invalid or missing
    /// Encoded/decoded by serializers as &quot;AM12&quot;.
    /// </summary>
    [EnumMember(Value = "AM12")]
    [IsoId("_t_V7vvRYEeuLhpyIdtJzwg")]
    [Description(@"Amount is invalid or missing")]
    InvalidAmount = ExternalStatusReasonCode.InvalidAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction amount exceeds limits set by clearing system
    /// Encoded/decoded by serializers as &quot;AM13&quot;.
    /// </summary>
    [EnumMember(Value = "AM13")]
    [IsoId("_t_fssvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction amount exceeds limits set by clearing system")]
    AmountExceedsClearingSystemLimit = ExternalStatusReasonCode.AmountExceedsClearingSystemLimit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction amount exceeds limits agreed between bank and client
    /// Encoded/decoded by serializers as &quot;AM14&quot;.
    /// </summary>
    [EnumMember(Value = "AM14")]
    [IsoId("_t_fstfRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction amount exceeds limits agreed between bank and client")]
    AmountExceedsAgreedLimit = ExternalStatusReasonCode.AmountExceedsAgreedLimit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction amount below minimum set by clearing system
    /// Encoded/decoded by serializers as &quot;AM15&quot;.
    /// </summary>
    [EnumMember(Value = "AM15")]
    [IsoId("_t_fsuPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction amount below minimum set by clearing system")]
    AmountBelowClearingSystemMinimum = ExternalStatusReasonCode.AmountBelowClearingSystemMinimum, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Control Sum at the Group level is invalid
    /// Encoded/decoded by serializers as &quot;AM16&quot;.
    /// </summary>
    [EnumMember(Value = "AM16")]
    [IsoId("_t_fsu_RYEeuLhpyIdtJzwg")]
    [Description(@"Control Sum at the Group level is invalid")]
    InvalidGroupControlSum = ExternalStatusReasonCode.InvalidGroupControlSum, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Control Sum at the Payment Information level is invalid
    /// Encoded/decoded by serializers as &quot;AM17&quot;.
    /// </summary>
    [EnumMember(Value = "AM17")]
    [IsoId("_t_o2ovRYEeuLhpyIdtJzwg")]
    [Description(@"Control Sum at the Payment Information level is invalid")]
    InvalidPaymentInfoControlSum = ExternalStatusReasonCode.InvalidPaymentInfoControlSum, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Number of transactions is invalid or missing.|Generic usage if cannot specify between group and payment information levels.
    /// Encoded/decoded by serializers as &quot;AM18&quot;.
    /// </summary>
    [EnumMember(Value = "AM18")]
    [IsoId("_t_o2pfRYEeuLhpyIdtJzwg")]
    [Description(@"Number of transactions is invalid or missing.|Generic usage if cannot specify between group and payment information levels.")]
    InvalidNumberOfTransactions = ExternalStatusReasonCode.InvalidNumberOfTransactions, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Number of transactions at the Group level is invalid or missing
    /// Encoded/decoded by serializers as &quot;AM19&quot;.
    /// </summary>
    [EnumMember(Value = "AM19")]
    [IsoId("_t_o2qPRYEeuLhpyIdtJzwg")]
    [Description(@"Number of transactions at the Group level is invalid or missing")]
    InvalidGroupNumberOfTransactions = ExternalStatusReasonCode.InvalidGroupNumberOfTransactions, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Number of transactions at the Payment Information level is invalid
    /// Encoded/decoded by serializers as &quot;AM20&quot;.
    /// </summary>
    [EnumMember(Value = "AM20")]
    [IsoId("_t_ynovRYEeuLhpyIdtJzwg")]
    [Description(@"Number of transactions at the Payment Information level is invalid")]
    InvalidPaymentInfoNumberOfTransactions = ExternalStatusReasonCode.InvalidPaymentInfoNumberOfTransactions, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction amount exceeds limits agreed between bank and client.
    /// Encoded/decoded by serializers as &quot;AM21&quot;.
    /// </summary>
    [EnumMember(Value = "AM21")]
    [IsoId("_t_ynpfRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction amount exceeds limits agreed between bank and client.")]
    LimitExceeded = ExternalStatusReasonCode.LimitExceeded, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unable to apply zero amount to designated account. For example, where the rules of a service allow the use of zero amount payments, however the back-office system is unable to apply the funds to the account. If the rules of a service prohibit the use of zero amount payments, then code AM01 is used to report the error condition.
    /// Encoded/decoded by serializers as &quot;AM22&quot;.
    /// </summary>
    [EnumMember(Value = "AM22")]
    [IsoId("_t_ynqPRYEeuLhpyIdtJzwg")]
    [Description(@"Unable to apply zero amount to designated account. For example, where the rules of a service allow the use of zero amount payments, however the back-office system is unable to apply the funds to the account. If the rules of a service prohibit the use of zero amount payments, then code AM01 is used to report the error condition.")]
    ZeroAmountNotApplied = ExternalStatusReasonCode.ZeroAmountNotApplied, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction amount exceeds settlement limit.
    /// Encoded/decoded by serializers as &quot;AM23&quot;.
    /// </summary>
    [EnumMember(Value = "AM23")]
    [IsoId("_t_ynq_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction amount exceeds settlement limit.")]
    AmountExceedsSettlementLimit = ExternalStatusReasonCode.AmountExceedsSettlementLimit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identification of end customer is not consistent with associated account number. (formerly CreditorConsistency).
    /// Encoded/decoded by serializers as &quot;BE01&quot;.
    /// </summary>
    [EnumMember(Value = "BE01")]
    [IsoId("_t_ynrvRYEeuLhpyIdtJzwg")]
    [Description(@"Identification of end customer is not consistent with associated account number. (formerly CreditorConsistency).")]
    InconsistenWithEndCustomer = ExternalStatusReasonCode.InconsistenWithEndCustomer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Specification of creditor&apos;s address, which is required for payment, is missing/not correct (formerly IncorrectCreditorAddress).
    /// Encoded/decoded by serializers as &quot;BE04&quot;.
    /// </summary>
    [EnumMember(Value = "BE04")]
    [IsoId("_t_7xkvRYEeuLhpyIdtJzwg")]
    [Description(@"Specification of creditor's address, which is required for payment, is missing/not correct (formerly IncorrectCreditorAddress).")]
    MissingCreditorAddress = ExternalStatusReasonCode.MissingCreditorAddress, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Party who initiated the message is not recognised by the end customer
    /// Encoded/decoded by serializers as &quot;BE05&quot;.
    /// </summary>
    [EnumMember(Value = "BE05")]
    [IsoId("_t_7xlfRYEeuLhpyIdtJzwg")]
    [Description(@"Party who initiated the message is not recognised by the end customer")]
    UnrecognisedInitiatingParty = ExternalStatusReasonCode.UnrecognisedInitiatingParty, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// End customer specified is not known at associated Sort/National Bank Code or does no longer exist in the books
    /// Encoded/decoded by serializers as &quot;BE06&quot;.
    /// </summary>
    [EnumMember(Value = "BE06")]
    [IsoId("_t_7xmPRYEeuLhpyIdtJzwg")]
    [Description(@"End customer specified is not known at associated Sort/National Bank Code or does no longer exist in the books")]
    UnknownEndCustomer = ExternalStatusReasonCode.UnknownEndCustomer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Specification of debtor&apos;s address, which is required for payment, is missing/not correct.
    /// Encoded/decoded by serializers as &quot;BE07&quot;.
    /// </summary>
    [EnumMember(Value = "BE07")]
    [IsoId("_uAFikvRYEeuLhpyIdtJzwg")]
    [Description(@"Specification of debtor's address, which is required for payment, is missing/not correct.")]
    MissingDebtorAddress = ExternalStatusReasonCode.MissingDebtorAddress, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Debtor name is missing
    /// Encoded/decoded by serializers as &quot;BE08&quot;.
    /// </summary>
    [EnumMember(Value = "BE08")]
    [IsoId("_uAFilfRYEeuLhpyIdtJzwg")]
    [Description(@"Debtor name is missing")]
    MissingDebtorName = ExternalStatusReasonCode.MissingDebtorName, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Country code is missing or Invalid.|Generic usage if cannot specifically identify debtor or creditor
    /// Encoded/decoded by serializers as &quot;BE09&quot;.
    /// </summary>
    [EnumMember(Value = "BE09")]
    [IsoId("_uAFimPRYEeuLhpyIdtJzwg")]
    [Description(@"Country code is missing or Invalid.|Generic usage if cannot specifically identify debtor or creditor")]
    InvalidCountry = ExternalStatusReasonCode.InvalidCountry, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Debtor country code is missing or invalid
    /// Encoded/decoded by serializers as &quot;BE10&quot;.
    /// </summary>
    [EnumMember(Value = "BE10")]
    [IsoId("_uAFim_RYEeuLhpyIdtJzwg")]
    [Description(@"Debtor country code is missing or invalid")]
    InvalidDebtorCountry = ExternalStatusReasonCode.InvalidDebtorCountry, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Creditor country code is missing or invalid
    /// Encoded/decoded by serializers as &quot;BE11&quot;.
    /// </summary>
    [EnumMember(Value = "BE11")]
    [IsoId("_uAPTkvRYEeuLhpyIdtJzwg")]
    [Description(@"Creditor country code is missing or invalid")]
    InvalidCreditorCountry = ExternalStatusReasonCode.InvalidCreditorCountry, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Country code of residence is missing or Invalid.|Generic usage if cannot specifically identify debtor or creditor
    /// Encoded/decoded by serializers as &quot;BE12&quot;.
    /// </summary>
    [EnumMember(Value = "BE12")]
    [IsoId("_uAPTlfRYEeuLhpyIdtJzwg")]
    [Description(@"Country code of residence is missing or Invalid.|Generic usage if cannot specifically identify debtor or creditor")]
    InvalidCountryOfResidence = ExternalStatusReasonCode.InvalidCountryOfResidence, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Country code of debtor&apos;s residence is missing or Invalid
    /// Encoded/decoded by serializers as &quot;BE13&quot;.
    /// </summary>
    [EnumMember(Value = "BE13")]
    [IsoId("_uAPTmPRYEeuLhpyIdtJzwg")]
    [Description(@"Country code of debtor's residence is missing or Invalid")]
    InvalidDebtorCountryOfResidence = ExternalStatusReasonCode.InvalidDebtorCountryOfResidence, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Country code of creditor&apos;s residence is missing or Invalid
    /// Encoded/decoded by serializers as &quot;BE14&quot;.
    /// </summary>
    [EnumMember(Value = "BE14")]
    [IsoId("_uAPTm_RYEeuLhpyIdtJzwg")]
    [Description(@"Country code of creditor's residence is missing or Invalid")]
    InvalidCreditorCountryOfResidence = ExternalStatusReasonCode.InvalidCreditorCountryOfResidence, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identification code missing or invalid.|Generic usage if cannot specifically identify debtor or creditor.
    /// Encoded/decoded by serializers as &quot;BE15&quot;.
    /// </summary>
    [EnumMember(Value = "BE15")]
    [IsoId("_uAPTnvRYEeuLhpyIdtJzwg")]
    [Description(@"Identification code missing or invalid.|Generic usage if cannot specifically identify debtor or creditor.")]
    InvalidIdentificationCode = ExternalStatusReasonCode.InvalidIdentificationCode, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Debtor or Ultimate Debtor identification code missing or invalid
    /// Encoded/decoded by serializers as &quot;BE16&quot;.
    /// </summary>
    [EnumMember(Value = "BE16")]
    [IsoId("_uAYdgvRYEeuLhpyIdtJzwg")]
    [Description(@"Debtor or Ultimate Debtor identification code missing or invalid")]
    InvalidDebtorIdentificationCode = ExternalStatusReasonCode.InvalidDebtorIdentificationCode, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Creditor or Ultimate Creditor identification code missing or invalid
    /// Encoded/decoded by serializers as &quot;BE17&quot;.
    /// </summary>
    [EnumMember(Value = "BE17")]
    [IsoId("_uAYdhfRYEeuLhpyIdtJzwg")]
    [Description(@"Creditor or Ultimate Creditor identification code missing or invalid")]
    InvalidCreditorIdentificationCode = ExternalStatusReasonCode.InvalidCreditorIdentificationCode, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Contact details missing or invalid
    /// Encoded/decoded by serializers as &quot;BE18&quot;.
    /// </summary>
    [EnumMember(Value = "BE18")]
    [IsoId("_uAYdiPRYEeuLhpyIdtJzwg")]
    [Description(@"Contact details missing or invalid")]
    InvalidContactDetails = ExternalStatusReasonCode.InvalidContactDetails, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Charge bearer code for transaction type is invalid
    /// Encoded/decoded by serializers as &quot;BE19&quot;.
    /// </summary>
    [EnumMember(Value = "BE19")]
    [IsoId("_uAiOgvRYEeuLhpyIdtJzwg")]
    [Description(@"Charge bearer code for transaction type is invalid")]
    InvalidChargeBearerCode = ExternalStatusReasonCode.InvalidChargeBearerCode, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Name length exceeds local rules for payment type.
    /// Encoded/decoded by serializers as &quot;BE20&quot;.
    /// </summary>
    [EnumMember(Value = "BE20")]
    [IsoId("_uAiOhfRYEeuLhpyIdtJzwg")]
    [Description(@"Name length exceeds local rules for payment type.")]
    InvalidNameLength = ExternalStatusReasonCode.InvalidNameLength, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Name missing or invalid.  Generic usage if cannot specifically identify debtor or creditor.
    /// Encoded/decoded by serializers as &quot;BE21&quot;.
    /// </summary>
    [EnumMember(Value = "BE21")]
    [IsoId("_uAiOiPRYEeuLhpyIdtJzwg")]
    [Description(@"Name missing or invalid.  Generic usage if cannot specifically identify debtor or creditor.")]
    MissingName = ExternalStatusReasonCode.MissingName, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Creditor name is missing
    /// Encoded/decoded by serializers as &quot;BE22&quot;.
    /// </summary>
    [EnumMember(Value = "BE22")]
    [IsoId("_uAiOi_RYEeuLhpyIdtJzwg")]
    [Description(@"Creditor name is missing")]
    MissingCreditorName = ExternalStatusReasonCode.MissingCreditorName, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Phone number or email address, or any other proxy, used as the account proxy is unknown or invalid.
    /// Encoded/decoded by serializers as &quot;BE23&quot;.
    /// </summary>
    [EnumMember(Value = "BE23")]
    [IsoId("_uAr_gvRYEeuLhpyIdtJzwg")]
    [Description(@"Phone number or email address, or any other proxy, used as the account proxy is unknown or invalid.")]
    AccountProxyInvalid = ExternalStatusReasonCode.AccountProxyInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Credit transfer is not tagged as an Extended Remittance Information (ERI) transaction but contains ERI.
    /// Encoded/decoded by serializers as &quot;CERI&quot;.
    /// </summary>
    [EnumMember(Value = "CERI")]
    [IsoId("_uAr_hfRYEeuLhpyIdtJzwg")]
    [Description(@"Credit transfer is not tagged as an Extended Remittance Information (ERI) transaction but contains ERI.")]
    CheckERI = ExternalStatusReasonCode.CheckERI, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Value in Requested Execution Date or Requested Collection Date is too far in the future
    /// Encoded/decoded by serializers as &quot;CH03&quot;.
    /// </summary>
    [EnumMember(Value = "CH03")]
    [IsoId("_uAr_iPRYEeuLhpyIdtJzwg")]
    [Description(@"Value in Requested Execution Date or Requested Collection Date is too far in the future")]
    RequestedExecutionDateOrRequestedCollectionDateTooFarInFuture = ExternalStatusReasonCode.RequestedExecutionDateOrRequestedCollectionDateTooFarInFuture, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Value in Requested Execution Date or Requested Collection Date is too far in the past
    /// Encoded/decoded by serializers as &quot;CH04&quot;.
    /// </summary>
    [EnumMember(Value = "CH04")]
    [IsoId("_uAr_i_RYEeuLhpyIdtJzwg")]
    [Description(@"Value in Requested Execution Date or Requested Collection Date is too far in the past")]
    RequestedExecutionDateOrRequestedCollectionDateTooFarInPast = ExternalStatusReasonCode.RequestedExecutionDateOrRequestedCollectionDateTooFarInPast, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Element is not to be used at B- and C-Level
    /// Encoded/decoded by serializers as &quot;CH07&quot;.
    /// </summary>
    [EnumMember(Value = "CH07")]
    [IsoId("_uA1JcvRYEeuLhpyIdtJzwg")]
    [Description(@"Element is not to be used at B- and C-Level")]
    ElementIsNotToBeUsedAtB_andC_Level = ExternalStatusReasonCode.ElementIsNotToBeUsedAtB_andC_Level, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Mandate changes are not allowed
    /// Encoded/decoded by serializers as &quot;CH09&quot;.
    /// </summary>
    [EnumMember(Value = "CH09")]
    [IsoId("_uA1JdfRYEeuLhpyIdtJzwg")]
    [Description(@"Mandate changes are not allowed")]
    MandateChangesNotAllowed = ExternalStatusReasonCode.MandateChangesNotAllowed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Information on mandate changes are missing
    /// Encoded/decoded by serializers as &quot;CH10&quot;.
    /// </summary>
    [EnumMember(Value = "CH10")]
    [IsoId("_uA1JePRYEeuLhpyIdtJzwg")]
    [Description(@"Information on mandate changes are missing")]
    InformationOnMandateChangesMissing = ExternalStatusReasonCode.InformationOnMandateChangesMissing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Value in Creditor Identifier is incorrect
    /// Encoded/decoded by serializers as &quot;CH11&quot;.
    /// </summary>
    [EnumMember(Value = "CH11")]
    [IsoId("_uA-6cvRYEeuLhpyIdtJzwg")]
    [Description(@"Value in Creditor Identifier is incorrect")]
    CreditorIdentifierIncorrect = ExternalStatusReasonCode.CreditorIdentifierIncorrect, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Creditor Identifier is ambiguous at Transaction Level
    /// Encoded/decoded by serializers as &quot;CH12&quot;.
    /// </summary>
    [EnumMember(Value = "CH12")]
    [IsoId("_uA-6dfRYEeuLhpyIdtJzwg")]
    [Description(@"Creditor Identifier is ambiguous at Transaction Level")]
    CreditorIdentifierNotUnambiguouslyAtTransaction_Level = ExternalStatusReasonCode.CreditorIdentifierNotUnambiguouslyAtTransaction_Level, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Original Debtor Account is not to be used
    /// Encoded/decoded by serializers as &quot;CH13&quot;.
    /// </summary>
    [EnumMember(Value = "CH13")]
    [IsoId("_uA-6ePRYEeuLhpyIdtJzwg")]
    [Description(@"Original Debtor Account is not to be used")]
    OriginalDebtorAccountIsNotToBeUsed = ExternalStatusReasonCode.OriginalDebtorAccountIsNotToBeUsed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Original Debtor Agent  is not to be used
    /// Encoded/decoded by serializers as &quot;CH14&quot;.
    /// </summary>
    [EnumMember(Value = "CH14")]
    [IsoId("_uA-6e_RYEeuLhpyIdtJzwg")]
    [Description(@"Original Debtor Agent  is not to be used")]
    OriginalDebtorAgentIsNotToBeUsed = ExternalStatusReasonCode.OriginalDebtorAgentIsNotToBeUsed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Content Remittance Information/Structured includes more than 140 characters
    /// Encoded/decoded by serializers as &quot;CH15&quot;.
    /// </summary>
    [EnumMember(Value = "CH15")]
    [IsoId("_uBIrcvRYEeuLhpyIdtJzwg")]
    [Description(@"Content Remittance Information/Structured includes more than 140 characters")]
    ElementContentIncludesMoreThan140Characters = ExternalStatusReasonCode.ElementContentIncludesMoreThan140Characters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Content is incorrect
    /// Encoded/decoded by serializers as &quot;CH16&quot;.
    /// </summary>
    [EnumMember(Value = "CH16")]
    [IsoId("_uBIrdfRYEeuLhpyIdtJzwg")]
    [Description(@"Content is incorrect")]
    ElementContentFormallyIncorrect = ExternalStatusReasonCode.ElementContentFormallyIncorrect, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Element is not allowed
    /// Encoded/decoded by serializers as &quot;CH17&quot;.
    /// </summary>
    [EnumMember(Value = "CH17")]
    [IsoId("_uBIrePRYEeuLhpyIdtJzwg")]
    [Description(@"Element is not allowed")]
    ElementNotAdmitted = ExternalStatusReasonCode.ElementNotAdmitted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Values in Interbank Settlement Date or Requested Collection Date will be set to the next TARGET day
    /// Encoded/decoded by serializers as &quot;CH19&quot;.
    /// </summary>
    [EnumMember(Value = "CH19")]
    [IsoId("_uBIre_RYEeuLhpyIdtJzwg")]
    [Description(@"Values in Interbank Settlement Date or Requested Collection Date will be set to the next TARGET day")]
    ValuesWillBeSetToNextTARGETday = ExternalStatusReasonCode.ValuesWillBeSetToNextTARGETday, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Number of decimal points not compatible with the currency
    /// Encoded/decoded by serializers as &quot;CH20&quot;.
    /// </summary>
    [EnumMember(Value = "CH20")]
    [IsoId("_uBIrfvRYEeuLhpyIdtJzwg")]
    [Description(@"Number of decimal points not compatible with the currency")]
    DecimalPointsNotCompatibleWithCurrency = ExternalStatusReasonCode.DecimalPointsNotCompatibleWithCurrency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Mandatory element is missing 
    /// Encoded/decoded by serializers as &quot;CH21&quot;.
    /// </summary>
    [EnumMember(Value = "CH21")]
    [IsoId("_uBR1YvRYEeuLhpyIdtJzwg")]
    [Description(@"Mandatory element is missing ")]
    RequiredCompulsoryElementMissing = ExternalStatusReasonCode.RequiredCompulsoryElementMissing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// SDD CORE and B2B not permitted within one message 
    /// Encoded/decoded by serializers as &quot;CH22&quot;.
    /// </summary>
    [EnumMember(Value = "CH22")]
    [IsoId("_uBR1ZfRYEeuLhpyIdtJzwg")]
    [Description(@"SDD CORE and B2B not permitted within one message ")]
    COREandB2BwithinOnemessage = ExternalStatusReasonCode.COREandB2BwithinOnemessage, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cheque has been presented in cheque clearing and settled on the creditor’s account.
    /// Encoded/decoded by serializers as &quot;CHQC&quot;.
    /// </summary>
    [EnumMember(Value = "CHQC")]
    [IsoId("_uBR1aPRYEeuLhpyIdtJzwg")]
    [Description(@"Cheque has been presented in cheque clearing and settled on the creditor’s account.")]
    ChequeSettledOnCreditorAccount = ExternalStatusReasonCode.ChequeSettledOnCreditorAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Creditor bank is not registered under this BIC in the CSM
    /// Encoded/decoded by serializers as &quot;CNOR&quot;.
    /// </summary>
    [EnumMember(Value = "CNOR")]
    [IsoId("_uBbmYvRYEeuLhpyIdtJzwg")]
    [Description(@"Creditor bank is not registered under this BIC in the CSM")]
    CreditorBankIsNotRegistered = ExternalStatusReasonCode.CreditorBankIsNotRegistered, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Currency of the payment is incorrect
    /// Encoded/decoded by serializers as &quot;CURR&quot;.
    /// </summary>
    [EnumMember(Value = "CURR")]
    [IsoId("_uBbmZfRYEeuLhpyIdtJzwg")]
    [Description(@"Currency of the payment is incorrect")]
    IncorrectCurrency = ExternalStatusReasonCode.IncorrectCurrency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation requested by the Debtor
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_uBbmaPRYEeuLhpyIdtJzwg")]
    [Description(@"Cancellation requested by the Debtor")]
    RequestedByCustomer = ExternalStatusReasonCode.RequestedByCustomer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Debtor bank is not registered under this BIC in the CSM
    /// Encoded/decoded by serializers as &quot;DNOR&quot;.
    /// </summary>
    [EnumMember(Value = "DNOR")]
    [IsoId("_uBbma_RYEeuLhpyIdtJzwg")]
    [Description(@"Debtor bank is not registered under this BIC in the CSM")]
    DebtorBankIsNotRegistered = ExternalStatusReasonCode.DebtorBankIsNotRegistered, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The electronic signature(s) is/are correct
    /// Encoded/decoded by serializers as &quot;DS01&quot;.
    /// </summary>
    [EnumMember(Value = "DS01")]
    [IsoId("_uBbmbvRYEeuLhpyIdtJzwg")]
    [Description(@"The electronic signature(s) is/are correct")]
    ElectronicSignaturesCorrect = ExternalStatusReasonCode.ElectronicSignaturesCorrect, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// An authorized user has cancelled the order
    /// Encoded/decoded by serializers as &quot;DS02&quot;.
    /// </summary>
    [EnumMember(Value = "DS02")]
    [IsoId("_uBlXYvRYEeuLhpyIdtJzwg")]
    [Description(@"An authorized user has cancelled the order")]
    OrderCancelled = ExternalStatusReasonCode.OrderCancelled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The user’s attempt to cancel the order was not successful 
    /// Encoded/decoded by serializers as &quot;DS03&quot;.
    /// </summary>
    [EnumMember(Value = "DS03")]
    [IsoId("_uBlXZfRYEeuLhpyIdtJzwg")]
    [Description(@"The user’s attempt to cancel the order was not successful ")]
    OrderNotCancelled = ExternalStatusReasonCode.OrderNotCancelled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The order was rejected by the bank side (for reasons concerning content)
    /// Encoded/decoded by serializers as &quot;DS04&quot;.
    /// </summary>
    [EnumMember(Value = "DS04")]
    [IsoId("_uBuhUvRYEeuLhpyIdtJzwg")]
    [Description(@"The order was rejected by the bank side (for reasons concerning content)")]
    OrderRejected = ExternalStatusReasonCode.OrderRejected, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The order was correct and could be forwarded for postprocessing
    /// Encoded/decoded by serializers as &quot;DS05&quot;.
    /// </summary>
    [EnumMember(Value = "DS05")]
    [IsoId("_uBuhVfRYEeuLhpyIdtJzwg")]
    [Description(@"The order was correct and could be forwarded for postprocessing")]
    OrderForwardedForPostprocessing = ExternalStatusReasonCode.OrderForwardedForPostprocessing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The order was transferred to VEU
    /// Encoded/decoded by serializers as &quot;DS06&quot;.
    /// </summary>
    [EnumMember(Value = "DS06")]
    [IsoId("_uBuhWPRYEeuLhpyIdtJzwg")]
    [Description(@"The order was transferred to VEU")]
    TransferOrder = ExternalStatusReasonCode.TransferOrder, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// All actions concerning the order could be done by the EBICS bank server
    /// Encoded/decoded by serializers as &quot;DS07&quot;.
    /// </summary>
    [EnumMember(Value = "DS07")]
    [IsoId("_uBuhW_RYEeuLhpyIdtJzwg")]
    [Description(@"All actions concerning the order could be done by the EBICS bank server")]
    ProcessingOK = ExternalStatusReasonCode.ProcessingOK, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The decompression of the file was not successful
    /// Encoded/decoded by serializers as &quot;DS08&quot;.
    /// </summary>
    [EnumMember(Value = "DS08")]
    [IsoId("_uB4SUvRYEeuLhpyIdtJzwg")]
    [Description(@"The decompression of the file was not successful")]
    DecompressionError = ExternalStatusReasonCode.DecompressionError, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The decryption of the file was not successful
    /// Encoded/decoded by serializers as &quot;DS09&quot;.
    /// </summary>
    [EnumMember(Value = "DS09")]
    [IsoId("_uB4SVfRYEeuLhpyIdtJzwg")]
    [Description(@"The decryption of the file was not successful")]
    DecryptionError = ExternalStatusReasonCode.DecryptionError, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Data signature is required.
    /// Encoded/decoded by serializers as &quot;DS0A&quot;.
    /// </summary>
    [EnumMember(Value = "DS0A")]
    [IsoId("_uB4SWPRYEeuLhpyIdtJzwg")]
    [Description(@"Data signature is required.")]
    DataSignRequested = ExternalStatusReasonCode.DataSignRequested, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Data signature for the format is not available or invalid.
    /// Encoded/decoded by serializers as &quot;DS0B&quot;.
    /// </summary>
    [EnumMember(Value = "DS0B")]
    [IsoId("_uB4SW_RYEeuLhpyIdtJzwg")]
    [Description(@"Data signature for the format is not available or invalid.")]
    UnknownDataSignFormat = ExternalStatusReasonCode.UnknownDataSignFormat, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The signer certificate is revoked.
    /// Encoded/decoded by serializers as &quot;DS0C&quot;.
    /// </summary>
    [EnumMember(Value = "DS0C")]
    [IsoId("_uB4SXvRYEeuLhpyIdtJzwg")]
    [Description(@"The signer certificate is revoked.")]
    SignerCertificateRevoked = ExternalStatusReasonCode.SignerCertificateRevoked, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The signer certificate is not valid (revoked or not active).
    /// Encoded/decoded by serializers as &quot;DS0D&quot;.
    /// </summary>
    [EnumMember(Value = "DS0D")]
    [IsoId("_uCBcQvRYEeuLhpyIdtJzwg")]
    [Description(@"The signer certificate is not valid (revoked or not active).")]
    SignerCertificateNotValid = ExternalStatusReasonCode.SignerCertificateNotValid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The signer certificate is not present.
    /// Encoded/decoded by serializers as &quot;DS0E&quot;.
    /// </summary>
    [EnumMember(Value = "DS0E")]
    [IsoId("_uCBcRfRYEeuLhpyIdtJzwg")]
    [Description(@"The signer certificate is not present.")]
    IncorrectSignerCertificate = ExternalStatusReasonCode.IncorrectSignerCertificate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The authority of the signer certification sending the certificate is unknown.
    /// Encoded/decoded by serializers as &quot;DS0F&quot;.
    /// </summary>
    [EnumMember(Value = "DS0F")]
    [IsoId("_uCBcSPRYEeuLhpyIdtJzwg")]
    [Description(@"The authority of the signer certification sending the certificate is unknown.")]
    SignerCertificationAuthoritySignerNotValid = ExternalStatusReasonCode.SignerCertificationAuthoritySignerNotValid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Signer is not allowed to sign this operation type.
    /// Encoded/decoded by serializers as &quot;DS0G&quot;.
    /// </summary>
    [EnumMember(Value = "DS0G")]
    [IsoId("_uCLNQvRYEeuLhpyIdtJzwg")]
    [Description(@"Signer is not allowed to sign this operation type.")]
    NotAllowedPayment = ExternalStatusReasonCode.NotAllowedPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Signer is not allowed to sign for this account.
    /// Encoded/decoded by serializers as &quot;DS0H&quot;.
    /// </summary>
    [EnumMember(Value = "DS0H")]
    [IsoId("_uCLNRfRYEeuLhpyIdtJzwg")]
    [Description(@"Signer is not allowed to sign for this account.")]
    NotAllowedAccount = ExternalStatusReasonCode.NotAllowedAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The number of transaction is over the number allowed for this signer.
    /// Encoded/decoded by serializers as &quot;DS0K&quot;.
    /// </summary>
    [EnumMember(Value = "DS0K")]
    [IsoId("_uCLNSPRYEeuLhpyIdtJzwg")]
    [Description(@"The number of transaction is over the number allowed for this signer.")]
    NotAllowedNumberOfTransaction = ExternalStatusReasonCode.NotAllowedNumberOfTransaction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The certificate is revoked for the first signer.
    /// Encoded/decoded by serializers as &quot;DS10&quot;.
    /// </summary>
    [EnumMember(Value = "DS10")]
    [IsoId("_uCLNS_RYEeuLhpyIdtJzwg")]
    [Description(@"The certificate is revoked for the first signer.")]
    Signer1CertificateRevoked = ExternalStatusReasonCode.Signer1CertificateRevoked, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The certificate is not valid (revoked or not active) for the first signer.
    /// Encoded/decoded by serializers as &quot;DS11&quot;.
    /// </summary>
    [EnumMember(Value = "DS11")]
    [IsoId("_uCU-QvRYEeuLhpyIdtJzwg")]
    [Description(@"The certificate is not valid (revoked or not active) for the first signer.")]
    Signer1CertificateNotValid = ExternalStatusReasonCode.Signer1CertificateNotValid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The certificate is not present for the first signer.
    /// Encoded/decoded by serializers as &quot;DS12&quot;.
    /// </summary>
    [EnumMember(Value = "DS12")]
    [IsoId("_uCU-RfRYEeuLhpyIdtJzwg")]
    [Description(@"The certificate is not present for the first signer.")]
    IncorrectSigner1Certificate = ExternalStatusReasonCode.IncorrectSigner1Certificate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The authority of signer certification sending the certificate is unknown for the first signer.
    /// Encoded/decoded by serializers as &quot;DS13&quot;.
    /// </summary>
    [EnumMember(Value = "DS13")]
    [IsoId("_uCU-SPRYEeuLhpyIdtJzwg")]
    [Description(@"The authority of signer certification sending the certificate is unknown for the first signer.")]
    SignerCertificationAuthoritySigner1NotValid = ExternalStatusReasonCode.SignerCertificationAuthoritySigner1NotValid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The user is unknown on the server
    /// Encoded/decoded by serializers as &quot;DS14&quot;.
    /// </summary>
    [EnumMember(Value = "DS14")]
    [IsoId("_uCeIMvRYEeuLhpyIdtJzwg")]
    [Description(@"The user is unknown on the server")]
    UserDoesNotExist = ExternalStatusReasonCode.UserDoesNotExist, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The same signature has already been sent to the bank
    /// Encoded/decoded by serializers as &quot;DS15&quot;.
    /// </summary>
    [EnumMember(Value = "DS15")]
    [IsoId("_uCeINfRYEeuLhpyIdtJzwg")]
    [Description(@"The same signature has already been sent to the bank")]
    IdenticalSignatureFound = ExternalStatusReasonCode.IdenticalSignatureFound, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The public key version is not correct. This code is returned when a customer sends signature files to the financial institution after conversion from an older program version (old ES format) to a new program version (new ES format) without having carried out re-initialisation with regard to a public key change.
    /// Encoded/decoded by serializers as &quot;DS16&quot;.
    /// </summary>
    [EnumMember(Value = "DS16")]
    [IsoId("_uCeIOPRYEeuLhpyIdtJzwg")]
    [Description(@"The public key version is not correct. This code is returned when a customer sends signature files to the financial institution after conversion from an older program version (old ES format) to a new program version (new ES format) without having carried out re-initialisation with regard to a public key change.")]
    PublicKeyVersionIncorrect = ExternalStatusReasonCode.PublicKeyVersionIncorrect, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Order data and signatures don’t match
    /// Encoded/decoded by serializers as &quot;DS17&quot;.
    /// </summary>
    [EnumMember(Value = "DS17")]
    [IsoId("_uCeIO_RYEeuLhpyIdtJzwg")]
    [Description(@"Order data and signatures don’t match")]
    DifferentOrderDataInSignatures = ExternalStatusReasonCode.DifferentOrderDataInSignatures, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// File cannot be tested, the complete order has to be repeated. This code is returned in the event of a malfunction during the signature check, e.g. not enough storage space.
    /// Encoded/decoded by serializers as &quot;DS18&quot;.
    /// </summary>
    [EnumMember(Value = "DS18")]
    [IsoId("_uCn5MvRYEeuLhpyIdtJzwg")]
    [Description(@"File cannot be tested, the complete order has to be repeated. This code is returned in the event of a malfunction during the signature check, e.g. not enough storage space.")]
    RepeatOrder = ExternalStatusReasonCode.RepeatOrder, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The user’s rights (concerning his signature) are insufficient to execute the order
    /// Encoded/decoded by serializers as &quot;DS19&quot;.
    /// </summary>
    [EnumMember(Value = "DS19")]
    [IsoId("_uCn5NfRYEeuLhpyIdtJzwg")]
    [Description(@"The user’s rights (concerning his signature) are insufficient to execute the order")]
    ElectronicSignatureRightsInsufficient = ExternalStatusReasonCode.ElectronicSignatureRightsInsufficient, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The certificate is revoked for the second signer.
    /// Encoded/decoded by serializers as &quot;DS20&quot;.
    /// </summary>
    [EnumMember(Value = "DS20")]
    [IsoId("_uCn5OPRYEeuLhpyIdtJzwg")]
    [Description(@"The certificate is revoked for the second signer.")]
    Signer2CertificateRevoked = ExternalStatusReasonCode.Signer2CertificateRevoked, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The certificate is not valid (revoked or not active) for the second signer.
    /// Encoded/decoded by serializers as &quot;DS21&quot;.
    /// </summary>
    [EnumMember(Value = "DS21")]
    [IsoId("_uCn5O_RYEeuLhpyIdtJzwg")]
    [Description(@"The certificate is not valid (revoked or not active) for the second signer.")]
    Signer2CertificateNotValid = ExternalStatusReasonCode.Signer2CertificateNotValid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The certificate is not present for the second signer.
    /// Encoded/decoded by serializers as &quot;DS22&quot;.
    /// </summary>
    [EnumMember(Value = "DS22")]
    [IsoId("_uCxqMvRYEeuLhpyIdtJzwg")]
    [Description(@"The certificate is not present for the second signer.")]
    IncorrectSigner2Certificate = ExternalStatusReasonCode.IncorrectSigner2Certificate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The authority of signer certification sending the certificate is unknown for the second signer.
    /// Encoded/decoded by serializers as &quot;DS23&quot;.
    /// </summary>
    [EnumMember(Value = "DS23")]
    [IsoId("_uCxqNfRYEeuLhpyIdtJzwg")]
    [Description(@"The authority of signer certification sending the certificate is unknown for the second signer.")]
    SignerCertificationAuthoritySigner2NotValid = ExternalStatusReasonCode.SignerCertificationAuthoritySigner2NotValid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Waiting time expired due to incomplete order
    /// Encoded/decoded by serializers as &quot;DS24&quot;.
    /// </summary>
    [EnumMember(Value = "DS24")]
    [IsoId("_uCxqOPRYEeuLhpyIdtJzwg")]
    [Description(@"Waiting time expired due to incomplete order")]
    WaitingTimeExpired = ExternalStatusReasonCode.WaitingTimeExpired, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The order file was deleted by the bank server |(for multiple reasons)
    /// Encoded/decoded by serializers as &quot;DS25&quot;.
    /// </summary>
    [EnumMember(Value = "DS25")]
    [IsoId("_uCxqO_RYEeuLhpyIdtJzwg")]
    [Description(@"The order file was deleted by the bank server |(for multiple reasons)")]
    OrderFileDeleted = ExternalStatusReasonCode.OrderFileDeleted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The same user has signed multiple times
    /// Encoded/decoded by serializers as &quot;DS26&quot;.
    /// </summary>
    [EnumMember(Value = "DS26")]
    [IsoId("_uCxqPvRYEeuLhpyIdtJzwg")]
    [Description(@"The same user has signed multiple times")]
    UserSignedMultipleTimes = ExternalStatusReasonCode.UserSignedMultipleTimes, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The user is not yet activated (technically)
    /// Encoded/decoded by serializers as &quot;DS27&quot;.
    /// </summary>
    [EnumMember(Value = "DS27")]
    [IsoId("_uC60IvRYEeuLhpyIdtJzwg")]
    [Description(@"The user is not yet activated (technically)")]
    UserNotYetActivated = ExternalStatusReasonCode.UserNotYetActivated, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Invalid date (eg, wrong or missing settlement date)
    /// Encoded/decoded by serializers as &quot;DT01&quot;.
    /// </summary>
    [EnumMember(Value = "DT01")]
    [IsoId("_uC60JfRYEeuLhpyIdtJzwg")]
    [Description(@"Invalid date (eg, wrong or missing settlement date)")]
    InvalidDate = ExternalStatusReasonCode.InvalidDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Invalid creation date and time in Group Header (eg, historic date)
    /// Encoded/decoded by serializers as &quot;DT02&quot;.
    /// </summary>
    [EnumMember(Value = "DT02")]
    [IsoId("_uC60KPRYEeuLhpyIdtJzwg")]
    [Description(@"Invalid creation date and time in Group Header (eg, historic date)")]
    InvalidCreationDate = ExternalStatusReasonCode.InvalidCreationDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Invalid non bank processing date (eg, weekend or local public holiday)
    /// Encoded/decoded by serializers as &quot;DT03&quot;.
    /// </summary>
    [EnumMember(Value = "DT03")]
    [IsoId("_uC60K_RYEeuLhpyIdtJzwg")]
    [Description(@"Invalid non bank processing date (eg, weekend or local public holiday)")]
    InvalidNonProcessingDate = ExternalStatusReasonCode.InvalidNonProcessingDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Future date not supported
    /// Encoded/decoded by serializers as &quot;DT04&quot;.
    /// </summary>
    [EnumMember(Value = "DT04")]
    [IsoId("_uC60LvRYEeuLhpyIdtJzwg")]
    [Description(@"Future date not supported")]
    FutureDateNotSupported = ExternalStatusReasonCode.FutureDateNotSupported, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Associated message, payment information block or transaction was received after agreed processing cut-off date, i.e., date in the past.
    /// Encoded/decoded by serializers as &quot;DT05&quot;.
    /// </summary>
    [EnumMember(Value = "DT05")]
    [IsoId("_uDElIvRYEeuLhpyIdtJzwg")]
    [Description(@"Associated message, payment information block or transaction was received after agreed processing cut-off date, i.e., date in the past.")]
    InvalidCutOffDate = ExternalStatusReasonCode.InvalidCutOffDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Execution Date has been modified in order for transaction to be processed
    /// Encoded/decoded by serializers as &quot;DT06&quot;.
    /// </summary>
    [EnumMember(Value = "DT06")]
    [IsoId("_uDElJfRYEeuLhpyIdtJzwg")]
    [Description(@"Execution Date has been modified in order for transaction to be processed")]
    ExecutionDateChanged = ExternalStatusReasonCode.ExecutionDateChanged, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Message Identification is not unique.
    /// Encoded/decoded by serializers as &quot;DU01&quot;.
    /// </summary>
    [EnumMember(Value = "DU01")]
    [IsoId("_uDElKPRYEeuLhpyIdtJzwg")]
    [Description(@"Message Identification is not unique.")]
    DuplicateMessageID = ExternalStatusReasonCode.DuplicateMessageID, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment Information Block is not unique.
    /// Encoded/decoded by serializers as &quot;DU02&quot;.
    /// </summary>
    [EnumMember(Value = "DU02")]
    [IsoId("_uDElK_RYEeuLhpyIdtJzwg")]
    [Description(@"Payment Information Block is not unique.")]
    DuplicatePaymentInformationID = ExternalStatusReasonCode.DuplicatePaymentInformationID, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is not unique.
    /// Encoded/decoded by serializers as &quot;DU03&quot;.
    /// </summary>
    [EnumMember(Value = "DU03")]
    [IsoId("_uDElLvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is not unique.")]
    DuplicateTransaction = ExternalStatusReasonCode.DuplicateTransaction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// End To End ID is not unique.
    /// Encoded/decoded by serializers as &quot;DU04&quot;.
    /// </summary>
    [EnumMember(Value = "DU04")]
    [IsoId("_uDNvEvRYEeuLhpyIdtJzwg")]
    [Description(@"End To End ID is not unique.")]
    DuplicateEndToEndID = ExternalStatusReasonCode.DuplicateEndToEndID, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction ID is not unique.
    /// Encoded/decoded by serializers as &quot;DU05&quot;.
    /// </summary>
    [EnumMember(Value = "DU05")]
    [IsoId("_uDNvFfRYEeuLhpyIdtJzwg")]
    [Description(@"Instruction ID is not unique.")]
    DuplicateInstructionID = ExternalStatusReasonCode.DuplicateInstructionID, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment is a duplicate of another payment
    /// Encoded/decoded by serializers as &quot;DUPL&quot;.
    /// </summary>
    [EnumMember(Value = "DUPL")]
    [IsoId("_uDNvGPRYEeuLhpyIdtJzwg")]
    [Description(@"Payment is a duplicate of another payment")]
    DuplicatePayment = ExternalStatusReasonCode.DuplicatePayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Correspondent bank not possible.
    /// Encoded/decoded by serializers as &quot;ED01&quot;.
    /// </summary>
    [EnumMember(Value = "ED01")]
    [IsoId("_uDXgEvRYEeuLhpyIdtJzwg")]
    [Description(@"Correspondent bank not possible.")]
    CorrespondentBankNotPossible = ExternalStatusReasonCode.CorrespondentBankNotPossible, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of payments complementary info is requested
    /// Encoded/decoded by serializers as &quot;ED03&quot;.
    /// </summary>
    [EnumMember(Value = "ED03")]
    [IsoId("_uDXgFfRYEeuLhpyIdtJzwg")]
    [Description(@"Balance of payments complementary info is requested")]
    BalanceInfoRequest = ExternalStatusReasonCode.BalanceInfoRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement of the transaction has failed.
    /// Encoded/decoded by serializers as &quot;ED05&quot;.
    /// </summary>
    [EnumMember(Value = "ED05")]
    [IsoId("_uDXgGPRYEeuLhpyIdtJzwg")]
    [Description(@"Settlement of the transaction has failed.")]
    SettlementFailed = ExternalStatusReasonCode.SettlementFailed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Interbank settlement system not available.
    /// Encoded/decoded by serializers as &quot;ED06&quot;.
    /// </summary>
    [EnumMember(Value = "ED06")]
    [IsoId("_uDXgG_RYEeuLhpyIdtJzwg")]
    [Description(@"Interbank settlement system not available.")]
    SettlementSystemNotAvailable = ExternalStatusReasonCode.SettlementSystemNotAvailable, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Extended Remittance Information (ERI) option is not supported.
    /// Encoded/decoded by serializers as &quot;ERIN&quot;.
    /// </summary>
    [EnumMember(Value = "ERIN")]
    [IsoId("_uDgqAvRYEeuLhpyIdtJzwg")]
    [Description(@"Extended Remittance Information (ERI) option is not supported.")]
    ERIOptionNotSupported = ExternalStatusReasonCode.ERIOptionNotSupported, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// File Format incomplete or invalid
    /// Encoded/decoded by serializers as &quot;FF01&quot;.
    /// </summary>
    [EnumMember(Value = "FF01")]
    [IsoId("_uDgqBfRYEeuLhpyIdtJzwg")]
    [Description(@"File Format incomplete or invalid")]
    InvalidFileFormat = ExternalStatusReasonCode.InvalidFileFormat, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Syntax error reason is provided as narrative information in the additional reason information.
    /// Encoded/decoded by serializers as &quot;FF02&quot;.
    /// </summary>
    [EnumMember(Value = "FF02")]
    [IsoId("_uDgqCPRYEeuLhpyIdtJzwg")]
    [Description(@"Syntax error reason is provided as narrative information in the additional reason information.")]
    SyntaxError = ExternalStatusReasonCode.SyntaxError, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment Type Information is missing or invalid.|Generic usage if cannot specify Service Level or Local Instrument code
    /// Encoded/decoded by serializers as &quot;FF03&quot;.
    /// </summary>
    [EnumMember(Value = "FF03")]
    [IsoId("_uDqbAvRYEeuLhpyIdtJzwg")]
    [Description(@"Payment Type Information is missing or invalid.|Generic usage if cannot specify Service Level or Local Instrument code")]
    InvalidPaymentTypeInformation = ExternalStatusReasonCode.InvalidPaymentTypeInformation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Service Level code is missing or invalid
    /// Encoded/decoded by serializers as &quot;FF04&quot;.
    /// </summary>
    [EnumMember(Value = "FF04")]
    [IsoId("_uDqbBfRYEeuLhpyIdtJzwg")]
    [Description(@"Service Level code is missing or invalid")]
    InvalidServiceLevelCode = ExternalStatusReasonCode.InvalidServiceLevelCode, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Local Instrument code is missing or invalid
    /// Encoded/decoded by serializers as &quot;FF05&quot;.
    /// </summary>
    [EnumMember(Value = "FF05")]
    [IsoId("_uD0MAvRYEeuLhpyIdtJzwg")]
    [Description(@"Local Instrument code is missing or invalid")]
    InvalidLocalInstrumentCode = ExternalStatusReasonCode.InvalidLocalInstrumentCode, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Category Purpose code is missing or invalid
    /// Encoded/decoded by serializers as &quot;FF06&quot;.
    /// </summary>
    [EnumMember(Value = "FF06")]
    [IsoId("_uD0MBfRYEeuLhpyIdtJzwg")]
    [Description(@"Category Purpose code is missing or invalid")]
    InvalidCategoryPurposeCode = ExternalStatusReasonCode.InvalidCategoryPurposeCode, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Purpose is missing or invalid
    /// Encoded/decoded by serializers as &quot;FF07&quot;.
    /// </summary>
    [EnumMember(Value = "FF07")]
    [IsoId("_uD0MCPRYEeuLhpyIdtJzwg")]
    [Description(@"Purpose is missing or invalid")]
    InvalidPurpose = ExternalStatusReasonCode.InvalidPurpose, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// End to End Id missing or invalid
    /// Encoded/decoded by serializers as &quot;FF08&quot;.
    /// </summary>
    [EnumMember(Value = "FF08")]
    [IsoId("_uD0MC_RYEeuLhpyIdtJzwg")]
    [Description(@"End to End Id missing or invalid")]
    InvalidEndToEndId = ExternalStatusReasonCode.InvalidEndToEndId, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cheque number missing or invalid
    /// Encoded/decoded by serializers as &quot;FF09&quot;.
    /// </summary>
    [EnumMember(Value = "FF09")]
    [IsoId("_uD0MDvRYEeuLhpyIdtJzwg")]
    [Description(@"Cheque number missing or invalid")]
    InvalidChequeNumber = ExternalStatusReasonCode.InvalidChequeNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// File or transaction cannot be processed due to technical issues at the bank side
    /// Encoded/decoded by serializers as &quot;FF10&quot;.
    /// </summary>
    [EnumMember(Value = "FF10")]
    [IsoId("_uD9V8vRYEeuLhpyIdtJzwg")]
    [Description(@"File or transaction cannot be processed due to technical issues at the bank side")]
    BankSystemProcessingError = ExternalStatusReasonCode.BankSystemProcessingError, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Clearing request rejected due it being subject to an abort operation.
    /// Encoded/decoded by serializers as &quot;FF11&quot;.
    /// </summary>
    [EnumMember(Value = "FF11")]
    [IsoId("_uD9V9fRYEeuLhpyIdtJzwg")]
    [Description(@"Clearing request rejected due it being subject to an abort operation.")]
    ClearingRequestAborted = ExternalStatusReasonCode.ClearingRequestAborted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// In an FI To FI Customer Credit Transfer: The Status Originator transferred the payment to the next Agent or to a Market Infrastructure. The payment transfer is tracked. No further updates will follow from the Status Originator.||In a Financial Institution Credit Transfer with cover: The Status Originator performed the account booking and transferred the cover transaction to the next Reimbursement Agent or to a Market Infrastructure. The payment transfer is tracked. No further updates will follow from the Status Originator.|
    /// Encoded/decoded by serializers as &quot;G000&quot;.
    /// </summary>
    [EnumMember(Value = "G000")]
    [IsoId("_uD9V-PRYEeuLhpyIdtJzwg")]
    [Description(@"In an FI To FI Customer Credit Transfer: The Status Originator transferred the payment to the next Agent or to a Market Infrastructure. The payment transfer is tracked. No further updates will follow from the Status Originator.||In a Financial Institution Credit Transfer with cover: The Status Originator performed the account booking and transferred the cover transaction to the next Reimbursement Agent or to a Market Infrastructure. The payment transfer is tracked. No further updates will follow from the Status Originator.|")]
    PaymentTransferredAndTracked = ExternalStatusReasonCode.PaymentTransferredAndTracked, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// In an FI To FI Customer Credit Transfer: The Status Originator transferred the payment to the next Agent or to a Market Infrastructure. The payment transfer is not tracked. No further updates will follow from the Status Originator.||In a Financial Institution Credit Transfer with cover: The Status Originator performed the account booking and transferred the cover transaction to the next Reimbursement Agent or to a Market Infrastructure. The payment transfer is not tracked. No further updates will follow from the Status Originator.|
    /// Encoded/decoded by serializers as &quot;G001&quot;.
    /// </summary>
    [EnumMember(Value = "G001")]
    [IsoId("_uEHG8vRYEeuLhpyIdtJzwg")]
    [Description(@"In an FI To FI Customer Credit Transfer: The Status Originator transferred the payment to the next Agent or to a Market Infrastructure. The payment transfer is not tracked. No further updates will follow from the Status Originator.||In a Financial Institution Credit Transfer with cover: The Status Originator performed the account booking and transferred the cover transaction to the next Reimbursement Agent or to a Market Infrastructure. The payment transfer is not tracked. No further updates will follow from the Status Originator.|")]
    PaymentTransferredAndNotTracked = ExternalStatusReasonCode.PaymentTransferredAndNotTracked, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// In a FIToFI Customer Credit Transfer: Credit to the creditor’s account may not be confirmed same day. Update will follow from the Status Originator.|In a Financial Institution Credit Transfer with cover: Debit/credit to nostro account may not be confirmed same day or Financial Institution Credit Transfer may not be transferred same day. Update will follow from the Status Originator.
    /// Encoded/decoded by serializers as &quot;G002&quot;.
    /// </summary>
    [EnumMember(Value = "G002")]
    [IsoId("_uEHG9fRYEeuLhpyIdtJzwg")]
    [Description(@"In a FIToFI Customer Credit Transfer: Credit to the creditor’s account may not be confirmed same day. Update will follow from the Status Originator.|In a Financial Institution Credit Transfer with cover: Debit/credit to nostro account may not be confirmed same day or Financial Institution Credit Transfer may not be transferred same day. Update will follow from the Status Originator.")]
    CreditDebitNotConfirmed = ExternalStatusReasonCode.CreditDebitNotConfirmed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// In a FIToFI Customer Credit Transfer: Credit to creditor’s account is pending receipt of required documents. The Status Originator has requested creditor to provide additional documentation. Update will follow from the Status Originator. |In a Financial Institution Credit Transfer with cover: Status Originator has requested a previous Agent to provide additional information/correct information. Update will follow from the Status Originator.
    /// Encoded/decoded by serializers as &quot;G003&quot;.
    /// </summary>
    [EnumMember(Value = "G003")]
    [IsoId("_uEHG-PRYEeuLhpyIdtJzwg")]
    [Description(@"In a FIToFI Customer Credit Transfer: Credit to creditor’s account is pending receipt of required documents. The Status Originator has requested creditor to provide additional documentation. Update will follow from the Status Originator. |In a Financial Institution Credit Transfer with cover: Status Originator has requested a previous Agent to provide additional information/correct information. Update will follow from the Status Originator.")]
    CreditPendingDocuments = ExternalStatusReasonCode.CreditPendingDocuments, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// In a FIToFI Customer Credit Transfer: Credit to the creditor’s account is pending, status Originator is waiting for funds provided via a cover. Update will follow from the Status Originator.
    /// Encoded/decoded by serializers as &quot;G004&quot;.
    /// </summary>
    [EnumMember(Value = "G004")]
    [IsoId("_uEQQ4vRYEeuLhpyIdtJzwg")]
    [Description(@"In a FIToFI Customer Credit Transfer: Credit to the creditor’s account is pending, status Originator is waiting for funds provided via a cover. Update will follow from the Status Originator.")]
    CreditPendingFunds = ExternalStatusReasonCode.CreditPendingFunds, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment has been delivered to creditor agent with service level.
    /// Encoded/decoded by serializers as &quot;G005&quot;.
    /// </summary>
    [EnumMember(Value = "G005")]
    [IsoId("_uEQQ5fRYEeuLhpyIdtJzwg")]
    [Description(@"Payment has been delivered to creditor agent with service level.")]
    DeliveredWithServiceLevel = ExternalStatusReasonCode.DeliveredWithServiceLevel, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment has been delivered to creditor agent without service level.
    /// Encoded/decoded by serializers as &quot;G006&quot;.
    /// </summary>
    [EnumMember(Value = "G006")]
    [IsoId("_uEQQ6PRYEeuLhpyIdtJzwg")]
    [Description(@"Payment has been delivered to creditor agent without service level.")]
    DeliveredWIthoutServiceLevel = ExternalStatusReasonCode.DeliveredWIthoutServiceLevel, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Signature file was sent to the bank but the corresponding original file has not been sent yet.
    /// Encoded/decoded by serializers as &quot;ID01&quot;.
    /// </summary>
    [EnumMember(Value = "ID01")]
    [IsoId("_uEaB4vRYEeuLhpyIdtJzwg")]
    [Description(@"Signature file was sent to the bank but the corresponding original file has not been sent yet.")]
    CorrespondingOriginalFileStillNotSent = ExternalStatusReasonCode.CorrespondingOriginalFileStillNotSent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// No Mandate
    /// Encoded/decoded by serializers as &quot;MD01&quot;.
    /// </summary>
    [EnumMember(Value = "MD01")]
    [IsoId("_uEaB5fRYEeuLhpyIdtJzwg")]
    [Description(@"No Mandate")]
    NoMandate = ExternalStatusReasonCode.NoMandate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Mandate related information data required by the scheme is missing.
    /// Encoded/decoded by serializers as &quot;MD02&quot;.
    /// </summary>
    [EnumMember(Value = "MD02")]
    [IsoId("_uEaB6PRYEeuLhpyIdtJzwg")]
    [Description(@"Mandate related information data required by the scheme is missing.")]
    MissingMandatoryInformationInMandate = ExternalStatusReasonCode.MissingMandatoryInformationInMandate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Creditor or creditor&apos;s agent should not have collected the direct debit
    /// Encoded/decoded by serializers as &quot;MD05&quot;.
    /// </summary>
    [EnumMember(Value = "MD05")]
    [IsoId("_uEaB6_RYEeuLhpyIdtJzwg")]
    [Description(@"Creditor or creditor's agent should not have collected the direct debit")]
    CollectionNotDue = ExternalStatusReasonCode.CollectionNotDue, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Return of funds requested by end customer
    /// Encoded/decoded by serializers as &quot;MD06&quot;.
    /// </summary>
    [EnumMember(Value = "MD06")]
    [IsoId("_uEaB7vRYEeuLhpyIdtJzwg")]
    [Description(@"Return of funds requested by end customer")]
    RefundRequestByEndCustomer = ExternalStatusReasonCode.RefundRequestByEndCustomer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// End customer is deceased.
    /// Encoded/decoded by serializers as &quot;MD07&quot;.
    /// </summary>
    [EnumMember(Value = "MD07")]
    [IsoId("_uEjy4vRYEeuLhpyIdtJzwg")]
    [Description(@"End customer is deceased.")]
    EndCustomerDeceased = ExternalStatusReasonCode.EndCustomerDeceased, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reason has not been specified by end customer
    /// Encoded/decoded by serializers as &quot;MS02&quot;.
    /// </summary>
    [EnumMember(Value = "MS02")]
    [IsoId("_uEjy5fRYEeuLhpyIdtJzwg")]
    [Description(@"Reason has not been specified by end customer")]
    NotSpecifiedReasonCustomerGenerated = ExternalStatusReasonCode.NotSpecifiedReasonCustomerGenerated, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reason has not been specified by agent.
    /// Encoded/decoded by serializers as &quot;MS03&quot;.
    /// </summary>
    [EnumMember(Value = "MS03")]
    [IsoId("_uEjy6PRYEeuLhpyIdtJzwg")]
    [Description(@"Reason has not been specified by agent.")]
    NotSpecifiedReasonAgentGenerated = ExternalStatusReasonCode.NotSpecifiedReasonAgentGenerated, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reason is provided as narrative information in the additional reason information.
    /// Encoded/decoded by serializers as &quot;NARR&quot;.
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("_uEs80vRYEeuLhpyIdtJzwg")]
    [Description(@"Reason is provided as narrative information in the additional reason information.")]
    Narrative = ExternalStatusReasonCode.Narrative, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Credit transfer is tagged as an Extended Remittance Information (ERI) transaction but does not contain ERI.
    /// Encoded/decoded by serializers as &quot;NERI&quot;.
    /// </summary>
    [EnumMember(Value = "NERI")]
    [IsoId("_uEs81fRYEeuLhpyIdtJzwg")]
    [Description(@"Credit transfer is tagged as an Extended Remittance Information (ERI) transaction but does not contain ERI.")]
    NoERI = ExternalStatusReasonCode.NoERI, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bank identifier code specified in the message has an incorrect format (formerly IncorrectFormatForRoutingCode).
    /// Encoded/decoded by serializers as &quot;RC01&quot;.
    /// </summary>
    [EnumMember(Value = "RC01")]
    [IsoId("_uEs82PRYEeuLhpyIdtJzwg")]
    [Description(@"Bank identifier code specified in the message has an incorrect format (formerly IncorrectFormatForRoutingCode).")]
    BankIdentifierIncorrect = ExternalStatusReasonCode.BankIdentifierIncorrect, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bank identifier is invalid or missing.|Generic usage if cannot specify between debit or credit account
    /// Encoded/decoded by serializers as &quot;RC02&quot;.
    /// </summary>
    [EnumMember(Value = "RC02")]
    [IsoId("_uEs82_RYEeuLhpyIdtJzwg")]
    [Description(@"Bank identifier is invalid or missing.|Generic usage if cannot specify between debit or credit account")]
    InvalidBankIdentifier = ExternalStatusReasonCode.InvalidBankIdentifier, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Debtor bank identifier is invalid or missing
    /// Encoded/decoded by serializers as &quot;RC03&quot;.
    /// </summary>
    [EnumMember(Value = "RC03")]
    [IsoId("_uE2t0vRYEeuLhpyIdtJzwg")]
    [Description(@"Debtor bank identifier is invalid or missing")]
    InvalidDebtorBankIdentifier = ExternalStatusReasonCode.InvalidDebtorBankIdentifier, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Creditor bank identifier is invalid or missing
    /// Encoded/decoded by serializers as &quot;RC04&quot;.
    /// </summary>
    [EnumMember(Value = "RC04")]
    [IsoId("_uE2t1fRYEeuLhpyIdtJzwg")]
    [Description(@"Creditor bank identifier is invalid or missing")]
    InvalidCreditorBankIdentifier = ExternalStatusReasonCode.InvalidCreditorBankIdentifier, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// BIC identifier is invalid or missing.|Generic usage if cannot specify between debit or credit account.
    /// Encoded/decoded by serializers as &quot;RC05&quot;.
    /// </summary>
    [EnumMember(Value = "RC05")]
    [IsoId("_uE2t2PRYEeuLhpyIdtJzwg")]
    [Description(@"BIC identifier is invalid or missing.|Generic usage if cannot specify between debit or credit account.")]
    InvalidBICIdentifier = ExternalStatusReasonCode.InvalidBICIdentifier, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Debtor BIC identifier is invalid or missing
    /// Encoded/decoded by serializers as &quot;RC06&quot;.
    /// </summary>
    [EnumMember(Value = "RC06")]
    [IsoId("_uE2t2_RYEeuLhpyIdtJzwg")]
    [Description(@"Debtor BIC identifier is invalid or missing")]
    InvalidDebtorBICIdentifier = ExternalStatusReasonCode.InvalidDebtorBICIdentifier, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Creditor BIC identifier is invalid or missing
    /// Encoded/decoded by serializers as &quot;RC07&quot;.
    /// </summary>
    [EnumMember(Value = "RC07")]
    [IsoId("_uE2t3vRYEeuLhpyIdtJzwg")]
    [Description(@"Creditor BIC identifier is invalid or missing")]
    InvalidCreditorBICIdentifier = ExternalStatusReasonCode.InvalidCreditorBICIdentifier, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// ClearingSystemMemberidentifier is invalid or missing.|Generic usage if cannot specify between debit or credit account
    /// Encoded/decoded by serializers as &quot;RC08&quot;.
    /// </summary>
    [EnumMember(Value = "RC08")]
    [IsoId("_uFAe0vRYEeuLhpyIdtJzwg")]
    [Description(@"ClearingSystemMemberidentifier is invalid or missing.|Generic usage if cannot specify between debit or credit account")]
    InvalidClearingSystemMemberIdentifier = ExternalStatusReasonCode.InvalidClearingSystemMemberIdentifier, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Debtor ClearingSystemMember identifier is invalid or missing
    /// Encoded/decoded by serializers as &quot;RC09&quot;.
    /// </summary>
    [EnumMember(Value = "RC09")]
    [IsoId("_uFAe1fRYEeuLhpyIdtJzwg")]
    [Description(@"Debtor ClearingSystemMember identifier is invalid or missing")]
    InvalidDebtorClearingSystemMemberIdentifier = ExternalStatusReasonCode.InvalidDebtorClearingSystemMemberIdentifier, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Creditor ClearingSystemMember identifier is invalid or missing
    /// Encoded/decoded by serializers as &quot;RC10&quot;.
    /// </summary>
    [EnumMember(Value = "RC10")]
    [IsoId("_uFJowvRYEeuLhpyIdtJzwg")]
    [Description(@"Creditor ClearingSystemMember identifier is invalid or missing")]
    InvalidCreditorClearingSystemMemberIdentifier = ExternalStatusReasonCode.InvalidCreditorClearingSystemMemberIdentifier, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Intermediary Agent is invalid or missing
    /// Encoded/decoded by serializers as &quot;RC11&quot;.
    /// </summary>
    [EnumMember(Value = "RC11")]
    [IsoId("_uFJoxfRYEeuLhpyIdtJzwg")]
    [Description(@"Intermediary Agent is invalid or missing")]
    InvalidIntermediaryAgent = ExternalStatusReasonCode.InvalidIntermediaryAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Creditor Scheme Id is invalid or  missing
    /// Encoded/decoded by serializers as &quot;RC12&quot;.
    /// </summary>
    [EnumMember(Value = "RC12")]
    [IsoId("_uFJoyPRYEeuLhpyIdtJzwg")]
    [Description(@"Creditor Scheme Id is invalid or  missing")]
    MissingCreditorSchemeId = ExternalStatusReasonCode.MissingCreditorSchemeId, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Conflict with R-Message
    /// Encoded/decoded by serializers as &quot;RCON&quot;.
    /// </summary>
    [EnumMember(Value = "RCON")]
    [IsoId("_uFJoy_RYEeuLhpyIdtJzwg")]
    [Description(@"Conflict with R-Message")]
    RMessageConflict = ExternalStatusReasonCode.RMessageConflict, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Further information regarding the intended recipient. 
    /// Encoded/decoded by serializers as &quot;RECI&quot;.
    /// </summary>
    [EnumMember(Value = "RECI")]
    [IsoId("_uFJozvRYEeuLhpyIdtJzwg")]
    [Description(@"Further information regarding the intended recipient. ")]
    ReceiverCustomerInformation = ExternalStatusReasonCode.ReceiverCustomerInformation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction reference is not unique within the message.
    /// Encoded/decoded by serializers as &quot;RF01&quot;.
    /// </summary>
    [EnumMember(Value = "RF01")]
    [IsoId("_uFTZwvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction reference is not unique within the message.")]
    NotUniqueTransactionReference = ExternalStatusReasonCode.NotUniqueTransactionReference, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Specification of the debtor’s account or unique identification needed for reasons of regulatory requirements is insufficient or missing
    /// Encoded/decoded by serializers as &quot;RR01&quot;.
    /// </summary>
    [EnumMember(Value = "RR01")]
    [IsoId("_uFTZxfRYEeuLhpyIdtJzwg")]
    [Description(@"Specification of the debtor’s account or unique identification needed for reasons of regulatory requirements is insufficient or missing")]
    MissingDebtorAccountOrIdentification = ExternalStatusReasonCode.MissingDebtorAccountOrIdentification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Specification of the debtor’s name and/or address needed for regulatory requirements is insufficient or missing.
    /// Encoded/decoded by serializers as &quot;RR02&quot;.
    /// </summary>
    [EnumMember(Value = "RR02")]
    [IsoId("_uFTZyPRYEeuLhpyIdtJzwg")]
    [Description(@"Specification of the debtor’s name and/or address needed for regulatory requirements is insufficient or missing.")]
    MissingDebtorNameOrAddress = ExternalStatusReasonCode.MissingDebtorNameOrAddress, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Specification of the creditor’s name and/or address needed for regulatory requirements is insufficient or missing.
    /// Encoded/decoded by serializers as &quot;RR03&quot;.
    /// </summary>
    [EnumMember(Value = "RR03")]
    [IsoId("_uFTZy_RYEeuLhpyIdtJzwg")]
    [Description(@"Specification of the creditor’s name and/or address needed for regulatory requirements is insufficient or missing.")]
    MissingCreditorNameOrAddress = ExternalStatusReasonCode.MissingCreditorNameOrAddress, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Regulatory Reason
    /// Encoded/decoded by serializers as &quot;RR04&quot;.
    /// </summary>
    [EnumMember(Value = "RR04")]
    [IsoId("_uFcjsvRYEeuLhpyIdtJzwg")]
    [Description(@"Regulatory Reason")]
    RegulatoryReason = ExternalStatusReasonCode.RegulatoryReason, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Regulatory or Central Bank Reporting information missing, incomplete or invalid.
    /// Encoded/decoded by serializers as &quot;RR05&quot;.
    /// </summary>
    [EnumMember(Value = "RR05")]
    [IsoId("_uFcjtfRYEeuLhpyIdtJzwg")]
    [Description(@"Regulatory or Central Bank Reporting information missing, incomplete or invalid.")]
    RegulatoryInformationInvalid = ExternalStatusReasonCode.RegulatoryInformationInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax information missing, incomplete or invalid.
    /// Encoded/decoded by serializers as &quot;RR06&quot;.
    /// </summary>
    [EnumMember(Value = "RR06")]
    [IsoId("_uFcjuPRYEeuLhpyIdtJzwg")]
    [Description(@"Tax information missing, incomplete or invalid.")]
    TaxInformationInvalid = ExternalStatusReasonCode.TaxInformationInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Remittance information structure does not comply with rules for payment type.
    /// Encoded/decoded by serializers as &quot;RR07&quot;.
    /// </summary>
    [EnumMember(Value = "RR07")]
    [IsoId("_uFcju_RYEeuLhpyIdtJzwg")]
    [Description(@"Remittance information structure does not comply with rules for payment type.")]
    RemittanceInformationInvalid = ExternalStatusReasonCode.RemittanceInformationInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Remittance information truncated to comply with rules for payment type.
    /// Encoded/decoded by serializers as &quot;RR08&quot;.
    /// </summary>
    [EnumMember(Value = "RR08")]
    [IsoId("_uFcjvvRYEeuLhpyIdtJzwg")]
    [Description(@"Remittance information truncated to comply with rules for payment type.")]
    RemittanceInformationTruncated = ExternalStatusReasonCode.RemittanceInformationTruncated, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Structured creditor reference invalid or missing.
    /// Encoded/decoded by serializers as &quot;RR09&quot;.
    /// </summary>
    [EnumMember(Value = "RR09")]
    [IsoId("_uFmUsvRYEeuLhpyIdtJzwg")]
    [Description(@"Structured creditor reference invalid or missing.")]
    InvalidStructuredCreditorReference = ExternalStatusReasonCode.InvalidStructuredCreditorReference, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Character set supplied not valid for the country and payment type.
    /// Encoded/decoded by serializers as &quot;RR10&quot;.
    /// </summary>
    [EnumMember(Value = "RR10")]
    [IsoId("_uFmUtfRYEeuLhpyIdtJzwg")]
    [Description(@"Character set supplied not valid for the country and payment type.")]
    InvalidCharacterSet = ExternalStatusReasonCode.InvalidCharacterSet, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Invalid or missing identification of a bank proprietary service.
    /// Encoded/decoded by serializers as &quot;RR11&quot;.
    /// </summary>
    [EnumMember(Value = "RR11")]
    [IsoId("_uFwFsvRYEeuLhpyIdtJzwg")]
    [Description(@"Invalid or missing identification of a bank proprietary service.")]
    InvalidDebtorAgentServiceID = ExternalStatusReasonCode.InvalidDebtorAgentServiceID, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Invalid or missing identification required within a particular country or payment type.
    /// Encoded/decoded by serializers as &quot;RR12&quot;.
    /// </summary>
    [EnumMember(Value = "RR12")]
    [IsoId("_uFwFtfRYEeuLhpyIdtJzwg")]
    [Description(@"Invalid or missing identification required within a particular country or payment type.")]
    InvalidPartyID = ExternalStatusReasonCode.InvalidPartyID, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request for Cancellation is acknowledged following validation.
    /// Encoded/decoded by serializers as &quot;S000&quot;.
    /// </summary>
    [EnumMember(Value = "S000")]
    [IsoId("_uFwFuPRYEeuLhpyIdtJzwg")]
    [Description(@"Request for Cancellation is acknowledged following validation.")]
    ValidRequestForCancellationAcknowledged = ExternalStatusReasonCode.ValidRequestForCancellationAcknowledged, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unique End-to-end Transaction Reference (UETR) relating to a payment has been identified as being associated with a Request for Cancellation.
    /// Encoded/decoded by serializers as &quot;S001&quot;.
    /// </summary>
    [EnumMember(Value = "S001")]
    [IsoId("_uFwFu_RYEeuLhpyIdtJzwg")]
    [Description(@"Unique End-to-end Transaction Reference (UETR) relating to a payment has been identified as being associated with a Request for Cancellation.")]
    UETRFlaggedForCancellation = ExternalStatusReasonCode.UETRFlaggedForCancellation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unique End-to-end Transaction Reference (UETR) relating to a payment has been prevent from traveling across a messaging network.
    /// Encoded/decoded by serializers as &quot;S002&quot;.
    /// </summary>
    [EnumMember(Value = "S002")]
    [IsoId("_uF5PovRYEeuLhpyIdtJzwg")]
    [Description(@"Unique End-to-end Transaction Reference (UETR) relating to a payment has been prevent from traveling across a messaging network.")]
    NetworkStopOfUETR = ExternalStatusReasonCode.NetworkStopOfUETR, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request for Cancellation has been forwarded to the payment processing/last payment processing agent.
    /// Encoded/decoded by serializers as &quot;S003&quot;.
    /// </summary>
    [EnumMember(Value = "S003")]
    [IsoId("_uF5PpfRYEeuLhpyIdtJzwg")]
    [Description(@"Request for Cancellation has been forwarded to the payment processing/last payment processing agent.")]
    RequestForCancellationForwarded = ExternalStatusReasonCode.RequestForCancellationForwarded, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request for Cancellation has been acknowledged as delivered to payment processing/last payment processing agent.
    /// Encoded/decoded by serializers as &quot;S004&quot;.
    /// </summary>
    [EnumMember(Value = "S004")]
    [IsoId("_uF5PqPRYEeuLhpyIdtJzwg")]
    [Description(@"Request for Cancellation has been acknowledged as delivered to payment processing/last payment processing agent.")]
    RequestForCancellationDeliveryAcknowledgement = ExternalStatusReasonCode.RequestForCancellationDeliveryAcknowledgement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Due to specific service offered by the Debtor Agent.
    /// Encoded/decoded by serializers as &quot;SL01&quot;.
    /// </summary>
    [EnumMember(Value = "SL01")]
    [IsoId("_uF5Pq_RYEeuLhpyIdtJzwg")]
    [Description(@"Due to specific service offered by the Debtor Agent.")]
    SpecificServiceOfferedByDebtorAgent = ExternalStatusReasonCode.SpecificServiceOfferedByDebtorAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Due to specific service offered by the Creditor Agent.
    /// Encoded/decoded by serializers as &quot;SL02&quot;.
    /// </summary>
    [EnumMember(Value = "SL02")]
    [IsoId("_uF5PrvRYEeuLhpyIdtJzwg")]
    [Description(@"Due to specific service offered by the Creditor Agent.")]
    SpecificServiceOfferedByCreditorAgent = ExternalStatusReasonCode.SpecificServiceOfferedByCreditorAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Due to a specific service offered by the clearing system.
    /// Encoded/decoded by serializers as &quot;SL03&quot;.
    /// </summary>
    [EnumMember(Value = "SL03")]
    [IsoId("_uGDAovRYEeuLhpyIdtJzwg")]
    [Description(@"Due to a specific service offered by the clearing system.")]
    ServiceofClearingSystem = ExternalStatusReasonCode.ServiceofClearingSystem, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Whitelisting service offered by the Debtor Agent; Debtor has not included the Creditor on its “Whitelist” (yet). In the Whitelist the Debtor may list all allowed Creditors to debit Debtor bank account.
    /// Encoded/decoded by serializers as &quot;SL11&quot;.
    /// </summary>
    [EnumMember(Value = "SL11")]
    [IsoId("_uGDApfRYEeuLhpyIdtJzwg")]
    [Description(@"Whitelisting service offered by the Debtor Agent; Debtor has not included the Creditor on its “Whitelist” (yet). In the Whitelist the Debtor may list all allowed Creditors to debit Debtor bank account.")]
    CreditorNotOnWhitelistOfDebtor = ExternalStatusReasonCode.CreditorNotOnWhitelistOfDebtor, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Blacklisting service offered by the Debtor Agent; Debtor included the Creditor on his “Blacklist”. In the Blacklist the Debtor may list all Creditors not allowed to debit Debtor bank account.
    /// Encoded/decoded by serializers as &quot;SL12&quot;.
    /// </summary>
    [EnumMember(Value = "SL12")]
    [IsoId("_uGDAqPRYEeuLhpyIdtJzwg")]
    [Description(@"Blacklisting service offered by the Debtor Agent; Debtor included the Creditor on his “Blacklist”. In the Blacklist the Debtor may list all Creditors not allowed to debit Debtor bank account.")]
    CreditorOnBlacklistOfDebtor = ExternalStatusReasonCode.CreditorOnBlacklistOfDebtor, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Due to Maximum allowed Direct Debit Transactions per period service offered by the Debtor Agent.
    /// Encoded/decoded by serializers as &quot;SL13&quot;.
    /// </summary>
    [EnumMember(Value = "SL13")]
    [IsoId("_uGMxovRYEeuLhpyIdtJzwg")]
    [Description(@"Due to Maximum allowed Direct Debit Transactions per period service offered by the Debtor Agent.")]
    MaximumNumberOfDirectDebitTransactionsExceeded = ExternalStatusReasonCode.MaximumNumberOfDirectDebitTransactionsExceeded, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Due to Maximum allowed Direct Debit Transaction amount service offered by the Debtor Agent.
    /// Encoded/decoded by serializers as &quot;SL14&quot;.
    /// </summary>
    [EnumMember(Value = "SL14")]
    [IsoId("_uGMxpfRYEeuLhpyIdtJzwg")]
    [Description(@"Due to Maximum allowed Direct Debit Transaction amount service offered by the Debtor Agent.")]
    MaximumDirectDebitTransactionAmountExceeded = ExternalStatusReasonCode.MaximumDirectDebitTransactionAmountExceeded, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The transmission of the file was not successful – it had to be aborted (for technical reasons)
    /// Encoded/decoded by serializers as &quot;TA01&quot;.
    /// </summary>
    [EnumMember(Value = "TA01")]
    [IsoId("_uGMxqPRYEeuLhpyIdtJzwg")]
    [Description(@"The transmission of the file was not successful – it had to be aborted (for technical reasons)")]
    TransmissonAborted = ExternalStatusReasonCode.TransmissonAborted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// There is no data available (for download)
    /// Encoded/decoded by serializers as &quot;TD01&quot;.
    /// </summary>
    [EnumMember(Value = "TD01")]
    [IsoId("_uGMxq_RYEeuLhpyIdtJzwg")]
    [Description(@"There is no data available (for download)")]
    NoDataAvailable = ExternalStatusReasonCode.NoDataAvailable, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The file cannot be read (e.g. unknown format)
    /// Encoded/decoded by serializers as &quot;TD02&quot;.
    /// </summary>
    [EnumMember(Value = "TD02")]
    [IsoId("_uGV7kvRYEeuLhpyIdtJzwg")]
    [Description(@"The file cannot be read (e.g. unknown format)")]
    FileNonReadable = ExternalStatusReasonCode.FileNonReadable, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The file format is incomplete or invalid
    /// Encoded/decoded by serializers as &quot;TD03&quot;.
    /// </summary>
    [EnumMember(Value = "TD03")]
    [IsoId("_uGV7lfRYEeuLhpyIdtJzwg")]
    [Description(@"The file format is incomplete or invalid")]
    IncorrectFileStructure = ExternalStatusReasonCode.IncorrectFileStructure, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Token is invalid.
    /// Encoded/decoded by serializers as &quot;TK01&quot;.
    /// </summary>
    [EnumMember(Value = "TK01")]
    [IsoId("_uGV7mPRYEeuLhpyIdtJzwg")]
    [Description(@"Token is invalid.")]
    TokenInvalid = ExternalStatusReasonCode.TokenInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Token used for the sender does not exist.
    /// Encoded/decoded by serializers as &quot;TK02&quot;.
    /// </summary>
    [EnumMember(Value = "TK02")]
    [IsoId("_uGV7m_RYEeuLhpyIdtJzwg")]
    [Description(@"Token used for the sender does not exist.")]
    SenderTokenNotFound = ExternalStatusReasonCode.SenderTokenNotFound, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Token used for the receiver does not exist.
    /// Encoded/decoded by serializers as &quot;TK03&quot;.
    /// </summary>
    [EnumMember(Value = "TK03")]
    [IsoId("_uGfskfRYEeuLhpyIdtJzwg")]
    [Description(@"Token used for the receiver does not exist.")]
    ReceiverTokenNotFound = ExternalStatusReasonCode.ReceiverTokenNotFound, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Token required for request is missing.
    /// Encoded/decoded by serializers as &quot;TK09&quot;.
    /// </summary>
    [EnumMember(Value = "TK09")]
    [IsoId("_uGfslPRYEeuLhpyIdtJzwg")]
    [Description(@"Token required for request is missing.")]
    TokenMissing = ExternalStatusReasonCode.TokenMissing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Token found with counterparty mismatch. 
    /// Encoded/decoded by serializers as &quot;TKCM&quot;.
    /// </summary>
    [EnumMember(Value = "TKCM")]
    [IsoId("_uGfsl_RYEeuLhpyIdtJzwg")]
    [Description(@"Token found with counterparty mismatch. ")]
    TokenCounterpartyMismatch = ExternalStatusReasonCode.TokenCounterpartyMismatch, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Single Use Token already used. 
    /// Encoded/decoded by serializers as &quot;TKSG&quot;.
    /// </summary>
    [EnumMember(Value = "TKSG")]
    [IsoId("_uGpdkvRYEeuLhpyIdtJzwg")]
    [Description(@"Single Use Token already used. ")]
    TokenSingleUse = ExternalStatusReasonCode.TokenSingleUse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Token found with suspended status.
    /// Encoded/decoded by serializers as &quot;TKSP&quot;.
    /// </summary>
    [EnumMember(Value = "TKSP")]
    [IsoId("_uGpdlfRYEeuLhpyIdtJzwg")]
    [Description(@"Token found with suspended status.")]
    TokenSuspended = ExternalStatusReasonCode.TokenSuspended, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Token found with value limit rule violation. 
    /// Encoded/decoded by serializers as &quot;TKVE&quot;.
    /// </summary>
    [EnumMember(Value = "TKVE")]
    [IsoId("_uGpdmPRYEeuLhpyIdtJzwg")]
    [Description(@"Token found with value limit rule violation. ")]
    TokenValueLimitExceeded = ExternalStatusReasonCode.TokenValueLimitExceeded, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Token expired.
    /// Encoded/decoded by serializers as &quot;TKXP&quot;.
    /// </summary>
    [EnumMember(Value = "TKXP")]
    [IsoId("_uGpdm_RYEeuLhpyIdtJzwg")]
    [Description(@"Token expired.")]
    TokenExpired = ExternalStatusReasonCode.TokenExpired, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Associated message, payment information block, or transaction was received after agreed processing cut-off time.
    /// Encoded/decoded by serializers as &quot;TM01&quot;.
    /// </summary>
    [EnumMember(Value = "TM01")]
    [IsoId("_uGyngvRYEeuLhpyIdtJzwg")]
    [Description(@"Associated message, payment information block, or transaction was received after agreed processing cut-off time.")]
    InvalidCutOffTime = ExternalStatusReasonCode.InvalidCutOffTime, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The (technical) transmission of the file was successful.
    /// Encoded/decoded by serializers as &quot;TS01&quot;.
    /// </summary>
    [EnumMember(Value = "TS01")]
    [IsoId("_uGynhfRYEeuLhpyIdtJzwg")]
    [Description(@"The (technical) transmission of the file was successful.")]
    TransmissionSuccessful = ExternalStatusReasonCode.TransmissionSuccessful, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The order was transferred to pass by accompanying note signed by hand
    /// Encoded/decoded by serializers as &quot;TS04&quot;.
    /// </summary>
    [EnumMember(Value = "TS04")]
    [IsoId("_uGyniPRYEeuLhpyIdtJzwg")]
    [Description(@"The order was transferred to pass by accompanying note signed by hand")]
    TransferToSignByHand = ExternalStatusReasonCode.TransferToSignByHand, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Authorisation is cancelled.
    /// Encoded/decoded by serializers as &quot;CN01&quot;.
    /// </summary>
    [EnumMember(Value = "CN01")]
    [IsoId("_WsByQQQnEey95qpfbNuEwg")]
    [Description(@"Authorisation is cancelled.")]
    AuthorisationCancelled = ExternalStatusReasonCode.AuthorisationCancelled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Return following a cancellation request.
    /// Encoded/decoded by serializers as &quot;FOCR&quot;.
    /// </summary>
    [EnumMember(Value = "FOCR")]
    [IsoId("_04dfMQQoEey95qpfbNuEwg")]
    [Description(@"Return following a cancellation request.")]
    FollowingCancellationRequest = ExternalStatusReasonCode.FollowingCancellationRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Returned as a result of fraud.
    /// Encoded/decoded by serializers as &quot;FR01&quot;.
    /// </summary>
    [EnumMember(Value = "FR01")]
    [IsoId("_1G6x8QQoEey95qpfbNuEwg")]
    [Description(@"Returned as a result of fraud.")]
    Fraud = ExternalStatusReasonCode.Fraud, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Customer account is not compliant with regulatory requirements, for example FICA (in South Africa) or any other regulatory requirements which render an account inactive for certain processing.
    /// Encoded/decoded by serializers as &quot;NOCM&quot;.
    /// </summary>
    [EnumMember(Value = "NOCM")]
    [IsoId("_2MWwAQQoEey95qpfbNuEwg")]
    [Description(@"Customer account is not compliant with regulatory requirements, for example FICA (in South Africa) or any other regulatory requirements which render an account inactive for certain processing.")]
    NotCompliantGeneric = ExternalStatusReasonCode.NotCompliantGeneric, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// No response from Beneficiary.
    /// Encoded/decoded by serializers as &quot;NOAS&quot;.
    /// </summary>
    [EnumMember(Value = "NOAS")]
    [IsoId("_2r8PAQQoEey95qpfbNuEwg")]
    [Description(@"No response from Beneficiary.")]
    NoAnswerFromCustomer = ExternalStatusReasonCode.NoAnswerFromCustomer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Return following investigation request and no remediation possible.
    /// Encoded/decoded by serializers as &quot;RUTA&quot;.
    /// </summary>
    [EnumMember(Value = "RUTA")]
    [IsoId("_3dkgQQQoEey95qpfbNuEwg")]
    [Description(@"Return following investigation request and no remediation possible.")]
    ReturnUponUnableToApply = ExternalStatusReasonCode.ReturnUponUnableToApply, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment is not justified.
    /// Encoded/decoded by serializers as &quot;UPAY&quot;.
    /// </summary>
    [EnumMember(Value = "UPAY")]
    [IsoId("_39mrMQQoEey95qpfbNuEwg")]
    [Description(@"Payment is not justified.")]
    UnduePayment = ExternalStatusReasonCode.UnduePayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request-to-pay has already been accepted by the Debtor.
    /// Encoded/decoded by serializers as &quot;ALAC&quot;.
    /// </summary>
    [EnumMember(Value = "ALAC")]
    [IsoId("_r-rfwVEDEey6cYDbEubNXg")]
    [Description(@"Request-to-pay has already been accepted by the Debtor.")]
    AlreadyAcceptedRTP = ExternalStatusReasonCode.AlreadyAcceptedRTP, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request-to-pay Expiry Date and Time has already passed.
    /// Encoded/decoded by serializers as &quot;AEXR&quot;.
    /// </summary>
    [EnumMember(Value = "AEXR")]
    [IsoId("_sHxxYVEDEey6cYDbEubNXg")]
    [Description(@"Request-to-pay Expiry Date and Time has already passed.")]
    AlreadyExpiredRTP = ExternalStatusReasonCode.AlreadyExpiredRTP, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request-to-pay has already been refused by the Debtor.
    /// Encoded/decoded by serializers as &quot;ARFR&quot;.
    /// </summary>
    [EnumMember(Value = "ARFR")]
    [IsoId("_sQH1EVEDEey6cYDbEubNXg")]
    [Description(@"Request-to-pay has already been refused by the Debtor.")]
    AlreadyRefusedRTP = ExternalStatusReasonCode.AlreadyRefusedRTP, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request-to-pay has already been rejected.
    /// Encoded/decoded by serializers as &quot;ARJR&quot;.
    /// </summary>
    [EnumMember(Value = "ARJR")]
    [IsoId("_sY59oVEDEey6cYDbEubNXg")]
    [Description(@"Request-to-pay has already been rejected.")]
    AlreadyRejectedRTP = ExternalStatusReasonCode.AlreadyRejectedRTP, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Attachments to the request-to-pay are not supported.
    /// Encoded/decoded by serializers as &quot;ATNS&quot;.
    /// </summary>
    [EnumMember(Value = "ATNS")]
    [IsoId("_ssSMoVEDEey6cYDbEubNXg")]
    [Description(@"Attachments to the request-to-pay are not supported.")]
    AttachementsNotSupported = ExternalStatusReasonCode.AttachementsNotSupported, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Expiry date time of the request-to-pay is already reached.
    /// Encoded/decoded by serializers as &quot;EDTR&quot;.
    /// </summary>
    [EnumMember(Value = "EDTR")]
    [IsoId("_tQMK8VEDEey6cYDbEubNXg")]
    [Description(@"Expiry date time of the request-to-pay is already reached.")]
    ExpiryDateTimeReached = ExternalStatusReasonCode.ExpiryDateTimeReached, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Expiry date time of the request-to-pay is too far in the future.
    /// Encoded/decoded by serializers as &quot;EDTL&quot;.
    /// </summary>
    [EnumMember(Value = "EDTL")]
    [IsoId("_tWTaAVEDEey6cYDbEubNXg")]
    [Description(@"Expiry date time of the request-to-pay is too far in the future.")]
    ExpiryDateTooLong = ExternalStatusReasonCode.ExpiryDateTooLong, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation requested following a transaction that was originated fraudulently. The use of the FraudulentOrigin code should be governed by jurisdictions.
    /// Encoded/decoded by serializers as &quot;FRAD&quot;.
    /// </summary>
    [EnumMember(Value = "FRAD")]
    [IsoId("_tkUA0VEDEey6cYDbEubNXg")]
    [Description(@"Cancellation requested following a transaction that was originated fraudulently. The use of the FraudulentOrigin code should be governed by jurisdictions.")]
    FraudulentOrigin = ExternalStatusReasonCode.FraudulentOrigin, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Expiry date time of the request-to-pay is incorrect.
    /// Encoded/decoded by serializers as &quot;IEDT&quot;.
    /// </summary>
    [EnumMember(Value = "IEDT")]
    [IsoId("_uDTp8VEDEey6cYDbEubNXg")]
    [Description(@"Expiry date time of the request-to-pay is incorrect.")]
    IncorrectExpiryDateTime = ExternalStatusReasonCode.IncorrectExpiryDateTime, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// No initial request-to-pay has been received.
    /// Encoded/decoded by serializers as &quot;IRNR&quot;.
    /// </summary>
    [EnumMember(Value = "IRNR")]
    [IsoId("_uOCTQVEDEey6cYDbEubNXg")]
    [Description(@"No initial request-to-pay has been received.")]
    InitialRTPNeverReceived = ExternalStatusReasonCode.InitialRTPNeverReceived, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// No existing agreement for receiving request-to-pay messages.
    /// Encoded/decoded by serializers as &quot;NOAR&quot;.
    /// </summary>
    [EnumMember(Value = "NOAR")]
    [IsoId("_u-KvsVEDEey6cYDbEubNXg")]
    [Description(@"No existing agreement for receiving request-to-pay messages.")]
    NonAgreedRTP = ExternalStatusReasonCode.NonAgreedRTP, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Requested payment guarantee (by Creditor) related to a request-to-pay cannot be provided.
    /// Encoded/decoded by serializers as &quot;NOPG&quot;.
    /// </summary>
    [EnumMember(Value = "NOPG")]
    [IsoId("_vD1S0VEDEey6cYDbEubNXg")]
    [Description(@"Requested payment guarantee (by Creditor) related to a request-to-pay cannot be provided.")]
    NoPaymentGuarantee = ExternalStatusReasonCode.NoPaymentGuarantee, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Recipient side of the request-to-pay (payer or its request-to-pay service provider) is not reachable.
    /// Encoded/decoded by serializers as &quot;NRCH&quot;.
    /// </summary>
    [EnumMember(Value = "NRCH")]
    [IsoId("_vncWMVEDEey6cYDbEubNXg")]
    [Description(@"Recipient side of the request-to-pay (payer or its request-to-pay service provider) is not reachable.")]
    PayerOrPayerRTPSPNotReachable = ExternalStatusReasonCode.PayerOrPayerRTPSPNotReachable, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Debtor does not support request-to-pay transactions.
    /// Encoded/decoded by serializers as &quot;RTNS&quot;.
    /// </summary>
    [EnumMember(Value = "RTNS")]
    [IsoId("_wDnU0VEDEey6cYDbEubNXg")]
    [Description(@"Debtor does not support request-to-pay transactions.")]
    RTPNotSupportedForDebtor = ExternalStatusReasonCode.RTPNotSupportedForDebtor, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request-to-pay has been received and can be processed further.
    /// Encoded/decoded by serializers as &quot;REPR&quot;.
    /// </summary>
    [EnumMember(Value = "REPR")]
    [IsoId("_wJIG8VEDEey6cYDbEubNXg")]
    [Description(@"Request-to-pay has been received and can be processed further.")]
    RTPReceivedCanBeProcessed = ExternalStatusReasonCode.RTPReceivedCanBeProcessed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identifier of the request-to-pay service provider is incorrect.
    /// Encoded/decoded by serializers as &quot;SPII&quot;.
    /// </summary>
    [EnumMember(Value = "SPII")]
    [IsoId("_wOo5EVEDEey6cYDbEubNXg")]
    [Description(@"Identifier of the request-to-pay service provider is incorrect.")]
    RTPServiceProviderIdentifierIncorrect = ExternalStatusReasonCode.RTPServiceProviderIdentifierIncorrect, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Type of payment requested in the request-to-pay is not supported by the payer.
    /// Encoded/decoded by serializers as &quot;PINS&quot;.
    /// </summary>
    [EnumMember(Value = "PINS")]
    [IsoId("_wz47MVEDEey6cYDbEubNXg")]
    [Description(@"Type of payment requested in the request-to-pay is not supported by the payer.")]
    TypeOfPaymentInstrumentNotSupported = ExternalStatusReasonCode.TypeOfPaymentInstrumentNotSupported, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unknown Creditor.
    /// Encoded/decoded by serializers as &quot;UCRD&quot;.
    /// </summary>
    [EnumMember(Value = "UCRD")]
    [IsoId("_w-BuoVEDEey6cYDbEubNXg")]
    [Description(@"Unknown Creditor.")]
    UnknownCreditor = ExternalStatusReasonCode.UnknownCreditor, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Original payment is not eligible to be returned given its current status.
    /// Encoded/decoded by serializers as &quot;FF12&quot;.
    /// </summary>
    [EnumMember(Value = "FF12")]
    [IsoId("_hweBsY5AEeyANo-d7JlQ1A")]
    [Description(@"Original payment is not eligible to be returned given its current status.")]
    OriginalTransactionNotEligibleForRequestedReturn = ExternalStatusReasonCode.OriginalTransactionNotEligibleForRequestedReturn, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// No record of request for cancellation found.
    /// Encoded/decoded by serializers as &quot;FF13&quot;.
    /// </summary>
    [EnumMember(Value = "FF13")]
    [IsoId("_igJyMY5AEeyANo-d7JlQ1A")]
    [Description(@"No record of request for cancellation found.")]
    RequestForCancellationNotFound = ExternalStatusReasonCode.RequestForCancellationNotFound, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Rejection of a payment due to covering FI settlement not being received.
    /// Encoded/decoded by serializers as &quot;DC02&quot;.
    /// </summary>
    [EnumMember(Value = "DC02")]
    [IsoId("_QeieAeAdEey0k8vo1GQhqQ")]
    [Description(@"Rejection of a payment due to covering FI settlement not being received.")]
    SettlementNotReceived = ExternalStatusReasonCode.SettlementNotReceived, // same ordinal as derivation source for type conversions
    
}
