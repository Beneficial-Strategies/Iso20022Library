// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for a transaction to be rejected, returned or reversed by an instructed agent or somebody acting on behalf of an instructed agent.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YsS_xdp-Ed-ak6NoX_4Aeg_-819075130")]
[Description(
    @"Specifies the reason for a transaction to be rejected, returned or reversed by an instructed agent or somebody acting on behalf of an instructed agent."
)]
[Derivations(
    typeof(TransactionRejectReason5Code),
    typeof(TransactionRejectReason6Code),
    typeof(TransactionReturnReason1Code),
    typeof(TransactionRejectReason7Code),
    typeof(TransactionRejectReason2Code),
    typeof(TransactionReversalReason2Code),
    typeof(TransactionReversalReason1Code),
    typeof(TransactionRejectReason4Code)
)]
public enum TransactionReasonCode
{
    /// <summary>
    /// Format of the account number specified is not correct.
    /// Encoded/decoded by serializers as &quot;AC01&quot;.
    /// </summary>
    [EnumMember(Value = "AC01")]
    [IsoId("_YsS_xtp-Ed-ak6NoX_4Aeg_-371166097")]
    [Description(@"Format of the account number specified is not correct.")]
    IncorrectAccountNumber,

    /// <summary>
    /// Format of the account number specified is non-numeric.
    /// Encoded/decoded by serializers as &quot;AC02&quot;.
    /// </summary>
    [EnumMember(Value = "AC02")]
    [IsoId("_YsS_x9p-Ed-ak6NoX_4Aeg_-371166037")]
    [Description(@"Format of the account number specified is non-numeric.")]
    NonNumericAccountNumber,

    /// <summary>
    /// Format of the account number specified is not valid for local Sort/National Clearing Code.
    /// Encoded/decoded by serializers as &quot;AC03&quot;.
    /// </summary>
    [EnumMember(Value = "AC03")]
    [IsoId("_YsS_yNp-Ed-ak6NoX_4Aeg_-371166002")]
    [Description(
        @"Format of the account number specified is not valid for local Sort/National Clearing Code."
    )]
    InvalidAccountNumberForClearingCode,

    /// <summary>
    /// Account number specified has been closed on the Receiver&apos;s books.
    /// Encoded/decoded by serializers as &quot;AC04&quot;.
    /// </summary>
    [EnumMember(Value = "AC04")]
    [IsoId("_YsS_ydp-Ed-ak6NoX_4Aeg_-371165924")]
    [Description(@"Account number specified has been closed on the Receiver's books.")]
    ClosedAccountNumber,

    /// <summary>
    /// Account number specified is not a valid account at the Final Agent.
    /// Encoded/decoded by serializers as &quot;AC05&quot;.
    /// </summary>
    [EnumMember(Value = "AC05")]
    [IsoId("_YscJsNp-Ed-ak6NoX_4Aeg_-371165882")]
    [Description(@"Account number specified is not a valid account at the Final Agent.")]
    InvalidAccountNumberWithInstitution,

    /// <summary>
    /// Account specified is blocked, prohibiting posting of transactions against it.
    /// Encoded/decoded by serializers as &quot;AC06&quot;.
    /// </summary>
    [EnumMember(Value = "AC06")]
    [IsoId("_YscJsdp-Ed-ak6NoX_4Aeg_-371165611")]
    [Description(@"Account specified is blocked, prohibiting posting of transactions against it.")]
    BlockedAccount,

    /// <summary>
    /// Specified message amount is equal to zero.
    /// Encoded/decoded by serializers as &quot;AM01&quot;.
    /// </summary>
    [EnumMember(Value = "AM01")]
    [IsoId("_YscJstp-Ed-ak6NoX_4Aeg_-371165509")]
    [Description(@"Specified message amount is equal to zero.")]
    ZeroAmount,

    /// <summary>
    /// Specified transaction/message amount is greater than allowed maximum.
    /// Encoded/decoded by serializers as &quot;AM02&quot;.
    /// </summary>
    [EnumMember(Value = "AM02")]
    [IsoId("_YscJs9p-Ed-ak6NoX_4Aeg_-371165183")]
    [Description(@"Specified transaction/message amount is greater than allowed maximum.")]
    NotAllowedAmount,

    /// <summary>
    /// Specified message amount is in an non processable currency outside of existing agreement.
    /// Encoded/decoded by serializers as &quot;AM03&quot;.
    /// </summary>
    [EnumMember(Value = "AM03")]
    [IsoId("_YscJtNp-Ed-ak6NoX_4Aeg_-371165123")]
    [Description(
        @"Specified message amount is in an non processable currency outside of existing agreement."
    )]
    NotAllowedCurrency,

    /// <summary>
    /// Amount of funds available to cover specified message amount is insufficient.
    /// Encoded/decoded by serializers as &quot;AM04&quot;.
    /// </summary>
    [EnumMember(Value = "AM04")]
    [IsoId("_YscJtdp-Ed-ak6NoX_4Aeg_-371165071")]
    [Description(@"Amount of funds available to cover specified message amount is insufficient.")]
    InsufficientFunds,

    /// <summary>
    /// This message appears to have been duplicated.
    /// Encoded/decoded by serializers as &quot;AM05&quot;.
    /// </summary>
    [EnumMember(Value = "AM05")]
    [IsoId("_YscJttp-Ed-ak6NoX_4Aeg_-371165011")]
    [Description(@"This message appears to have been duplicated.")]
    Duplication,

    /// <summary>
    /// Specified transaction amount is less than agreed minimum.
    /// Encoded/decoded by serializers as &quot;AM06&quot;.
    /// </summary>
    [EnumMember(Value = "AM06")]
    [IsoId("_YscJt9p-Ed-ak6NoX_4Aeg_-371164951")]
    [Description(@"Specified transaction amount is less than agreed minimum.")]
    TooLowAmount,

    /// <summary>
    /// Amount specified in message has been blocked by regulatory authorities.
    /// Encoded/decoded by serializers as &quot;AM07&quot;.
    /// </summary>
    [EnumMember(Value = "AM07")]
    [IsoId("_YscJuNp-Ed-ak6NoX_4Aeg_-371164656")]
    [Description(@"Amount specified in message has been blocked by regulatory authorities.")]
    BlockedAmount,

    /// <summary>
    /// Specified charges amount is not as agreed between sender and receiver.
    /// Encoded/decoded by serializers as &quot;AM08&quot;.
    /// </summary>
    [EnumMember(Value = "AM08")]
    [IsoId("_YscJudp-Ed-ak6NoX_4Aeg_-371164596")]
    [Description(@"Specified charges amount is not as agreed between sender and receiver.")]
    ChargeDisagreement,

    /// <summary>
    /// Identification of end customer is not consistent with associated account number. (formerly CreditorConsistency).
    /// Encoded/decoded by serializers as &quot;BE01&quot;.
    /// </summary>
    [EnumMember(Value = "BE01")]
    [IsoId("_Ysl6sNp-Ed-ak6NoX_4Aeg_-371164544")]
    [Description(
        @"Identification of end customer is not consistent with associated account number. (formerly CreditorConsistency)."
    )]
    InconsistentWithEndCustomer,

    /// <summary>
    /// Creditor specified is not known at associated Sort/National Clearing code.
    /// Encoded/decoded by serializers as &quot;BE02&quot;.
    /// </summary>
    [EnumMember(Value = "BE02")]
    [IsoId("_Ysl6sdp-Ed-ak6NoX_4Aeg_-370244477")]
    [Description(@"Creditor specified is not known at associated Sort/National Clearing code.")]
    UnknownCreditor,

    /// <summary>
    /// Creditor specified no longer exists in the books.
    /// Encoded/decoded by serializers as &quot;BE03&quot;.
    /// </summary>
    [EnumMember(Value = "BE03")]
    [IsoId("_Ysl6stp-Ed-ak6NoX_4Aeg_-370244322")]
    [Description(@"Creditor specified no longer exists in the books.")]
    NoLongerValidCreditor,

    /// <summary>
    /// Specification of creditor&apos;s address, which is required for payment, is missing/not correct (formerly IncorrectCreditorAddress).
    /// Encoded/decoded by serializers as &quot;BE04&quot;.
    /// </summary>
    [EnumMember(Value = "BE04")]
    [IsoId("_Ysl6s9p-Ed-ak6NoX_4Aeg_-370244020")]
    [Description(
        @"Specification of creditor's address, which is required for payment, is missing/not correct (formerly IncorrectCreditorAddress)."
    )]
    MissingCreditorAddress,

    /// <summary>
    /// Party who initiated the message is not recognised by the end customer.
    /// Encoded/decoded by serializers as &quot;BE05&quot;.
    /// </summary>
    [EnumMember(Value = "BE05")]
    [IsoId("_Ysl6tNp-Ed-ak6NoX_4Aeg_-370243925")]
    [Description(@"Party who initiated the message is not recognised by the end customer.")]
    UnrecognisedInitiatingParty,

    /// <summary>
    /// Transaction forbidden on this type of account (formerly NoAgreement).
    /// Encoded/decoded by serializers as &quot;AG01&quot;.
    /// </summary>
    [EnumMember(Value = "AG01")]
    [IsoId("_Ysl6tdp-Ed-ak6NoX_4Aeg_-370243865")]
    [Description(@"Transaction forbidden on this type of account (formerly NoAgreement).")]
    TransactionForbidden,

    /// <summary>
    /// Bank Operation code specified in the message is not valid for receiver.
    /// Encoded/decoded by serializers as &quot;AG02&quot;.
    /// </summary>
    [EnumMember(Value = "AG02")]
    [IsoId("_Ysl6ttp-Ed-ak6NoX_4Aeg_-370243522")]
    [Description(@"Bank Operation code specified in the message is not valid for receiver.")]
    InvalidBankOperationCode,

    /// <summary>
    /// Invalid date (eg, wrong settlement date).
    /// Encoded/decoded by serializers as &quot;DT01&quot;.
    /// </summary>
    [EnumMember(Value = "DT01")]
    [IsoId("_Ysl6t9p-Ed-ak6NoX_4Aeg_-370243427")]
    [Description(@"Invalid date (eg, wrong settlement date).")]
    InvalidDate,

    /// <summary>
    /// Reason has not been specified due to sensitivities.
    /// Encoded/decoded by serializers as &quot;MS01&quot;.
    /// </summary>
    [EnumMember(Value = "MS01")]
    [IsoId("_Ysl6uNp-Ed-ak6NoX_4Aeg_-370243331")]
    [Description(@"Reason has not been specified due to sensitivities.")]
    NotSpecifiedReason,

    /// <summary>
    /// Unknown account with institution.
    /// Encoded/decoded by serializers as &quot;PY01&quot;.
    /// </summary>
    [EnumMember(Value = "PY01")]
    [IsoId("_Ysl6udp-Ed-ak6NoX_4Aeg_-370243012")]
    [Description(@"Unknown account with institution.")]
    UnknownAccount,

    /// <summary>
    /// Transaction reference is not unique within the message.
    /// Encoded/decoded by serializers as &quot;RF01&quot;.
    /// </summary>
    [EnumMember(Value = "RF01")]
    [IsoId("_YsvrsNp-Ed-ak6NoX_4Aeg_-370242959")]
    [Description(@"Transaction reference is not unique within the message.")]
    NotUniqueTransactionReference,

    /// <summary>
    /// Bank identifier code specified in the message has an incorrect format (formerly IncorrectFormatForRoutingCode).
    /// Encoded/decoded by serializers as &quot;RC01&quot;.
    /// </summary>
    [EnumMember(Value = "RC01")]
    [IsoId("_Ysvrsdp-Ed-ak6NoX_4Aeg_-370242609")]
    [Description(
        @"Bank identifier code specified in the message has an incorrect format (formerly IncorrectFormatForRoutingCode)."
    )]
    BankIdentifierIncorrect,

    /// <summary>
    /// Routing code specified in the transaction/message is not numeric.
    /// Encoded/decoded by serializers as &quot;RC02&quot;.
    /// </summary>
    [EnumMember(Value = "RC02")]
    [IsoId("_Ysvrstp-Ed-ak6NoX_4Aeg_-370242531")]
    [Description(@"Routing code specified in the transaction/message is not numeric.")]
    NonNumericRoutingCode,

    /// <summary>
    /// Routing code specified in the transaction/message is not valid for local clearing.
    /// Encoded/decoded by serializers as &quot;RC03&quot;.
    /// </summary>
    [EnumMember(Value = "RC03")]
    [IsoId("_Ysvrs9p-Ed-ak6NoX_4Aeg_-370242436")]
    [Description(
        @"Routing code specified in the transaction/message is not valid for local clearing."
    )]
    NotValidRoutingCode,

    /// <summary>
    /// Routing code specified in the transaction/message refers to a closed branch.
    /// Encoded/decoded by serializers as &quot;RC04&quot;.
    /// </summary>
    [EnumMember(Value = "RC04")]
    [IsoId("_YsvrtNp-Ed-ak6NoX_4Aeg_-370242341")]
    [Description(@"Routing code specified in the transaction/message refers to a closed branch.")]
    ClosedBranch,

    /// <summary>
    /// Associated message was received after agreed processing cut-off time.
    /// Encoded/decoded by serializers as &quot;TM01&quot;.
    /// </summary>
    [EnumMember(Value = "TM01")]
    [IsoId("_Ysvrtdp-Ed-ak6NoX_4Aeg_-370242047")]
    [Description(@"Associated message was received after agreed processing cut-off time.")]
    CutOffTime,

    /// <summary>
    /// Correspondent bank not possible.
    /// Encoded/decoded by serializers as &quot;ED01&quot;.
    /// </summary>
    [EnumMember(Value = "ED01")]
    [IsoId("_Ysvrttp-Ed-ak6NoX_4Aeg_-370241927")]
    [Description(@"Correspondent bank not possible.")]
    CorrespondentBankNotPossible,

    /// <summary>
    /// Transaction reason non reportable.
    /// Encoded/decoded by serializers as &quot;ED02&quot;.
    /// </summary>
    [EnumMember(Value = "ED02")]
    [IsoId("_Ysvrt9p-Ed-ak6NoX_4Aeg_-370241584")]
    [Description(@"Transaction reason non reportable.")]
    TransactionReasonNonReportable,

    /// <summary>
    /// Balance of payments complementary info is requested.
    /// Encoded/decoded by serializers as &quot;ED03&quot;.
    /// </summary>
    [EnumMember(Value = "ED03")]
    [IsoId("_YsvruNp-Ed-ak6NoX_4Aeg_-370241489")]
    [Description(@"Balance of payments complementary info is requested.")]
    BalanceInfoRequested,

    /// <summary>
    /// Charge details not correct.
    /// Encoded/decoded by serializers as &quot;ED04&quot;.
    /// </summary>
    [EnumMember(Value = "ED04")]
    [IsoId("_Ysvrudp-Ed-ak6NoX_4Aeg_-370241369")]
    [Description(@"Charge details not correct.")]
    ChargeDetailsNotCorrect,

    /// <summary>
    /// Reason has not been specified by agent.
    /// Encoded/decoded by serializers as &quot;MS03&quot;.
    /// </summary>
    [EnumMember(Value = "MS03")]
    [IsoId("_Ysvrutp-Ed-ak6NoX_4Aeg_1015961068")]
    [Description(@"Reason has not been specified by agent.")]
    NotSpecifiedReasonAgentGenerated,

    /// <summary>
    /// Reason has not been specified by end customer.
    /// Encoded/decoded by serializers as &quot;MS02&quot;.
    /// </summary>
    [EnumMember(Value = "MS02")]
    [IsoId("_Ys41oNp-Ed-ak6NoX_4Aeg_1030740222")]
    [Description(@"Reason has not been specified by end customer.")]
    NotSpecifiedReasonCustomerGenerated,

    /// <summary>
    /// End customer specified is not known at associated Sort/National Bank Code or does no longer exist in the books.
    /// Encoded/decoded by serializers as &quot;BE06&quot;.
    /// </summary>
    [EnumMember(Value = "BE06")]
    [IsoId("_Ys41odp-Ed-ak6NoX_4Aeg_1473105324")]
    [Description(
        @"End customer specified is not known at associated Sort/National Bank Code or does no longer exist in the books."
    )]
    UnknownEndCustomer,

    /// <summary>
    /// Specification of debtor&apos;s address, which is required for payment, is missing/not correct.
    /// Encoded/decoded by serializers as &quot;BE07&quot;.
    /// </summary>
    [EnumMember(Value = "BE07")]
    [IsoId("_Ys41otp-Ed-ak6NoX_4Aeg_1904390558")]
    [Description(
        @"Specification of debtor's address, which is required for payment, is missing/not correct."
    )]
    MissingDebtorAddress,

    /// <summary>
    /// Amount received is not the amount agreed or expected.
    /// Encoded/decoded by serializers as &quot;AM09&quot;.
    /// </summary>
    [EnumMember(Value = "AM09")]
    [IsoId("_Ys41o9p-Ed-ak6NoX_4Aeg_-1889107065")]
    [Description(@"Amount received is not the amount agreed or expected.")]
    WrongAmount,

    /// <summary>
    /// Sum of instructed amounts does not equal the control sum.
    /// Encoded/decoded by serializers as &quot;AM10&quot;.
    /// </summary>
    [EnumMember(Value = "AM10")]
    [IsoId("_Ys41pNp-Ed-ak6NoX_4Aeg_-1564026693")]
    [Description(@"Sum of instructed amounts does not equal the control sum.")]
    InvalidControlSum,

    /// <summary>
    /// Mandate is cancelled or invalid.
    /// Encoded/decoded by serializers as &quot;MD01&quot;.
    /// </summary>
    [EnumMember(Value = "MD01")]
    [IsoId("_Ys41pdp-Ed-ak6NoX_4Aeg_-1003449105")]
    [Description(@"Mandate is cancelled or invalid.")]
    NoMandate,

    /// <summary>
    /// Mandate related information data required by the scheme is missing.
    /// Encoded/decoded by serializers as &quot;MD02&quot;.
    /// </summary>
    [EnumMember(Value = "MD02")]
    [IsoId("_Ys41ptp-Ed-ak6NoX_4Aeg_-900939252")]
    [Description(@"Mandate related information data required by the scheme is missing.")]
    MissingMandatoryInformationInMandate,

    /// <summary>
    /// File format incomplete or invalid.
    /// Encoded/decoded by serializers as &quot;MD03&quot;.
    /// </summary>
    [EnumMember(Value = "MD03")]
    [IsoId("_Ys41p9p-Ed-ak6NoX_4Aeg_-604488852")]
    [Description(@"File format incomplete or invalid.")]
    InvalidFileFormatForOtherReasonThanGroupingIndicator,

    /// <summary>
    /// File format incorrect in terms of grouping indicator.
    /// Encoded/decoded by serializers as &quot;MD04&quot;.
    /// </summary>
    [EnumMember(Value = "MD04")]
    [IsoId("_Ys41qNp-Ed-ak6NoX_4Aeg_-286797660")]
    [Description(@"File format incorrect in terms of grouping indicator.")]
    InvalidFileFormatForGroupingIndicator,

    /// <summary>
    /// Return of funds requested by end customer.
    /// Encoded/decoded by serializers as &quot;MD06&quot;.
    /// </summary>
    [EnumMember(Value = "MD06")]
    [IsoId("_YtCmoNp-Ed-ak6NoX_4Aeg_-83623586")]
    [Description(@"Return of funds requested by end customer.")]
    RefundRequestByEndCustomer,

    /// <summary>
    /// End customer is deceased.
    /// Encoded/decoded by serializers as &quot;MD07&quot;.
    /// </summary>
    [EnumMember(Value = "MD07")]
    [IsoId("_YtCmodp-Ed-ak6NoX_4Aeg_197126350")]
    [Description(@"End customer is deceased.")]
    EndCustomerDeceased,

    /// <summary>
    /// Creditor or creditor&apos;s agent should not have collected the direct debit.
    /// Encoded/decoded by serializers as &quot;MD05&quot;.
    /// </summary>
    [EnumMember(Value = "MD05")]
    [IsoId("_YtCmotp-Ed-ak6NoX_4Aeg_338428408")]
    [Description(@"Creditor or creditor's agent should not have collected the direct debit.")]
    CollectionNotDue,

    /// <summary>
    /// Name provided is not valid.
    /// Encoded/decoded by serializers as &quot;AC07&quot;.
    /// </summary>
    [EnumMember(Value = "AC07")]
    [IsoId("_YtCmo9p-Ed-ak6NoX_4Aeg_-275055644")]
    [Description(@"Name provided is not valid.")]
    InvalidName,

    /// <summary>
    /// Settlement of the transaction has failed.
    /// Encoded/decoded by serializers as &quot;ED05&quot;.
    /// </summary>
    [EnumMember(Value = "ED05")]
    [IsoId("_YtCmpNp-Ed-ak6NoX_4Aeg_-1585165125")]
    [Description(@"Settlement of the transaction has failed.")]
    SettlementFailed,

    /// <summary>
    /// Reason is provided as narrative information in the additional reason information.
    /// Encoded/decoded by serializers as &quot;NARR&quot;.
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("_YtCmpdp-Ed-ak6NoX_4Aeg_-1585164368")]
    [Description(
        @"Reason is provided as narrative information in the additional reason information."
    )]
    Narrative,
}
