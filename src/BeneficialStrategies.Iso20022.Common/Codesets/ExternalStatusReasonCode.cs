// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status reason, as published in an external status reason code list.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a929gJ0uEeeuSNj2bfEs7Q")]
[Description(
    @"Specifies the status reason, as published in an external status reason code list.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalStatusReason1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExternalStatusReasonCode>))]
#endif
public enum ExternalStatusReasonCode
{
    /// <summary>
    /// Clearing process aborted due to timeout.
    /// Encoded/decoded by serializers as &quot;AB01&quot;.
    /// </summary>
    [EnumMember(Value = "AB01")]
    [IsoId("_t9aCA_RYEeuLhpyIdtJzwg")]
    [Description(@"Clearing process aborted due to timeout.   ")]
    AbortedClearingTimeout,

    /// <summary>
    /// Clearing process aborted due to a fatal error.
    /// Encoded/decoded by serializers as &quot;AB02&quot;.
    /// </summary>
    [EnumMember(Value = "AB02")]
    [IsoId("_t9jzAPRYEeuLhpyIdtJzwg")]
    [Description(@"Clearing process aborted due to a fatal error.   ")]
    AbortedClearingFatalError,

    /// <summary>
    /// Settlement aborted due to timeout.
    /// Encoded/decoded by serializers as &quot;AB03&quot;.
    /// </summary>
    [EnumMember(Value = "AB03")]
    [IsoId("_t9jzA_RYEeuLhpyIdtJzwg")]
    [Description(@"Settlement aborted due to timeout.   ")]
    AbortedSettlementTimeout,

    /// <summary>
    /// Settlement process aborted due to a fatal error.
    /// Encoded/decoded by serializers as &quot;AB04&quot;.
    /// </summary>
    [EnumMember(Value = "AB04")]
    [IsoId("_t9s88PRYEeuLhpyIdtJzwg")]
    [Description(@"Settlement process aborted due to a fatal error.   ")]
    AbortedSettlementFatalError,

    /// <summary>
    /// Transaction stopped due to timeout at the Creditor Agent.
    /// Encoded/decoded by serializers as &quot;AB05&quot;.
    /// </summary>
    [EnumMember(Value = "AB05")]
    [IsoId("_t9s88_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction stopped due to timeout at the Creditor Agent.")]
    TimeoutCreditorAgent,

    /// <summary>
    /// Transaction stopped due to timeout at the Instructed Agent.
    /// Encoded/decoded by serializers as &quot;AB06&quot;.
    /// </summary>
    [EnumMember(Value = "AB06")]
    [IsoId("_t9s89vRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction stopped due to timeout at the Instructed Agent.")]
    TimeoutInstructedAgent,

    /// <summary>
    /// Agent of message is not online.|Generic usage if it cannot be determined who exactly is not online.
    /// Encoded/decoded by serializers as &quot;AB07&quot;.
    /// </summary>
    [EnumMember(Value = "AB07")]
    [IsoId("_t92t8PRYEeuLhpyIdtJzwg")]
    [Description(
        @"Agent of message is not online.|Generic usage if it cannot be determined who exactly is not online."
    )]
    OfflineAgent,

    /// <summary>
    /// Creditor Agent is not online.
    /// Encoded/decoded by serializers as &quot;AB08&quot;.
    /// </summary>
    [EnumMember(Value = "AB08")]
    [IsoId("_t92t8_RYEeuLhpyIdtJzwg")]
    [Description(@"Creditor Agent is not online.")]
    OfflineCreditorAgent,

    /// <summary>
    /// Transaction stopped due to error at the Creditor Agent.
    /// Encoded/decoded by serializers as &quot;AB09&quot;.
    /// </summary>
    [EnumMember(Value = "AB09")]
    [IsoId("_t92t9vRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction stopped due to error at the Creditor Agent.")]
    ErrorCreditorAgent,

    /// <summary>
    /// Transaction stopped due to error at the Instructed Agent.
    /// Encoded/decoded by serializers as &quot;AB10&quot;.
    /// </summary>
    [EnumMember(Value = "AB10")]
    [IsoId("_t92t-fRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction stopped due to error at the Instructed Agent.")]
    ErrorInstructedAgent,

    /// <summary>
    /// Transaction stopped due to timeout at the Debtor Agent.
    /// Encoded/decoded by serializers as &quot;AB11&quot;.
    /// </summary>
    [EnumMember(Value = "AB11")]
    [IsoId("_t92t_PRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction stopped due to timeout at the Debtor Agent.")]
    TimeoutDebtorAgent,

    /// <summary>
    /// Account number is invalid or missing.   |
    /// Encoded/decoded by serializers as &quot;AC01&quot;.
    /// </summary>
    [EnumMember(Value = "AC01")]
    [IsoId("_t-Ae8PRYEeuLhpyIdtJzwg")]
    [Description(@"Account number is invalid or missing.   |")]
    IncorrectAccountNumber,

    /// <summary>
    /// Debtor account number invalid or missing
    /// Encoded/decoded by serializers as &quot;AC02&quot;.
    /// </summary>
    [EnumMember(Value = "AC02")]
    [IsoId("_t-Ae8_RYEeuLhpyIdtJzwg")]
    [Description(@"Debtor account number invalid or missing")]
    InvalidDebtorAccountNumber,

    /// <summary>
    /// Creditor account number invalid or missing
    /// Encoded/decoded by serializers as &quot;AC03&quot;.
    /// </summary>
    [EnumMember(Value = "AC03")]
    [IsoId("_t-Jo4PRYEeuLhpyIdtJzwg")]
    [Description(@"Creditor account number invalid or missing")]
    InvalidCreditorAccountNumber,

    /// <summary>
    /// Account number specified has been closed on the bank of account&apos;s books.
    /// Encoded/decoded by serializers as &quot;AC04&quot;.
    /// </summary>
    [EnumMember(Value = "AC04")]
    [IsoId("_t-Jo4_RYEeuLhpyIdtJzwg")]
    [Description(@"Account number specified has been closed on the bank of account's books. ")]
    ClosedAccountNumber,

    /// <summary>
    /// Debtor account number closed
    /// Encoded/decoded by serializers as &quot;AC05&quot;.
    /// </summary>
    [EnumMember(Value = "AC05")]
    [IsoId("_t-Jo5vRYEeuLhpyIdtJzwg")]
    [Description(@"Debtor account number closed")]
    ClosedDebtorAccountNumber,

    /// <summary>
    /// Account specified is blocked, prohibiting posting of transactions against it.
    /// Encoded/decoded by serializers as &quot;AC06&quot;.
    /// </summary>
    [EnumMember(Value = "AC06")]
    [IsoId("_t-Jo6fRYEeuLhpyIdtJzwg")]
    [Description(@"Account specified is blocked, prohibiting posting of transactions against it.")]
    BlockedAccount,

    /// <summary>
    /// Creditor account number closed
    /// Encoded/decoded by serializers as &quot;AC07&quot;.
    /// </summary>
    [EnumMember(Value = "AC07")]
    [IsoId("_t-Jo7PRYEeuLhpyIdtJzwg")]
    [Description(@"Creditor account number closed")]
    ClosedCreditorAccountNumber,

    /// <summary>
    /// Branch code is invalid or missing
    /// Encoded/decoded by serializers as &quot;AC08&quot;.
    /// </summary>
    [EnumMember(Value = "AC08")]
    [IsoId("_t-TZ4PRYEeuLhpyIdtJzwg")]
    [Description(@"Branch code is invalid or missing")]
    InvalidBranchCode,

    /// <summary>
    /// Account currency is invalid or missing
    /// Encoded/decoded by serializers as &quot;AC09&quot;.
    /// </summary>
    [EnumMember(Value = "AC09")]
    [IsoId("_t-TZ4_RYEeuLhpyIdtJzwg")]
    [Description(@"Account currency is invalid or missing")]
    InvalidAccountCurrency,

    /// <summary>
    /// Debtor account currency is invalid or missing
    /// Encoded/decoded by serializers as &quot;AC10&quot;.
    /// </summary>
    [EnumMember(Value = "AC10")]
    [IsoId("_t-TZ5vRYEeuLhpyIdtJzwg")]
    [Description(@"Debtor account currency is invalid or missing")]
    InvalidDebtorAccountCurrency,

    /// <summary>
    /// Creditor account currency is invalid or missing
    /// Encoded/decoded by serializers as &quot;AC11&quot;.
    /// </summary>
    [EnumMember(Value = "AC11")]
    [IsoId("_t-TZ6fRYEeuLhpyIdtJzwg")]
    [Description(@"Creditor account currency is invalid or missing")]
    InvalidCreditorAccountCurrency,

    /// <summary>
    /// Account type missing or invalid.|Generic usage if cannot specify between group and payment information levels
    /// Encoded/decoded by serializers as &quot;AC12&quot;.
    /// </summary>
    [EnumMember(Value = "AC12")]
    [IsoId("_t-TZ7PRYEeuLhpyIdtJzwg")]
    [Description(
        @"Account type missing or invalid.|Generic usage if cannot specify between group and payment information levels"
    )]
    InvalidAccountType,

    /// <summary>
    /// Debtor account type missing or invalid
    /// Encoded/decoded by serializers as &quot;AC13&quot;.
    /// </summary>
    [EnumMember(Value = "AC13")]
    [IsoId("_t-cj0PRYEeuLhpyIdtJzwg")]
    [Description(@"Debtor account type missing or invalid")]
    InvalidDebtorAccountType,

    /// <summary>
    /// Creditor account type missing or invalid
    /// Encoded/decoded by serializers as &quot;AC14&quot;.
    /// </summary>
    [EnumMember(Value = "AC14")]
    [IsoId("_t-cj0_RYEeuLhpyIdtJzwg")]
    [Description(@"Creditor account type missing or invalid")]
    InvalidCreditorAccountType,

    /// <summary>
    /// The account details for the counterparty have changed.
    /// Encoded/decoded by serializers as &quot;AC15&quot;.
    /// </summary>
    [EnumMember(Value = "AC15")]
    [IsoId("_t-cj1vRYEeuLhpyIdtJzwg")]
    [Description(@"The account details for the counterparty have changed.")]
    AccountDetailsChanged,

    /// <summary>
    /// Credit or debit card number is invalid.
    /// Encoded/decoded by serializers as &quot;AC16&quot;.
    /// </summary>
    [EnumMember(Value = "AC16")]
    [IsoId("_t-cj2fRYEeuLhpyIdtJzwg")]
    [Description(@"Credit or debit card number is invalid.")]
    CardNumberInvalid,

    /// <summary>
    /// Transaction forbidden on this type of account (formerly NoAgreement)
    /// Encoded/decoded by serializers as &quot;AG01&quot;.
    /// </summary>
    [EnumMember(Value = "AG01")]
    [IsoId("_t-cj3PRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction forbidden on this type of account (formerly NoAgreement)")]
    TransactionForbidden,

    /// <summary>
    /// Bank Operation code specified in the message is not valid for receiver
    /// Encoded/decoded by serializers as &quot;AG02&quot;.
    /// </summary>
    [EnumMember(Value = "AG02")]
    [IsoId("_t-mU0PRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Operation code specified in the message is not valid for receiver")]
    InvalidBankOperationCode,

    /// <summary>
    /// Transaction type not supported/authorized on this account
    /// Encoded/decoded by serializers as &quot;AG03&quot;.
    /// </summary>
    [EnumMember(Value = "AG03")]
    [IsoId("_t-mU0_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction type not supported/authorized on this account ")]
    TransactionNotSupported,

    /// <summary>
    /// Agent country code is missing or invalid.|Generic usage if cannot specify between group and payment information levels.
    /// Encoded/decoded by serializers as &quot;AG04&quot;.
    /// </summary>
    [EnumMember(Value = "AG04")]
    [IsoId("_t-mU1vRYEeuLhpyIdtJzwg")]
    [Description(
        @"Agent country code is missing or invalid.|Generic usage if cannot specify between group and payment information levels."
    )]
    InvalidAgentCountry,

    /// <summary>
    /// Debtor agent country code is missing or invalid
    /// Encoded/decoded by serializers as &quot;AG05&quot;.
    /// </summary>
    [EnumMember(Value = "AG05")]
    [IsoId("_t-mU2fRYEeuLhpyIdtJzwg")]
    [Description(@"Debtor agent country code is missing or invalid")]
    InvalidDebtorAgentCountry,

    /// <summary>
    /// Creditor agent country code is missing or invalid
    /// Encoded/decoded by serializers as &quot;AG06&quot;.
    /// </summary>
    [EnumMember(Value = "AG06")]
    [IsoId("_t-mU3PRYEeuLhpyIdtJzwg")]
    [Description(@"Creditor agent country code is missing or invalid")]
    InvalidCreditorAgentCountry,

    /// <summary>
    /// Debtor account cannot be debited for a generic reason.|Code value may be used in general purposes and as a replacement for AM04 if debtor bank does not reveal its customer&apos;s insufficient funds for privacy reasons
    /// Encoded/decoded by serializers as &quot;AG07&quot;.
    /// </summary>
    [EnumMember(Value = "AG07")]
    [IsoId("_t-wF0PRYEeuLhpyIdtJzwg")]
    [Description(
        @"Debtor account cannot be debited for a generic reason.|Code value may be used in general purposes and as a replacement for AM04 if debtor bank does not reveal its customer's insufficient funds for privacy reasons"
    )]
    UnsuccesfulDirectDebit,

    /// <summary>
    /// Transaction failed due to invalid or missing user or access right
    /// Encoded/decoded by serializers as &quot;AG08&quot;.
    /// </summary>
    [EnumMember(Value = "AG08")]
    [IsoId("_t-wF0_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction failed due to invalid or missing user or access right")]
    InvalidAccessRights,

    /// <summary>
    /// Original payment never received.
    /// Encoded/decoded by serializers as &quot;AG09&quot;.
    /// </summary>
    [EnumMember(Value = "AG09")]
    [IsoId("_t-wF1vRYEeuLhpyIdtJzwg")]
    [Description(@"Original payment never received.")]
    PaymentNotReceived,

    /// <summary>
    /// Agent of message is suspended from the Real Time Payment system.|Generic usage if it cannot be determined who exactly is suspended.
    /// Encoded/decoded by serializers as &quot;AG10&quot;.
    /// </summary>
    [EnumMember(Value = "AG10")]
    [IsoId("_t-wF2fRYEeuLhpyIdtJzwg")]
    [Description(
        @"Agent of message is suspended from the Real Time Payment system.|Generic usage if it cannot be determined who exactly is suspended."
    )]
    AgentSuspended,

    /// <summary>
    /// Creditor Agent of message is suspended from the Real Time Payment system.
    /// Encoded/decoded by serializers as &quot;AG11&quot;.
    /// </summary>
    [EnumMember(Value = "AG11")]
    [IsoId("_t-wF3PRYEeuLhpyIdtJzwg")]
    [Description(@"Creditor Agent of message is suspended from the Real Time Payment system.")]
    CreditorAgentSuspended,

    /// <summary>
    /// Payment orders made by transferring funds from one account to another at the same financial institution (bank or payment institution) are not allowed.
    /// Encoded/decoded by serializers as &quot;AG12&quot;.
    /// </summary>
    [EnumMember(Value = "AG12")]
    [IsoId("_t-5PwPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Payment orders made by transferring funds from one account to another at the same financial institution (bank or payment institution) are not allowed."
    )]
    NotAllowedBookTransfer,

    /// <summary>
    /// Returned payments derived from previously returned transactions are not allowed.
    /// Encoded/decoded by serializers as &quot;AG13&quot;.
    /// </summary>
    [EnumMember(Value = "AG13")]
    [IsoId("_t-5Pw_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Returned payments derived from previously returned transactions are not allowed."
    )]
    ForbiddenReturnPayment,

    /// <summary>
    /// Agent in the payment workflow is incorrect
    /// Encoded/decoded by serializers as &quot;AGNT&quot;.
    /// </summary>
    [EnumMember(Value = "AGNT")]
    [IsoId("_t_DAwPRYEeuLhpyIdtJzwg")]
    [Description(@"Agent in the payment workflow is incorrect")]
    IncorrectAgent,

    /// <summary>
    /// Specified message amount is equal to zero
    /// Encoded/decoded by serializers as &quot;AM01&quot;.
    /// </summary>
    [EnumMember(Value = "AM01")]
    [IsoId("_t_DAw_RYEeuLhpyIdtJzwg")]
    [Description(@"Specified message amount is equal to zero")]
    ZeroAmount,

    /// <summary>
    /// Specific transaction/message amount is greater than allowed maximum
    /// Encoded/decoded by serializers as &quot;AM02&quot;.
    /// </summary>
    [EnumMember(Value = "AM02")]
    [IsoId("_t_DAxvRYEeuLhpyIdtJzwg")]
    [Description(@"Specific transaction/message amount is greater than allowed maximum")]
    NotAllowedAmount,

    /// <summary>
    /// Specified message amount is an non processable currency outside of existing agreement
    /// Encoded/decoded by serializers as &quot;AM03&quot;.
    /// </summary>
    [EnumMember(Value = "AM03")]
    [IsoId("_t_DAyfRYEeuLhpyIdtJzwg")]
    [Description(
        @"Specified message amount is an non processable currency outside of existing agreement"
    )]
    NotAllowedCurrency,

    /// <summary>
    /// Amount of funds available to cover specified message amount is insufficient.
    /// Encoded/decoded by serializers as &quot;AM04&quot;.
    /// </summary>
    [EnumMember(Value = "AM04")]
    [IsoId("_t_MxwPRYEeuLhpyIdtJzwg")]
    [Description(@"Amount of funds available to cover specified message amount is insufficient.")]
    InsufficientFunds,

    /// <summary>
    /// Duplication
    /// Encoded/decoded by serializers as &quot;AM05&quot;.
    /// </summary>
    [EnumMember(Value = "AM05")]
    [IsoId("_t_Mxw_RYEeuLhpyIdtJzwg")]
    [Description(@"Duplication")]
    Duplication,

    /// <summary>
    /// Specified transaction amount is less than agreed minimum.
    /// Encoded/decoded by serializers as &quot;AM06&quot;.
    /// </summary>
    [EnumMember(Value = "AM06")]
    [IsoId("_t_MxxvRYEeuLhpyIdtJzwg")]
    [Description(@"Specified transaction amount is less than agreed minimum.")]
    TooLowAmount,

    /// <summary>
    /// Amount specified in message has been blocked by regulatory authorities.
    /// Encoded/decoded by serializers as &quot;AM07&quot;.
    /// </summary>
    [EnumMember(Value = "AM07")]
    [IsoId("_t_V7sPRYEeuLhpyIdtJzwg")]
    [Description(@"Amount specified in message has been blocked by regulatory authorities.")]
    BlockedAmount,

    /// <summary>
    /// Amount received is not the amount agreed or expected
    /// Encoded/decoded by serializers as &quot;AM09&quot;.
    /// </summary>
    [EnumMember(Value = "AM09")]
    [IsoId("_t_V7s_RYEeuLhpyIdtJzwg")]
    [Description(@"Amount received is not the amount agreed or expected")]
    WrongAmount,

    /// <summary>
    /// Sum of instructed amounts does not equal the control sum.
    /// Encoded/decoded by serializers as &quot;AM10&quot;.
    /// </summary>
    [EnumMember(Value = "AM10")]
    [IsoId("_t_V7tvRYEeuLhpyIdtJzwg")]
    [Description(@"Sum of instructed amounts does not equal the control sum.")]
    InvalidControlSum,

    /// <summary>
    /// Transaction currency is invalid or missing
    /// Encoded/decoded by serializers as &quot;AM11&quot;.
    /// </summary>
    [EnumMember(Value = "AM11")]
    [IsoId("_t_V7ufRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction currency is invalid or missing")]
    InvalidTransactionCurrency,

    /// <summary>
    /// Amount is invalid or missing
    /// Encoded/decoded by serializers as &quot;AM12&quot;.
    /// </summary>
    [EnumMember(Value = "AM12")]
    [IsoId("_t_V7vPRYEeuLhpyIdtJzwg")]
    [Description(@"Amount is invalid or missing")]
    InvalidAmount,

    /// <summary>
    /// Transaction amount exceeds limits set by clearing system
    /// Encoded/decoded by serializers as &quot;AM13&quot;.
    /// </summary>
    [EnumMember(Value = "AM13")]
    [IsoId("_t_fssPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction amount exceeds limits set by clearing system")]
    AmountExceedsClearingSystemLimit,

    /// <summary>
    /// Transaction amount exceeds limits agreed between bank and client
    /// Encoded/decoded by serializers as &quot;AM14&quot;.
    /// </summary>
    [EnumMember(Value = "AM14")]
    [IsoId("_t_fss_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction amount exceeds limits agreed between bank and client")]
    AmountExceedsAgreedLimit,

    /// <summary>
    /// Transaction amount below minimum set by clearing system
    /// Encoded/decoded by serializers as &quot;AM15&quot;.
    /// </summary>
    [EnumMember(Value = "AM15")]
    [IsoId("_t_fstvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction amount below minimum set by clearing system")]
    AmountBelowClearingSystemMinimum,

    /// <summary>
    /// Control Sum at the Group level is invalid
    /// Encoded/decoded by serializers as &quot;AM16&quot;.
    /// </summary>
    [EnumMember(Value = "AM16")]
    [IsoId("_t_fsufRYEeuLhpyIdtJzwg")]
    [Description(@"Control Sum at the Group level is invalid")]
    InvalidGroupControlSum,

    /// <summary>
    /// Control Sum at the Payment Information level is invalid
    /// Encoded/decoded by serializers as &quot;AM17&quot;.
    /// </summary>
    [EnumMember(Value = "AM17")]
    [IsoId("_t_o2oPRYEeuLhpyIdtJzwg")]
    [Description(@"Control Sum at the Payment Information level is invalid")]
    InvalidPaymentInfoControlSum,

    /// <summary>
    /// Number of transactions is invalid or missing.|Generic usage if cannot specify between group and payment information levels.
    /// Encoded/decoded by serializers as &quot;AM18&quot;.
    /// </summary>
    [EnumMember(Value = "AM18")]
    [IsoId("_t_o2o_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Number of transactions is invalid or missing.|Generic usage if cannot specify between group and payment information levels."
    )]
    InvalidNumberOfTransactions,

    /// <summary>
    /// Number of transactions at the Group level is invalid or missing
    /// Encoded/decoded by serializers as &quot;AM19&quot;.
    /// </summary>
    [EnumMember(Value = "AM19")]
    [IsoId("_t_o2pvRYEeuLhpyIdtJzwg")]
    [Description(@"Number of transactions at the Group level is invalid or missing")]
    InvalidGroupNumberOfTransactions,

    /// <summary>
    /// Number of transactions at the Payment Information level is invalid
    /// Encoded/decoded by serializers as &quot;AM20&quot;.
    /// </summary>
    [EnumMember(Value = "AM20")]
    [IsoId("_t_ynoPRYEeuLhpyIdtJzwg")]
    [Description(@"Number of transactions at the Payment Information level is invalid")]
    InvalidPaymentInfoNumberOfTransactions,

    /// <summary>
    /// Transaction amount exceeds limits agreed between bank and client.
    /// Encoded/decoded by serializers as &quot;AM21&quot;.
    /// </summary>
    [EnumMember(Value = "AM21")]
    [IsoId("_t_yno_RYEeuLhpyIdtJzwg")]
    [Description(@"Transaction amount exceeds limits agreed between bank and client.")]
    LimitExceeded,

    /// <summary>
    /// Unable to apply zero amount to designated account. For example, where the rules of a service allow the use of zero amount payments, however the back-office system is unable to apply the funds to the account. If the rules of a service prohibit the use of zero amount payments, then code AM01 is used to report the error condition.
    /// Encoded/decoded by serializers as &quot;AM22&quot;.
    /// </summary>
    [EnumMember(Value = "AM22")]
    [IsoId("_t_ynpvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Unable to apply zero amount to designated account. For example, where the rules of a service allow the use of zero amount payments, however the back-office system is unable to apply the funds to the account. If the rules of a service prohibit the use of zero amount payments, then code AM01 is used to report the error condition."
    )]
    ZeroAmountNotApplied,

    /// <summary>
    /// Transaction amount exceeds settlement limit.
    /// Encoded/decoded by serializers as &quot;AM23&quot;.
    /// </summary>
    [EnumMember(Value = "AM23")]
    [IsoId("_t_ynqfRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction amount exceeds settlement limit.")]
    AmountExceedsSettlementLimit,

    /// <summary>
    /// Identification of end customer is not consistent with associated account number. (formerly CreditorConsistency).
    /// Encoded/decoded by serializers as &quot;BE01&quot;.
    /// </summary>
    [EnumMember(Value = "BE01")]
    [IsoId("_t_ynrPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Identification of end customer is not consistent with associated account number. (formerly CreditorConsistency)."
    )]
    InconsistenWithEndCustomer,

    /// <summary>
    /// Specification of creditor&apos;s address, which is required for payment, is missing/not correct (formerly IncorrectCreditorAddress).
    /// Encoded/decoded by serializers as &quot;BE04&quot;.
    /// </summary>
    [EnumMember(Value = "BE04")]
    [IsoId("_t_7xkPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Specification of creditor's address, which is required for payment, is missing/not correct (formerly IncorrectCreditorAddress)."
    )]
    MissingCreditorAddress,

    /// <summary>
    /// Party who initiated the message is not recognised by the end customer
    /// Encoded/decoded by serializers as &quot;BE05&quot;.
    /// </summary>
    [EnumMember(Value = "BE05")]
    [IsoId("_t_7xk_RYEeuLhpyIdtJzwg")]
    [Description(@"Party who initiated the message is not recognised by the end customer")]
    UnrecognisedInitiatingParty,

    /// <summary>
    /// End customer specified is not known at associated Sort/National Bank Code or does no longer exist in the books
    /// Encoded/decoded by serializers as &quot;BE06&quot;.
    /// </summary>
    [EnumMember(Value = "BE06")]
    [IsoId("_t_7xlvRYEeuLhpyIdtJzwg")]
    [Description(
        @"End customer specified is not known at associated Sort/National Bank Code or does no longer exist in the books"
    )]
    UnknownEndCustomer,

    /// <summary>
    /// Specification of debtor&apos;s address, which is required for payment, is missing/not correct.
    /// Encoded/decoded by serializers as &quot;BE07&quot;.
    /// </summary>
    [EnumMember(Value = "BE07")]
    [IsoId("_uAFikPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Specification of debtor's address, which is required for payment, is missing/not correct."
    )]
    MissingDebtorAddress,

    /// <summary>
    /// Debtor name is missing
    /// Encoded/decoded by serializers as &quot;BE08&quot;.
    /// </summary>
    [EnumMember(Value = "BE08")]
    [IsoId("_uAFik_RYEeuLhpyIdtJzwg")]
    [Description(@"Debtor name is missing")]
    MissingDebtorName,

    /// <summary>
    /// Country code is missing or Invalid.|Generic usage if cannot specifically identify debtor or creditor
    /// Encoded/decoded by serializers as &quot;BE09&quot;.
    /// </summary>
    [EnumMember(Value = "BE09")]
    [IsoId("_uAFilvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Country code is missing or Invalid.|Generic usage if cannot specifically identify debtor or creditor"
    )]
    InvalidCountry,

    /// <summary>
    /// Debtor country code is missing or invalid
    /// Encoded/decoded by serializers as &quot;BE10&quot;.
    /// </summary>
    [EnumMember(Value = "BE10")]
    [IsoId("_uAFimfRYEeuLhpyIdtJzwg")]
    [Description(@"Debtor country code is missing or invalid")]
    InvalidDebtorCountry,

    /// <summary>
    /// Creditor country code is missing or invalid
    /// Encoded/decoded by serializers as &quot;BE11&quot;.
    /// </summary>
    [EnumMember(Value = "BE11")]
    [IsoId("_uAPTkPRYEeuLhpyIdtJzwg")]
    [Description(@"Creditor country code is missing or invalid")]
    InvalidCreditorCountry,

    /// <summary>
    /// Country code of residence is missing or Invalid.|Generic usage if cannot specifically identify debtor or creditor
    /// Encoded/decoded by serializers as &quot;BE12&quot;.
    /// </summary>
    [EnumMember(Value = "BE12")]
    [IsoId("_uAPTk_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Country code of residence is missing or Invalid.|Generic usage if cannot specifically identify debtor or creditor"
    )]
    InvalidCountryOfResidence,

    /// <summary>
    /// Country code of debtor&apos;s residence is missing or Invalid
    /// Encoded/decoded by serializers as &quot;BE13&quot;.
    /// </summary>
    [EnumMember(Value = "BE13")]
    [IsoId("_uAPTlvRYEeuLhpyIdtJzwg")]
    [Description(@"Country code of debtor's residence is missing or Invalid")]
    InvalidDebtorCountryOfResidence,

    /// <summary>
    /// Country code of creditor&apos;s residence is missing or Invalid
    /// Encoded/decoded by serializers as &quot;BE14&quot;.
    /// </summary>
    [EnumMember(Value = "BE14")]
    [IsoId("_uAPTmfRYEeuLhpyIdtJzwg")]
    [Description(@"Country code of creditor's residence is missing or Invalid")]
    InvalidCreditorCountryOfResidence,

    /// <summary>
    /// Identification code missing or invalid.|Generic usage if cannot specifically identify debtor or creditor.
    /// Encoded/decoded by serializers as &quot;BE15&quot;.
    /// </summary>
    [EnumMember(Value = "BE15")]
    [IsoId("_uAPTnPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Identification code missing or invalid.|Generic usage if cannot specifically identify debtor or creditor."
    )]
    InvalidIdentificationCode,

    /// <summary>
    /// Debtor or Ultimate Debtor identification code missing or invalid
    /// Encoded/decoded by serializers as &quot;BE16&quot;.
    /// </summary>
    [EnumMember(Value = "BE16")]
    [IsoId("_uAYdgPRYEeuLhpyIdtJzwg")]
    [Description(@"Debtor or Ultimate Debtor identification code missing or invalid")]
    InvalidDebtorIdentificationCode,

    /// <summary>
    /// Creditor or Ultimate Creditor identification code missing or invalid
    /// Encoded/decoded by serializers as &quot;BE17&quot;.
    /// </summary>
    [EnumMember(Value = "BE17")]
    [IsoId("_uAYdg_RYEeuLhpyIdtJzwg")]
    [Description(@"Creditor or Ultimate Creditor identification code missing or invalid")]
    InvalidCreditorIdentificationCode,

    /// <summary>
    /// Contact details missing or invalid
    /// Encoded/decoded by serializers as &quot;BE18&quot;.
    /// </summary>
    [EnumMember(Value = "BE18")]
    [IsoId("_uAYdhvRYEeuLhpyIdtJzwg")]
    [Description(@"Contact details missing or invalid")]
    InvalidContactDetails,

    /// <summary>
    /// Charge bearer code for transaction type is invalid
    /// Encoded/decoded by serializers as &quot;BE19&quot;.
    /// </summary>
    [EnumMember(Value = "BE19")]
    [IsoId("_uAiOgPRYEeuLhpyIdtJzwg")]
    [Description(@"Charge bearer code for transaction type is invalid")]
    InvalidChargeBearerCode,

    /// <summary>
    /// Name length exceeds local rules for payment type.
    /// Encoded/decoded by serializers as &quot;BE20&quot;.
    /// </summary>
    [EnumMember(Value = "BE20")]
    [IsoId("_uAiOg_RYEeuLhpyIdtJzwg")]
    [Description(@"Name length exceeds local rules for payment type.")]
    InvalidNameLength,

    /// <summary>
    /// Name missing or invalid.  Generic usage if cannot specifically identify debtor or creditor.
    /// Encoded/decoded by serializers as &quot;BE21&quot;.
    /// </summary>
    [EnumMember(Value = "BE21")]
    [IsoId("_uAiOhvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Name missing or invalid.  Generic usage if cannot specifically identify debtor or creditor."
    )]
    MissingName,

    /// <summary>
    /// Creditor name is missing
    /// Encoded/decoded by serializers as &quot;BE22&quot;.
    /// </summary>
    [EnumMember(Value = "BE22")]
    [IsoId("_uAiOifRYEeuLhpyIdtJzwg")]
    [Description(@"Creditor name is missing")]
    MissingCreditorName,

    /// <summary>
    /// Phone number or email address, or any other proxy, used as the account proxy is unknown or invalid.
    /// Encoded/decoded by serializers as &quot;BE23&quot;.
    /// </summary>
    [EnumMember(Value = "BE23")]
    [IsoId("_uAr_gPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Phone number or email address, or any other proxy, used as the account proxy is unknown or invalid."
    )]
    AccountProxyInvalid,

    /// <summary>
    /// Credit transfer is not tagged as an Extended Remittance Information (ERI) transaction but contains ERI.
    /// Encoded/decoded by serializers as &quot;CERI&quot;.
    /// </summary>
    [EnumMember(Value = "CERI")]
    [IsoId("_uAr_g_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Credit transfer is not tagged as an Extended Remittance Information (ERI) transaction but contains ERI."
    )]
    CheckERI,

    /// <summary>
    /// Value in Requested Execution Date or Requested Collection Date is too far in the future
    /// Encoded/decoded by serializers as &quot;CH03&quot;.
    /// </summary>
    [EnumMember(Value = "CH03")]
    [IsoId("_uAr_hvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Value in Requested Execution Date or Requested Collection Date is too far in the future"
    )]
    RequestedExecutionDateOrRequestedCollectionDateTooFarInFuture,

    /// <summary>
    /// Value in Requested Execution Date or Requested Collection Date is too far in the past
    /// Encoded/decoded by serializers as &quot;CH04&quot;.
    /// </summary>
    [EnumMember(Value = "CH04")]
    [IsoId("_uAr_ifRYEeuLhpyIdtJzwg")]
    [Description(
        @"Value in Requested Execution Date or Requested Collection Date is too far in the past"
    )]
    RequestedExecutionDateOrRequestedCollectionDateTooFarInPast,

    /// <summary>
    /// Element is not to be used at B- and C-Level
    /// Encoded/decoded by serializers as &quot;CH07&quot;.
    /// </summary>
    [EnumMember(Value = "CH07")]
    [IsoId("_uA1JcPRYEeuLhpyIdtJzwg")]
    [Description(@"Element is not to be used at B- and C-Level")]
    ElementIsNotToBeUsedAtB_andC_Level,

    /// <summary>
    /// Mandate changes are not allowed
    /// Encoded/decoded by serializers as &quot;CH09&quot;.
    /// </summary>
    [EnumMember(Value = "CH09")]
    [IsoId("_uA1Jc_RYEeuLhpyIdtJzwg")]
    [Description(@"Mandate changes are not allowed")]
    MandateChangesNotAllowed,

    /// <summary>
    /// Information on mandate changes are missing
    /// Encoded/decoded by serializers as &quot;CH10&quot;.
    /// </summary>
    [EnumMember(Value = "CH10")]
    [IsoId("_uA1JdvRYEeuLhpyIdtJzwg")]
    [Description(@"Information on mandate changes are missing")]
    InformationOnMandateChangesMissing,

    /// <summary>
    /// Value in Creditor Identifier is incorrect
    /// Encoded/decoded by serializers as &quot;CH11&quot;.
    /// </summary>
    [EnumMember(Value = "CH11")]
    [IsoId("_uA-6cPRYEeuLhpyIdtJzwg")]
    [Description(@"Value in Creditor Identifier is incorrect")]
    CreditorIdentifierIncorrect,

    /// <summary>
    /// Creditor Identifier is ambiguous at Transaction Level
    /// Encoded/decoded by serializers as &quot;CH12&quot;.
    /// </summary>
    [EnumMember(Value = "CH12")]
    [IsoId("_uA-6c_RYEeuLhpyIdtJzwg")]
    [Description(@"Creditor Identifier is ambiguous at Transaction Level")]
    CreditorIdentifierNotUnambiguouslyAtTransaction_Level,

    /// <summary>
    /// Original Debtor Account is not to be used
    /// Encoded/decoded by serializers as &quot;CH13&quot;.
    /// </summary>
    [EnumMember(Value = "CH13")]
    [IsoId("_uA-6dvRYEeuLhpyIdtJzwg")]
    [Description(@"Original Debtor Account is not to be used")]
    OriginalDebtorAccountIsNotToBeUsed,

    /// <summary>
    /// Original Debtor Agent  is not to be used
    /// Encoded/decoded by serializers as &quot;CH14&quot;.
    /// </summary>
    [EnumMember(Value = "CH14")]
    [IsoId("_uA-6efRYEeuLhpyIdtJzwg")]
    [Description(@"Original Debtor Agent  is not to be used")]
    OriginalDebtorAgentIsNotToBeUsed,

    /// <summary>
    /// Content Remittance Information/Structured includes more than 140 characters
    /// Encoded/decoded by serializers as &quot;CH15&quot;.
    /// </summary>
    [EnumMember(Value = "CH15")]
    [IsoId("_uBIrcPRYEeuLhpyIdtJzwg")]
    [Description(@"Content Remittance Information/Structured includes more than 140 characters")]
    ElementContentIncludesMoreThan140Characters,

    /// <summary>
    /// Content is incorrect
    /// Encoded/decoded by serializers as &quot;CH16&quot;.
    /// </summary>
    [EnumMember(Value = "CH16")]
    [IsoId("_uBIrc_RYEeuLhpyIdtJzwg")]
    [Description(@"Content is incorrect")]
    ElementContentFormallyIncorrect,

    /// <summary>
    /// Element is not allowed
    /// Encoded/decoded by serializers as &quot;CH17&quot;.
    /// </summary>
    [EnumMember(Value = "CH17")]
    [IsoId("_uBIrdvRYEeuLhpyIdtJzwg")]
    [Description(@"Element is not allowed")]
    ElementNotAdmitted,

    /// <summary>
    /// Values in Interbank Settlement Date or Requested Collection Date will be set to the next TARGET day
    /// Encoded/decoded by serializers as &quot;CH19&quot;.
    /// </summary>
    [EnumMember(Value = "CH19")]
    [IsoId("_uBIrefRYEeuLhpyIdtJzwg")]
    [Description(
        @"Values in Interbank Settlement Date or Requested Collection Date will be set to the next TARGET day"
    )]
    ValuesWillBeSetToNextTARGETday,

    /// <summary>
    /// Number of decimal points not compatible with the currency
    /// Encoded/decoded by serializers as &quot;CH20&quot;.
    /// </summary>
    [EnumMember(Value = "CH20")]
    [IsoId("_uBIrfPRYEeuLhpyIdtJzwg")]
    [Description(@"Number of decimal points not compatible with the currency")]
    DecimalPointsNotCompatibleWithCurrency,

    /// <summary>
    /// Mandatory element is missing
    /// Encoded/decoded by serializers as &quot;CH21&quot;.
    /// </summary>
    [EnumMember(Value = "CH21")]
    [IsoId("_uBR1YPRYEeuLhpyIdtJzwg")]
    [Description(@"Mandatory element is missing ")]
    RequiredCompulsoryElementMissing,

    /// <summary>
    /// SDD CORE and B2B not permitted within one message
    /// Encoded/decoded by serializers as &quot;CH22&quot;.
    /// </summary>
    [EnumMember(Value = "CH22")]
    [IsoId("_uBR1Y_RYEeuLhpyIdtJzwg")]
    [Description(@"SDD CORE and B2B not permitted within one message ")]
    COREandB2BwithinOnemessage,

    /// <summary>
    /// Cheque has been presented in cheque clearing and settled on the creditor’s account.
    /// Encoded/decoded by serializers as &quot;CHQC&quot;.
    /// </summary>
    [EnumMember(Value = "CHQC")]
    [IsoId("_uBR1ZvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Cheque has been presented in cheque clearing and settled on the creditor’s account."
    )]
    ChequeSettledOnCreditorAccount,

    /// <summary>
    /// Creditor bank is not registered under this BIC in the CSM
    /// Encoded/decoded by serializers as &quot;CNOR&quot;.
    /// </summary>
    [EnumMember(Value = "CNOR")]
    [IsoId("_uBbmYPRYEeuLhpyIdtJzwg")]
    [Description(@"Creditor bank is not registered under this BIC in the CSM")]
    CreditorBankIsNotRegistered,

    /// <summary>
    /// Currency of the payment is incorrect
    /// Encoded/decoded by serializers as &quot;CURR&quot;.
    /// </summary>
    [EnumMember(Value = "CURR")]
    [IsoId("_uBbmY_RYEeuLhpyIdtJzwg")]
    [Description(@"Currency of the payment is incorrect")]
    IncorrectCurrency,

    /// <summary>
    /// Cancellation requested by the Debtor
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_uBbmZvRYEeuLhpyIdtJzwg")]
    [Description(@"Cancellation requested by the Debtor")]
    RequestedByCustomer,

    /// <summary>
    /// Debtor bank is not registered under this BIC in the CSM
    /// Encoded/decoded by serializers as &quot;DNOR&quot;.
    /// </summary>
    [EnumMember(Value = "DNOR")]
    [IsoId("_uBbmafRYEeuLhpyIdtJzwg")]
    [Description(@"Debtor bank is not registered under this BIC in the CSM")]
    DebtorBankIsNotRegistered,

    /// <summary>
    /// The electronic signature(s) is/are correct
    /// Encoded/decoded by serializers as &quot;DS01&quot;.
    /// </summary>
    [EnumMember(Value = "DS01")]
    [IsoId("_uBbmbPRYEeuLhpyIdtJzwg")]
    [Description(@"The electronic signature(s) is/are correct")]
    ElectronicSignaturesCorrect,

    /// <summary>
    /// An authorized user has cancelled the order
    /// Encoded/decoded by serializers as &quot;DS02&quot;.
    /// </summary>
    [EnumMember(Value = "DS02")]
    [IsoId("_uBlXYPRYEeuLhpyIdtJzwg")]
    [Description(@"An authorized user has cancelled the order")]
    OrderCancelled,

    /// <summary>
    /// The user’s attempt to cancel the order was not successful
    /// Encoded/decoded by serializers as &quot;DS03&quot;.
    /// </summary>
    [EnumMember(Value = "DS03")]
    [IsoId("_uBlXY_RYEeuLhpyIdtJzwg")]
    [Description(@"The user’s attempt to cancel the order was not successful ")]
    OrderNotCancelled,

    /// <summary>
    /// The order was rejected by the bank side (for reasons concerning content)
    /// Encoded/decoded by serializers as &quot;DS04&quot;.
    /// </summary>
    [EnumMember(Value = "DS04")]
    [IsoId("_uBuhUPRYEeuLhpyIdtJzwg")]
    [Description(@"The order was rejected by the bank side (for reasons concerning content)")]
    OrderRejected,

    /// <summary>
    /// The order was correct and could be forwarded for postprocessing
    /// Encoded/decoded by serializers as &quot;DS05&quot;.
    /// </summary>
    [EnumMember(Value = "DS05")]
    [IsoId("_uBuhU_RYEeuLhpyIdtJzwg")]
    [Description(@"The order was correct and could be forwarded for postprocessing")]
    OrderForwardedForPostprocessing,

    /// <summary>
    /// The order was transferred to VEU
    /// Encoded/decoded by serializers as &quot;DS06&quot;.
    /// </summary>
    [EnumMember(Value = "DS06")]
    [IsoId("_uBuhVvRYEeuLhpyIdtJzwg")]
    [Description(@"The order was transferred to VEU")]
    TransferOrder,

    /// <summary>
    /// All actions concerning the order could be done by the EBICS bank server
    /// Encoded/decoded by serializers as &quot;DS07&quot;.
    /// </summary>
    [EnumMember(Value = "DS07")]
    [IsoId("_uBuhWfRYEeuLhpyIdtJzwg")]
    [Description(@"All actions concerning the order could be done by the EBICS bank server")]
    ProcessingOK,

    /// <summary>
    /// The decompression of the file was not successful
    /// Encoded/decoded by serializers as &quot;DS08&quot;.
    /// </summary>
    [EnumMember(Value = "DS08")]
    [IsoId("_uB4SUPRYEeuLhpyIdtJzwg")]
    [Description(@"The decompression of the file was not successful")]
    DecompressionError,

    /// <summary>
    /// The decryption of the file was not successful
    /// Encoded/decoded by serializers as &quot;DS09&quot;.
    /// </summary>
    [EnumMember(Value = "DS09")]
    [IsoId("_uB4SU_RYEeuLhpyIdtJzwg")]
    [Description(@"The decryption of the file was not successful")]
    DecryptionError,

    /// <summary>
    /// Data signature is required.
    /// Encoded/decoded by serializers as &quot;DS0A&quot;.
    /// </summary>
    [EnumMember(Value = "DS0A")]
    [IsoId("_uB4SVvRYEeuLhpyIdtJzwg")]
    [Description(@"Data signature is required.")]
    DataSignRequested,

    /// <summary>
    /// Data signature for the format is not available or invalid.
    /// Encoded/decoded by serializers as &quot;DS0B&quot;.
    /// </summary>
    [EnumMember(Value = "DS0B")]
    [IsoId("_uB4SWfRYEeuLhpyIdtJzwg")]
    [Description(@"Data signature for the format is not available or invalid.")]
    UnknownDataSignFormat,

    /// <summary>
    /// The signer certificate is revoked.
    /// Encoded/decoded by serializers as &quot;DS0C&quot;.
    /// </summary>
    [EnumMember(Value = "DS0C")]
    [IsoId("_uB4SXPRYEeuLhpyIdtJzwg")]
    [Description(@"The signer certificate is revoked.")]
    SignerCertificateRevoked,

    /// <summary>
    /// The signer certificate is not valid (revoked or not active).
    /// Encoded/decoded by serializers as &quot;DS0D&quot;.
    /// </summary>
    [EnumMember(Value = "DS0D")]
    [IsoId("_uCBcQPRYEeuLhpyIdtJzwg")]
    [Description(@"The signer certificate is not valid (revoked or not active).")]
    SignerCertificateNotValid,

    /// <summary>
    /// The signer certificate is not present.
    /// Encoded/decoded by serializers as &quot;DS0E&quot;.
    /// </summary>
    [EnumMember(Value = "DS0E")]
    [IsoId("_uCBcQ_RYEeuLhpyIdtJzwg")]
    [Description(@"The signer certificate is not present.")]
    IncorrectSignerCertificate,

    /// <summary>
    /// The authority of the signer certification sending the certificate is unknown.
    /// Encoded/decoded by serializers as &quot;DS0F&quot;.
    /// </summary>
    [EnumMember(Value = "DS0F")]
    [IsoId("_uCBcRvRYEeuLhpyIdtJzwg")]
    [Description(@"The authority of the signer certification sending the certificate is unknown.")]
    SignerCertificationAuthoritySignerNotValid,

    /// <summary>
    /// Signer is not allowed to sign this operation type.
    /// Encoded/decoded by serializers as &quot;DS0G&quot;.
    /// </summary>
    [EnumMember(Value = "DS0G")]
    [IsoId("_uCLNQPRYEeuLhpyIdtJzwg")]
    [Description(@"Signer is not allowed to sign this operation type.")]
    NotAllowedPayment,

    /// <summary>
    /// Signer is not allowed to sign for this account.
    /// Encoded/decoded by serializers as &quot;DS0H&quot;.
    /// </summary>
    [EnumMember(Value = "DS0H")]
    [IsoId("_uCLNQ_RYEeuLhpyIdtJzwg")]
    [Description(@"Signer is not allowed to sign for this account.")]
    NotAllowedAccount,

    /// <summary>
    /// The number of transaction is over the number allowed for this signer.
    /// Encoded/decoded by serializers as &quot;DS0K&quot;.
    /// </summary>
    [EnumMember(Value = "DS0K")]
    [IsoId("_uCLNRvRYEeuLhpyIdtJzwg")]
    [Description(@"The number of transaction is over the number allowed for this signer.")]
    NotAllowedNumberOfTransaction,

    /// <summary>
    /// The certificate is revoked for the first signer.
    /// Encoded/decoded by serializers as &quot;DS10&quot;.
    /// </summary>
    [EnumMember(Value = "DS10")]
    [IsoId("_uCLNSfRYEeuLhpyIdtJzwg")]
    [Description(@"The certificate is revoked for the first signer.")]
    Signer1CertificateRevoked,

    /// <summary>
    /// The certificate is not valid (revoked or not active) for the first signer.
    /// Encoded/decoded by serializers as &quot;DS11&quot;.
    /// </summary>
    [EnumMember(Value = "DS11")]
    [IsoId("_uCU-QPRYEeuLhpyIdtJzwg")]
    [Description(@"The certificate is not valid (revoked or not active) for the first signer.")]
    Signer1CertificateNotValid,

    /// <summary>
    /// The certificate is not present for the first signer.
    /// Encoded/decoded by serializers as &quot;DS12&quot;.
    /// </summary>
    [EnumMember(Value = "DS12")]
    [IsoId("_uCU-Q_RYEeuLhpyIdtJzwg")]
    [Description(@"The certificate is not present for the first signer.")]
    IncorrectSigner1Certificate,

    /// <summary>
    /// The authority of signer certification sending the certificate is unknown for the first signer.
    /// Encoded/decoded by serializers as &quot;DS13&quot;.
    /// </summary>
    [EnumMember(Value = "DS13")]
    [IsoId("_uCU-RvRYEeuLhpyIdtJzwg")]
    [Description(
        @"The authority of signer certification sending the certificate is unknown for the first signer."
    )]
    SignerCertificationAuthoritySigner1NotValid,

    /// <summary>
    /// The user is unknown on the server
    /// Encoded/decoded by serializers as &quot;DS14&quot;.
    /// </summary>
    [EnumMember(Value = "DS14")]
    [IsoId("_uCeIMPRYEeuLhpyIdtJzwg")]
    [Description(@"The user is unknown on the server")]
    UserDoesNotExist,

    /// <summary>
    /// The same signature has already been sent to the bank
    /// Encoded/decoded by serializers as &quot;DS15&quot;.
    /// </summary>
    [EnumMember(Value = "DS15")]
    [IsoId("_uCeIM_RYEeuLhpyIdtJzwg")]
    [Description(@"The same signature has already been sent to the bank")]
    IdenticalSignatureFound,

    /// <summary>
    /// The public key version is not correct. This code is returned when a customer sends signature files to the financial institution after conversion from an older program version (old ES format) to a new program version (new ES format) without having carried out re-initialisation with regard to a public key change.
    /// Encoded/decoded by serializers as &quot;DS16&quot;.
    /// </summary>
    [EnumMember(Value = "DS16")]
    [IsoId("_uCeINvRYEeuLhpyIdtJzwg")]
    [Description(
        @"The public key version is not correct. This code is returned when a customer sends signature files to the financial institution after conversion from an older program version (old ES format) to a new program version (new ES format) without having carried out re-initialisation with regard to a public key change."
    )]
    PublicKeyVersionIncorrect,

    /// <summary>
    /// Order data and signatures don’t match
    /// Encoded/decoded by serializers as &quot;DS17&quot;.
    /// </summary>
    [EnumMember(Value = "DS17")]
    [IsoId("_uCeIOfRYEeuLhpyIdtJzwg")]
    [Description(@"Order data and signatures don’t match")]
    DifferentOrderDataInSignatures,

    /// <summary>
    /// File cannot be tested, the complete order has to be repeated. This code is returned in the event of a malfunction during the signature check, e.g. not enough storage space.
    /// Encoded/decoded by serializers as &quot;DS18&quot;.
    /// </summary>
    [EnumMember(Value = "DS18")]
    [IsoId("_uCn5MPRYEeuLhpyIdtJzwg")]
    [Description(
        @"File cannot be tested, the complete order has to be repeated. This code is returned in the event of a malfunction during the signature check, e.g. not enough storage space."
    )]
    RepeatOrder,

    /// <summary>
    /// The user’s rights (concerning his signature) are insufficient to execute the order
    /// Encoded/decoded by serializers as &quot;DS19&quot;.
    /// </summary>
    [EnumMember(Value = "DS19")]
    [IsoId("_uCn5M_RYEeuLhpyIdtJzwg")]
    [Description(
        @"The user’s rights (concerning his signature) are insufficient to execute the order"
    )]
    ElectronicSignatureRightsInsufficient,

    /// <summary>
    /// The certificate is revoked for the second signer.
    /// Encoded/decoded by serializers as &quot;DS20&quot;.
    /// </summary>
    [EnumMember(Value = "DS20")]
    [IsoId("_uCn5NvRYEeuLhpyIdtJzwg")]
    [Description(@"The certificate is revoked for the second signer.")]
    Signer2CertificateRevoked,

    /// <summary>
    /// The certificate is not valid (revoked or not active) for the second signer.
    /// Encoded/decoded by serializers as &quot;DS21&quot;.
    /// </summary>
    [EnumMember(Value = "DS21")]
    [IsoId("_uCn5OfRYEeuLhpyIdtJzwg")]
    [Description(@"The certificate is not valid (revoked or not active) for the second signer.")]
    Signer2CertificateNotValid,

    /// <summary>
    /// The certificate is not present for the second signer.
    /// Encoded/decoded by serializers as &quot;DS22&quot;.
    /// </summary>
    [EnumMember(Value = "DS22")]
    [IsoId("_uCxqMPRYEeuLhpyIdtJzwg")]
    [Description(@"The certificate is not present for the second signer.")]
    IncorrectSigner2Certificate,

    /// <summary>
    /// The authority of signer certification sending the certificate is unknown for the second signer.
    /// Encoded/decoded by serializers as &quot;DS23&quot;.
    /// </summary>
    [EnumMember(Value = "DS23")]
    [IsoId("_uCxqM_RYEeuLhpyIdtJzwg")]
    [Description(
        @"The authority of signer certification sending the certificate is unknown for the second signer."
    )]
    SignerCertificationAuthoritySigner2NotValid,

    /// <summary>
    /// Waiting time expired due to incomplete order
    /// Encoded/decoded by serializers as &quot;DS24&quot;.
    /// </summary>
    [EnumMember(Value = "DS24")]
    [IsoId("_uCxqNvRYEeuLhpyIdtJzwg")]
    [Description(@"Waiting time expired due to incomplete order")]
    WaitingTimeExpired,

    /// <summary>
    /// The order file was deleted by the bank server |(for multiple reasons)
    /// Encoded/decoded by serializers as &quot;DS25&quot;.
    /// </summary>
    [EnumMember(Value = "DS25")]
    [IsoId("_uCxqOfRYEeuLhpyIdtJzwg")]
    [Description(@"The order file was deleted by the bank server |(for multiple reasons)")]
    OrderFileDeleted,

    /// <summary>
    /// The same user has signed multiple times
    /// Encoded/decoded by serializers as &quot;DS26&quot;.
    /// </summary>
    [EnumMember(Value = "DS26")]
    [IsoId("_uCxqPPRYEeuLhpyIdtJzwg")]
    [Description(@"The same user has signed multiple times")]
    UserSignedMultipleTimes,

    /// <summary>
    /// The user is not yet activated (technically)
    /// Encoded/decoded by serializers as &quot;DS27&quot;.
    /// </summary>
    [EnumMember(Value = "DS27")]
    [IsoId("_uC60IPRYEeuLhpyIdtJzwg")]
    [Description(@"The user is not yet activated (technically)")]
    UserNotYetActivated,

    /// <summary>
    /// Invalid date (eg, wrong or missing settlement date)
    /// Encoded/decoded by serializers as &quot;DT01&quot;.
    /// </summary>
    [EnumMember(Value = "DT01")]
    [IsoId("_uC60I_RYEeuLhpyIdtJzwg")]
    [Description(@"Invalid date (eg, wrong or missing settlement date)")]
    InvalidDate,

    /// <summary>
    /// Invalid creation date and time in Group Header (eg, historic date)
    /// Encoded/decoded by serializers as &quot;DT02&quot;.
    /// </summary>
    [EnumMember(Value = "DT02")]
    [IsoId("_uC60JvRYEeuLhpyIdtJzwg")]
    [Description(@"Invalid creation date and time in Group Header (eg, historic date)")]
    InvalidCreationDate,

    /// <summary>
    /// Invalid non bank processing date (eg, weekend or local public holiday)
    /// Encoded/decoded by serializers as &quot;DT03&quot;.
    /// </summary>
    [EnumMember(Value = "DT03")]
    [IsoId("_uC60KfRYEeuLhpyIdtJzwg")]
    [Description(@"Invalid non bank processing date (eg, weekend or local public holiday)")]
    InvalidNonProcessingDate,

    /// <summary>
    /// Future date not supported
    /// Encoded/decoded by serializers as &quot;DT04&quot;.
    /// </summary>
    [EnumMember(Value = "DT04")]
    [IsoId("_uC60LPRYEeuLhpyIdtJzwg")]
    [Description(@"Future date not supported")]
    FutureDateNotSupported,

    /// <summary>
    /// Associated message, payment information block or transaction was received after agreed processing cut-off date, i.e., date in the past.
    /// Encoded/decoded by serializers as &quot;DT05&quot;.
    /// </summary>
    [EnumMember(Value = "DT05")]
    [IsoId("_uDElIPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Associated message, payment information block or transaction was received after agreed processing cut-off date, i.e., date in the past."
    )]
    InvalidCutOffDate,

    /// <summary>
    /// Execution Date has been modified in order for transaction to be processed
    /// Encoded/decoded by serializers as &quot;DT06&quot;.
    /// </summary>
    [EnumMember(Value = "DT06")]
    [IsoId("_uDElI_RYEeuLhpyIdtJzwg")]
    [Description(@"Execution Date has been modified in order for transaction to be processed")]
    ExecutionDateChanged,

    /// <summary>
    /// Message Identification is not unique.
    /// Encoded/decoded by serializers as &quot;DU01&quot;.
    /// </summary>
    [EnumMember(Value = "DU01")]
    [IsoId("_uDElJvRYEeuLhpyIdtJzwg")]
    [Description(@"Message Identification is not unique.")]
    DuplicateMessageID,

    /// <summary>
    /// Payment Information Block is not unique.
    /// Encoded/decoded by serializers as &quot;DU02&quot;.
    /// </summary>
    [EnumMember(Value = "DU02")]
    [IsoId("_uDElKfRYEeuLhpyIdtJzwg")]
    [Description(@"Payment Information Block is not unique.")]
    DuplicatePaymentInformationID,

    /// <summary>
    /// Transaction is not unique.
    /// Encoded/decoded by serializers as &quot;DU03&quot;.
    /// </summary>
    [EnumMember(Value = "DU03")]
    [IsoId("_uDElLPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction is not unique.")]
    DuplicateTransaction,

    /// <summary>
    /// End To End ID is not unique.
    /// Encoded/decoded by serializers as &quot;DU04&quot;.
    /// </summary>
    [EnumMember(Value = "DU04")]
    [IsoId("_uDNvEPRYEeuLhpyIdtJzwg")]
    [Description(@"End To End ID is not unique.")]
    DuplicateEndToEndID,

    /// <summary>
    /// Instruction ID is not unique.
    /// Encoded/decoded by serializers as &quot;DU05&quot;.
    /// </summary>
    [EnumMember(Value = "DU05")]
    [IsoId("_uDNvE_RYEeuLhpyIdtJzwg")]
    [Description(@"Instruction ID is not unique.")]
    DuplicateInstructionID,

    /// <summary>
    /// Payment is a duplicate of another payment
    /// Encoded/decoded by serializers as &quot;DUPL&quot;.
    /// </summary>
    [EnumMember(Value = "DUPL")]
    [IsoId("_uDNvFvRYEeuLhpyIdtJzwg")]
    [Description(@"Payment is a duplicate of another payment")]
    DuplicatePayment,

    /// <summary>
    /// Correspondent bank not possible.
    /// Encoded/decoded by serializers as &quot;ED01&quot;.
    /// </summary>
    [EnumMember(Value = "ED01")]
    [IsoId("_uDXgEPRYEeuLhpyIdtJzwg")]
    [Description(@"Correspondent bank not possible.")]
    CorrespondentBankNotPossible,

    /// <summary>
    /// Balance of payments complementary info is requested
    /// Encoded/decoded by serializers as &quot;ED03&quot;.
    /// </summary>
    [EnumMember(Value = "ED03")]
    [IsoId("_uDXgE_RYEeuLhpyIdtJzwg")]
    [Description(@"Balance of payments complementary info is requested")]
    BalanceInfoRequest,

    /// <summary>
    /// Settlement of the transaction has failed.
    /// Encoded/decoded by serializers as &quot;ED05&quot;.
    /// </summary>
    [EnumMember(Value = "ED05")]
    [IsoId("_uDXgFvRYEeuLhpyIdtJzwg")]
    [Description(@"Settlement of the transaction has failed.")]
    SettlementFailed,

    /// <summary>
    /// Interbank settlement system not available.
    /// Encoded/decoded by serializers as &quot;ED06&quot;.
    /// </summary>
    [EnumMember(Value = "ED06")]
    [IsoId("_uDXgGfRYEeuLhpyIdtJzwg")]
    [Description(@"Interbank settlement system not available.")]
    SettlementSystemNotAvailable,

    /// <summary>
    /// Extended Remittance Information (ERI) option is not supported.
    /// Encoded/decoded by serializers as &quot;ERIN&quot;.
    /// </summary>
    [EnumMember(Value = "ERIN")]
    [IsoId("_uDgqAPRYEeuLhpyIdtJzwg")]
    [Description(@"Extended Remittance Information (ERI) option is not supported.")]
    ERIOptionNotSupported,

    /// <summary>
    /// File Format incomplete or invalid
    /// Encoded/decoded by serializers as &quot;FF01&quot;.
    /// </summary>
    [EnumMember(Value = "FF01")]
    [IsoId("_uDgqA_RYEeuLhpyIdtJzwg")]
    [Description(@"File Format incomplete or invalid")]
    InvalidFileFormat,

    /// <summary>
    /// Syntax error reason is provided as narrative information in the additional reason information.
    /// Encoded/decoded by serializers as &quot;FF02&quot;.
    /// </summary>
    [EnumMember(Value = "FF02")]
    [IsoId("_uDgqBvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Syntax error reason is provided as narrative information in the additional reason information."
    )]
    SyntaxError,

    /// <summary>
    /// Payment Type Information is missing or invalid.|Generic usage if cannot specify Service Level or Local Instrument code
    /// Encoded/decoded by serializers as &quot;FF03&quot;.
    /// </summary>
    [EnumMember(Value = "FF03")]
    [IsoId("_uDqbAPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Payment Type Information is missing or invalid.|Generic usage if cannot specify Service Level or Local Instrument code"
    )]
    InvalidPaymentTypeInformation,

    /// <summary>
    /// Service Level code is missing or invalid
    /// Encoded/decoded by serializers as &quot;FF04&quot;.
    /// </summary>
    [EnumMember(Value = "FF04")]
    [IsoId("_uDqbA_RYEeuLhpyIdtJzwg")]
    [Description(@"Service Level code is missing or invalid")]
    InvalidServiceLevelCode,

    /// <summary>
    /// Local Instrument code is missing or invalid
    /// Encoded/decoded by serializers as &quot;FF05&quot;.
    /// </summary>
    [EnumMember(Value = "FF05")]
    [IsoId("_uD0MAPRYEeuLhpyIdtJzwg")]
    [Description(@"Local Instrument code is missing or invalid")]
    InvalidLocalInstrumentCode,

    /// <summary>
    /// Category Purpose code is missing or invalid
    /// Encoded/decoded by serializers as &quot;FF06&quot;.
    /// </summary>
    [EnumMember(Value = "FF06")]
    [IsoId("_uD0MA_RYEeuLhpyIdtJzwg")]
    [Description(@"Category Purpose code is missing or invalid")]
    InvalidCategoryPurposeCode,

    /// <summary>
    /// Purpose is missing or invalid
    /// Encoded/decoded by serializers as &quot;FF07&quot;.
    /// </summary>
    [EnumMember(Value = "FF07")]
    [IsoId("_uD0MBvRYEeuLhpyIdtJzwg")]
    [Description(@"Purpose is missing or invalid")]
    InvalidPurpose,

    /// <summary>
    /// End to End Id missing or invalid
    /// Encoded/decoded by serializers as &quot;FF08&quot;.
    /// </summary>
    [EnumMember(Value = "FF08")]
    [IsoId("_uD0MCfRYEeuLhpyIdtJzwg")]
    [Description(@"End to End Id missing or invalid")]
    InvalidEndToEndId,

    /// <summary>
    /// Cheque number missing or invalid
    /// Encoded/decoded by serializers as &quot;FF09&quot;.
    /// </summary>
    [EnumMember(Value = "FF09")]
    [IsoId("_uD0MDPRYEeuLhpyIdtJzwg")]
    [Description(@"Cheque number missing or invalid")]
    InvalidChequeNumber,

    /// <summary>
    /// File or transaction cannot be processed due to technical issues at the bank side
    /// Encoded/decoded by serializers as &quot;FF10&quot;.
    /// </summary>
    [EnumMember(Value = "FF10")]
    [IsoId("_uD9V8PRYEeuLhpyIdtJzwg")]
    [Description(
        @"File or transaction cannot be processed due to technical issues at the bank side"
    )]
    BankSystemProcessingError,

    /// <summary>
    /// Clearing request rejected due it being subject to an abort operation.
    /// Encoded/decoded by serializers as &quot;FF11&quot;.
    /// </summary>
    [EnumMember(Value = "FF11")]
    [IsoId("_uD9V8_RYEeuLhpyIdtJzwg")]
    [Description(@"Clearing request rejected due it being subject to an abort operation.")]
    ClearingRequestAborted,

    /// <summary>
    /// In an FI To FI Customer Credit Transfer: The Status Originator transferred the payment to the next Agent or to a Market Infrastructure. The payment transfer is tracked. No further updates will follow from the Status Originator.||In a Financial Institution Credit Transfer with cover: The Status Originator performed the account booking and transferred the cover transaction to the next Reimbursement Agent or to a Market Infrastructure. The payment transfer is tracked. No further updates will follow from the Status Originator.|
    /// Encoded/decoded by serializers as &quot;G000&quot;.
    /// </summary>
    [EnumMember(Value = "G000")]
    [IsoId("_uD9V9vRYEeuLhpyIdtJzwg")]
    [Description(
        @"In an FI To FI Customer Credit Transfer: The Status Originator transferred the payment to the next Agent or to a Market Infrastructure. The payment transfer is tracked. No further updates will follow from the Status Originator.||In a Financial Institution Credit Transfer with cover: The Status Originator performed the account booking and transferred the cover transaction to the next Reimbursement Agent or to a Market Infrastructure. The payment transfer is tracked. No further updates will follow from the Status Originator.|"
    )]
    PaymentTransferredAndTracked,

    /// <summary>
    /// In an FI To FI Customer Credit Transfer: The Status Originator transferred the payment to the next Agent or to a Market Infrastructure. The payment transfer is not tracked. No further updates will follow from the Status Originator.||In a Financial Institution Credit Transfer with cover: The Status Originator performed the account booking and transferred the cover transaction to the next Reimbursement Agent or to a Market Infrastructure. The payment transfer is not tracked. No further updates will follow from the Status Originator.|
    /// Encoded/decoded by serializers as &quot;G001&quot;.
    /// </summary>
    [EnumMember(Value = "G001")]
    [IsoId("_uEHG8PRYEeuLhpyIdtJzwg")]
    [Description(
        @"In an FI To FI Customer Credit Transfer: The Status Originator transferred the payment to the next Agent or to a Market Infrastructure. The payment transfer is not tracked. No further updates will follow from the Status Originator.||In a Financial Institution Credit Transfer with cover: The Status Originator performed the account booking and transferred the cover transaction to the next Reimbursement Agent or to a Market Infrastructure. The payment transfer is not tracked. No further updates will follow from the Status Originator.|"
    )]
    PaymentTransferredAndNotTracked,

    /// <summary>
    /// In a FIToFI Customer Credit Transfer: Credit to the creditor’s account may not be confirmed same day. Update will follow from the Status Originator.|In a Financial Institution Credit Transfer with cover: Debit/credit to nostro account may not be confirmed same day or Financial Institution Credit Transfer may not be transferred same day. Update will follow from the Status Originator.
    /// Encoded/decoded by serializers as &quot;G002&quot;.
    /// </summary>
    [EnumMember(Value = "G002")]
    [IsoId("_uEHG8_RYEeuLhpyIdtJzwg")]
    [Description(
        @"In a FIToFI Customer Credit Transfer: Credit to the creditor’s account may not be confirmed same day. Update will follow from the Status Originator.|In a Financial Institution Credit Transfer with cover: Debit/credit to nostro account may not be confirmed same day or Financial Institution Credit Transfer may not be transferred same day. Update will follow from the Status Originator."
    )]
    CreditDebitNotConfirmed,

    /// <summary>
    /// In a FIToFI Customer Credit Transfer: Credit to creditor’s account is pending receipt of required documents. The Status Originator has requested creditor to provide additional documentation. Update will follow from the Status Originator. |In a Financial Institution Credit Transfer with cover: Status Originator has requested a previous Agent to provide additional information/correct information. Update will follow from the Status Originator.
    /// Encoded/decoded by serializers as &quot;G003&quot;.
    /// </summary>
    [EnumMember(Value = "G003")]
    [IsoId("_uEHG9vRYEeuLhpyIdtJzwg")]
    [Description(
        @"In a FIToFI Customer Credit Transfer: Credit to creditor’s account is pending receipt of required documents. The Status Originator has requested creditor to provide additional documentation. Update will follow from the Status Originator. |In a Financial Institution Credit Transfer with cover: Status Originator has requested a previous Agent to provide additional information/correct information. Update will follow from the Status Originator."
    )]
    CreditPendingDocuments,

    /// <summary>
    /// In a FIToFI Customer Credit Transfer: Credit to the creditor’s account is pending, status Originator is waiting for funds provided via a cover. Update will follow from the Status Originator.
    /// Encoded/decoded by serializers as &quot;G004&quot;.
    /// </summary>
    [EnumMember(Value = "G004")]
    [IsoId("_uEQQ4PRYEeuLhpyIdtJzwg")]
    [Description(
        @"In a FIToFI Customer Credit Transfer: Credit to the creditor’s account is pending, status Originator is waiting for funds provided via a cover. Update will follow from the Status Originator."
    )]
    CreditPendingFunds,

    /// <summary>
    /// Payment has been delivered to creditor agent with service level.
    /// Encoded/decoded by serializers as &quot;G005&quot;.
    /// </summary>
    [EnumMember(Value = "G005")]
    [IsoId("_uEQQ4_RYEeuLhpyIdtJzwg")]
    [Description(@"Payment has been delivered to creditor agent with service level.")]
    DeliveredWithServiceLevel,

    /// <summary>
    /// Payment has been delivered to creditor agent without service level.
    /// Encoded/decoded by serializers as &quot;G006&quot;.
    /// </summary>
    [EnumMember(Value = "G006")]
    [IsoId("_uEQQ5vRYEeuLhpyIdtJzwg")]
    [Description(@"Payment has been delivered to creditor agent without service level.")]
    DeliveredWIthoutServiceLevel,

    /// <summary>
    /// Signature file was sent to the bank but the corresponding original file has not been sent yet.
    /// Encoded/decoded by serializers as &quot;ID01&quot;.
    /// </summary>
    [EnumMember(Value = "ID01")]
    [IsoId("_uEaB4PRYEeuLhpyIdtJzwg")]
    [Description(
        @"Signature file was sent to the bank but the corresponding original file has not been sent yet."
    )]
    CorrespondingOriginalFileStillNotSent,

    /// <summary>
    /// No Mandate
    /// Encoded/decoded by serializers as &quot;MD01&quot;.
    /// </summary>
    [EnumMember(Value = "MD01")]
    [IsoId("_uEaB4_RYEeuLhpyIdtJzwg")]
    [Description(@"No Mandate")]
    NoMandate,

    /// <summary>
    /// Mandate related information data required by the scheme is missing.
    /// Encoded/decoded by serializers as &quot;MD02&quot;.
    /// </summary>
    [EnumMember(Value = "MD02")]
    [IsoId("_uEaB5vRYEeuLhpyIdtJzwg")]
    [Description(@"Mandate related information data required by the scheme is missing.")]
    MissingMandatoryInformationInMandate,

    /// <summary>
    /// Creditor or creditor&apos;s agent should not have collected the direct debit
    /// Encoded/decoded by serializers as &quot;MD05&quot;.
    /// </summary>
    [EnumMember(Value = "MD05")]
    [IsoId("_uEaB6fRYEeuLhpyIdtJzwg")]
    [Description(@"Creditor or creditor's agent should not have collected the direct debit")]
    CollectionNotDue,

    /// <summary>
    /// Return of funds requested by end customer
    /// Encoded/decoded by serializers as &quot;MD06&quot;.
    /// </summary>
    [EnumMember(Value = "MD06")]
    [IsoId("_uEaB7PRYEeuLhpyIdtJzwg")]
    [Description(@"Return of funds requested by end customer")]
    RefundRequestByEndCustomer,

    /// <summary>
    /// End customer is deceased.
    /// Encoded/decoded by serializers as &quot;MD07&quot;.
    /// </summary>
    [EnumMember(Value = "MD07")]
    [IsoId("_uEjy4PRYEeuLhpyIdtJzwg")]
    [Description(@"End customer is deceased.")]
    EndCustomerDeceased,

    /// <summary>
    /// Reason has not been specified by end customer
    /// Encoded/decoded by serializers as &quot;MS02&quot;.
    /// </summary>
    [EnumMember(Value = "MS02")]
    [IsoId("_uEjy4_RYEeuLhpyIdtJzwg")]
    [Description(@"Reason has not been specified by end customer")]
    NotSpecifiedReasonCustomerGenerated,

    /// <summary>
    /// Reason has not been specified by agent.
    /// Encoded/decoded by serializers as &quot;MS03&quot;.
    /// </summary>
    [EnumMember(Value = "MS03")]
    [IsoId("_uEjy5vRYEeuLhpyIdtJzwg")]
    [Description(@"Reason has not been specified by agent.")]
    NotSpecifiedReasonAgentGenerated,

    /// <summary>
    /// Reason is provided as narrative information in the additional reason information.
    /// Encoded/decoded by serializers as &quot;NARR&quot;.
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("_uEs80PRYEeuLhpyIdtJzwg")]
    [Description(
        @"Reason is provided as narrative information in the additional reason information."
    )]
    Narrative,

    /// <summary>
    /// Credit transfer is tagged as an Extended Remittance Information (ERI) transaction but does not contain ERI.
    /// Encoded/decoded by serializers as &quot;NERI&quot;.
    /// </summary>
    [EnumMember(Value = "NERI")]
    [IsoId("_uEs80_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Credit transfer is tagged as an Extended Remittance Information (ERI) transaction but does not contain ERI."
    )]
    NoERI,

    /// <summary>
    /// Bank identifier code specified in the message has an incorrect format (formerly IncorrectFormatForRoutingCode).
    /// Encoded/decoded by serializers as &quot;RC01&quot;.
    /// </summary>
    [EnumMember(Value = "RC01")]
    [IsoId("_uEs81vRYEeuLhpyIdtJzwg")]
    [Description(
        @"Bank identifier code specified in the message has an incorrect format (formerly IncorrectFormatForRoutingCode)."
    )]
    BankIdentifierIncorrect,

    /// <summary>
    /// Bank identifier is invalid or missing.|Generic usage if cannot specify between debit or credit account
    /// Encoded/decoded by serializers as &quot;RC02&quot;.
    /// </summary>
    [EnumMember(Value = "RC02")]
    [IsoId("_uEs82fRYEeuLhpyIdtJzwg")]
    [Description(
        @"Bank identifier is invalid or missing.|Generic usage if cannot specify between debit or credit account"
    )]
    InvalidBankIdentifier,

    /// <summary>
    /// Debtor bank identifier is invalid or missing
    /// Encoded/decoded by serializers as &quot;RC03&quot;.
    /// </summary>
    [EnumMember(Value = "RC03")]
    [IsoId("_uE2t0PRYEeuLhpyIdtJzwg")]
    [Description(@"Debtor bank identifier is invalid or missing")]
    InvalidDebtorBankIdentifier,

    /// <summary>
    /// Creditor bank identifier is invalid or missing
    /// Encoded/decoded by serializers as &quot;RC04&quot;.
    /// </summary>
    [EnumMember(Value = "RC04")]
    [IsoId("_uE2t0_RYEeuLhpyIdtJzwg")]
    [Description(@"Creditor bank identifier is invalid or missing")]
    InvalidCreditorBankIdentifier,

    /// <summary>
    /// BIC identifier is invalid or missing.|Generic usage if cannot specify between debit or credit account.
    /// Encoded/decoded by serializers as &quot;RC05&quot;.
    /// </summary>
    [EnumMember(Value = "RC05")]
    [IsoId("_uE2t1vRYEeuLhpyIdtJzwg")]
    [Description(
        @"BIC identifier is invalid or missing.|Generic usage if cannot specify between debit or credit account."
    )]
    InvalidBICIdentifier,

    /// <summary>
    /// Debtor BIC identifier is invalid or missing
    /// Encoded/decoded by serializers as &quot;RC06&quot;.
    /// </summary>
    [EnumMember(Value = "RC06")]
    [IsoId("_uE2t2fRYEeuLhpyIdtJzwg")]
    [Description(@"Debtor BIC identifier is invalid or missing")]
    InvalidDebtorBICIdentifier,

    /// <summary>
    /// Creditor BIC identifier is invalid or missing
    /// Encoded/decoded by serializers as &quot;RC07&quot;.
    /// </summary>
    [EnumMember(Value = "RC07")]
    [IsoId("_uE2t3PRYEeuLhpyIdtJzwg")]
    [Description(@"Creditor BIC identifier is invalid or missing")]
    InvalidCreditorBICIdentifier,

    /// <summary>
    /// ClearingSystemMemberidentifier is invalid or missing.|Generic usage if cannot specify between debit or credit account
    /// Encoded/decoded by serializers as &quot;RC08&quot;.
    /// </summary>
    [EnumMember(Value = "RC08")]
    [IsoId("_uFAe0PRYEeuLhpyIdtJzwg")]
    [Description(
        @"ClearingSystemMemberidentifier is invalid or missing.|Generic usage if cannot specify between debit or credit account"
    )]
    InvalidClearingSystemMemberIdentifier,

    /// <summary>
    /// Debtor ClearingSystemMember identifier is invalid or missing
    /// Encoded/decoded by serializers as &quot;RC09&quot;.
    /// </summary>
    [EnumMember(Value = "RC09")]
    [IsoId("_uFAe0_RYEeuLhpyIdtJzwg")]
    [Description(@"Debtor ClearingSystemMember identifier is invalid or missing")]
    InvalidDebtorClearingSystemMemberIdentifier,

    /// <summary>
    /// Creditor ClearingSystemMember identifier is invalid or missing
    /// Encoded/decoded by serializers as &quot;RC10&quot;.
    /// </summary>
    [EnumMember(Value = "RC10")]
    [IsoId("_uFJowPRYEeuLhpyIdtJzwg")]
    [Description(@"Creditor ClearingSystemMember identifier is invalid or missing")]
    InvalidCreditorClearingSystemMemberIdentifier,

    /// <summary>
    /// Intermediary Agent is invalid or missing
    /// Encoded/decoded by serializers as &quot;RC11&quot;.
    /// </summary>
    [EnumMember(Value = "RC11")]
    [IsoId("_uFJow_RYEeuLhpyIdtJzwg")]
    [Description(@"Intermediary Agent is invalid or missing")]
    InvalidIntermediaryAgent,

    /// <summary>
    /// Creditor Scheme Id is invalid or  missing
    /// Encoded/decoded by serializers as &quot;RC12&quot;.
    /// </summary>
    [EnumMember(Value = "RC12")]
    [IsoId("_uFJoxvRYEeuLhpyIdtJzwg")]
    [Description(@"Creditor Scheme Id is invalid or  missing")]
    MissingCreditorSchemeId,

    /// <summary>
    /// Conflict with R-Message
    /// Encoded/decoded by serializers as &quot;RCON&quot;.
    /// </summary>
    [EnumMember(Value = "RCON")]
    [IsoId("_uFJoyfRYEeuLhpyIdtJzwg")]
    [Description(@"Conflict with R-Message")]
    RMessageConflict,

    /// <summary>
    /// Further information regarding the intended recipient.
    /// Encoded/decoded by serializers as &quot;RECI&quot;.
    /// </summary>
    [EnumMember(Value = "RECI")]
    [IsoId("_uFJozPRYEeuLhpyIdtJzwg")]
    [Description(@"Further information regarding the intended recipient. ")]
    ReceiverCustomerInformation,

    /// <summary>
    /// Transaction reference is not unique within the message.
    /// Encoded/decoded by serializers as &quot;RF01&quot;.
    /// </summary>
    [EnumMember(Value = "RF01")]
    [IsoId("_uFTZwPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction reference is not unique within the message.")]
    NotUniqueTransactionReference,

    /// <summary>
    /// Specification of the debtor’s account or unique identification needed for reasons of regulatory requirements is insufficient or missing
    /// Encoded/decoded by serializers as &quot;RR01&quot;.
    /// </summary>
    [EnumMember(Value = "RR01")]
    [IsoId("_uFTZw_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Specification of the debtor’s account or unique identification needed for reasons of regulatory requirements is insufficient or missing"
    )]
    MissingDebtorAccountOrIdentification,

    /// <summary>
    /// Specification of the debtor’s name and/or address needed for regulatory requirements is insufficient or missing.
    /// Encoded/decoded by serializers as &quot;RR02&quot;.
    /// </summary>
    [EnumMember(Value = "RR02")]
    [IsoId("_uFTZxvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Specification of the debtor’s name and/or address needed for regulatory requirements is insufficient or missing."
    )]
    MissingDebtorNameOrAddress,

    /// <summary>
    /// Specification of the creditor’s name and/or address needed for regulatory requirements is insufficient or missing.
    /// Encoded/decoded by serializers as &quot;RR03&quot;.
    /// </summary>
    [EnumMember(Value = "RR03")]
    [IsoId("_uFTZyfRYEeuLhpyIdtJzwg")]
    [Description(
        @"Specification of the creditor’s name and/or address needed for regulatory requirements is insufficient or missing."
    )]
    MissingCreditorNameOrAddress,

    /// <summary>
    /// Regulatory Reason
    /// Encoded/decoded by serializers as &quot;RR04&quot;.
    /// </summary>
    [EnumMember(Value = "RR04")]
    [IsoId("_uFcjsPRYEeuLhpyIdtJzwg")]
    [Description(@"Regulatory Reason")]
    RegulatoryReason,

    /// <summary>
    /// Regulatory or Central Bank Reporting information missing, incomplete or invalid.
    /// Encoded/decoded by serializers as &quot;RR05&quot;.
    /// </summary>
    [EnumMember(Value = "RR05")]
    [IsoId("_uFcjs_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Regulatory or Central Bank Reporting information missing, incomplete or invalid."
    )]
    RegulatoryInformationInvalid,

    /// <summary>
    /// Tax information missing, incomplete or invalid.
    /// Encoded/decoded by serializers as &quot;RR06&quot;.
    /// </summary>
    [EnumMember(Value = "RR06")]
    [IsoId("_uFcjtvRYEeuLhpyIdtJzwg")]
    [Description(@"Tax information missing, incomplete or invalid.")]
    TaxInformationInvalid,

    /// <summary>
    /// Remittance information structure does not comply with rules for payment type.
    /// Encoded/decoded by serializers as &quot;RR07&quot;.
    /// </summary>
    [EnumMember(Value = "RR07")]
    [IsoId("_uFcjufRYEeuLhpyIdtJzwg")]
    [Description(@"Remittance information structure does not comply with rules for payment type.")]
    RemittanceInformationInvalid,

    /// <summary>
    /// Remittance information truncated to comply with rules for payment type.
    /// Encoded/decoded by serializers as &quot;RR08&quot;.
    /// </summary>
    [EnumMember(Value = "RR08")]
    [IsoId("_uFcjvPRYEeuLhpyIdtJzwg")]
    [Description(@"Remittance information truncated to comply with rules for payment type.")]
    RemittanceInformationTruncated,

    /// <summary>
    /// Structured creditor reference invalid or missing.
    /// Encoded/decoded by serializers as &quot;RR09&quot;.
    /// </summary>
    [EnumMember(Value = "RR09")]
    [IsoId("_uFmUsPRYEeuLhpyIdtJzwg")]
    [Description(@"Structured creditor reference invalid or missing.")]
    InvalidStructuredCreditorReference,

    /// <summary>
    /// Character set supplied not valid for the country and payment type.
    /// Encoded/decoded by serializers as &quot;RR10&quot;.
    /// </summary>
    [EnumMember(Value = "RR10")]
    [IsoId("_uFmUs_RYEeuLhpyIdtJzwg")]
    [Description(@"Character set supplied not valid for the country and payment type.")]
    InvalidCharacterSet,

    /// <summary>
    /// Invalid or missing identification of a bank proprietary service.
    /// Encoded/decoded by serializers as &quot;RR11&quot;.
    /// </summary>
    [EnumMember(Value = "RR11")]
    [IsoId("_uFwFsPRYEeuLhpyIdtJzwg")]
    [Description(@"Invalid or missing identification of a bank proprietary service.")]
    InvalidDebtorAgentServiceID,

    /// <summary>
    /// Invalid or missing identification required within a particular country or payment type.
    /// Encoded/decoded by serializers as &quot;RR12&quot;.
    /// </summary>
    [EnumMember(Value = "RR12")]
    [IsoId("_uFwFs_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Invalid or missing identification required within a particular country or payment type."
    )]
    InvalidPartyID,

    /// <summary>
    /// Request for Cancellation is acknowledged following validation.
    /// Encoded/decoded by serializers as &quot;S000&quot;.
    /// </summary>
    [EnumMember(Value = "S000")]
    [IsoId("_uFwFtvRYEeuLhpyIdtJzwg")]
    [Description(@"Request for Cancellation is acknowledged following validation.")]
    ValidRequestForCancellationAcknowledged,

    /// <summary>
    /// Unique End-to-end Transaction Reference (UETR) relating to a payment has been identified as being associated with a Request for Cancellation.
    /// Encoded/decoded by serializers as &quot;S001&quot;.
    /// </summary>
    [EnumMember(Value = "S001")]
    [IsoId("_uFwFufRYEeuLhpyIdtJzwg")]
    [Description(
        @"Unique End-to-end Transaction Reference (UETR) relating to a payment has been identified as being associated with a Request for Cancellation."
    )]
    UETRFlaggedForCancellation,

    /// <summary>
    /// Unique End-to-end Transaction Reference (UETR) relating to a payment has been prevent from traveling across a messaging network.
    /// Encoded/decoded by serializers as &quot;S002&quot;.
    /// </summary>
    [EnumMember(Value = "S002")]
    [IsoId("_uF5PoPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Unique End-to-end Transaction Reference (UETR) relating to a payment has been prevent from traveling across a messaging network."
    )]
    NetworkStopOfUETR,

    /// <summary>
    /// Request for Cancellation has been forwarded to the payment processing/last payment processing agent.
    /// Encoded/decoded by serializers as &quot;S003&quot;.
    /// </summary>
    [EnumMember(Value = "S003")]
    [IsoId("_uF5Po_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Request for Cancellation has been forwarded to the payment processing/last payment processing agent."
    )]
    RequestForCancellationForwarded,

    /// <summary>
    /// Request for Cancellation has been acknowledged as delivered to payment processing/last payment processing agent.
    /// Encoded/decoded by serializers as &quot;S004&quot;.
    /// </summary>
    [EnumMember(Value = "S004")]
    [IsoId("_uF5PpvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Request for Cancellation has been acknowledged as delivered to payment processing/last payment processing agent."
    )]
    RequestForCancellationDeliveryAcknowledgement,

    /// <summary>
    /// Due to specific service offered by the Debtor Agent.
    /// Encoded/decoded by serializers as &quot;SL01&quot;.
    /// </summary>
    [EnumMember(Value = "SL01")]
    [IsoId("_uF5PqfRYEeuLhpyIdtJzwg")]
    [Description(@"Due to specific service offered by the Debtor Agent.")]
    SpecificServiceOfferedByDebtorAgent,

    /// <summary>
    /// Due to specific service offered by the Creditor Agent.
    /// Encoded/decoded by serializers as &quot;SL02&quot;.
    /// </summary>
    [EnumMember(Value = "SL02")]
    [IsoId("_uF5PrPRYEeuLhpyIdtJzwg")]
    [Description(@"Due to specific service offered by the Creditor Agent.")]
    SpecificServiceOfferedByCreditorAgent,

    /// <summary>
    /// Due to a specific service offered by the clearing system.
    /// Encoded/decoded by serializers as &quot;SL03&quot;.
    /// </summary>
    [EnumMember(Value = "SL03")]
    [IsoId("_uGDAoPRYEeuLhpyIdtJzwg")]
    [Description(@"Due to a specific service offered by the clearing system.")]
    ServiceofClearingSystem,

    /// <summary>
    /// Whitelisting service offered by the Debtor Agent; Debtor has not included the Creditor on its “Whitelist” (yet). In the Whitelist the Debtor may list all allowed Creditors to debit Debtor bank account.
    /// Encoded/decoded by serializers as &quot;SL11&quot;.
    /// </summary>
    [EnumMember(Value = "SL11")]
    [IsoId("_uGDAo_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Whitelisting service offered by the Debtor Agent; Debtor has not included the Creditor on its “Whitelist” (yet). In the Whitelist the Debtor may list all allowed Creditors to debit Debtor bank account."
    )]
    CreditorNotOnWhitelistOfDebtor,

    /// <summary>
    /// Blacklisting service offered by the Debtor Agent; Debtor included the Creditor on his “Blacklist”. In the Blacklist the Debtor may list all Creditors not allowed to debit Debtor bank account.
    /// Encoded/decoded by serializers as &quot;SL12&quot;.
    /// </summary>
    [EnumMember(Value = "SL12")]
    [IsoId("_uGDApvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Blacklisting service offered by the Debtor Agent; Debtor included the Creditor on his “Blacklist”. In the Blacklist the Debtor may list all Creditors not allowed to debit Debtor bank account."
    )]
    CreditorOnBlacklistOfDebtor,

    /// <summary>
    /// Due to Maximum allowed Direct Debit Transactions per period service offered by the Debtor Agent.
    /// Encoded/decoded by serializers as &quot;SL13&quot;.
    /// </summary>
    [EnumMember(Value = "SL13")]
    [IsoId("_uGMxoPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Due to Maximum allowed Direct Debit Transactions per period service offered by the Debtor Agent."
    )]
    MaximumNumberOfDirectDebitTransactionsExceeded,

    /// <summary>
    /// Due to Maximum allowed Direct Debit Transaction amount service offered by the Debtor Agent.
    /// Encoded/decoded by serializers as &quot;SL14&quot;.
    /// </summary>
    [EnumMember(Value = "SL14")]
    [IsoId("_uGMxo_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Due to Maximum allowed Direct Debit Transaction amount service offered by the Debtor Agent."
    )]
    MaximumDirectDebitTransactionAmountExceeded,

    /// <summary>
    /// The transmission of the file was not successful – it had to be aborted (for technical reasons)
    /// Encoded/decoded by serializers as &quot;TA01&quot;.
    /// </summary>
    [EnumMember(Value = "TA01")]
    [IsoId("_uGMxpvRYEeuLhpyIdtJzwg")]
    [Description(
        @"The transmission of the file was not successful – it had to be aborted (for technical reasons)"
    )]
    TransmissonAborted,

    /// <summary>
    /// There is no data available (for download)
    /// Encoded/decoded by serializers as &quot;TD01&quot;.
    /// </summary>
    [EnumMember(Value = "TD01")]
    [IsoId("_uGMxqfRYEeuLhpyIdtJzwg")]
    [Description(@"There is no data available (for download)")]
    NoDataAvailable,

    /// <summary>
    /// The file cannot be read (e.g. unknown format)
    /// Encoded/decoded by serializers as &quot;TD02&quot;.
    /// </summary>
    [EnumMember(Value = "TD02")]
    [IsoId("_uGV7kPRYEeuLhpyIdtJzwg")]
    [Description(@"The file cannot be read (e.g. unknown format)")]
    FileNonReadable,

    /// <summary>
    /// The file format is incomplete or invalid
    /// Encoded/decoded by serializers as &quot;TD03&quot;.
    /// </summary>
    [EnumMember(Value = "TD03")]
    [IsoId("_uGV7k_RYEeuLhpyIdtJzwg")]
    [Description(@"The file format is incomplete or invalid")]
    IncorrectFileStructure,

    /// <summary>
    /// Token is invalid.
    /// Encoded/decoded by serializers as &quot;TK01&quot;.
    /// </summary>
    [EnumMember(Value = "TK01")]
    [IsoId("_uGV7lvRYEeuLhpyIdtJzwg")]
    [Description(@"Token is invalid.")]
    TokenInvalid,

    /// <summary>
    /// Token used for the sender does not exist.
    /// Encoded/decoded by serializers as &quot;TK02&quot;.
    /// </summary>
    [EnumMember(Value = "TK02")]
    [IsoId("_uGV7mfRYEeuLhpyIdtJzwg")]
    [Description(@"Token used for the sender does not exist.")]
    SenderTokenNotFound,

    /// <summary>
    /// Token used for the receiver does not exist.
    /// Encoded/decoded by serializers as &quot;TK03&quot;.
    /// </summary>
    [EnumMember(Value = "TK03")]
    [IsoId("_uGV7nPRYEeuLhpyIdtJzwg")]
    [Description(@"Token used for the receiver does not exist.")]
    ReceiverTokenNotFound,

    /// <summary>
    /// Token required for request is missing.
    /// Encoded/decoded by serializers as &quot;TK09&quot;.
    /// </summary>
    [EnumMember(Value = "TK09")]
    [IsoId("_uGfskvRYEeuLhpyIdtJzwg")]
    [Description(@"Token required for request is missing.")]
    TokenMissing,

    /// <summary>
    /// Token found with counterparty mismatch.
    /// Encoded/decoded by serializers as &quot;TKCM&quot;.
    /// </summary>
    [EnumMember(Value = "TKCM")]
    [IsoId("_uGfslfRYEeuLhpyIdtJzwg")]
    [Description(@"Token found with counterparty mismatch. ")]
    TokenCounterpartyMismatch,

    /// <summary>
    /// Single Use Token already used.
    /// Encoded/decoded by serializers as &quot;TKSG&quot;.
    /// </summary>
    [EnumMember(Value = "TKSG")]
    [IsoId("_uGpdkPRYEeuLhpyIdtJzwg")]
    [Description(@"Single Use Token already used. ")]
    TokenSingleUse,

    /// <summary>
    /// Token found with suspended status.
    /// Encoded/decoded by serializers as &quot;TKSP&quot;.
    /// </summary>
    [EnumMember(Value = "TKSP")]
    [IsoId("_uGpdk_RYEeuLhpyIdtJzwg")]
    [Description(@"Token found with suspended status.")]
    TokenSuspended,

    /// <summary>
    /// Token found with value limit rule violation.
    /// Encoded/decoded by serializers as &quot;TKVE&quot;.
    /// </summary>
    [EnumMember(Value = "TKVE")]
    [IsoId("_uGpdlvRYEeuLhpyIdtJzwg")]
    [Description(@"Token found with value limit rule violation. ")]
    TokenValueLimitExceeded,

    /// <summary>
    /// Token expired.
    /// Encoded/decoded by serializers as &quot;TKXP&quot;.
    /// </summary>
    [EnumMember(Value = "TKXP")]
    [IsoId("_uGpdmfRYEeuLhpyIdtJzwg")]
    [Description(@"Token expired.")]
    TokenExpired,

    /// <summary>
    /// Associated message, payment information block, or transaction was received after agreed processing cut-off time.
    /// Encoded/decoded by serializers as &quot;TM01&quot;.
    /// </summary>
    [EnumMember(Value = "TM01")]
    [IsoId("_uGyngPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Associated message, payment information block, or transaction was received after agreed processing cut-off time."
    )]
    InvalidCutOffTime,

    /// <summary>
    /// The (technical) transmission of the file was successful.
    /// Encoded/decoded by serializers as &quot;TS01&quot;.
    /// </summary>
    [EnumMember(Value = "TS01")]
    [IsoId("_uGyng_RYEeuLhpyIdtJzwg")]
    [Description(@"The (technical) transmission of the file was successful.")]
    TransmissionSuccessful,

    /// <summary>
    /// The order was transferred to pass by accompanying note signed by hand
    /// Encoded/decoded by serializers as &quot;TS04&quot;.
    /// </summary>
    [EnumMember(Value = "TS04")]
    [IsoId("_uGynhvRYEeuLhpyIdtJzwg")]
    [Description(@"The order was transferred to pass by accompanying note signed by hand")]
    TransferToSignByHand,

    /// <summary>
    /// Authorisation is cancelled.
    /// Encoded/decoded by serializers as &quot;CN01&quot;.
    /// </summary>
    [EnumMember(Value = "CN01")]
    [IsoId("_FGsTQAQnEey95qpfbNuEwg")]
    [Description(@"Authorisation is cancelled.")]
    AuthorisationCancelled,

    /// <summary>
    /// Return following a cancellation request.
    /// Encoded/decoded by serializers as &quot;FOCR&quot;.
    /// </summary>
    [EnumMember(Value = "FOCR")]
    [IsoId("_aWuiYAQnEey95qpfbNuEwg")]
    [Description(@"Return following a cancellation request.")]
    FollowingCancellationRequest,

    /// <summary>
    /// Returned as a result of fraud.
    /// Encoded/decoded by serializers as &quot;FR01&quot;.
    /// </summary>
    [EnumMember(Value = "FR01")]
    [IsoId("_lnpdAAQnEey95qpfbNuEwg")]
    [Description(@"Returned as a result of fraud.")]
    Fraud,

    /// <summary>
    /// No response from Beneficiary.
    /// Encoded/decoded by serializers as &quot;NOAS&quot;.
    /// </summary>
    [EnumMember(Value = "NOAS")]
    [IsoId("_s1SIYAQnEey95qpfbNuEwg")]
    [Description(@"No response from Beneficiary.")]
    NoAnswerFromCustomer,

    /// <summary>
    /// Customer account is not compliant with regulatory requirements, for example FICA (in South Africa) or any other regulatory requirements which render an account inactive for certain processing.
    /// Encoded/decoded by serializers as &quot;NOCM&quot;.
    /// </summary>
    [EnumMember(Value = "NOCM")]
    [IsoId("_x0nwMAQnEey95qpfbNuEwg")]
    [Description(
        @"Customer account is not compliant with regulatory requirements, for example FICA (in South Africa) or any other regulatory requirements which render an account inactive for certain processing."
    )]
    NotCompliantGeneric,

    /// <summary>
    /// Return following investigation request and no remediation possible.
    /// Encoded/decoded by serializers as &quot;RUTA&quot;.
    /// </summary>
    [EnumMember(Value = "RUTA")]
    [IsoId("_LzJHsAQoEey95qpfbNuEwg")]
    [Description(@"Return following investigation request and no remediation possible.")]
    ReturnUponUnableToApply,

    /// <summary>
    /// Payment is not justified.
    /// Encoded/decoded by serializers as &quot;UPAY&quot;.
    /// </summary>
    [EnumMember(Value = "UPAY")]
    [IsoId("_WirzkAQoEey95qpfbNuEwg")]
    [Description(@"Payment is not justified.")]
    UnduePayment,

    /// <summary>
    /// Request-to-pay Expiry Date and Time has already passed.
    /// Encoded/decoded by serializers as &quot;AEXR&quot;.
    /// </summary>
    [EnumMember(Value = "AEXR")]
    [IsoId("_Q5m3QFEAEey6cYDbEubNXg")]
    [Description(@"Request-to-pay Expiry Date and Time has already passed.")]
    AlreadyExpiredRTP,

    /// <summary>
    /// Request-to-pay has already been accepted by the Debtor.
    /// Encoded/decoded by serializers as &quot;ALAC&quot;.
    /// </summary>
    [EnumMember(Value = "ALAC")]
    [IsoId("_fy_GUFEAEey6cYDbEubNXg")]
    [Description(@"Request-to-pay has already been accepted by the Debtor.")]
    AlreadyAcceptedRTP,

    /// <summary>
    /// Request-to-pay has already been refused by the Debtor.
    /// Encoded/decoded by serializers as &quot;ARFR&quot;.
    /// </summary>
    [EnumMember(Value = "ARFR")]
    [IsoId("_oVkLYFEAEey6cYDbEubNXg")]
    [Description(@"Request-to-pay has already been refused by the Debtor.")]
    AlreadyRefusedRTP,

    /// <summary>
    /// Request-to-pay has already been rejected.
    /// Encoded/decoded by serializers as &quot;ARJR&quot;.
    /// </summary>
    [EnumMember(Value = "ARJR")]
    [IsoId("_vFjRcFEAEey6cYDbEubNXg")]
    [Description(@"Request-to-pay has already been rejected.")]
    AlreadyRejectedRTP,

    /// <summary>
    /// Attachments to the request-to-pay are not supported.
    /// Encoded/decoded by serializers as &quot;ATNS&quot;.
    /// </summary>
    [EnumMember(Value = "ATNS")]
    [IsoId("_22gFQFEAEey6cYDbEubNXg")]
    [Description(@"Attachments to the request-to-pay are not supported.")]
    AttachementsNotSupported,

    /// <summary>
    /// Expiry date time of the request-to-pay is too far in the future.
    /// Encoded/decoded by serializers as &quot;EDTL&quot;.
    /// </summary>
    [EnumMember(Value = "EDTL")]
    [IsoId("_BGThIFEBEey6cYDbEubNXg")]
    [Description(@"Expiry date time of the request-to-pay is too far in the future.")]
    ExpiryDateTooLong,

    /// <summary>
    /// Expiry date time of the request-to-pay is already reached.
    /// Encoded/decoded by serializers as &quot;EDTR&quot;.
    /// </summary>
    [EnumMember(Value = "EDTR")]
    [IsoId("_c4VdoFEBEey6cYDbEubNXg")]
    [Description(@"Expiry date time of the request-to-pay is already reached.")]
    ExpiryDateTimeReached,

    /// <summary>
    /// Cancellation requested following a transaction that was originated fraudulently. The use of the FraudulentOrigin code should be governed by jurisdictions.
    /// Encoded/decoded by serializers as &quot;FRAD&quot;.
    /// </summary>
    [EnumMember(Value = "FRAD")]
    [IsoId("_mt7CsFEBEey6cYDbEubNXg")]
    [Description(
        @"Cancellation requested following a transaction that was originated fraudulently. The use of the FraudulentOrigin code should be governed by jurisdictions."
    )]
    FraudulentOrigin,

    /// <summary>
    /// Expiry date time of the request-to-pay is incorrect.
    /// Encoded/decoded by serializers as &quot;IEDT&quot;.
    /// </summary>
    [EnumMember(Value = "IEDT")]
    [IsoId("_sXSe8FEBEey6cYDbEubNXg")]
    [Description(@"Expiry date time of the request-to-pay is incorrect.")]
    IncorrectExpiryDateTime,

    /// <summary>
    /// No initial request-to-pay has been received.
    /// Encoded/decoded by serializers as &quot;IRNR&quot;.
    /// </summary>
    [EnumMember(Value = "IRNR")]
    [IsoId("_2VEWsFEBEey6cYDbEubNXg")]
    [Description(@"No initial request-to-pay has been received.")]
    InitialRTPNeverReceived,

    /// <summary>
    /// No existing agreement for receiving request-to-pay messages.
    /// Encoded/decoded by serializers as &quot;NOAR&quot;.
    /// </summary>
    [EnumMember(Value = "NOAR")]
    [IsoId("_F4fBQFECEey6cYDbEubNXg")]
    [Description(@"No existing agreement for receiving request-to-pay messages.")]
    NonAgreedRTP,

    /// <summary>
    /// Requested payment guarantee (by Creditor) related to a request-to-pay cannot be provided.
    /// Encoded/decoded by serializers as &quot;NOPG&quot;.
    /// </summary>
    [EnumMember(Value = "NOPG")]
    [IsoId("_PZ8JYFECEey6cYDbEubNXg")]
    [Description(
        @"Requested payment guarantee (by Creditor) related to a request-to-pay cannot be provided."
    )]
    NoPaymentGuarantee,

    /// <summary>
    /// Recipient side of the request-to-pay (payer or its request-to-pay service provider) is not reachable.
    /// Encoded/decoded by serializers as &quot;NRCH&quot;.
    /// </summary>
    [EnumMember(Value = "NRCH")]
    [IsoId("_fUStQFECEey6cYDbEubNXg")]
    [Description(
        @"Recipient side of the request-to-pay (payer or its request-to-pay service provider) is not reachable."
    )]
    PayerOrPayerRTPSPNotReachable,

    /// <summary>
    /// Type of payment requested in the request-to-pay is not supported by the payer.
    /// Encoded/decoded by serializers as &quot;PINS&quot;.
    /// </summary>
    [EnumMember(Value = "PINS")]
    [IsoId("_p2b2UFECEey6cYDbEubNXg")]
    [Description(@"Type of payment requested in the request-to-pay is not supported by the payer.")]
    TypeOfPaymentInstrumentNotSupported,

    /// <summary>
    /// Request-to-pay has been received and can be processed further.
    /// Encoded/decoded by serializers as &quot;REPR&quot;.
    /// </summary>
    [EnumMember(Value = "REPR")]
    [IsoId("_z1_2wFECEey6cYDbEubNXg")]
    [Description(@"Request-to-pay has been received and can be processed further.")]
    RTPReceivedCanBeProcessed,

    /// <summary>
    /// Debtor does not support request-to-pay transactions.
    /// Encoded/decoded by serializers as &quot;RTNS&quot;.
    /// </summary>
    [EnumMember(Value = "RTNS")]
    [IsoId("_FpMLkFEDEey6cYDbEubNXg")]
    [Description(@"Debtor does not support request-to-pay transactions.")]
    RTPNotSupportedForDebtor,

    /// <summary>
    /// Identifier of the request-to-pay service provider is incorrect.
    /// Encoded/decoded by serializers as &quot;SPII&quot;.
    /// </summary>
    [EnumMember(Value = "SPII")]
    [IsoId("_SJFawFEDEey6cYDbEubNXg")]
    [Description(@"Identifier of the request-to-pay service provider is incorrect.")]
    RTPServiceProviderIdentifierIncorrect,

    /// <summary>
    /// Unknown Creditor.
    /// Encoded/decoded by serializers as &quot;UCRD&quot;.
    /// </summary>
    [EnumMember(Value = "UCRD")]
    [IsoId("_aBpScFEDEey6cYDbEubNXg")]
    [Description(@"Unknown Creditor.")]
    UnknownCreditor,

    /// <summary>
    /// Original payment is not eligible to be returned given its current status.
    /// Encoded/decoded by serializers as &quot;FF12&quot;.
    /// </summary>
    [EnumMember(Value = "FF12")]
    [IsoId("_9E8U8I4_EeyANo-d7JlQ1A")]
    [Description(@"Original payment is not eligible to be returned given its current status.")]
    OriginalTransactionNotEligibleForRequestedReturn,

    /// <summary>
    /// No record of request for cancellation found.
    /// Encoded/decoded by serializers as &quot;FF13&quot;.
    /// </summary>
    [EnumMember(Value = "FF13")]
    [IsoId("_TTQKMI5AEeyANo-d7JlQ1A")]
    [Description(@"No record of request for cancellation found.")]
    RequestForCancellationNotFound,

    /// <summary>
    /// Rejection of a payment due to covering FI settlement not being received.
    /// Encoded/decoded by serializers as &quot;DC02&quot;.
    /// </summary>
    [EnumMember(Value = "DC02")]
    [IsoId("_79YjkOAbEey0k8vo1GQhqQ")]
    [Description(@"Rejection of a payment due to covering FI settlement not being received.")]
    SettlementNotReceived,
}
