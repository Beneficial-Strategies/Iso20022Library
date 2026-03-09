// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external mandate processing reason code in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Ps0OwMMxEeijqcQihwvv2A")]
[Description(@"Specifies the external mandate processing reason code in the format of character string with a maximum length of 4 characters.|The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org.")]
[Derivations(typeof(ExternalMandateReason1Code))]
public enum ExternalMandateReasonCode
{
    /// <summary>
    /// Format of the account number specified is not correct
    /// Encoded/decoded by serializers as &quot;AC01&quot;.
    /// </summary>
    [EnumMember(Value = "AC01")]
    [IsoId("_tqLkCfRYEeuLhpyIdtJzwg")]
    [Description(@"Format of the account number specified is not correct")]
    IncorrectAccountNumber,
    
    /// <summary>
    /// Account number specified has been closed on the Receiver&apos;s books
    /// Encoded/decoded by serializers as &quot;AC04&quot;.
    /// </summary>
    [EnumMember(Value = "AC04")]
    [IsoId("_tqVVAPRYEeuLhpyIdtJzwg")]
    [Description(@"Account number specified has been closed on the Receiver's books")]
    ClosedAccountNumber,
    
    /// <summary>
    /// Account specified is blocked, prohibiting posting of transactions against it.
    /// Encoded/decoded by serializers as &quot;AC06&quot;.
    /// </summary>
    [EnumMember(Value = "AC06")]
    [IsoId("_tqVVA_RYEeuLhpyIdtJzwg")]
    [Description(@"Account specified is blocked, prohibiting posting of transactions against it.")]
    BlockedAccount,
    
    /// <summary>
    /// Transaction forbidden on this type of account (formerly NoAgreement)
    /// Encoded/decoded by serializers as &quot;AG01&quot;.
    /// </summary>
    [EnumMember(Value = "AG01")]
    [IsoId("_tqVVBvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction forbidden on this type of account (formerly NoAgreement)")]
    TransactionForbidden,
    
    /// <summary>
    /// Bank Operation code specified in the message is not valid for receiver
    /// Encoded/decoded by serializers as &quot;AG02&quot;.
    /// </summary>
    [EnumMember(Value = "AG02")]
    [IsoId("_tqee8PRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Operation code specified in the message is not valid for receiver")]
    InvalidBankOperationCode,
    
    /// <summary>
    /// Specific transaction/message amount is greater than allowed maximum
    /// Encoded/decoded by serializers as &quot;AM02&quot;.
    /// </summary>
    [EnumMember(Value = "AM02")]
    [IsoId("_tqee8_RYEeuLhpyIdtJzwg")]
    [Description(@"Specific transaction/message amount is greater than allowed maximum")]
    NotAllowedAmount,
    
    /// <summary>
    /// Specified message amount is a non processable currency outside of existing agreement
    /// Encoded/decoded by serializers as &quot;AM03&quot;.
    /// </summary>
    [EnumMember(Value = "AM03")]
    [IsoId("_tqee9vRYEeuLhpyIdtJzwg")]
    [Description(@"Specified message amount is a non processable currency outside of existing agreement")]
    NotAllowedCurrency,
    
    /// <summary>
    /// Duplication 
    /// Encoded/decoded by serializers as &quot;AM05&quot;.
    /// </summary>
    [EnumMember(Value = "AM05")]
    [IsoId("_tqoP8PRYEeuLhpyIdtJzwg")]
    [Description(@"Duplication ")]
    Duplication,
    
    /// <summary>
    /// Identification of end customer is not consistent with associated account number. (formerly CreditorConsistency).
    /// Encoded/decoded by serializers as &quot;BE01&quot;.
    /// </summary>
    [EnumMember(Value = "BE01")]
    [IsoId("_tqoP8_RYEeuLhpyIdtJzwg")]
    [Description(@"Identification of end customer is not consistent with associated account number. (formerly CreditorConsistency).")]
    InconsistenWithEndCustomer,
    
    /// <summary>
    /// Specification of creditor&apos;s address, which is required for payment, is missing/not correct (formerly IncorrectCreditorAddress).
    /// Encoded/decoded by serializers as &quot;BE04&quot;.
    /// </summary>
    [EnumMember(Value = "BE04")]
    [IsoId("_tqoP9vRYEeuLhpyIdtJzwg")]
    [Description(@"Specification of creditor's address, which is required for payment, is missing/not correct (formerly IncorrectCreditorAddress).")]
    MissingCreditorAddress,
    
    /// <summary>
    /// Party who initiated the message is not recognised by the end customer
    /// Encoded/decoded by serializers as &quot;BE05&quot;.
    /// </summary>
    [EnumMember(Value = "BE05")]
    [IsoId("_tqoP-fRYEeuLhpyIdtJzwg")]
    [Description(@"Party who initiated the message is not recognised by the end customer")]
    UnrecognisedInitiatingParty,
    
    /// <summary>
    /// End customer specified is not known at associated Sort/National Bank Code or does no longer exist in the books
    /// Encoded/decoded by serializers as &quot;BE06&quot;.
    /// </summary>
    [EnumMember(Value = "BE06")]
    [IsoId("_tqyA8PRYEeuLhpyIdtJzwg")]
    [Description(@"End customer specified is not known at associated Sort/National Bank Code or does no longer exist in the books")]
    UnknownEndCustomer,
    
    /// <summary>
    /// Specification of debtor&apos;s address, which is required for payment, is missing/not correct.
    /// Encoded/decoded by serializers as &quot;BE07&quot;.
    /// </summary>
    [EnumMember(Value = "BE07")]
    [IsoId("_tqyA8_RYEeuLhpyIdtJzwg")]
    [Description(@"Specification of debtor's address, which is required for payment, is missing/not correct.")]
    MissingDebtorAddress,
    
    /// <summary>
    /// Invalid date (eg, wrong settlement date)
    /// Encoded/decoded by serializers as &quot;DT01&quot;.
    /// </summary>
    [EnumMember(Value = "DT01")]
    [IsoId("_tqyA9vRYEeuLhpyIdtJzwg")]
    [Description(@"Invalid date (eg, wrong settlement date)")]
    InvalidDate,
    
    /// <summary>
    /// File format incomplete or invalid
    /// Encoded/decoded by serializers as &quot;FF01&quot;.
    /// </summary>
    [EnumMember(Value = "FF01")]
    [IsoId("_tq7K4PRYEeuLhpyIdtJzwg")]
    [Description(@"File format incomplete or invalid")]
    InvalidFileFormat,
    
    /// <summary>
    /// No Mandate
    /// Encoded/decoded by serializers as &quot;MD01&quot;.
    /// </summary>
    [EnumMember(Value = "MD01")]
    [IsoId("_tq7K4_RYEeuLhpyIdtJzwg")]
    [Description(@"No Mandate")]
    NoMandate,
    
    /// <summary>
    /// Mandate related information data required by the scheme is missing.
    /// Encoded/decoded by serializers as &quot;MD02&quot;.
    /// </summary>
    [EnumMember(Value = "MD02")]
    [IsoId("_tq7K5vRYEeuLhpyIdtJzwg")]
    [Description(@"Mandate related information data required by the scheme is missing.")]
    MissingMandatoryInformationInMandate,
    
    /// <summary>
    /// End customer is deceased.
    /// Encoded/decoded by serializers as &quot;MD07&quot;.
    /// </summary>
    [EnumMember(Value = "MD07")]
    [IsoId("_tq7K6fRYEeuLhpyIdtJzwg")]
    [Description(@"End customer is deceased.")]
    EndCustomerDeceased,
    
    /// <summary>
    /// Receiving agent does not offer specified Mandate services
    /// Encoded/decoded by serializers as &quot;MD08&quot;.
    /// </summary>
    [EnumMember(Value = "MD08")]
    [IsoId("_trE74PRYEeuLhpyIdtJzwg")]
    [Description(@"Receiving agent does not offer specified Mandate services")]
    NoMandateServiceByAgent,
    
    /// <summary>
    /// Account is not open to specified Mandates services
    /// Encoded/decoded by serializers as &quot;MD09&quot;.
    /// </summary>
    [EnumMember(Value = "MD09")]
    [IsoId("_trE74_RYEeuLhpyIdtJzwg")]
    [Description(@"Account is not open to specified Mandates services")]
    NoMandateServiceOnCustomer,
    
    /// <summary>
    /// Account is not open to specified Mandates services for this particular creditor
    /// Encoded/decoded by serializers as &quot;MD10&quot;.
    /// </summary>
    [EnumMember(Value = "MD10")]
    [IsoId("_trE75vRYEeuLhpyIdtJzwg")]
    [Description(@"Account is not open to specified Mandates services for this particular creditor")]
    NoMandateServiceForSpecified,
    
    /// <summary>
    /// Agent to whom the message needs to be forwarded cannot be located
    /// Encoded/decoded by serializers as &quot;MD11&quot;.
    /// </summary>
    [EnumMember(Value = "MD11")]
    [IsoId("_trE76fRYEeuLhpyIdtJzwg")]
    [Description(@"Agent to whom the message needs to be forwarded cannot be located")]
    UnrecognisedAgent,
    
    /// <summary>
    /// Mandate identification is not unique to the creditor
    /// Encoded/decoded by serializers as &quot;MD12&quot;.
    /// </summary>
    [EnumMember(Value = "MD12")]
    [IsoId("_trOs4PRYEeuLhpyIdtJzwg")]
    [Description(@"Mandate identification is not unique to the creditor")]
    NotUniqueMandateReference,
    
    /// <summary>
    /// There is a problem with the customer authentication
    /// Encoded/decoded by serializers as &quot;MD13&quot;.
    /// </summary>
    [EnumMember(Value = "MD13")]
    [IsoId("_trOs4_RYEeuLhpyIdtJzwg")]
    [Description(@"There is a problem with the customer authentication")]
    IncorrectCustomerAuthentication,
    
    /// <summary>
    /// Agent in the payment workflow is incorrect
    /// Encoded/decoded by serializers as &quot;MD14&quot;.
    /// </summary>
    [EnumMember(Value = "MD14")]
    [IsoId("_trOs5vRYEeuLhpyIdtJzwg")]
    [Description(@"Agent in the payment workflow is incorrect")]
    IncorrectAgent,
    
    /// <summary>
    /// Currency of the transaction is incorrect
    /// Encoded/decoded by serializers as &quot;MD15&quot;.
    /// </summary>
    [EnumMember(Value = "MD15")]
    [IsoId("_trOs6fRYEeuLhpyIdtJzwg")]
    [Description(@"Currency of the transaction is incorrect")]
    IncorrectCurrency,
    
    /// <summary>
    /// Cancellation/amendment requested by the debtor
    /// Encoded/decoded by serializers as &quot;MD16&quot;.
    /// </summary>
    [EnumMember(Value = "MD16")]
    [IsoId("_trOs7PRYEeuLhpyIdtJzwg")]
    [Description(@"Cancellation/amendment requested by the debtor")]
    RequestedByCustomer,
    
    /// <summary>
    /// Cancellation/amendment requested by the creditor
    /// Encoded/decoded by serializers as &quot;MD17&quot;.
    /// </summary>
    [EnumMember(Value = "MD17")]
    [IsoId("_trX20PRYEeuLhpyIdtJzwg")]
    [Description(@"Cancellation/amendment requested by the creditor")]
    RequestedByInitiatingParty,
    
    /// <summary>
    /// Cancellation/amendment requested by the creditor and the debtor
    /// Encoded/decoded by serializers as &quot;MD18&quot;.
    /// </summary>
    [EnumMember(Value = "MD18")]
    [IsoId("_trX20_RYEeuLhpyIdtJzwg")]
    [Description(@"Cancellation/amendment requested by the creditor and the debtor")]
    RequestedByInitiatingPartyAndCustomer,
    
    /// <summary>
    /// Mandate cancellation following early reimbursement of the debit by the debtor
    /// Encoded/decoded by serializers as &quot;MD19&quot;.
    /// </summary>
    [EnumMember(Value = "MD19")]
    [IsoId("_trX21vRYEeuLhpyIdtJzwg")]
    [Description(@"Mandate cancellation following early reimbursement of the debit by the debtor")]
    MandateCancelledDueToEarlySettlement,
    
    /// <summary>
    /// Mandate cancellation following validity expiration
    /// Encoded/decoded by serializers as &quot;MD20&quot;.
    /// </summary>
    [EnumMember(Value = "MD20")]
    [IsoId("_trX22fRYEeuLhpyIdtJzwg")]
    [Description(@"Mandate cancellation following validity expiration")]
    MandateExpired,
    
    /// <summary>
    /// Mandate cancellation due to suspected fraud
    /// Encoded/decoded by serializers as &quot;MD21&quot;.
    /// </summary>
    [EnumMember(Value = "MD21")]
    [IsoId("_trhn0PRYEeuLhpyIdtJzwg")]
    [Description(@"Mandate cancellation due to suspected fraud")]
    MandateCancelledDueToFraud,
    
    /// <summary>
    /// Mandate cancellation following mandate initiation cancellation
    /// Encoded/decoded by serializers as &quot;MD22&quot;.
    /// </summary>
    [EnumMember(Value = "MD22")]
    [IsoId("_trhn0_RYEeuLhpyIdtJzwg")]
    [Description(@"Mandate cancellation following mandate initiation cancellation")]
    MandateInitiationCancelled,
    
    /// <summary>
    /// Mandate cancellation following mandate amendment cancellation
    /// Encoded/decoded by serializers as &quot;MD23&quot;.
    /// </summary>
    [EnumMember(Value = "MD23")]
    [IsoId("_trhn1vRYEeuLhpyIdtJzwg")]
    [Description(@"Mandate cancellation following mandate amendment cancellation")]
    MandateAmendmentCancelled,
    
    /// <summary>
    /// Reason has not been specified by end customer
    /// Encoded/decoded by serializers as &quot;MS02&quot;.
    /// </summary>
    [EnumMember(Value = "MS02")]
    [IsoId("_trhn2fRYEeuLhpyIdtJzwg")]
    [Description(@"Reason has not been specified by end customer")]
    NotSpecifiedReasonCustomerGenerated,
    
    /// <summary>
    /// Reason has not been specified by agent.
    /// Encoded/decoded by serializers as &quot;MS03&quot;.
    /// </summary>
    [EnumMember(Value = "MS03")]
    [IsoId("_trhn3PRYEeuLhpyIdtJzwg")]
    [Description(@"Reason has not been specified by agent.")]
    NotSpecifiedReasonAgentGenerated,
    
    /// <summary>
    /// Reason is provided as narrative information in the additional reason information.
    /// Encoded/decoded by serializers as &quot;NARR&quot;.
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("_trqxwPRYEeuLhpyIdtJzwg")]
    [Description(@"Reason is provided as narrative information in the additional reason information.")]
    Narrative,
    
    /// <summary>
    /// Bank Identifier code specified in the message has an incorrect format (formerly IncorrectFormatForRoutingCode).
    /// Encoded/decoded by serializers as &quot;RC01&quot;.
    /// </summary>
    [EnumMember(Value = "RC01")]
    [IsoId("_trqxw_RYEeuLhpyIdtJzwg")]
    [Description(@"Bank Identifier code specified in the message has an incorrect format (formerly IncorrectFormatForRoutingCode).")]
    BankIdentifierIncorrect,
    
    /// <summary>
    /// Transaction reference is not unique within the message.
    /// Encoded/decoded by serializers as &quot;RF01&quot;.
    /// </summary>
    [EnumMember(Value = "RF01")]
    [IsoId("_trqxxvRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction reference is not unique within the message.")]
    NotUniqueTransactionReference,
    
    /// <summary>
    /// Specification of the debtor’s account or unique identification needed for reasons of regulatory requirements is insufficient or missing
    /// Encoded/decoded by serializers as &quot;RR01&quot;.
    /// </summary>
    [EnumMember(Value = "RR01")]
    [IsoId("_tr0iwPRYEeuLhpyIdtJzwg")]
    [Description(@"Specification of the debtor’s account or unique identification needed for reasons of regulatory requirements is insufficient or missing")]
    MissingDebtorAccountOrIdentification,
    
    /// <summary>
    /// Specification of the debtor’s name and/or address needed for regulatory requirements is insufficient or missing.
    /// Encoded/decoded by serializers as &quot;RR02&quot;.
    /// </summary>
    [EnumMember(Value = "RR02")]
    [IsoId("_tr0iw_RYEeuLhpyIdtJzwg")]
    [Description(@"Specification of the debtor’s name and/or address needed for regulatory requirements is insufficient or missing.")]
    MissingDebtorNameOrAddress,
    
    /// <summary>
    /// Specification of the creditor’s name and/or address needed for regulatory requirements is insufficient or missing.
    /// Encoded/decoded by serializers as &quot;RR03&quot;.
    /// </summary>
    [EnumMember(Value = "RR03")]
    [IsoId("_tr0ixvRYEeuLhpyIdtJzwg")]
    [Description(@"Specification of the creditor’s name and/or address needed for regulatory requirements is insufficient or missing.")]
    MissingCreditorNameOrAddress,
    
    /// <summary>
    /// Regulatory Reason
    /// Encoded/decoded by serializers as &quot;RR04&quot;.
    /// </summary>
    [EnumMember(Value = "RR04")]
    [IsoId("_tr0iyfRYEeuLhpyIdtJzwg")]
    [Description(@"Regulatory Reason")]
    RegulatoryReason,
    
    /// <summary>
    /// Due to specific service offered by the Debtor Agent
    /// Encoded/decoded by serializers as &quot;SL01&quot;.
    /// </summary>
    [EnumMember(Value = "SL01")]
    [IsoId("_tr-TwPRYEeuLhpyIdtJzwg")]
    [Description(@"Due to specific service offered by the Debtor Agent")]
    SpecificServiceOfferedByDebtorAgent,
    
    /// <summary>
    /// Whitelisting service offered by the Debtor Agent; Debtor has not included the Creditor on its “Whitelist” (yet). In the Whitelist the Debtor may list all allowed Creditors to debit Debtor bank account.
    /// Encoded/decoded by serializers as &quot;SL11&quot;.
    /// </summary>
    [EnumMember(Value = "SL11")]
    [IsoId("_tr-Tw_RYEeuLhpyIdtJzwg")]
    [Description(@"Whitelisting service offered by the Debtor Agent; Debtor has not included the Creditor on its “Whitelist” (yet). In the Whitelist the Debtor may list all allowed Creditors to debit Debtor bank account.")]
    CreditorNotOnWhitelistOfDebtor,
    
    /// <summary>
    /// Blacklisting service offered by the Debtor Agent; Debtor included the Creditor on his “Blacklist”. In the Blacklist the Debtor may list all Creditors not allowed to debit Debtor bank account.
    /// Encoded/decoded by serializers as &quot;SL12&quot;.
    /// </summary>
    [EnumMember(Value = "SL12")]
    [IsoId("_tr-TxvRYEeuLhpyIdtJzwg")]
    [Description(@"Blacklisting service offered by the Debtor Agent; Debtor included the Creditor on his “Blacklist”. In the Blacklist the Debtor may list all Creditors not allowed to debit Debtor bank account.")]
    CreditorOnBlacklistOfDebtor,
    
    /// <summary>
    /// Due to Maximum allowed Direct Debit Transactions per period service offered by the Debtor Agent.
    /// Encoded/decoded by serializers as &quot;SL13&quot;.
    /// </summary>
    [EnumMember(Value = "SL13")]
    [IsoId("_tr-TyfRYEeuLhpyIdtJzwg")]
    [Description(@"Due to Maximum allowed Direct Debit Transactions per period service offered by the Debtor Agent.")]
    MaximumNumberOfDirectDebitTransactionsExceeded,
    
    /// <summary>
    /// Due to Maximum allowed Direct Debit Transaction amount service offered by the Debtor Agent.
    /// Encoded/decoded by serializers as &quot;SL14&quot;.
    /// </summary>
    [EnumMember(Value = "SL14")]
    [IsoId("_tr-TzPRYEeuLhpyIdtJzwg")]
    [Description(@"Due to Maximum allowed Direct Debit Transaction amount service offered by the Debtor Agent.")]
    MaximumDirectDebitTransactionAmountExceeded,
    
}
