// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the return reason, as published in an external return reason code list.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_MNnSwLf9Eee9KIDjEHK7ZQ")]
[Description(
    @"Specifies the return reason, as published in an external return reason code list.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalReturnReason1Code))]
public enum ExternalReturnReasonCode
{
    /// <summary>
    /// Format of the account number specified is not correct
    /// Encoded/decoded by serializers as &quot;AC01&quot;.
    /// </summary>
    [EnumMember(Value = "AC01")]
    [IsoId("_t4yAufRYEeuLhpyIdtJzwg")]
    [Description(@"Format of the account number specified is not correct")]
    IncorrectAccountNumber,

    /// <summary>
    /// Wrong IBAN in SCT
    /// Encoded/decoded by serializers as &quot;AC03&quot;.
    /// </summary>
    [EnumMember(Value = "AC03")]
    [IsoId("_t4yAvPRYEeuLhpyIdtJzwg")]
    [Description(@"Wrong IBAN in SCT")]
    InvalidCreditorAccountNumber,

    /// <summary>
    /// Account number specified has been closed on the bank of account&apos;s books
    /// Encoded/decoded by serializers as &quot;AC04&quot;.
    /// </summary>
    [EnumMember(Value = "AC04")]
    [IsoId("_t47xsPRYEeuLhpyIdtJzwg")]
    [Description(@"Account number specified has been closed on the bank of account's books")]
    ClosedAccountNumber,

    /// <summary>
    /// Account specified is blocked, prohibiting posting of transactions against it.
    /// Encoded/decoded by serializers as &quot;AC06&quot;.
    /// </summary>
    [EnumMember(Value = "AC06")]
    [IsoId("_t47xs_RYEeuLhpyIdtJzwg")]
    [Description(@"Account specified is blocked, prohibiting posting of transactions against it.")]
    BlockedAccount,

    /// <summary>
    /// Debtor account type is missing or invalid
    /// Encoded/decoded by serializers as &quot;AC13&quot;.
    /// </summary>
    [EnumMember(Value = "AC13")]
    [IsoId("_t47xtvRYEeuLhpyIdtJzwg")]
    [Description(@"Debtor account type is missing or invalid")]
    InvalidDebtorAccountType,

    /// <summary>
    /// An agent in the payment chain is invalid.
    /// Encoded/decoded by serializers as &quot;AC14&quot;.
    /// </summary>
    [EnumMember(Value = "AC14")]
    [IsoId("_t47xufRYEeuLhpyIdtJzwg")]
    [Description(@"An agent in the payment chain is invalid.")]
    InvalidAgent,

    /// <summary>
    /// Account details have changed.
    /// Encoded/decoded by serializers as &quot;AC15&quot;.
    /// </summary>
    [EnumMember(Value = "AC15")]
    [IsoId("_t47xvPRYEeuLhpyIdtJzwg")]
    [Description(@"Account details have changed.")]
    AccountDetailsChanged,

    /// <summary>
    /// Account is in sequestration.
    /// Encoded/decoded by serializers as &quot;AC16&quot;.
    /// </summary>
    [EnumMember(Value = "AC16")]
    [IsoId("_t5FisPRYEeuLhpyIdtJzwg")]
    [Description(@"Account is in sequestration.")]
    AccountInSequestration,

    /// <summary>
    /// Account is in liquidation.
    /// Encoded/decoded by serializers as &quot;AC17&quot;.
    /// </summary>
    [EnumMember(Value = "AC17")]
    [IsoId("_t5Fis_RYEeuLhpyIdtJzwg")]
    [Description(@"Account is in liquidation.")]
    AccountInLiquidation,

    /// <summary>
    /// Transaction forbidden on this type of account (formerly NoAgreement)
    /// Encoded/decoded by serializers as &quot;AG01&quot;.
    /// </summary>
    [EnumMember(Value = "AG01")]
    [IsoId("_t5OsoPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction forbidden on this type of account (formerly NoAgreement)")]
    TransactionForbidden,

    /// <summary>
    /// Bank Operation code specified in the message is not valid for receiver
    /// Encoded/decoded by serializers as &quot;AG02&quot;.
    /// </summary>
    [EnumMember(Value = "AG02")]
    [IsoId("_t5Oso_RYEeuLhpyIdtJzwg")]
    [Description(@"Bank Operation code specified in the message is not valid for receiver")]
    InvalidBankOperationCode,

    /// <summary>
    /// Specified message amount is equal to zero
    /// Encoded/decoded by serializers as &quot;AM01&quot;.
    /// </summary>
    [EnumMember(Value = "AM01")]
    [IsoId("_t5YdoPRYEeuLhpyIdtJzwg")]
    [Description(@"Specified message amount is equal to zero")]
    ZeroAmount,

    /// <summary>
    /// Specific transaction/message amount is greater than allowed maximum
    /// Encoded/decoded by serializers as &quot;AM02&quot;.
    /// </summary>
    [EnumMember(Value = "AM02")]
    [IsoId("_t5Ydo_RYEeuLhpyIdtJzwg")]
    [Description(@"Specific transaction/message amount is greater than allowed maximum")]
    NotAllowedAmount,

    /// <summary>
    /// Specified message amount is an non processable currency outside of existing agreement
    /// Encoded/decoded by serializers as &quot;AM03&quot;.
    /// </summary>
    [EnumMember(Value = "AM03")]
    [IsoId("_t5iOoPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Specified message amount is an non processable currency outside of existing agreement"
    )]
    NotAllowedCurrency,

    /// <summary>
    /// Amount of funds available to cover specified message amount is insufficient.
    /// Encoded/decoded by serializers as &quot;AM04&quot;.
    /// </summary>
    [EnumMember(Value = "AM04")]
    [IsoId("_t5iOo_RYEeuLhpyIdtJzwg")]
    [Description(@"Amount of funds available to cover specified message amount is insufficient.")]
    InsufficientFunds,

    /// <summary>
    /// Duplication
    /// Encoded/decoded by serializers as &quot;AM05&quot;.
    /// </summary>
    [EnumMember(Value = "AM05")]
    [IsoId("_t5iOpvRYEeuLhpyIdtJzwg")]
    [Description(@"Duplication")]
    Duplication,

    /// <summary>
    /// Specified transaction amount is less than agreed minimum.
    /// Encoded/decoded by serializers as &quot;AM06&quot;.
    /// </summary>
    [EnumMember(Value = "AM06")]
    [IsoId("_t5iOqfRYEeuLhpyIdtJzwg")]
    [Description(@"Specified transaction amount is less than agreed minimum.")]
    TooLowAmount,

    /// <summary>
    /// Amount specified in message has been blocked by regulatory authorities.
    /// Encoded/decoded by serializers as &quot;AM07&quot;.
    /// </summary>
    [EnumMember(Value = "AM07")]
    [IsoId("_t5rYkPRYEeuLhpyIdtJzwg")]
    [Description(@"Amount specified in message has been blocked by regulatory authorities.")]
    BlockedAmount,

    /// <summary>
    /// Amount received is not the amount agreed or expected
    /// Encoded/decoded by serializers as &quot;AM09&quot;.
    /// </summary>
    [EnumMember(Value = "AM09")]
    [IsoId("_t5rYk_RYEeuLhpyIdtJzwg")]
    [Description(@"Amount received is not the amount agreed or expected")]
    WrongAmount,

    /// <summary>
    /// Sum of instructed amounts does not equal the control sum.
    /// Encoded/decoded by serializers as &quot;AM10&quot;.
    /// </summary>
    [EnumMember(Value = "AM10")]
    [IsoId("_t5rYlvRYEeuLhpyIdtJzwg")]
    [Description(@"Sum of instructed amounts does not equal the control sum.")]
    InvalidControlSum,

    /// <summary>
    /// Already returned original SCT
    /// Encoded/decoded by serializers as &quot;ARDT&quot;.
    /// </summary>
    [EnumMember(Value = "ARDT")]
    [IsoId("_t5rYmfRYEeuLhpyIdtJzwg")]
    [Description(@"Already returned original SCT")]
    AlreadyReturnedTransaction,

    /// <summary>
    /// Identification of end customer is not consistent with associated account number, organisation ID or private ID.
    /// Encoded/decoded by serializers as &quot;BE01&quot;.
    /// </summary>
    [EnumMember(Value = "BE01")]
    [IsoId("_t51JkPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Identification of end customer is not consistent with associated account number, organisation ID or private ID."
    )]
    InconsistenWithEndCustomer,

    /// <summary>
    /// Specification of creditor&apos;s address, which is required for payment, is missing/not correct (formerly IncorrectCreditorAddress).
    /// Encoded/decoded by serializers as &quot;BE04&quot;.
    /// </summary>
    [EnumMember(Value = "BE04")]
    [IsoId("_t51Jk_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Specification of creditor's address, which is required for payment, is missing/not correct (formerly IncorrectCreditorAddress)."
    )]
    MissingCreditorAddress,

    /// <summary>
    /// Party who initiated the message is not recognised by the end customer
    /// Encoded/decoded by serializers as &quot;BE05&quot;.
    /// </summary>
    [EnumMember(Value = "BE05")]
    [IsoId("_t5-6kPRYEeuLhpyIdtJzwg")]
    [Description(@"Party who initiated the message is not recognised by the end customer")]
    UnrecognisedInitiatingParty,

    /// <summary>
    /// End customer specified is not known at associated Sort/National Bank Code or does no longer exist in the books
    /// Encoded/decoded by serializers as &quot;BE06&quot;.
    /// </summary>
    [EnumMember(Value = "BE06")]
    [IsoId("_t5-6k_RYEeuLhpyIdtJzwg")]
    [Description(
        @"End customer specified is not known at associated Sort/National Bank Code or does no longer exist in the books"
    )]
    UnknownEndCustomer,

    /// <summary>
    /// Specification of debtor&apos;s address, which is required for payment, is missing/not correct.
    /// Encoded/decoded by serializers as &quot;BE07&quot;.
    /// </summary>
    [EnumMember(Value = "BE07")]
    [IsoId("_t5-6lvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Specification of debtor's address, which is required for payment, is missing/not correct."
    )]
    MissingDebtorAddress,

    /// <summary>
    /// Returned as a result of a bank error.
    /// Encoded/decoded by serializers as &quot;BE08&quot;.
    /// </summary>
    [EnumMember(Value = "BE08")]
    [IsoId("_t5-6mfRYEeuLhpyIdtJzwg")]
    [Description(@"Returned as a result of a bank error.")]
    BankError,

    /// <summary>
    /// Authorisation is cancelled.
    /// Encoded/decoded by serializers as &quot;CN01&quot;.
    /// </summary>
    [EnumMember(Value = "CN01")]
    [IsoId("_t5-6nPRYEeuLhpyIdtJzwg")]
    [Description(@"Authorisation is cancelled.")]
    AuthorisationCancelled,

    /// <summary>
    /// Creditor bank is not registered under this BIC in the CSM
    /// Encoded/decoded by serializers as &quot;CNOR&quot;.
    /// </summary>
    [EnumMember(Value = "CNOR")]
    [IsoId("_t6IEgPRYEeuLhpyIdtJzwg")]
    [Description(@"Creditor bank is not registered under this BIC in the CSM")]
    CreditorBankIsNotRegistered,

    /// <summary>
    /// Cash not picked up by Creditor or cash could not be delivered to Creditor
    /// Encoded/decoded by serializers as &quot;CNPC&quot;.
    /// </summary>
    [EnumMember(Value = "CNPC")]
    [IsoId("_t6R1gPRYEeuLhpyIdtJzwg")]
    [Description(@"Cash not picked up by Creditor or cash could not be delivered to Creditor")]
    CashNotPickedUp,

    /// <summary>
    /// Currency of the payment is incorrect
    /// Encoded/decoded by serializers as &quot;CURR&quot;.
    /// </summary>
    [EnumMember(Value = "CURR")]
    [IsoId("_t6R1g_RYEeuLhpyIdtJzwg")]
    [Description(@"Currency of the payment is incorrect")]
    IncorrectCurrency,

    /// <summary>
    /// Cancellation requested by the Debtor
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_t6R1hvRYEeuLhpyIdtJzwg")]
    [Description(@"Cancellation requested by the Debtor")]
    RequestedByCustomer,

    /// <summary>
    /// Debtor bank is not registered under this BIC in the CSM
    /// Encoded/decoded by serializers as &quot;DNOR&quot;.
    /// </summary>
    [EnumMember(Value = "DNOR")]
    [IsoId("_t6bmgPRYEeuLhpyIdtJzwg")]
    [Description(@"Debtor bank is not registered under this BIC in the CSM")]
    DebtorBankIsNotRegistered,

    /// <summary>
    /// Return following technical problems resulting in erroneous transaction.
    /// Encoded/decoded by serializers as &quot;DS28&quot;.
    /// </summary>
    [EnumMember(Value = "DS28")]
    [IsoId("_t6bmg_RYEeuLhpyIdtJzwg")]
    [Description(@"Return following technical problems resulting in erroneous transaction.")]
    ReturnForTechnicalReason,

    /// <summary>
    /// Invalid date (eg, wrong settlement date)
    /// Encoded/decoded by serializers as &quot;DT01&quot;.
    /// </summary>
    [EnumMember(Value = "DT01")]
    [IsoId("_t6kwcPRYEeuLhpyIdtJzwg")]
    [Description(@"Invalid date (eg, wrong settlement date)")]
    InvalidDate,

    /// <summary>
    /// Cheque has been issued but not deposited and is considered expired.
    /// Encoded/decoded by serializers as &quot;DT02&quot;.
    /// </summary>
    [EnumMember(Value = "DT02")]
    [IsoId("_t6kwc_RYEeuLhpyIdtJzwg")]
    [Description(@"Cheque has been issued but not deposited and is considered expired.")]
    ChequeExpired,

    /// <summary>
    /// Correspondent bank not possible.
    /// Encoded/decoded by serializers as &quot;ED01&quot;.
    /// </summary>
    [EnumMember(Value = "ED01")]
    [IsoId("_t6uhcPRYEeuLhpyIdtJzwg")]
    [Description(@"Correspondent bank not possible.")]
    CorrespondentBankNotPossible,

    /// <summary>
    /// Balance of payments complementary info is requested
    /// Encoded/decoded by serializers as &quot;ED03&quot;.
    /// </summary>
    [EnumMember(Value = "ED03")]
    [IsoId("_t6uhc_RYEeuLhpyIdtJzwg")]
    [Description(@"Balance of payments complementary info is requested")]
    BalanceInfoRequest,

    /// <summary>
    /// Settlement of the transaction has failed.
    /// Encoded/decoded by serializers as &quot;ED05&quot;.
    /// </summary>
    [EnumMember(Value = "ED05")]
    [IsoId("_t6uhdvRYEeuLhpyIdtJzwg")]
    [Description(@"Settlement of the transaction has failed.")]
    SettlementFailed,

    /// <summary>
    /// The card payment is fraudulent and was not processed with EMV technology for an EMV card.
    /// Encoded/decoded by serializers as &quot;EMVL&quot;.
    /// </summary>
    [EnumMember(Value = "EMVL")]
    [IsoId("_t6uhefRYEeuLhpyIdtJzwg")]
    [Description(
        @"The card payment is fraudulent and was not processed with EMV technology for an EMV card. "
    )]
    EMVLiabilityShift,

    /// <summary>
    /// The Extended Remittance Information (ERI) option is not supported.
    /// Encoded/decoded by serializers as &quot;ERIN&quot;.
    /// </summary>
    [EnumMember(Value = "ERIN")]
    [IsoId("_t6uhfPRYEeuLhpyIdtJzwg")]
    [Description(@"The Extended Remittance Information (ERI) option is not supported.")]
    ERIOptionNotSupported,

    /// <summary>
    /// Local Instrument code is missing or invalid
    /// Encoded/decoded by serializers as &quot;FF05&quot;.
    /// </summary>
    [EnumMember(Value = "FF05")]
    [IsoId("_t63rYPRYEeuLhpyIdtJzwg")]
    [Description(@"Local Instrument code is missing or invalid")]
    InvalidLocalInstrumentCode,

    /// <summary>
    /// Return following a cancellation request
    /// Encoded/decoded by serializers as &quot;FOCR&quot;.
    /// </summary>
    [EnumMember(Value = "FOCR")]
    [IsoId("_t63rY_RYEeuLhpyIdtJzwg")]
    [Description(@"Return following a cancellation request")]
    FollowingCancellationRequest,

    /// <summary>
    /// Returned as a result of fraud.
    /// Encoded/decoded by serializers as &quot;FR01&quot;.
    /// </summary>
    [EnumMember(Value = "FR01")]
    [IsoId("_t7BcYPRYEeuLhpyIdtJzwg")]
    [Description(@"Returned as a result of fraud.")]
    Fraud,

    /// <summary>
    /// Final response/tracking is recalled as mandate is cancelled.
    /// Encoded/decoded by serializers as &quot;FRTR&quot;.
    /// </summary>
    [EnumMember(Value = "FRTR")]
    [IsoId("_t7BcY_RYEeuLhpyIdtJzwg")]
    [Description(@"Final response/tracking is recalled as mandate is cancelled.")]
    FinalResponseMandateCancelled,

    /// <summary>
    /// No Mandate
    /// Encoded/decoded by serializers as &quot;MD01&quot;.
    /// </summary>
    [EnumMember(Value = "MD01")]
    [IsoId("_t7BcZvRYEeuLhpyIdtJzwg")]
    [Description(@"No Mandate")]
    NoMandate,

    /// <summary>
    /// Mandate related information data required by the scheme is missing.
    /// Encoded/decoded by serializers as &quot;MD02&quot;.
    /// </summary>
    [EnumMember(Value = "MD02")]
    [IsoId("_t7LNYPRYEeuLhpyIdtJzwg")]
    [Description(@"Mandate related information data required by the scheme is missing.")]
    MissingMandatoryInformationInMandate,

    /// <summary>
    /// Return of funds requested by end customer
    /// Encoded/decoded by serializers as &quot;MD06&quot;.
    /// </summary>
    [EnumMember(Value = "MD06")]
    [IsoId("_t7LNY_RYEeuLhpyIdtJzwg")]
    [Description(@"Return of funds requested by end customer")]
    RefundRequestByEndCustomer,

    /// <summary>
    /// End customer is deceased.
    /// Encoded/decoded by serializers as &quot;MD07&quot;.
    /// </summary>
    [EnumMember(Value = "MD07")]
    [IsoId("_t7UXUPRYEeuLhpyIdtJzwg")]
    [Description(@"End customer is deceased.")]
    EndCustomerDeceased,

    /// <summary>
    /// Reason has not been specified by end customer
    /// Encoded/decoded by serializers as &quot;MS02&quot;.
    /// </summary>
    [EnumMember(Value = "MS02")]
    [IsoId("_t7UXU_RYEeuLhpyIdtJzwg")]
    [Description(@"Reason has not been specified by end customer")]
    NotSpecifiedReasonCustomerGenerated,

    /// <summary>
    /// Reason has not been specified by agent.
    /// Encoded/decoded by serializers as &quot;MS03&quot;.
    /// </summary>
    [EnumMember(Value = "MS03")]
    [IsoId("_t7UXVvRYEeuLhpyIdtJzwg")]
    [Description(@"Reason has not been specified by agent.")]
    NotSpecifiedReasonAgentGenerated,

    /// <summary>
    /// Reason is provided as narrative information in the additional reason information.
    /// Encoded/decoded by serializers as &quot;NARR&quot;.
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("_t7eIUPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Reason is provided as narrative information in the additional reason information."
    )]
    Narrative,

    /// <summary>
    /// No response from Beneficiary
    /// Encoded/decoded by serializers as &quot;NOAS&quot;.
    /// </summary>
    [EnumMember(Value = "NOAS")]
    [IsoId("_t7eIU_RYEeuLhpyIdtJzwg")]
    [Description(@"No response from Beneficiary")]
    NoAnswerFromCustomer,

    /// <summary>
    /// Customer account is not compliant with regulatory requirements, for example FICA (in South Africa) or any other regulatory requirements which render an account inactive for certain processing.
    /// Encoded/decoded by serializers as &quot;NOCM&quot;.
    /// </summary>
    [EnumMember(Value = "NOCM")]
    [IsoId("_t7eIVvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Customer account is not compliant with regulatory requirements, for example FICA (in South Africa) or any other regulatory requirements which render an account inactive for certain processing."
    )]
    NotCompliant,

    /// <summary>
    /// Original SCT never received
    /// Encoded/decoded by serializers as &quot;NOOR&quot;.
    /// </summary>
    [EnumMember(Value = "NOOR")]
    [IsoId("_t7eIWfRYEeuLhpyIdtJzwg")]
    [Description(@"Original SCT never received")]
    NoOriginalTransactionReceived,

    /// <summary>
    /// The card payment is fraudulent (lost and stolen fraud) and was processed as EMV transaction without PIN verification.
    /// Encoded/decoded by serializers as &quot;PINL&quot;.
    /// </summary>
    [EnumMember(Value = "PINL")]
    [IsoId("_t7eIXPRYEeuLhpyIdtJzwg")]
    [Description(
        @"The card payment is fraudulent (lost and stolen fraud) and was processed as EMV transaction without PIN verification."
    )]
    PINLiabilityShift,

    /// <summary>
    /// Bank Identifier code specified in the message has an incorrect format (formerly IncorrectFormatForRoutingCode).
    /// Encoded/decoded by serializers as &quot;RC01&quot;.
    /// </summary>
    [EnumMember(Value = "RC01")]
    [IsoId("_t7n5UPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Bank Identifier code specified in the message has an incorrect format (formerly IncorrectFormatForRoutingCode)."
    )]
    BankIdentifierIncorrect,

    /// <summary>
    /// Incorrrect BIC of the beneficiary Bank in the SCTR
    /// Encoded/decoded by serializers as &quot;RC07&quot;.
    /// </summary>
    [EnumMember(Value = "RC07")]
    [IsoId("_t7n5U_RYEeuLhpyIdtJzwg")]
    [Description(@"Incorrrect BIC of the beneficiary Bank in the SCTR")]
    InvalidCreditorBICIdentifier,

    /// <summary>
    /// Transaction reference is not unique within the message.
    /// Encoded/decoded by serializers as &quot;RF01&quot;.
    /// </summary>
    [EnumMember(Value = "RF01")]
    [IsoId("_t7n5VvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction reference is not unique within the message.")]
    NotUniqueTransactionReference,

    /// <summary>
    /// Specification of the debtor’s account or unique identification needed for reasons of regulatory requirements is insufficient or missing
    /// Encoded/decoded by serializers as &quot;RR01&quot;.
    /// </summary>
    [EnumMember(Value = "RR01")]
    [IsoId("_t7n5WfRYEeuLhpyIdtJzwg")]
    [Description(
        @"Specification of the debtor’s account or unique identification needed for reasons of regulatory requirements is insufficient or missing"
    )]
    MissingDebtorAccountOrIdentification,

    /// <summary>
    /// Specification of the debtor’s name and/or address needed for regulatory requirements is insufficient or missing.
    /// Encoded/decoded by serializers as &quot;RR02&quot;.
    /// </summary>
    [EnumMember(Value = "RR02")]
    [IsoId("_t7xDQPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Specification of the debtor’s name and/or address needed for regulatory requirements is insufficient or missing."
    )]
    MissingDebtorNameOrAddress,

    /// <summary>
    /// Specification of the creditor’s name and/or address needed for regulatory requirements is insufficient or missing.
    /// Encoded/decoded by serializers as &quot;RR03&quot;.
    /// </summary>
    [EnumMember(Value = "RR03")]
    [IsoId("_t7xDQ_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Specification of the creditor’s name and/or address needed for regulatory requirements is insufficient or missing."
    )]
    MissingCreditorNameOrAddress,

    /// <summary>
    /// Regulatory Reason
    /// Encoded/decoded by serializers as &quot;RR04&quot;.
    /// </summary>
    [EnumMember(Value = "RR04")]
    [IsoId("_t7xDRvRYEeuLhpyIdtJzwg")]
    [Description(@"Regulatory Reason")]
    RegulatoryReason,

    /// <summary>
    /// Return following investigation request and no remediation possible.
    /// Encoded/decoded by serializers as &quot;RUTA&quot;.
    /// </summary>
    [EnumMember(Value = "RUTA")]
    [IsoId("_t760QPRYEeuLhpyIdtJzwg")]
    [Description(@"Return following investigation request and no remediation possible.")]
    ReturnUponUnableToApply,

    /// <summary>
    /// Due to specific service offered by the Debtor Agent
    /// Encoded/decoded by serializers as &quot;SL01&quot;.
    /// </summary>
    [EnumMember(Value = "SL01")]
    [IsoId("_t760Q_RYEeuLhpyIdtJzwg")]
    [Description(@"Due to specific service offered by the Debtor Agent")]
    SpecificServiceOfferedByDebtorAgent,

    /// <summary>
    /// Due to specific service offered by the Creditor Agent
    /// Encoded/decoded by serializers as &quot;SL02&quot;.
    /// </summary>
    [EnumMember(Value = "SL02")]
    [IsoId("_t760RvRYEeuLhpyIdtJzwg")]
    [Description(@"Due to specific service offered by the Creditor Agent")]
    SpecificServiceOfferedByCreditorAgent,

    /// <summary>
    /// Whitelisting service offered by the Debtor Agent; Debtor has not included the Creditor on its “Whitelist” (yet). In the Whitelist the Debtor may list all allowed Creditors to debit Debtor bank account.
    /// Encoded/decoded by serializers as &quot;SL11&quot;.
    /// </summary>
    [EnumMember(Value = "SL11")]
    [IsoId("_t760SfRYEeuLhpyIdtJzwg")]
    [Description(
        @"Whitelisting service offered by the Debtor Agent; Debtor has not included the Creditor on its “Whitelist” (yet). In the Whitelist the Debtor may list all allowed Creditors to debit Debtor bank account."
    )]
    CreditorNotOnWhitelistOfDebtor,

    /// <summary>
    /// Blacklisting service offered by the Debtor Agent; Debtor included the Creditor on his “Blacklist”. In the Blacklist the Debtor may list all Creditors not allowed to debit Debtor bank account.
    /// Encoded/decoded by serializers as &quot;SL12&quot;.
    /// </summary>
    [EnumMember(Value = "SL12")]
    [IsoId("_t8ElQPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Blacklisting service offered by the Debtor Agent; Debtor included the Creditor on his “Blacklist”. In the Blacklist the Debtor may list all Creditors not allowed to debit Debtor bank account."
    )]
    CreditorOnBlacklistOfDebtor,

    /// <summary>
    /// Due to Maximum allowed Direct Debit Transactions per period service offered by the Debtor Agent.
    /// Encoded/decoded by serializers as &quot;SL13&quot;.
    /// </summary>
    [EnumMember(Value = "SL13")]
    [IsoId("_t8ElQ_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Due to Maximum allowed Direct Debit Transactions per period service offered by the Debtor Agent."
    )]
    MaximumNumberOfDirectDebitTransactionsExceeded,

    /// <summary>
    /// Due to Maximum allowed Direct Debit Transaction amount service offered by the Debtor Agent.
    /// Encoded/decoded by serializers as &quot;SL14&quot;.
    /// </summary>
    [EnumMember(Value = "SL14")]
    [IsoId("_t8ElRvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Due to Maximum allowed Direct Debit Transaction amount service offered by the Debtor Agent."
    )]
    MaximumDirectDebitTransactionAmountExceeded,

    /// <summary>
    /// Payment is stopped by account holder.
    /// Encoded/decoded by serializers as &quot;SP01&quot;.
    /// </summary>
    [EnumMember(Value = "SP01")]
    [IsoId("_t8NvMPRYEeuLhpyIdtJzwg")]
    [Description(@"Payment is stopped by account holder.")]
    PaymentStopped,

    /// <summary>
    /// Previously stopped by means of a stop payment advise.
    /// Encoded/decoded by serializers as &quot;SP02&quot;.
    /// </summary>
    [EnumMember(Value = "SP02")]
    [IsoId("_t8NvM_RYEeuLhpyIdtJzwg")]
    [Description(@"Previously stopped by means of a stop payment advise.")]
    PreviouslyStopped,

    /// <summary>
    /// The card payment is returned since a cash amount rendered was not correct or goods or a service was not rendered to the customer, e.g. in an e-commerce situation.
    /// Encoded/decoded by serializers as &quot;SVNR&quot;.
    /// </summary>
    [EnumMember(Value = "SVNR")]
    [IsoId("_t8W5IPRYEeuLhpyIdtJzwg")]
    [Description(
        @"The card payment is returned since a cash amount rendered was not correct or goods or a service was not rendered to the customer, e.g. in an e-commerce situation."
    )]
    ServiceNotRendered,

    /// <summary>
    /// Associated message was received after agreed processing cut-off time.
    /// Encoded/decoded by serializers as &quot;TM01&quot;.
    /// </summary>
    [EnumMember(Value = "TM01")]
    [IsoId("_t8W5I_RYEeuLhpyIdtJzwg")]
    [Description(@"Associated message was received after agreed processing cut-off time.")]
    CutOffTime,

    /// <summary>
    /// Return following direct debit being removed from tracking process.
    /// Encoded/decoded by serializers as &quot;TRAC&quot;.
    /// </summary>
    [EnumMember(Value = "TRAC")]
    [IsoId("_t8W5JvRYEeuLhpyIdtJzwg")]
    [Description(@"Return following direct debit being removed from tracking process.")]
    RemovedFromTracking,

    /// <summary>
    /// Payment is not justified.
    /// Encoded/decoded by serializers as &quot;UPAY&quot;.
    /// </summary>
    [EnumMember(Value = "UPAY")]
    [IsoId("_t8W5KfRYEeuLhpyIdtJzwg")]
    [Description(@"Payment is not justified.")]
    UnduePayment,

    /// <summary>
    /// Debtor account number invalid or missing.
    /// Encoded/decoded by serializers as &quot;AC02&quot;.
    /// </summary>
    [EnumMember(Value = "AC02")]
    [IsoId("_pATTgAQqEey95qpfbNuEwg")]
    [Description(@"Debtor account number invalid or missing.")]
    InvalidDebtorAccountNumber,

    /// <summary>
    /// Creditor account number closed.
    /// Encoded/decoded by serializers as &quot;AC07&quot;.
    /// </summary>
    [EnumMember(Value = "AC07")]
    [IsoId("_y0OEoAQqEey95qpfbNuEwg")]
    [Description(@"Creditor account number closed.")]
    ClosedCreditorAccountNumber,

    /// <summary>
    /// Agent in the payment workflow is incorrect.
    /// Encoded/decoded by serializers as &quot;AGNT&quot;.
    /// </summary>
    [EnumMember(Value = "AGNT")]
    [IsoId("_6tOoQAQqEey95qpfbNuEwg")]
    [Description(@"Agent in the payment workflow is incorrect.")]
    IncorrectAgent,

    /// <summary>
    /// Debtor account cannot be debited for a generic reason.
    /// Usage: Code value may be used in general purposes and as a replacement for AM04 if debtor bank does not reveal its customer&apos;s insufficient funds for privacy reasons.
    /// Encoded/decoded by serializers as &quot;AG07&quot;.
    /// </summary>
    [EnumMember(Value = "AG07")]
    [IsoId("_BKveQAQrEey95qpfbNuEwg")]
    [Description(
        @"Debtor account cannot be debited for a generic reason.|Usage: Code value may be used in general purposes and as a replacement for AM04 if debtor bank does not reveal its customer's insufficient funds for privacy reasons."
    )]
    UnsuccesfulDirectDebit,

    /// <summary>
    /// Debtor country code is missing or invalid.
    /// Encoded/decoded by serializers as &quot;BE10&quot;.
    /// </summary>
    [EnumMember(Value = "BE10")]
    [IsoId("_L76h0AQrEey95qpfbNuEwg")]
    [Description(@"Debtor country code is missing or invalid.")]
    InvalidDebtorCountry,

    /// <summary>
    /// Creditor country code is missing or invalid.
    /// Encoded/decoded by serializers as &quot;BE11&quot;.
    /// </summary>
    [EnumMember(Value = "BE11")]
    [IsoId("_SOZMgAQrEey95qpfbNuEwg")]
    [Description(@"Creditor country code is missing or invalid.")]
    InvalidCreditorCountry,

    /// <summary>
    /// Debtor or Ultimate Debtor identification code missing or invalid.
    /// Encoded/decoded by serializers as &quot;BE16&quot;.
    /// </summary>
    [EnumMember(Value = "BE16")]
    [IsoId("_j05o0AQuEey95qpfbNuEwg")]
    [Description(@"Debtor or Ultimate Debtor identification code missing or invalid.")]
    InvalidDebtorIdentificationCode,

    /// <summary>
    /// Creditor or Ultimate Creditor identification code missing or invalid.
    /// Encoded/decoded by serializers as &quot;BE17&quot;.
    /// </summary>
    [EnumMember(Value = "BE17")]
    [IsoId("_xDcGsAQuEey95qpfbNuEwg")]
    [Description(@"Creditor or Ultimate Creditor identification code missing or invalid.")]
    InvalidCreditorIdentificationCode,

    /// <summary>
    /// Payment Type Information is missing or invalid.
    /// Generic usage if cannot specify Service Level or Local Instrument code.
    /// Encoded/decoded by serializers as &quot;FF03&quot;.
    /// </summary>
    [EnumMember(Value = "FF03")]
    [IsoId("_4ZH60AQuEey95qpfbNuEwg")]
    [Description(
        @"Payment Type Information is missing or invalid.|Generic usage if cannot specify Service Level or Local Instrument code."
    )]
    InvalidPaymentTypeInformation,

    /// <summary>
    /// Service Level code is missing or invalid.
    /// Encoded/decoded by serializers as &quot;FF04&quot;.
    /// </summary>
    [EnumMember(Value = "FF04")]
    [IsoId("_HqWpMAQvEey95qpfbNuEwg")]
    [Description(@"Service Level code is missing or invalid.")]
    InvalidServiceLevelCode,

    /// <summary>
    /// Category Purpose code is missing or invalid.
    /// Encoded/decoded by serializers as &quot;FF06&quot;.
    /// </summary>
    [EnumMember(Value = "FF06")]
    [IsoId("_QhCWAAQvEey95qpfbNuEwg")]
    [Description(@"Category Purpose code is missing or invalid.")]
    InvalidCategoryPurposeCode,

    /// <summary>
    /// Purpose is missing or invalid.
    /// Encoded/decoded by serializers as &quot;FF07&quot;.
    /// </summary>
    [EnumMember(Value = "FF07")]
    [IsoId("_YMLcwAQvEey95qpfbNuEwg")]
    [Description(@"Purpose is missing or invalid.")]
    InvalidPurpose,

    /// <summary>
    /// In a FIToFI Customer Credit Transfer: Credit to the creditor’s account is pending, status Originator is waiting for funds provided via a cover. Update will follow from the Status Originator.
    /// Encoded/decoded by serializers as &quot;G004&quot;.
    /// </summary>
    [EnumMember(Value = "G004")]
    [IsoId("_d_0PUAQvEey95qpfbNuEwg")]
    [Description(
        @"In a FIToFI Customer Credit Transfer: Credit to the creditor’s account is pending, status Originator is waiting for funds provided via a cover. Update will follow from the Status Originator."
    )]
    CreditPendingFunds,

    /// <summary>
    /// Creditor or creditor&apos;s agent should not have collected the direct debit.
    /// Encoded/decoded by serializers as &quot;MD05&quot;.
    /// </summary>
    [EnumMember(Value = "MD05")]
    [IsoId("_nDLGMAQvEey95qpfbNuEwg")]
    [Description(@"Creditor or creditor's agent should not have collected the direct debit.")]
    CollectionNotDue,

    /// <summary>
    /// ClearingSystemMemberidentifier is invalid or missing.
    /// Generic usage if cannot specify between debit or credit account.
    /// Encoded/decoded by serializers as &quot;RC08&quot;.
    /// </summary>
    [EnumMember(Value = "RC08")]
    [IsoId("_tieE4AQvEey95qpfbNuEwg")]
    [Description(
        @"ClearingSystemMemberidentifier is invalid or missing.|Generic usage if cannot specify between debit or credit account."
    )]
    InvalidClearingSystemMemberIdentifier,

    /// <summary>
    /// Intermediary Agent is invalid or missing.
    /// Encoded/decoded by serializers as &quot;RC11&quot;.
    /// </summary>
    [EnumMember(Value = "RC11")]
    [IsoId("_AHll4AQwEey95qpfbNuEwg")]
    [Description(@"Intermediary Agent is invalid or missing.")]
    InvalidIntermediaryAgent,

    /// <summary>
    /// Regulatory or Central Bank Reporting information missing, incomplete or invalid.
    /// Encoded/decoded by serializers as &quot;RR05&quot;.
    /// </summary>
    [EnumMember(Value = "RR05")]
    [IsoId("_G6s4cAQwEey95qpfbNuEwg")]
    [Description(
        @"Regulatory or Central Bank Reporting information missing, incomplete or invalid."
    )]
    RegulatoryInformationInvalid,

    /// <summary>
    /// Tax information missing, incomplete or invalid.
    /// Encoded/decoded by serializers as &quot;RR06&quot;.
    /// </summary>
    [EnumMember(Value = "RR06")]
    [IsoId("_O0cb4AQwEey95qpfbNuEwg")]
    [Description(@"Tax information missing, incomplete or invalid.")]
    TaxInformationInvalid,

    /// <summary>
    /// Remittance information structure does not comply with rules for payment type.
    /// Encoded/decoded by serializers as &quot;RR07&quot;.
    /// </summary>
    [EnumMember(Value = "RR07")]
    [IsoId("_VViKUAQwEey95qpfbNuEwg")]
    [Description(@"Remittance information structure does not comply with rules for payment type.")]
    RemittanceInformationInvalid,

    /// <summary>
    /// Remittance information truncated to comply with rules for payment type.
    /// Encoded/decoded by serializers as &quot;RR08&quot;.
    /// </summary>
    [EnumMember(Value = "RR08")]
    [IsoId("_eAmdAAQwEey95qpfbNuEwg")]
    [Description(@"Remittance information truncated to comply with rules for payment type.")]
    RemittanceInformationTruncated,

    /// <summary>
    /// Structured creditor reference invalid or missing.
    /// Encoded/decoded by serializers as &quot;RR09&quot;.
    /// </summary>
    [EnumMember(Value = "RR09")]
    [IsoId("_lt1OcAQwEey95qpfbNuEwg")]
    [Description(@"Structured creditor reference invalid or missing.")]
    InvalidStructuredCreditorReference,

    /// <summary>
    /// Invalid or missing identification of a bank proprietary service.
    /// Encoded/decoded by serializers as &quot;RR11&quot;.
    /// </summary>
    [EnumMember(Value = "RR11")]
    [IsoId("_rlC5cAQwEey95qpfbNuEwg")]
    [Description(@"Invalid or missing identification of a bank proprietary service.")]
    InvalidDebtorAgentServiceIdentification,

    /// <summary>
    /// Invalid or missing identification required within a particular country or payment type.
    /// Encoded/decoded by serializers as &quot;RR12&quot;.
    /// </summary>
    [EnumMember(Value = "RR12")]
    [IsoId("_1sMvoAQwEey95qpfbNuEwg")]
    [Description(
        @"Invalid or missing identification required within a particular country or payment type."
    )]
    InvalidPartyIdentification,

    /// <summary>
    /// Return of Covering Settlement due to the underlying Credit Transfer details not being received.
    /// Encoded/decoded by serializers as &quot;DC04&quot;.
    /// </summary>
    [EnumMember(Value = "DC04")]
    [IsoId("_YHJOIOAdEey0k8vo1GQhqQ")]
    [Description(
        @"Return of Covering Settlement due to the underlying Credit Transfer details not being received."
    )]
    NoCustomerCreditTransferReceived,

    /// <summary>
    /// Creditor bank identifier is invalid or missing.
    /// Encoded/decoded by serializers as &quot;RC04&quot;.
    /// </summary>
    [EnumMember(Value = "RC04")]
    [IsoId("_UfcykMloEe2OhfSCsNFang")]
    [Description(@"Creditor bank identifier is invalid or missing.")]
    InvalidCreditorBankIdentifier,

    /// <summary>
    /// Future date not supported.
    /// Encoded/decoded by serializers as &quot;DT04&quot;.
    /// </summary>
    [EnumMember(Value = "DT04")]
    [IsoId("_UkqpwMloEe2OhfSCsNFang")]
    [Description(@"Future date not supported.")]
    FutureDateNotSupported,

    /// <summary>
    /// Payment is a duplicate of another payment.
    /// Encoded/decoded by serializers as &quot;DUPL&quot;.
    /// </summary>
    [EnumMember(Value = "DUPL")]
    [IsoId("_g7nYUMloEe2OhfSCsNFang")]
    [Description(@"Payment is a duplicate of another payment.")]
    DuplicatePayment,

    /// <summary>
    /// Debtor bank identifier is invalid or missing.
    /// Encoded/decoded by serializers as &quot;RC03&quot;.
    /// </summary>
    [EnumMember(Value = "RC03")]
    [IsoId("_tLkHAMloEe2OhfSCsNFang")]
    [Description(@"Debtor bank identifier is invalid or missing.")]
    InvalidDebtorBankIdentifier,
}
