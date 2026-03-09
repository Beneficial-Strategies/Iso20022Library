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
[IsoId("_amolg9p-Ed-ak6NoX_4Aeg_1571382159")]
[Description(@"Specifies the return reason, as published in an external return reason code list.|External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalReturnReasonCode))]
public enum ExternalReturnReason1Code
{
    /// <summary>
    /// Format of the account number specified is not correct
    /// Encoded/decoded by serializers as &quot;AC01&quot;.
    /// </summary>
    [EnumMember(Value = "AC01")]
    [IsoId("_t4yAu_RYEeuLhpyIdtJzwg")]
    [Description(@"Format of the account number specified is not correct")]
    IncorrectAccountNumber = ExternalReturnReasonCode.IncorrectAccountNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Wrong IBAN in SCT
    /// Encoded/decoded by serializers as &quot;AC03&quot;.
    /// </summary>
    [EnumMember(Value = "AC03")]
    [IsoId("_t4yAvvRYEeuLhpyIdtJzwg")]
    [Description(@"Wrong IBAN in SCT")]
    InvalidCreditorAccountNumber = ExternalReturnReasonCode.InvalidCreditorAccountNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account number specified has been closed on the bank of account&apos;s books
    /// Encoded/decoded by serializers as &quot;AC04&quot;.
    /// </summary>
    [EnumMember(Value = "AC04")]
    [IsoId("_t47xsvRYEeuLhpyIdtJzwg")]
    [Description(@"Account number specified has been closed on the bank of account's books")]
    ClosedAccountNumber = ExternalReturnReasonCode.ClosedAccountNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account specified is blocked, prohibiting posting of transactions against it.
    /// Encoded/decoded by serializers as &quot;AC06&quot;.
    /// </summary>
    [EnumMember(Value = "AC06")]
    [IsoId("_t47xtfRYEeuLhpyIdtJzwg")]
    [Description(@"Account specified is blocked, prohibiting posting of transactions against it.")]
    BlockedAccount = ExternalReturnReasonCode.BlockedAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Debtor account type is missing or invalid
    /// Encoded/decoded by serializers as &quot;AC13&quot;.
    /// </summary>
    [EnumMember(Value = "AC13")]
    [IsoId("_t47xuPRYEeuLhpyIdtJzwg")]
    [Description(@"Debtor account type is missing or invalid")]
    InvalidDebtorAccountType = ExternalReturnReasonCode.InvalidDebtorAccountType, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// An agent in the payment chain is invalid.
    /// Encoded/decoded by serializers as &quot;AC14&quot;.
    /// </summary>
    [EnumMember(Value = "AC14")]
    [IsoId("_t47xu_RYEeuLhpyIdtJzwg")]
    [Description(@"An agent in the payment chain is invalid.")]
    InvalidAgent = ExternalReturnReasonCode.InvalidAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account details have changed.
    /// Encoded/decoded by serializers as &quot;AC15&quot;.
    /// </summary>
    [EnumMember(Value = "AC15")]
    [IsoId("_t47xvvRYEeuLhpyIdtJzwg")]
    [Description(@"Account details have changed.")]
    AccountDetailsChanged = ExternalReturnReasonCode.AccountDetailsChanged, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account is in sequestration.
    /// Encoded/decoded by serializers as &quot;AC16&quot;.
    /// </summary>
    [EnumMember(Value = "AC16")]
    [IsoId("_t5FisvRYEeuLhpyIdtJzwg")]
    [Description(@"Account is in sequestration.")]
    AccountInSequestration = ExternalReturnReasonCode.AccountInSequestration, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account is in liquidation.
    /// Encoded/decoded by serializers as &quot;AC17&quot;.
    /// </summary>
    [EnumMember(Value = "AC17")]
    [IsoId("_t5FitfRYEeuLhpyIdtJzwg")]
    [Description(@"Account is in liquidation.")]
    AccountInLiquidation = ExternalReturnReasonCode.AccountInLiquidation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction forbidden on this type of account (formerly NoAgreement)
    /// Encoded/decoded by serializers as &quot;AG01&quot;.
    /// </summary>
    [EnumMember(Value = "AG01")]
    [IsoId("_t5OsovRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction forbidden on this type of account (formerly NoAgreement)")]
    TransactionForbidden = ExternalReturnReasonCode.TransactionForbidden, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bank Operation code specified in the message is not valid for receiver
    /// Encoded/decoded by serializers as &quot;AG02&quot;.
    /// </summary>
    [EnumMember(Value = "AG02")]
    [IsoId("_t5OspfRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Operation code specified in the message is not valid for receiver")]
    InvalidBankOperationCode = ExternalReturnReasonCode.InvalidBankOperationCode, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Specified message amount is equal to zero
    /// Encoded/decoded by serializers as &quot;AM01&quot;.
    /// </summary>
    [EnumMember(Value = "AM01")]
    [IsoId("_t5YdovRYEeuLhpyIdtJzwg")]
    [Description(@"Specified message amount is equal to zero")]
    ZeroAmount = ExternalReturnReasonCode.ZeroAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Specific transaction/message amount is greater than allowed maximum
    /// Encoded/decoded by serializers as &quot;AM02&quot;.
    /// </summary>
    [EnumMember(Value = "AM02")]
    [IsoId("_t5YdpfRYEeuLhpyIdtJzwg")]
    [Description(@"Specific transaction/message amount is greater than allowed maximum")]
    NotAllowedAmount = ExternalReturnReasonCode.NotAllowedAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Specified message amount is an non processable currency outside of existing agreement
    /// Encoded/decoded by serializers as &quot;AM03&quot;.
    /// </summary>
    [EnumMember(Value = "AM03")]
    [IsoId("_t5iOovRYEeuLhpyIdtJzwg")]
    [Description(@"Specified message amount is an non processable currency outside of existing agreement")]
    NotAllowedCurrency = ExternalReturnReasonCode.NotAllowedCurrency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amount of funds available to cover specified message amount is insufficient.
    /// Encoded/decoded by serializers as &quot;AM04&quot;.
    /// </summary>
    [EnumMember(Value = "AM04")]
    [IsoId("_t5iOpfRYEeuLhpyIdtJzwg")]
    [Description(@"Amount of funds available to cover specified message amount is insufficient.")]
    InsufficientFunds = ExternalReturnReasonCode.InsufficientFunds, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Duplication
    /// Encoded/decoded by serializers as &quot;AM05&quot;.
    /// </summary>
    [EnumMember(Value = "AM05")]
    [IsoId("_t5iOqPRYEeuLhpyIdtJzwg")]
    [Description(@"Duplication")]
    Duplication = ExternalReturnReasonCode.Duplication, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Specified transaction amount is less than agreed minimum.
    /// Encoded/decoded by serializers as &quot;AM06&quot;.
    /// </summary>
    [EnumMember(Value = "AM06")]
    [IsoId("_t5iOq_RYEeuLhpyIdtJzwg")]
    [Description(@"Specified transaction amount is less than agreed minimum.")]
    TooLowAmount = ExternalReturnReasonCode.TooLowAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amount specified in message has been blocked by regulatory authorities.
    /// Encoded/decoded by serializers as &quot;AM07&quot;.
    /// </summary>
    [EnumMember(Value = "AM07")]
    [IsoId("_t5rYkvRYEeuLhpyIdtJzwg")]
    [Description(@"Amount specified in message has been blocked by regulatory authorities.")]
    BlockedAmount = ExternalReturnReasonCode.BlockedAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amount received is not the amount agreed or expected
    /// Encoded/decoded by serializers as &quot;AM09&quot;.
    /// </summary>
    [EnumMember(Value = "AM09")]
    [IsoId("_t5rYlfRYEeuLhpyIdtJzwg")]
    [Description(@"Amount received is not the amount agreed or expected")]
    WrongAmount = ExternalReturnReasonCode.WrongAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Sum of instructed amounts does not equal the control sum.
    /// Encoded/decoded by serializers as &quot;AM10&quot;.
    /// </summary>
    [EnumMember(Value = "AM10")]
    [IsoId("_t5rYmPRYEeuLhpyIdtJzwg")]
    [Description(@"Sum of instructed amounts does not equal the control sum.")]
    InvalidControlSum = ExternalReturnReasonCode.InvalidControlSum, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Already returned original SCT
    /// Encoded/decoded by serializers as &quot;ARDT&quot;.
    /// </summary>
    [EnumMember(Value = "ARDT")]
    [IsoId("_t5rYm_RYEeuLhpyIdtJzwg")]
    [Description(@"Already returned original SCT")]
    AlreadyReturnedTransaction = ExternalReturnReasonCode.AlreadyReturnedTransaction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identification of end customer is not consistent with associated account number, organisation ID or private ID.
    /// Encoded/decoded by serializers as &quot;BE01&quot;.
    /// </summary>
    [EnumMember(Value = "BE01")]
    [IsoId("_t51JkvRYEeuLhpyIdtJzwg")]
    [Description(@"Identification of end customer is not consistent with associated account number, organisation ID or private ID.")]
    InconsistenWithEndCustomer = ExternalReturnReasonCode.InconsistenWithEndCustomer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Specification of creditor&apos;s address, which is required for payment, is missing/not correct (formerly IncorrectCreditorAddress).
    /// Encoded/decoded by serializers as &quot;BE04&quot;.
    /// </summary>
    [EnumMember(Value = "BE04")]
    [IsoId("_t51JlfRYEeuLhpyIdtJzwg")]
    [Description(@"Specification of creditor's address, which is required for payment, is missing/not correct (formerly IncorrectCreditorAddress).")]
    MissingCreditorAddress = ExternalReturnReasonCode.MissingCreditorAddress, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Party who initiated the message is not recognised by the end customer
    /// Encoded/decoded by serializers as &quot;BE05&quot;.
    /// </summary>
    [EnumMember(Value = "BE05")]
    [IsoId("_t5-6kvRYEeuLhpyIdtJzwg")]
    [Description(@"Party who initiated the message is not recognised by the end customer")]
    UnrecognisedInitiatingParty = ExternalReturnReasonCode.UnrecognisedInitiatingParty, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// End customer specified is not known at associated Sort/National Bank Code or does no longer exist in the books
    /// Encoded/decoded by serializers as &quot;BE06&quot;.
    /// </summary>
    [EnumMember(Value = "BE06")]
    [IsoId("_t5-6lfRYEeuLhpyIdtJzwg")]
    [Description(@"End customer specified is not known at associated Sort/National Bank Code or does no longer exist in the books")]
    UnknownEndCustomer = ExternalReturnReasonCode.UnknownEndCustomer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Specification of debtor&apos;s address, which is required for payment, is missing/not correct.
    /// Encoded/decoded by serializers as &quot;BE07&quot;.
    /// </summary>
    [EnumMember(Value = "BE07")]
    [IsoId("_t5-6mPRYEeuLhpyIdtJzwg")]
    [Description(@"Specification of debtor's address, which is required for payment, is missing/not correct.")]
    MissingDebtorAddress = ExternalReturnReasonCode.MissingDebtorAddress, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Returned as a result of a bank error.
    /// Encoded/decoded by serializers as &quot;BE08&quot;.
    /// </summary>
    [EnumMember(Value = "BE08")]
    [IsoId("_t5-6m_RYEeuLhpyIdtJzwg")]
    [Description(@"Returned as a result of a bank error.")]
    BankError = ExternalReturnReasonCode.BankError, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Authorisation is cancelled.
    /// Encoded/decoded by serializers as &quot;CN01&quot;.
    /// </summary>
    [EnumMember(Value = "CN01")]
    [IsoId("_t5-6nvRYEeuLhpyIdtJzwg")]
    [Description(@"Authorisation is cancelled.")]
    AuthorisationCancelled = ExternalReturnReasonCode.AuthorisationCancelled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Creditor bank is not registered under this BIC in the CSM
    /// Encoded/decoded by serializers as &quot;CNOR&quot;.
    /// </summary>
    [EnumMember(Value = "CNOR")]
    [IsoId("_t6IEgvRYEeuLhpyIdtJzwg")]
    [Description(@"Creditor bank is not registered under this BIC in the CSM")]
    CreditorBankIsNotRegistered = ExternalReturnReasonCode.CreditorBankIsNotRegistered, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cash not picked up by Creditor or cash could not be delivered to Creditor
    /// Encoded/decoded by serializers as &quot;CNPC&quot;.
    /// </summary>
    [EnumMember(Value = "CNPC")]
    [IsoId("_t6R1gvRYEeuLhpyIdtJzwg")]
    [Description(@"Cash not picked up by Creditor or cash could not be delivered to Creditor")]
    CashNotPickedUp = ExternalReturnReasonCode.CashNotPickedUp, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Currency of the payment is incorrect
    /// Encoded/decoded by serializers as &quot;CURR&quot;.
    /// </summary>
    [EnumMember(Value = "CURR")]
    [IsoId("_t6R1hfRYEeuLhpyIdtJzwg")]
    [Description(@"Currency of the payment is incorrect")]
    IncorrectCurrency = ExternalReturnReasonCode.IncorrectCurrency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation requested by the Debtor
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_t6R1iPRYEeuLhpyIdtJzwg")]
    [Description(@"Cancellation requested by the Debtor")]
    RequestedByCustomer = ExternalReturnReasonCode.RequestedByCustomer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Debtor bank is not registered under this BIC in the CSM
    /// Encoded/decoded by serializers as &quot;DNOR&quot;.
    /// </summary>
    [EnumMember(Value = "DNOR")]
    [IsoId("_t6bmgvRYEeuLhpyIdtJzwg")]
    [Description(@"Debtor bank is not registered under this BIC in the CSM")]
    DebtorBankIsNotRegistered = ExternalReturnReasonCode.DebtorBankIsNotRegistered, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Return following technical problems resulting in erroneous transaction.
    /// Encoded/decoded by serializers as &quot;DS28&quot;.
    /// </summary>
    [EnumMember(Value = "DS28")]
    [IsoId("_t6bmhfRYEeuLhpyIdtJzwg")]
    [Description(@"Return following technical problems resulting in erroneous transaction.")]
    ReturnForTechnicalReason = ExternalReturnReasonCode.ReturnForTechnicalReason, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Invalid date (eg, wrong settlement date)
    /// Encoded/decoded by serializers as &quot;DT01&quot;.
    /// </summary>
    [EnumMember(Value = "DT01")]
    [IsoId("_t6kwcvRYEeuLhpyIdtJzwg")]
    [Description(@"Invalid date (eg, wrong settlement date)")]
    InvalidDate = ExternalReturnReasonCode.InvalidDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cheque has been issued but not deposited and is considered expired.
    /// Encoded/decoded by serializers as &quot;DT02&quot;.
    /// </summary>
    [EnumMember(Value = "DT02")]
    [IsoId("_t6kwdfRYEeuLhpyIdtJzwg")]
    [Description(@"Cheque has been issued but not deposited and is considered expired.")]
    ChequeExpired = ExternalReturnReasonCode.ChequeExpired, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Correspondent bank not possible.
    /// Encoded/decoded by serializers as &quot;ED01&quot;.
    /// </summary>
    [EnumMember(Value = "ED01")]
    [IsoId("_t6uhcvRYEeuLhpyIdtJzwg")]
    [Description(@"Correspondent bank not possible.")]
    CorrespondentBankNotPossible = ExternalReturnReasonCode.CorrespondentBankNotPossible, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Balance of payments complementary info is requested
    /// Encoded/decoded by serializers as &quot;ED03&quot;.
    /// </summary>
    [EnumMember(Value = "ED03")]
    [IsoId("_t6uhdfRYEeuLhpyIdtJzwg")]
    [Description(@"Balance of payments complementary info is requested")]
    BalanceInfoRequest = ExternalReturnReasonCode.BalanceInfoRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Settlement of the transaction has failed.
    /// Encoded/decoded by serializers as &quot;ED05&quot;.
    /// </summary>
    [EnumMember(Value = "ED05")]
    [IsoId("_t6uhePRYEeuLhpyIdtJzwg")]
    [Description(@"Settlement of the transaction has failed.")]
    SettlementFailed = ExternalReturnReasonCode.SettlementFailed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The card payment is fraudulent and was not processed with EMV technology for an EMV card. 
    /// Encoded/decoded by serializers as &quot;EMVL&quot;.
    /// </summary>
    [EnumMember(Value = "EMVL")]
    [IsoId("_t6uhe_RYEeuLhpyIdtJzwg")]
    [Description(@"The card payment is fraudulent and was not processed with EMV technology for an EMV card. ")]
    EMVLiabilityShift = ExternalReturnReasonCode.EMVLiabilityShift, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The Extended Remittance Information (ERI) option is not supported.
    /// Encoded/decoded by serializers as &quot;ERIN&quot;.
    /// </summary>
    [EnumMember(Value = "ERIN")]
    [IsoId("_t6uhfvRYEeuLhpyIdtJzwg")]
    [Description(@"The Extended Remittance Information (ERI) option is not supported.")]
    ERIOptionNotSupported = ExternalReturnReasonCode.ERIOptionNotSupported, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Local Instrument code is missing or invalid
    /// Encoded/decoded by serializers as &quot;FF05&quot;.
    /// </summary>
    [EnumMember(Value = "FF05")]
    [IsoId("_t63rYvRYEeuLhpyIdtJzwg")]
    [Description(@"Local Instrument code is missing or invalid")]
    InvalidLocalInstrumentCode = ExternalReturnReasonCode.InvalidLocalInstrumentCode, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Return following a cancellation request
    /// Encoded/decoded by serializers as &quot;FOCR&quot;.
    /// </summary>
    [EnumMember(Value = "FOCR")]
    [IsoId("_t63rZfRYEeuLhpyIdtJzwg")]
    [Description(@"Return following a cancellation request")]
    FollowingCancellationRequest = ExternalReturnReasonCode.FollowingCancellationRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Returned as a result of fraud.
    /// Encoded/decoded by serializers as &quot;FR01&quot;.
    /// </summary>
    [EnumMember(Value = "FR01")]
    [IsoId("_t7BcYvRYEeuLhpyIdtJzwg")]
    [Description(@"Returned as a result of fraud.")]
    Fraud = ExternalReturnReasonCode.Fraud, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Final response/tracking is recalled as mandate is cancelled.
    /// Encoded/decoded by serializers as &quot;FRTR&quot;.
    /// </summary>
    [EnumMember(Value = "FRTR")]
    [IsoId("_t7BcZfRYEeuLhpyIdtJzwg")]
    [Description(@"Final response/tracking is recalled as mandate is cancelled.")]
    FinalResponseMandateCancelled = ExternalReturnReasonCode.FinalResponseMandateCancelled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// No Mandate
    /// Encoded/decoded by serializers as &quot;MD01&quot;.
    /// </summary>
    [EnumMember(Value = "MD01")]
    [IsoId("_t7BcaPRYEeuLhpyIdtJzwg")]
    [Description(@"No Mandate")]
    NoMandate = ExternalReturnReasonCode.NoMandate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Mandate related information data required by the scheme is missing.
    /// Encoded/decoded by serializers as &quot;MD02&quot;.
    /// </summary>
    [EnumMember(Value = "MD02")]
    [IsoId("_t7LNYvRYEeuLhpyIdtJzwg")]
    [Description(@"Mandate related information data required by the scheme is missing.")]
    MissingMandatoryInformationInMandate = ExternalReturnReasonCode.MissingMandatoryInformationInMandate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Return of funds requested by end customer
    /// Encoded/decoded by serializers as &quot;MD06&quot;.
    /// </summary>
    [EnumMember(Value = "MD06")]
    [IsoId("_t7LNZfRYEeuLhpyIdtJzwg")]
    [Description(@"Return of funds requested by end customer")]
    RefundRequestByEndCustomer = ExternalReturnReasonCode.RefundRequestByEndCustomer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// End customer is deceased.
    /// Encoded/decoded by serializers as &quot;MD07&quot;.
    /// </summary>
    [EnumMember(Value = "MD07")]
    [IsoId("_t7UXUvRYEeuLhpyIdtJzwg")]
    [Description(@"End customer is deceased.")]
    EndCustomerDeceased = ExternalReturnReasonCode.EndCustomerDeceased, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reason has not been specified by end customer
    /// Encoded/decoded by serializers as &quot;MS02&quot;.
    /// </summary>
    [EnumMember(Value = "MS02")]
    [IsoId("_t7UXVfRYEeuLhpyIdtJzwg")]
    [Description(@"Reason has not been specified by end customer")]
    NotSpecifiedReasonCustomerGenerated = ExternalReturnReasonCode.NotSpecifiedReasonCustomerGenerated, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reason has not been specified by agent.
    /// Encoded/decoded by serializers as &quot;MS03&quot;.
    /// </summary>
    [EnumMember(Value = "MS03")]
    [IsoId("_t7UXWPRYEeuLhpyIdtJzwg")]
    [Description(@"Reason has not been specified by agent.")]
    NotSpecifiedReasonAgentGenerated = ExternalReturnReasonCode.NotSpecifiedReasonAgentGenerated, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reason is provided as narrative information in the additional reason information.
    /// Encoded/decoded by serializers as &quot;NARR&quot;.
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("_t7eIUvRYEeuLhpyIdtJzwg")]
    [Description(@"Reason is provided as narrative information in the additional reason information.")]
    Narrative = ExternalReturnReasonCode.Narrative, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// No response from Beneficiary
    /// Encoded/decoded by serializers as &quot;NOAS&quot;.
    /// </summary>
    [EnumMember(Value = "NOAS")]
    [IsoId("_t7eIVfRYEeuLhpyIdtJzwg")]
    [Description(@"No response from Beneficiary")]
    NoAnswerFromCustomer = ExternalReturnReasonCode.NoAnswerFromCustomer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Customer account is not compliant with regulatory requirements, for example FICA (in South Africa) or any other regulatory requirements which render an account inactive for certain processing.
    /// Encoded/decoded by serializers as &quot;NOCM&quot;.
    /// </summary>
    [EnumMember(Value = "NOCM")]
    [IsoId("_t7eIWPRYEeuLhpyIdtJzwg")]
    [Description(@"Customer account is not compliant with regulatory requirements, for example FICA (in South Africa) or any other regulatory requirements which render an account inactive for certain processing.")]
    NotCompliant = ExternalReturnReasonCode.NotCompliant, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Original SCT never received
    /// Encoded/decoded by serializers as &quot;NOOR&quot;.
    /// </summary>
    [EnumMember(Value = "NOOR")]
    [IsoId("_t7eIW_RYEeuLhpyIdtJzwg")]
    [Description(@"Original SCT never received")]
    NoOriginalTransactionReceived = ExternalReturnReasonCode.NoOriginalTransactionReceived, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The card payment is fraudulent (lost and stolen fraud) and was processed as EMV transaction without PIN verification.
    /// Encoded/decoded by serializers as &quot;PINL&quot;.
    /// </summary>
    [EnumMember(Value = "PINL")]
    [IsoId("_t7eIXvRYEeuLhpyIdtJzwg")]
    [Description(@"The card payment is fraudulent (lost and stolen fraud) and was processed as EMV transaction without PIN verification.")]
    PINLiabilityShift = ExternalReturnReasonCode.PINLiabilityShift, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bank Identifier code specified in the message has an incorrect format (formerly IncorrectFormatForRoutingCode).
    /// Encoded/decoded by serializers as &quot;RC01&quot;.
    /// </summary>
    [EnumMember(Value = "RC01")]
    [IsoId("_t7n5UvRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Identifier code specified in the message has an incorrect format (formerly IncorrectFormatForRoutingCode).")]
    BankIdentifierIncorrect = ExternalReturnReasonCode.BankIdentifierIncorrect, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Incorrrect BIC of the beneficiary Bank in the SCTR
    /// Encoded/decoded by serializers as &quot;RC07&quot;.
    /// </summary>
    [EnumMember(Value = "RC07")]
    [IsoId("_t7n5VfRYEeuLhpyIdtJzwg")]
    [Description(@"Incorrrect BIC of the beneficiary Bank in the SCTR")]
    InvalidCreditorBICIdentifier = ExternalReturnReasonCode.InvalidCreditorBICIdentifier, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction reference is not unique within the message.
    /// Encoded/decoded by serializers as &quot;RF01&quot;.
    /// </summary>
    [EnumMember(Value = "RF01")]
    [IsoId("_t7n5WPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction reference is not unique within the message.")]
    NotUniqueTransactionReference = ExternalReturnReasonCode.NotUniqueTransactionReference, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Specification of the debtor’s account or unique identification needed for reasons of regulatory requirements is insufficient or missing
    /// Encoded/decoded by serializers as &quot;RR01&quot;.
    /// </summary>
    [EnumMember(Value = "RR01")]
    [IsoId("_t7n5W_RYEeuLhpyIdtJzwg")]
    [Description(@"Specification of the debtor’s account or unique identification needed for reasons of regulatory requirements is insufficient or missing")]
    MissingDebtorAccountOrIdentification = ExternalReturnReasonCode.MissingDebtorAccountOrIdentification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Specification of the debtor’s name and/or address needed for regulatory requirements is insufficient or missing.
    /// Encoded/decoded by serializers as &quot;RR02&quot;.
    /// </summary>
    [EnumMember(Value = "RR02")]
    [IsoId("_t7xDQvRYEeuLhpyIdtJzwg")]
    [Description(@"Specification of the debtor’s name and/or address needed for regulatory requirements is insufficient or missing.")]
    MissingDebtorNameOrAddress = ExternalReturnReasonCode.MissingDebtorNameOrAddress, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Specification of the creditor’s name and/or address needed for regulatory requirements is insufficient or missing.
    /// Encoded/decoded by serializers as &quot;RR03&quot;.
    /// </summary>
    [EnumMember(Value = "RR03")]
    [IsoId("_t7xDRfRYEeuLhpyIdtJzwg")]
    [Description(@"Specification of the creditor’s name and/or address needed for regulatory requirements is insufficient or missing.")]
    MissingCreditorNameOrAddress = ExternalReturnReasonCode.MissingCreditorNameOrAddress, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Regulatory Reason
    /// Encoded/decoded by serializers as &quot;RR04&quot;.
    /// </summary>
    [EnumMember(Value = "RR04")]
    [IsoId("_t7xDSPRYEeuLhpyIdtJzwg")]
    [Description(@"Regulatory Reason")]
    RegulatoryReason = ExternalReturnReasonCode.RegulatoryReason, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Return following investigation request and no remediation possible.
    /// Encoded/decoded by serializers as &quot;RUTA&quot;.
    /// </summary>
    [EnumMember(Value = "RUTA")]
    [IsoId("_t760QvRYEeuLhpyIdtJzwg")]
    [Description(@"Return following investigation request and no remediation possible.")]
    ReturnUponUnableToApply = ExternalReturnReasonCode.ReturnUponUnableToApply, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Due to specific service offered by the Debtor Agent
    /// Encoded/decoded by serializers as &quot;SL01&quot;.
    /// </summary>
    [EnumMember(Value = "SL01")]
    [IsoId("_t760RfRYEeuLhpyIdtJzwg")]
    [Description(@"Due to specific service offered by the Debtor Agent")]
    SpecificServiceOfferedByDebtorAgent = ExternalReturnReasonCode.SpecificServiceOfferedByDebtorAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Due to specific service offered by the Creditor Agent
    /// Encoded/decoded by serializers as &quot;SL02&quot;.
    /// </summary>
    [EnumMember(Value = "SL02")]
    [IsoId("_t760SPRYEeuLhpyIdtJzwg")]
    [Description(@"Due to specific service offered by the Creditor Agent")]
    SpecificServiceOfferedByCreditorAgent = ExternalReturnReasonCode.SpecificServiceOfferedByCreditorAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Whitelisting service offered by the Debtor Agent; Debtor has not included the Creditor on its “Whitelist” (yet). In the Whitelist the Debtor may list all allowed Creditors to debit Debtor bank account.
    /// Encoded/decoded by serializers as &quot;SL11&quot;.
    /// </summary>
    [EnumMember(Value = "SL11")]
    [IsoId("_t760S_RYEeuLhpyIdtJzwg")]
    [Description(@"Whitelisting service offered by the Debtor Agent; Debtor has not included the Creditor on its “Whitelist” (yet). In the Whitelist the Debtor may list all allowed Creditors to debit Debtor bank account.")]
    CreditorNotOnWhitelistOfDebtor = ExternalReturnReasonCode.CreditorNotOnWhitelistOfDebtor, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Blacklisting service offered by the Debtor Agent; Debtor included the Creditor on his “Blacklist”. In the Blacklist the Debtor may list all Creditors not allowed to debit Debtor bank account.
    /// Encoded/decoded by serializers as &quot;SL12&quot;.
    /// </summary>
    [EnumMember(Value = "SL12")]
    [IsoId("_t8ElQvRYEeuLhpyIdtJzwg")]
    [Description(@"Blacklisting service offered by the Debtor Agent; Debtor included the Creditor on his “Blacklist”. In the Blacklist the Debtor may list all Creditors not allowed to debit Debtor bank account.")]
    CreditorOnBlacklistOfDebtor = ExternalReturnReasonCode.CreditorOnBlacklistOfDebtor, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Due to Maximum allowed Direct Debit Transactions per period service offered by the Debtor Agent.
    /// Encoded/decoded by serializers as &quot;SL13&quot;.
    /// </summary>
    [EnumMember(Value = "SL13")]
    [IsoId("_t8ElRfRYEeuLhpyIdtJzwg")]
    [Description(@"Due to Maximum allowed Direct Debit Transactions per period service offered by the Debtor Agent.")]
    MaximumNumberOfDirectDebitTransactionsExceeded = ExternalReturnReasonCode.MaximumNumberOfDirectDebitTransactionsExceeded, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Due to Maximum allowed Direct Debit Transaction amount service offered by the Debtor Agent.
    /// Encoded/decoded by serializers as &quot;SL14&quot;.
    /// </summary>
    [EnumMember(Value = "SL14")]
    [IsoId("_t8ElSPRYEeuLhpyIdtJzwg")]
    [Description(@"Due to Maximum allowed Direct Debit Transaction amount service offered by the Debtor Agent.")]
    MaximumDirectDebitTransactionAmountExceeded = ExternalReturnReasonCode.MaximumDirectDebitTransactionAmountExceeded, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment is stopped by account holder.
    /// Encoded/decoded by serializers as &quot;SP01&quot;.
    /// </summary>
    [EnumMember(Value = "SP01")]
    [IsoId("_t8NvMvRYEeuLhpyIdtJzwg")]
    [Description(@"Payment is stopped by account holder.")]
    PaymentStopped = ExternalReturnReasonCode.PaymentStopped, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Previously stopped by means of a stop payment advise.
    /// Encoded/decoded by serializers as &quot;SP02&quot;.
    /// </summary>
    [EnumMember(Value = "SP02")]
    [IsoId("_t8NvNfRYEeuLhpyIdtJzwg")]
    [Description(@"Previously stopped by means of a stop payment advise.")]
    PreviouslyStopped = ExternalReturnReasonCode.PreviouslyStopped, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The card payment is returned since a cash amount rendered was not correct or goods or a service was not rendered to the customer, e.g. in an e-commerce situation.
    /// Encoded/decoded by serializers as &quot;SVNR&quot;.
    /// </summary>
    [EnumMember(Value = "SVNR")]
    [IsoId("_t8W5IvRYEeuLhpyIdtJzwg")]
    [Description(@"The card payment is returned since a cash amount rendered was not correct or goods or a service was not rendered to the customer, e.g. in an e-commerce situation.")]
    ServiceNotRendered = ExternalReturnReasonCode.ServiceNotRendered, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Associated message was received after agreed processing cut-off time.
    /// Encoded/decoded by serializers as &quot;TM01&quot;.
    /// </summary>
    [EnumMember(Value = "TM01")]
    [IsoId("_t8W5JfRYEeuLhpyIdtJzwg")]
    [Description(@"Associated message was received after agreed processing cut-off time.")]
    CutOffTime = ExternalReturnReasonCode.CutOffTime, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Return following direct debit being removed from tracking process.
    /// Encoded/decoded by serializers as &quot;TRAC&quot;.
    /// </summary>
    [EnumMember(Value = "TRAC")]
    [IsoId("_t8W5KPRYEeuLhpyIdtJzwg")]
    [Description(@"Return following direct debit being removed from tracking process.")]
    RemovedFromTracking = ExternalReturnReasonCode.RemovedFromTracking, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment is not justified.
    /// Encoded/decoded by serializers as &quot;UPAY&quot;.
    /// </summary>
    [EnumMember(Value = "UPAY")]
    [IsoId("_t8W5K_RYEeuLhpyIdtJzwg")]
    [Description(@"Payment is not justified.")]
    UnduePayment = ExternalReturnReasonCode.UnduePayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Agent in the payment workflow is incorrect.
    /// Encoded/decoded by serializers as &quot;AGNT&quot;.
    /// </summary>
    [EnumMember(Value = "AGNT")]
    [IsoId("_VXp0wQQxEey95qpfbNuEwg")]
    [Description(@"Agent in the payment workflow is incorrect.")]
    IncorrectAgent = ExternalReturnReasonCode.IncorrectAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Category Purpose code is missing or invalid.
    /// Encoded/decoded by serializers as &quot;FF06&quot;.
    /// </summary>
    [EnumMember(Value = "FF06")]
    [IsoId("_V-i1oQQxEey95qpfbNuEwg")]
    [Description(@"Category Purpose code is missing or invalid.")]
    InvalidCategoryPurposeCode = ExternalReturnReasonCode.InvalidCategoryPurposeCode, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// ClearingSystemMemberidentifier is invalid or missing.
    /// Generic usage if cannot specify between debit or credit account.
    /// Encoded/decoded by serializers as &quot;RC08&quot;.
    /// </summary>
    [EnumMember(Value = "RC08")]
    [IsoId("_WRLdwQQxEey95qpfbNuEwg")]
    [Description(@"ClearingSystemMemberidentifier is invalid or missing.|Generic usage if cannot specify between debit or credit account.")]
    InvalidClearingSystemMemberIdentifier = ExternalReturnReasonCode.InvalidClearingSystemMemberIdentifier, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Creditor country code is missing or invalid.
    /// Encoded/decoded by serializers as &quot;BE11&quot;.
    /// </summary>
    [EnumMember(Value = "BE11")]
    [IsoId("_WzTTYQQxEey95qpfbNuEwg")]
    [Description(@"Creditor country code is missing or invalid.")]
    InvalidCreditorCountry = ExternalReturnReasonCode.InvalidCreditorCountry, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Creditor or Ultimate Creditor identification code missing or invalid.
    /// Encoded/decoded by serializers as &quot;BE17&quot;.
    /// </summary>
    [EnumMember(Value = "BE17")]
    [IsoId("_W6JiQQQxEey95qpfbNuEwg")]
    [Description(@"Creditor or Ultimate Creditor identification code missing or invalid.")]
    InvalidCreditorIdentificationCode = ExternalReturnReasonCode.InvalidCreditorIdentificationCode, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Debtor account number invalid or missing.
    /// Encoded/decoded by serializers as &quot;AC02&quot;.
    /// </summary>
    [EnumMember(Value = "AC02")]
    [IsoId("_XD_awQQxEey95qpfbNuEwg")]
    [Description(@"Debtor account number invalid or missing.")]
    InvalidDebtorAccountNumber = ExternalReturnReasonCode.InvalidDebtorAccountNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Invalid or missing identification of a bank proprietary service.
    /// Encoded/decoded by serializers as &quot;RR11&quot;.
    /// </summary>
    [EnumMember(Value = "RR11")]
    [IsoId("_XKGCwQQxEey95qpfbNuEwg")]
    [Description(@"Invalid or missing identification of a bank proprietary service.")]
    InvalidDebtorAgentServiceIdentification = ExternalReturnReasonCode.InvalidDebtorAgentServiceIdentification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Debtor country code is missing or invalid.
    /// Encoded/decoded by serializers as &quot;BE10&quot;.
    /// </summary>
    [EnumMember(Value = "BE10")]
    [IsoId("_XPm04QQxEey95qpfbNuEwg")]
    [Description(@"Debtor country code is missing or invalid.")]
    InvalidDebtorCountry = ExternalReturnReasonCode.InvalidDebtorCountry, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Debtor or Ultimate Debtor identification code missing or invalid.
    /// Encoded/decoded by serializers as &quot;BE16&quot;.
    /// </summary>
    [EnumMember(Value = "BE16")]
    [IsoId("_XWnb0QQxEey95qpfbNuEwg")]
    [Description(@"Debtor or Ultimate Debtor identification code missing or invalid.")]
    InvalidDebtorIdentificationCode = ExternalReturnReasonCode.InvalidDebtorIdentificationCode, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Intermediary Agent is invalid or missing.
    /// Encoded/decoded by serializers as &quot;RC11&quot;.
    /// </summary>
    [EnumMember(Value = "RC11")]
    [IsoId("_XdBl0QQxEey95qpfbNuEwg")]
    [Description(@"Intermediary Agent is invalid or missing.")]
    InvalidIntermediaryAgent = ExternalReturnReasonCode.InvalidIntermediaryAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Invalid or missing identification required within a particular country or payment type.
    /// Encoded/decoded by serializers as &quot;RR12&quot;.
    /// </summary>
    [EnumMember(Value = "RR12")]
    [IsoId("_Xi1S4QQxEey95qpfbNuEwg")]
    [Description(@"Invalid or missing identification required within a particular country or payment type.")]
    InvalidPartyIdentification = ExternalReturnReasonCode.InvalidPartyIdentification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment Type Information is missing or invalid.
    /// Generic usage if cannot specify Service Level or Local Instrument code.
    /// Encoded/decoded by serializers as &quot;FF03&quot;.
    /// </summary>
    [EnumMember(Value = "FF03")]
    [IsoId("_XrVHkQQxEey95qpfbNuEwg")]
    [Description(@"Payment Type Information is missing or invalid.|Generic usage if cannot specify Service Level or Local Instrument code.")]
    InvalidPaymentTypeInformation = ExternalReturnReasonCode.InvalidPaymentTypeInformation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Purpose is missing or invalid.
    /// Encoded/decoded by serializers as &quot;FF07&quot;.
    /// </summary>
    [EnumMember(Value = "FF07")]
    [IsoId("_XxlgkQQxEey95qpfbNuEwg")]
    [Description(@"Purpose is missing or invalid.")]
    InvalidPurpose = ExternalReturnReasonCode.InvalidPurpose, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Service Level code is missing or invalid.
    /// Encoded/decoded by serializers as &quot;FF04&quot;.
    /// </summary>
    [EnumMember(Value = "FF04")]
    [IsoId("_X3QDsQQxEey95qpfbNuEwg")]
    [Description(@"Service Level code is missing or invalid.")]
    InvalidServiceLevelCode = ExternalReturnReasonCode.InvalidServiceLevelCode, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Structured creditor reference invalid or missing.
    /// Encoded/decoded by serializers as &quot;RR09&quot;.
    /// </summary>
    [EnumMember(Value = "RR09")]
    [IsoId("_X9NhwQQxEey95qpfbNuEwg")]
    [Description(@"Structured creditor reference invalid or missing.")]
    InvalidStructuredCreditorReference = ExternalReturnReasonCode.InvalidStructuredCreditorReference, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Regulatory or Central Bank Reporting information missing, incomplete or invalid.
    /// Encoded/decoded by serializers as &quot;RR05&quot;.
    /// </summary>
    [EnumMember(Value = "RR05")]
    [IsoId("_Yeb_gQQxEey95qpfbNuEwg")]
    [Description(@"Regulatory or Central Bank Reporting information missing, incomplete or invalid.")]
    RegulatoryInformationInvalid = ExternalReturnReasonCode.RegulatoryInformationInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Remittance information structure does not comply with rules for payment type.
    /// Encoded/decoded by serializers as &quot;RR07&quot;.
    /// </summary>
    [EnumMember(Value = "RR07")]
    [IsoId("_Yk2JgQQxEey95qpfbNuEwg")]
    [Description(@"Remittance information structure does not comply with rules for payment type.")]
    RemittanceInformationInvalid = ExternalReturnReasonCode.RemittanceInformationInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Remittance information truncated to comply with rules for payment type.
    /// Encoded/decoded by serializers as &quot;RR08&quot;.
    /// </summary>
    [EnumMember(Value = "RR08")]
    [IsoId("_Yqp2kQQxEey95qpfbNuEwg")]
    [Description(@"Remittance information truncated to comply with rules for payment type.")]
    RemittanceInformationTruncated = ExternalReturnReasonCode.RemittanceInformationTruncated, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax information missing, incomplete or invalid.
    /// Encoded/decoded by serializers as &quot;RR06&quot;.
    /// </summary>
    [EnumMember(Value = "RR06")]
    [IsoId("_ZKZGkQQxEey95qpfbNuEwg")]
    [Description(@"Tax information missing, incomplete or invalid.")]
    TaxInformationInvalid = ExternalReturnReasonCode.TaxInformationInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Debtor account cannot be debited for a generic reason.
    /// Usage: Code value may be used in general purposes and as a replacement for AM04 if debtor bank does not reveal its customer&apos;s insufficient funds for privacy reasons.
    /// Encoded/decoded by serializers as &quot;AG07&quot;.
    /// </summary>
    [EnumMember(Value = "AG07")]
    [IsoId("_ZWdzsQQxEey95qpfbNuEwg")]
    [Description(@"Debtor account cannot be debited for a generic reason.|Usage: Code value may be used in general purposes and as a replacement for AM04 if debtor bank does not reveal its customer's insufficient funds for privacy reasons.")]
    UnsuccesfulDirectDebit = ExternalReturnReasonCode.UnsuccesfulDirectDebit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// In a FIToFI Customer Credit Transfer: Credit to the creditor’s account is pending, status Originator is waiting for funds provided via a cover. Update will follow from the Status Originator.
    /// Encoded/decoded by serializers as &quot;G004&quot;.
    /// </summary>
    [EnumMember(Value = "G004")]
    [IsoId("_aK6vcQQxEey95qpfbNuEwg")]
    [Description(@"In a FIToFI Customer Credit Transfer: Credit to the creditor’s account is pending, status Originator is waiting for funds provided via a cover. Update will follow from the Status Originator.")]
    CreditPendingFunds = ExternalReturnReasonCode.CreditPendingFunds, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Creditor or creditor&apos;s agent should not have collected the direct debit.
    /// Encoded/decoded by serializers as &quot;MD05&quot;.
    /// </summary>
    [EnumMember(Value = "MD05")]
    [IsoId("_aW1rkQQxEey95qpfbNuEwg")]
    [Description(@"Creditor or creditor's agent should not have collected the direct debit.")]
    CollectionNotDue = ExternalReturnReasonCode.CollectionNotDue, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Creditor account number closed.
    /// Encoded/decoded by serializers as &quot;AC07&quot;.
    /// </summary>
    [EnumMember(Value = "AC07")]
    [IsoId("_agq9AQQxEey95qpfbNuEwg")]
    [Description(@"Creditor account number closed.")]
    ClosedCreditorAccountNumber = ExternalReturnReasonCode.ClosedCreditorAccountNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Return of Covering Settlement due to the underlying Credit Transfer details not being received.
    /// Encoded/decoded by serializers as &quot;DC04&quot;.
    /// </summary>
    [EnumMember(Value = "DC04")]
    [IsoId("_8OoZseAdEey0k8vo1GQhqQ")]
    [Description(@"Return of Covering Settlement due to the underlying Credit Transfer details not being received.")]
    NoCustomerCreditTransferReceived = ExternalReturnReasonCode.NoCustomerCreditTransferReceived, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Creditor bank identifier is invalid or missing.
    /// Encoded/decoded by serializers as &quot;RC04&quot;.
    /// </summary>
    [EnumMember(Value = "RC04")]
    [IsoId("_UfcyksloEe2OhfSCsNFang")]
    [Description(@"Creditor bank identifier is invalid or missing.")]
    InvalidCreditorBankIdentifier = ExternalReturnReasonCode.InvalidCreditorBankIdentifier, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Future date not supported.
    /// Encoded/decoded by serializers as &quot;DT04&quot;.
    /// </summary>
    [EnumMember(Value = "DT04")]
    [IsoId("_UkqpwsloEe2OhfSCsNFang")]
    [Description(@"Future date not supported.")]
    FutureDateNotSupported = ExternalReturnReasonCode.FutureDateNotSupported, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment is a duplicate of another payment.
    /// Encoded/decoded by serializers as &quot;DUPL&quot;.
    /// </summary>
    [EnumMember(Value = "DUPL")]
    [IsoId("_g7nYUsloEe2OhfSCsNFang")]
    [Description(@"Payment is a duplicate of another payment.")]
    DuplicatePayment = ExternalReturnReasonCode.DuplicatePayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Debtor bank identifier is invalid or missing.
    /// Encoded/decoded by serializers as &quot;RC03&quot;.
    /// </summary>
    [EnumMember(Value = "RC03")]
    [IsoId("_tLkHAsloEe2OhfSCsNFang")]
    [Description(@"Debtor bank identifier is invalid or missing.")]
    InvalidDebtorBankIdentifier = ExternalReturnReasonCode.InvalidDebtorBankIdentifier, // same ordinal as derivation source for type conversions
    
}
