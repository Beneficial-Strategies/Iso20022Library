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
[IsoId("_ame0g9p-Ed-ak6NoX_4Aeg_-2059737298")]
[Description(
    @"Specifies the external mandate processing reason code in the format of character string with a maximum length of 4 characters.|The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalMandateReasonCode))]
public enum ExternalMandateReason1Code
{
    /// <summary>
    /// Format of the account number specified is not correct
    /// Encoded/decoded by serializers as &quot;AC01&quot;.
    /// </summary>
    [EnumMember(Value = "AC01")]
    [IsoId("_tqLkC_RYEeuLhpyIdtJzwg")]
    [Description(@"Format of the account number specified is not correct")]
    IncorrectAccountNumber = ExternalMandateReasonCode.IncorrectAccountNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account number specified has been closed on the Receiver&apos;s books
    /// Encoded/decoded by serializers as &quot;AC04&quot;.
    /// </summary>
    [EnumMember(Value = "AC04")]
    [IsoId("_tqVVAvRYEeuLhpyIdtJzwg")]
    [Description(@"Account number specified has been closed on the Receiver's books")]
    ClosedAccountNumber = ExternalMandateReasonCode.ClosedAccountNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account specified is blocked, prohibiting posting of transactions against it.
    /// Encoded/decoded by serializers as &quot;AC06&quot;.
    /// </summary>
    [EnumMember(Value = "AC06")]
    [IsoId("_tqVVBfRYEeuLhpyIdtJzwg")]
    [Description(@"Account specified is blocked, prohibiting posting of transactions against it.")]
    BlockedAccount = ExternalMandateReasonCode.BlockedAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction forbidden on this type of account (formerly NoAgreement)
    /// Encoded/decoded by serializers as &quot;AG01&quot;.
    /// </summary>
    [EnumMember(Value = "AG01")]
    [IsoId("_tqVVCPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction forbidden on this type of account (formerly NoAgreement)")]
    TransactionForbidden = ExternalMandateReasonCode.TransactionForbidden, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bank Operation code specified in the message is not valid for receiver
    /// Encoded/decoded by serializers as &quot;AG02&quot;.
    /// </summary>
    [EnumMember(Value = "AG02")]
    [IsoId("_tqee8vRYEeuLhpyIdtJzwg")]
    [Description(@"Bank Operation code specified in the message is not valid for receiver")]
    InvalidBankOperationCode = ExternalMandateReasonCode.InvalidBankOperationCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specific transaction/message amount is greater than allowed maximum
    /// Encoded/decoded by serializers as &quot;AM02&quot;.
    /// </summary>
    [EnumMember(Value = "AM02")]
    [IsoId("_tqee9fRYEeuLhpyIdtJzwg")]
    [Description(@"Specific transaction/message amount is greater than allowed maximum")]
    NotAllowedAmount = ExternalMandateReasonCode.NotAllowedAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specified message amount is a non processable currency outside of existing agreement
    /// Encoded/decoded by serializers as &quot;AM03&quot;.
    /// </summary>
    [EnumMember(Value = "AM03")]
    [IsoId("_tqee-PRYEeuLhpyIdtJzwg")]
    [Description(
        @"Specified message amount is a non processable currency outside of existing agreement"
    )]
    NotAllowedCurrency = ExternalMandateReasonCode.NotAllowedCurrency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Duplication
    /// Encoded/decoded by serializers as &quot;AM05&quot;.
    /// </summary>
    [EnumMember(Value = "AM05")]
    [IsoId("_tqoP8vRYEeuLhpyIdtJzwg")]
    [Description(@"Duplication ")]
    Duplication = ExternalMandateReasonCode.Duplication, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identification of end customer is not consistent with associated account number. (formerly CreditorConsistency).
    /// Encoded/decoded by serializers as &quot;BE01&quot;.
    /// </summary>
    [EnumMember(Value = "BE01")]
    [IsoId("_tqoP9fRYEeuLhpyIdtJzwg")]
    [Description(
        @"Identification of end customer is not consistent with associated account number. (formerly CreditorConsistency)."
    )]
    InconsistenWithEndCustomer = ExternalMandateReasonCode.InconsistenWithEndCustomer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specification of creditor&apos;s address, which is required for payment, is missing/not correct (formerly IncorrectCreditorAddress).
    /// Encoded/decoded by serializers as &quot;BE04&quot;.
    /// </summary>
    [EnumMember(Value = "BE04")]
    [IsoId("_tqoP-PRYEeuLhpyIdtJzwg")]
    [Description(
        @"Specification of creditor's address, which is required for payment, is missing/not correct (formerly IncorrectCreditorAddress)."
    )]
    MissingCreditorAddress = ExternalMandateReasonCode.MissingCreditorAddress, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party who initiated the message is not recognised by the end customer
    /// Encoded/decoded by serializers as &quot;BE05&quot;.
    /// </summary>
    [EnumMember(Value = "BE05")]
    [IsoId("_tqoP-_RYEeuLhpyIdtJzwg")]
    [Description(@"Party who initiated the message is not recognised by the end customer")]
    UnrecognisedInitiatingParty = ExternalMandateReasonCode.UnrecognisedInitiatingParty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// End customer specified is not known at associated Sort/National Bank Code or does no longer exist in the books
    /// Encoded/decoded by serializers as &quot;BE06&quot;.
    /// </summary>
    [EnumMember(Value = "BE06")]
    [IsoId("_tqyA8vRYEeuLhpyIdtJzwg")]
    [Description(
        @"End customer specified is not known at associated Sort/National Bank Code or does no longer exist in the books"
    )]
    UnknownEndCustomer = ExternalMandateReasonCode.UnknownEndCustomer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specification of debtor&apos;s address, which is required for payment, is missing/not correct.
    /// Encoded/decoded by serializers as &quot;BE07&quot;.
    /// </summary>
    [EnumMember(Value = "BE07")]
    [IsoId("_tqyA9fRYEeuLhpyIdtJzwg")]
    [Description(
        @"Specification of debtor's address, which is required for payment, is missing/not correct."
    )]
    MissingDebtorAddress = ExternalMandateReasonCode.MissingDebtorAddress, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid date (eg, wrong settlement date)
    /// Encoded/decoded by serializers as &quot;DT01&quot;.
    /// </summary>
    [EnumMember(Value = "DT01")]
    [IsoId("_tqyA-PRYEeuLhpyIdtJzwg")]
    [Description(@"Invalid date (eg, wrong settlement date)")]
    InvalidDate = ExternalMandateReasonCode.InvalidDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// File format incomplete or invalid
    /// Encoded/decoded by serializers as &quot;FF01&quot;.
    /// </summary>
    [EnumMember(Value = "FF01")]
    [IsoId("_tq7K4vRYEeuLhpyIdtJzwg")]
    [Description(@"File format incomplete or invalid")]
    InvalidFileFormat = ExternalMandateReasonCode.InvalidFileFormat, // same ordinal as derivation source for type conversions

    /// <summary>
    /// No Mandate
    /// Encoded/decoded by serializers as &quot;MD01&quot;.
    /// </summary>
    [EnumMember(Value = "MD01")]
    [IsoId("_tq7K5fRYEeuLhpyIdtJzwg")]
    [Description(@"No Mandate")]
    NoMandate = ExternalMandateReasonCode.NoMandate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Mandate related information data required by the scheme is missing.
    /// Encoded/decoded by serializers as &quot;MD02&quot;.
    /// </summary>
    [EnumMember(Value = "MD02")]
    [IsoId("_tq7K6PRYEeuLhpyIdtJzwg")]
    [Description(@"Mandate related information data required by the scheme is missing.")]
    MissingMandatoryInformationInMandate =
        ExternalMandateReasonCode.MissingMandatoryInformationInMandate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// End customer is deceased.
    /// Encoded/decoded by serializers as &quot;MD07&quot;.
    /// </summary>
    [EnumMember(Value = "MD07")]
    [IsoId("_tq7K6_RYEeuLhpyIdtJzwg")]
    [Description(@"End customer is deceased.")]
    EndCustomerDeceased = ExternalMandateReasonCode.EndCustomerDeceased, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Receiving agent does not offer specified Mandate services
    /// Encoded/decoded by serializers as &quot;MD08&quot;.
    /// </summary>
    [EnumMember(Value = "MD08")]
    [IsoId("_trE74vRYEeuLhpyIdtJzwg")]
    [Description(@"Receiving agent does not offer specified Mandate services")]
    NoMandateServiceByAgent = ExternalMandateReasonCode.NoMandateServiceByAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account is not open to specified Mandates services
    /// Encoded/decoded by serializers as &quot;MD09&quot;.
    /// </summary>
    [EnumMember(Value = "MD09")]
    [IsoId("_trE75fRYEeuLhpyIdtJzwg")]
    [Description(@"Account is not open to specified Mandates services")]
    NoMandateServiceOnCustomer = ExternalMandateReasonCode.NoMandateServiceOnCustomer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account is not open to specified Mandates services for this particular creditor
    /// Encoded/decoded by serializers as &quot;MD10&quot;.
    /// </summary>
    [EnumMember(Value = "MD10")]
    [IsoId("_trE76PRYEeuLhpyIdtJzwg")]
    [Description(
        @"Account is not open to specified Mandates services for this particular creditor"
    )]
    NoMandateServiceForSpecified = ExternalMandateReasonCode.NoMandateServiceForSpecified, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Agent to whom the message needs to be forwarded cannot be located
    /// Encoded/decoded by serializers as &quot;MD11&quot;.
    /// </summary>
    [EnumMember(Value = "MD11")]
    [IsoId("_trE76_RYEeuLhpyIdtJzwg")]
    [Description(@"Agent to whom the message needs to be forwarded cannot be located")]
    UnrecognisedAgent = ExternalMandateReasonCode.UnrecognisedAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Mandate identification is not unique to the creditor
    /// Encoded/decoded by serializers as &quot;MD12&quot;.
    /// </summary>
    [EnumMember(Value = "MD12")]
    [IsoId("_trOs4vRYEeuLhpyIdtJzwg")]
    [Description(@"Mandate identification is not unique to the creditor")]
    NotUniqueMandateReference = ExternalMandateReasonCode.NotUniqueMandateReference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// There is a problem with the customer authentication
    /// Encoded/decoded by serializers as &quot;MD13&quot;.
    /// </summary>
    [EnumMember(Value = "MD13")]
    [IsoId("_trOs5fRYEeuLhpyIdtJzwg")]
    [Description(@"There is a problem with the customer authentication")]
    IncorrectCustomerAuthentication = ExternalMandateReasonCode.IncorrectCustomerAuthentication, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Agent in the payment workflow is incorrect
    /// Encoded/decoded by serializers as &quot;MD14&quot;.
    /// </summary>
    [EnumMember(Value = "MD14")]
    [IsoId("_trOs6PRYEeuLhpyIdtJzwg")]
    [Description(@"Agent in the payment workflow is incorrect")]
    IncorrectAgent = ExternalMandateReasonCode.IncorrectAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Currency of the transaction is incorrect
    /// Encoded/decoded by serializers as &quot;MD15&quot;.
    /// </summary>
    [EnumMember(Value = "MD15")]
    [IsoId("_trOs6_RYEeuLhpyIdtJzwg")]
    [Description(@"Currency of the transaction is incorrect")]
    IncorrectCurrency = ExternalMandateReasonCode.IncorrectCurrency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation/amendment requested by the debtor
    /// Encoded/decoded by serializers as &quot;MD16&quot;.
    /// </summary>
    [EnumMember(Value = "MD16")]
    [IsoId("_trOs7vRYEeuLhpyIdtJzwg")]
    [Description(@"Cancellation/amendment requested by the debtor")]
    RequestedByCustomer = ExternalMandateReasonCode.RequestedByCustomer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation/amendment requested by the creditor
    /// Encoded/decoded by serializers as &quot;MD17&quot;.
    /// </summary>
    [EnumMember(Value = "MD17")]
    [IsoId("_trX20vRYEeuLhpyIdtJzwg")]
    [Description(@"Cancellation/amendment requested by the creditor")]
    RequestedByInitiatingParty = ExternalMandateReasonCode.RequestedByInitiatingParty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation/amendment requested by the creditor and the debtor
    /// Encoded/decoded by serializers as &quot;MD18&quot;.
    /// </summary>
    [EnumMember(Value = "MD18")]
    [IsoId("_trX21fRYEeuLhpyIdtJzwg")]
    [Description(@"Cancellation/amendment requested by the creditor and the debtor")]
    RequestedByInitiatingPartyAndCustomer =
        ExternalMandateReasonCode.RequestedByInitiatingPartyAndCustomer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Mandate cancellation following early reimbursement of the debit by the debtor
    /// Encoded/decoded by serializers as &quot;MD19&quot;.
    /// </summary>
    [EnumMember(Value = "MD19")]
    [IsoId("_trX22PRYEeuLhpyIdtJzwg")]
    [Description(@"Mandate cancellation following early reimbursement of the debit by the debtor")]
    MandateCancelledDueToEarlySettlement =
        ExternalMandateReasonCode.MandateCancelledDueToEarlySettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Mandate cancellation following validity expiration
    /// Encoded/decoded by serializers as &quot;MD20&quot;.
    /// </summary>
    [EnumMember(Value = "MD20")]
    [IsoId("_trX22_RYEeuLhpyIdtJzwg")]
    [Description(@"Mandate cancellation following validity expiration")]
    MandateExpired = ExternalMandateReasonCode.MandateExpired, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Mandate cancellation due to suspected fraud
    /// Encoded/decoded by serializers as &quot;MD21&quot;.
    /// </summary>
    [EnumMember(Value = "MD21")]
    [IsoId("_trhn0vRYEeuLhpyIdtJzwg")]
    [Description(@"Mandate cancellation due to suspected fraud")]
    MandateCancelledDueToFraud = ExternalMandateReasonCode.MandateCancelledDueToFraud, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Mandate cancellation following mandate initiation cancellation
    /// Encoded/decoded by serializers as &quot;MD22&quot;.
    /// </summary>
    [EnumMember(Value = "MD22")]
    [IsoId("_trhn1fRYEeuLhpyIdtJzwg")]
    [Description(@"Mandate cancellation following mandate initiation cancellation")]
    MandateInitiationCancelled = ExternalMandateReasonCode.MandateInitiationCancelled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Mandate cancellation following mandate amendment cancellation
    /// Encoded/decoded by serializers as &quot;MD23&quot;.
    /// </summary>
    [EnumMember(Value = "MD23")]
    [IsoId("_trhn2PRYEeuLhpyIdtJzwg")]
    [Description(@"Mandate cancellation following mandate amendment cancellation")]
    MandateAmendmentCancelled = ExternalMandateReasonCode.MandateAmendmentCancelled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reason has not been specified by end customer
    /// Encoded/decoded by serializers as &quot;MS02&quot;.
    /// </summary>
    [EnumMember(Value = "MS02")]
    [IsoId("_trhn2_RYEeuLhpyIdtJzwg")]
    [Description(@"Reason has not been specified by end customer")]
    NotSpecifiedReasonCustomerGenerated =
        ExternalMandateReasonCode.NotSpecifiedReasonCustomerGenerated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reason has not been specified by agent.
    /// Encoded/decoded by serializers as &quot;MS03&quot;.
    /// </summary>
    [EnumMember(Value = "MS03")]
    [IsoId("_trhn3vRYEeuLhpyIdtJzwg")]
    [Description(@"Reason has not been specified by agent.")]
    NotSpecifiedReasonAgentGenerated = ExternalMandateReasonCode.NotSpecifiedReasonAgentGenerated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reason is provided as narrative information in the additional reason information.
    /// Encoded/decoded by serializers as &quot;NARR&quot;.
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("_trqxwvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Reason is provided as narrative information in the additional reason information."
    )]
    Narrative = ExternalMandateReasonCode.Narrative, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bank Identifier code specified in the message has an incorrect format (formerly IncorrectFormatForRoutingCode).
    /// Encoded/decoded by serializers as &quot;RC01&quot;.
    /// </summary>
    [EnumMember(Value = "RC01")]
    [IsoId("_trqxxfRYEeuLhpyIdtJzwg")]
    [Description(
        @"Bank Identifier code specified in the message has an incorrect format (formerly IncorrectFormatForRoutingCode)."
    )]
    BankIdentifierIncorrect = ExternalMandateReasonCode.BankIdentifierIncorrect, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction reference is not unique within the message.
    /// Encoded/decoded by serializers as &quot;RF01&quot;.
    /// </summary>
    [EnumMember(Value = "RF01")]
    [IsoId("_trqxyPRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction reference is not unique within the message.")]
    NotUniqueTransactionReference = ExternalMandateReasonCode.NotUniqueTransactionReference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specification of the debtor’s account or unique identification needed for reasons of regulatory requirements is insufficient or missing
    /// Encoded/decoded by serializers as &quot;RR01&quot;.
    /// </summary>
    [EnumMember(Value = "RR01")]
    [IsoId("_tr0iwvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Specification of the debtor’s account or unique identification needed for reasons of regulatory requirements is insufficient or missing"
    )]
    MissingDebtorAccountOrIdentification =
        ExternalMandateReasonCode.MissingDebtorAccountOrIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specification of the debtor’s name and/or address needed for regulatory requirements is insufficient or missing.
    /// Encoded/decoded by serializers as &quot;RR02&quot;.
    /// </summary>
    [EnumMember(Value = "RR02")]
    [IsoId("_tr0ixfRYEeuLhpyIdtJzwg")]
    [Description(
        @"Specification of the debtor’s name and/or address needed for regulatory requirements is insufficient or missing."
    )]
    MissingDebtorNameOrAddress = ExternalMandateReasonCode.MissingDebtorNameOrAddress, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specification of the creditor’s name and/or address needed for regulatory requirements is insufficient or missing.
    /// Encoded/decoded by serializers as &quot;RR03&quot;.
    /// </summary>
    [EnumMember(Value = "RR03")]
    [IsoId("_tr0iyPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Specification of the creditor’s name and/or address needed for regulatory requirements is insufficient or missing."
    )]
    MissingCreditorNameOrAddress = ExternalMandateReasonCode.MissingCreditorNameOrAddress, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Regulatory Reason
    /// Encoded/decoded by serializers as &quot;RR04&quot;.
    /// </summary>
    [EnumMember(Value = "RR04")]
    [IsoId("_tr0iy_RYEeuLhpyIdtJzwg")]
    [Description(@"Regulatory Reason")]
    RegulatoryReason = ExternalMandateReasonCode.RegulatoryReason, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Due to specific service offered by the Debtor Agent
    /// Encoded/decoded by serializers as &quot;SL01&quot;.
    /// </summary>
    [EnumMember(Value = "SL01")]
    [IsoId("_tr-TwvRYEeuLhpyIdtJzwg")]
    [Description(@"Due to specific service offered by the Debtor Agent")]
    SpecificServiceOfferedByDebtorAgent =
        ExternalMandateReasonCode.SpecificServiceOfferedByDebtorAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Whitelisting service offered by the Debtor Agent; Debtor has not included the Creditor on its “Whitelist” (yet). In the Whitelist the Debtor may list all allowed Creditors to debit Debtor bank account.
    /// Encoded/decoded by serializers as &quot;SL11&quot;.
    /// </summary>
    [EnumMember(Value = "SL11")]
    [IsoId("_tr-TxfRYEeuLhpyIdtJzwg")]
    [Description(
        @"Whitelisting service offered by the Debtor Agent; Debtor has not included the Creditor on its “Whitelist” (yet). In the Whitelist the Debtor may list all allowed Creditors to debit Debtor bank account."
    )]
    CreditorNotOnWhitelistOfDebtor = ExternalMandateReasonCode.CreditorNotOnWhitelistOfDebtor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Blacklisting service offered by the Debtor Agent; Debtor included the Creditor on his “Blacklist”. In the Blacklist the Debtor may list all Creditors not allowed to debit Debtor bank account.
    /// Encoded/decoded by serializers as &quot;SL12&quot;.
    /// </summary>
    [EnumMember(Value = "SL12")]
    [IsoId("_tr-TyPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Blacklisting service offered by the Debtor Agent; Debtor included the Creditor on his “Blacklist”. In the Blacklist the Debtor may list all Creditors not allowed to debit Debtor bank account."
    )]
    CreditorOnBlacklistOfDebtor = ExternalMandateReasonCode.CreditorOnBlacklistOfDebtor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Due to Maximum allowed Direct Debit Transactions per period service offered by the Debtor Agent.
    /// Encoded/decoded by serializers as &quot;SL13&quot;.
    /// </summary>
    [EnumMember(Value = "SL13")]
    [IsoId("_tr-Ty_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Due to Maximum allowed Direct Debit Transactions per period service offered by the Debtor Agent."
    )]
    MaximumNumberOfDirectDebitTransactionsExceeded =
        ExternalMandateReasonCode.MaximumNumberOfDirectDebitTransactionsExceeded, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Due to Maximum allowed Direct Debit Transaction amount service offered by the Debtor Agent.
    /// Encoded/decoded by serializers as &quot;SL14&quot;.
    /// </summary>
    [EnumMember(Value = "SL14")]
    [IsoId("_tr-TzvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Due to Maximum allowed Direct Debit Transaction amount service offered by the Debtor Agent."
    )]
    MaximumDirectDebitTransactionAmountExceeded =
        ExternalMandateReasonCode.MaximumDirectDebitTransactionAmountExceeded, // same ordinal as derivation source for type conversions
}
