// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for a transaction to be rejected or returned by an instructed agent or somebody acting on behalf of an instructed agent.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YtCmptp-Ed-ak6NoX_4Aeg_-996873465")]
[Description(
    @"Specifies the reason for a transaction to be rejected or returned by an instructed agent or somebody acting on behalf of an instructed agent."
)]
[DerivedFrom(typeof(TransactionReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TransactionRejectReason2Code>))]
#endif
public enum TransactionRejectReason2Code
{
    /// <summary>
    /// Format of the account number specified is not correct.
    /// Encoded/decoded by serializers as &quot;AC01&quot;.
    /// </summary>
    [EnumMember(Value = "AC01")]
    [IsoId("_YtCmp9p-Ed-ak6NoX_4Aeg_-996873447")]
    [Description(@"Format of the account number specified is not correct.")]
    IncorrectAccountNumber = TransactionReasonCode.IncorrectAccountNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account number specified has been closed on the Receiver&apos;s books.
    /// Encoded/decoded by serializers as &quot;AC04&quot;.
    /// </summary>
    [EnumMember(Value = "AC04")]
    [IsoId("_YtCmqNp-Ed-ak6NoX_4Aeg_-996873429")]
    [Description(@"Account number specified has been closed on the Receiver's books.")]
    ClosedAccountNumber = TransactionReasonCode.ClosedAccountNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account specified is blocked, prohibiting posting of transactions against it.
    /// Encoded/decoded by serializers as &quot;AC06&quot;.
    /// </summary>
    [EnumMember(Value = "AC06")]
    [IsoId("_YtMXoNp-Ed-ak6NoX_4Aeg_-996873404")]
    [Description(@"Account specified is blocked, prohibiting posting of transactions against it.")]
    BlockedAccount = TransactionReasonCode.BlockedAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specified message amount is equal to zero.
    /// Encoded/decoded by serializers as &quot;AM01&quot;.
    /// </summary>
    [EnumMember(Value = "AM01")]
    [IsoId("_YtMXodp-Ed-ak6NoX_4Aeg_-996873387")]
    [Description(@"Specified message amount is equal to zero.")]
    ZeroAmount = TransactionReasonCode.ZeroAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specified transaction/message amount is greater than allowed maximum.
    /// Encoded/decoded by serializers as &quot;AM02&quot;.
    /// </summary>
    [EnumMember(Value = "AM02")]
    [IsoId("_YtMXotp-Ed-ak6NoX_4Aeg_-996873352")]
    [Description(@"Specified transaction/message amount is greater than allowed maximum.")]
    NotAllowedAmount = TransactionReasonCode.NotAllowedAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specified message amount is in an non processable currency outside of existing agreement.
    /// Encoded/decoded by serializers as &quot;AM03&quot;.
    /// </summary>
    [EnumMember(Value = "AM03")]
    [IsoId("_YtMXo9p-Ed-ak6NoX_4Aeg_-996873334")]
    [Description(
        @"Specified message amount is in an non processable currency outside of existing agreement."
    )]
    NotAllowedCurrency = TransactionReasonCode.NotAllowedCurrency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount of funds available to cover specified message amount is insufficient.
    /// Encoded/decoded by serializers as &quot;AM04&quot;.
    /// </summary>
    [EnumMember(Value = "AM04")]
    [IsoId("_YtMXpNp-Ed-ak6NoX_4Aeg_-996873061")]
    [Description(@"Amount of funds available to cover specified message amount is insufficient.")]
    InsufficientFunds = TransactionReasonCode.InsufficientFunds, // same ordinal as derivation source for type conversions

    /// <summary>
    /// This message appears to have been duplicated.
    /// Encoded/decoded by serializers as &quot;AM05&quot;.
    /// </summary>
    [EnumMember(Value = "AM05")]
    [IsoId("_YtMXpdp-Ed-ak6NoX_4Aeg_-996873044")]
    [Description(@"This message appears to have been duplicated.")]
    Duplication = TransactionReasonCode.Duplication, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specified transaction amount is less than agreed minimum.
    /// Encoded/decoded by serializers as &quot;AM06&quot;.
    /// </summary>
    [EnumMember(Value = "AM06")]
    [IsoId("_YtMXptp-Ed-ak6NoX_4Aeg_-996873026")]
    [Description(@"Specified transaction amount is less than agreed minimum.")]
    TooLowAmount = TransactionReasonCode.TooLowAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount specified in message has been blocked by regulatory authorities.
    /// Encoded/decoded by serializers as &quot;AM07&quot;.
    /// </summary>
    [EnumMember(Value = "AM07")]
    [IsoId("_YtMXp9p-Ed-ak6NoX_4Aeg_-996873001")]
    [Description(@"Amount specified in message has been blocked by regulatory authorities.")]
    BlockedAmount = TransactionReasonCode.BlockedAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identification of end customer is not consistent with associated account number. (formerly CreditorConsistency).
    /// Encoded/decoded by serializers as &quot;BE01&quot;.
    /// </summary>
    [EnumMember(Value = "BE01")]
    [IsoId("_YtMXqNp-Ed-ak6NoX_4Aeg_-996872984")]
    [Description(
        @"Identification of end customer is not consistent with associated account number. (formerly CreditorConsistency)."
    )]
    InconsistentWithEndCustomer = TransactionReasonCode.InconsistentWithEndCustomer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specification of creditor&apos;s address, which is required for payment, is missing/not correct (formerly IncorrectCreditorAddress).
    /// Encoded/decoded by serializers as &quot;BE04&quot;.
    /// </summary>
    [EnumMember(Value = "BE04")]
    [IsoId("_YtMXqdp-Ed-ak6NoX_4Aeg_-996872966")]
    [Description(
        @"Specification of creditor's address, which is required for payment, is missing/not correct (formerly IncorrectCreditorAddress)."
    )]
    MissingCreditorAddress = TransactionReasonCode.MissingCreditorAddress, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party who initiated the message is not recognised by the end customer.
    /// Encoded/decoded by serializers as &quot;BE05&quot;.
    /// </summary>
    [EnumMember(Value = "BE05")]
    [IsoId("_YtVhkNp-Ed-ak6NoX_4Aeg_-996872931")]
    [Description(@"Party who initiated the message is not recognised by the end customer.")]
    UnrecognisedInitiatingParty = TransactionReasonCode.UnrecognisedInitiatingParty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction forbidden on this type of account (formerly NoAgreement).
    /// Encoded/decoded by serializers as &quot;AG01&quot;.
    /// </summary>
    [EnumMember(Value = "AG01")]
    [IsoId("_YtVhkdp-Ed-ak6NoX_4Aeg_-996872906")]
    [Description(@"Transaction forbidden on this type of account (formerly NoAgreement).")]
    TransactionForbidden = TransactionReasonCode.TransactionForbidden, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bank Operation code specified in the message is not valid for receiver.
    /// Encoded/decoded by serializers as &quot;AG02&quot;.
    /// </summary>
    [EnumMember(Value = "AG02")]
    [IsoId("_YtVhktp-Ed-ak6NoX_4Aeg_-996872889")]
    [Description(@"Bank Operation code specified in the message is not valid for receiver.")]
    InvalidBankOperationCode = TransactionReasonCode.InvalidBankOperationCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid date (eg, wrong settlement date).
    /// Encoded/decoded by serializers as &quot;DT01&quot;.
    /// </summary>
    [EnumMember(Value = "DT01")]
    [IsoId("_YtVhk9p-Ed-ak6NoX_4Aeg_-996872871")]
    [Description(@"Invalid date (eg, wrong settlement date).")]
    InvalidDate = TransactionReasonCode.InvalidDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction reference is not unique within the message.
    /// Encoded/decoded by serializers as &quot;RF01&quot;.
    /// </summary>
    [EnumMember(Value = "RF01")]
    [IsoId("_YtVhlNp-Ed-ak6NoX_4Aeg_-996872846")]
    [Description(@"Transaction reference is not unique within the message.")]
    NotUniqueTransactionReference = TransactionReasonCode.NotUniqueTransactionReference, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bank identifier code specified in the message has an incorrect format (formerly IncorrectFormatForRoutingCode).
    /// Encoded/decoded by serializers as &quot;RC01&quot;.
    /// </summary>
    [EnumMember(Value = "RC01")]
    [IsoId("_YtVhldp-Ed-ak6NoX_4Aeg_295595713")]
    [Description(
        @"Bank identifier code specified in the message has an incorrect format (formerly IncorrectFormatForRoutingCode)."
    )]
    BankIdentifierIncorrect = TransactionReasonCode.BankIdentifierIncorrect, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Associated message was received after agreed processing cut-off time.
    /// Encoded/decoded by serializers as &quot;TM01&quot;.
    /// </summary>
    [EnumMember(Value = "TM01")]
    [IsoId("_YtVhltp-Ed-ak6NoX_4Aeg_-996872811")]
    [Description(@"Associated message was received after agreed processing cut-off time.")]
    CutOffTime = TransactionReasonCode.CutOffTime, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Correspondent bank not possible.
    /// Encoded/decoded by serializers as &quot;ED01&quot;.
    /// </summary>
    [EnumMember(Value = "ED01")]
    [IsoId("_YtVhl9p-Ed-ak6NoX_4Aeg_-996872794")]
    [Description(@"Correspondent bank not possible.")]
    CorrespondentBankNotPossible = TransactionReasonCode.CorrespondentBankNotPossible, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of payments complementary info is requested.
    /// Encoded/decoded by serializers as &quot;ED03&quot;.
    /// </summary>
    [EnumMember(Value = "ED03")]
    [IsoId("_YtVhmNp-Ed-ak6NoX_4Aeg_-996872776")]
    [Description(@"Balance of payments complementary info is requested.")]
    BalanceInfoRequested = TransactionReasonCode.BalanceInfoRequested, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reason has not been specified by agent.
    /// Encoded/decoded by serializers as &quot;MS03&quot;.
    /// </summary>
    [EnumMember(Value = "MS03")]
    [IsoId("_YtfSkNp-Ed-ak6NoX_4Aeg_-996872534")]
    [Description(@"Reason has not been specified by agent.")]
    NotSpecifiedReasonAgentGenerated = TransactionReasonCode.NotSpecifiedReasonAgentGenerated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reason has not been specified by end customer.
    /// Encoded/decoded by serializers as &quot;MS02&quot;.
    /// </summary>
    [EnumMember(Value = "MS02")]
    [IsoId("_YtfSkdp-Ed-ak6NoX_4Aeg_-996872517")]
    [Description(@"Reason has not been specified by end customer.")]
    NotSpecifiedReasonCustomerGenerated = TransactionReasonCode.NotSpecifiedReasonCustomerGenerated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// End customer specified is not known at associated Sort/National Bank Code or does no longer exist in the books.
    /// Encoded/decoded by serializers as &quot;BE06&quot;.
    /// </summary>
    [EnumMember(Value = "BE06")]
    [IsoId("_YtfSktp-Ed-ak6NoX_4Aeg_-996872499")]
    [Description(
        @"End customer specified is not known at associated Sort/National Bank Code or does no longer exist in the books."
    )]
    UnknownEndCustomer = TransactionReasonCode.UnknownEndCustomer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specification of debtor&apos;s address, which is required for payment, is missing/not correct.
    /// Encoded/decoded by serializers as &quot;BE07&quot;.
    /// </summary>
    [EnumMember(Value = "BE07")]
    [IsoId("_YtfSk9p-Ed-ak6NoX_4Aeg_-996872474")]
    [Description(
        @"Specification of debtor's address, which is required for payment, is missing/not correct."
    )]
    MissingDebtorAddress = TransactionReasonCode.MissingDebtorAddress, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount received is not the amount agreed or expected.
    /// Encoded/decoded by serializers as &quot;AM09&quot;.
    /// </summary>
    [EnumMember(Value = "AM09")]
    [IsoId("_YtfSlNp-Ed-ak6NoX_4Aeg_-996872457")]
    [Description(@"Amount received is not the amount agreed or expected.")]
    WrongAmount = TransactionReasonCode.WrongAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Sum of instructed amounts does not equal the control sum.
    /// Encoded/decoded by serializers as &quot;AM10&quot;.
    /// </summary>
    [EnumMember(Value = "AM10")]
    [IsoId("_YtfSldp-Ed-ak6NoX_4Aeg_-996872439")]
    [Description(@"Sum of instructed amounts does not equal the control sum.")]
    InvalidControlSum = TransactionReasonCode.InvalidControlSum, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Mandate is cancelled or invalid.
    /// Encoded/decoded by serializers as &quot;MD01&quot;.
    /// </summary>
    [EnumMember(Value = "MD01")]
    [IsoId("_YtfSltp-Ed-ak6NoX_4Aeg_-996872422")]
    [Description(@"Mandate is cancelled or invalid.")]
    NoMandate = TransactionReasonCode.NoMandate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Mandate related information data required by the scheme is missing.
    /// Encoded/decoded by serializers as &quot;MD02&quot;.
    /// </summary>
    [EnumMember(Value = "MD02")]
    [IsoId("_YtfSl9p-Ed-ak6NoX_4Aeg_-996872404")]
    [Description(@"Mandate related information data required by the scheme is missing.")]
    MissingMandatoryInformationInMandate =
        TransactionReasonCode.MissingMandatoryInformationInMandate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// File format incomplete or invalid.
    /// Encoded/decoded by serializers as &quot;MD03&quot;.
    /// </summary>
    [EnumMember(Value = "MD03")]
    [IsoId("_YtocgNp-Ed-ak6NoX_4Aeg_-996872379")]
    [Description(@"File format incomplete or invalid.")]
    InvalidFileFormatForOtherReasonThanGroupingIndicator =
        TransactionReasonCode.InvalidFileFormatForOtherReasonThanGroupingIndicator, // same ordinal as derivation source for type conversions

    /// <summary>
    /// File format incorrect in terms of grouping indicator.
    /// Encoded/decoded by serializers as &quot;MD04&quot;.
    /// </summary>
    [EnumMember(Value = "MD04")]
    [IsoId("_Ytocgdp-Ed-ak6NoX_4Aeg_-996872362")]
    [Description(@"File format incorrect in terms of grouping indicator.")]
    InvalidFileFormatForGroupingIndicator =
        TransactionReasonCode.InvalidFileFormatForGroupingIndicator, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Return of funds requested by end customer.
    /// Encoded/decoded by serializers as &quot;MD06&quot;.
    /// </summary>
    [EnumMember(Value = "MD06")]
    [IsoId("_Ytocgtp-Ed-ak6NoX_4Aeg_-996872096")]
    [Description(@"Return of funds requested by end customer.")]
    RefundRequestByEndCustomer = TransactionReasonCode.RefundRequestByEndCustomer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// End customer is deceased.
    /// Encoded/decoded by serializers as &quot;MD07&quot;.
    /// </summary>
    [EnumMember(Value = "MD07")]
    [IsoId("_Ytocg9p-Ed-ak6NoX_4Aeg_-996872071")]
    [Description(@"End customer is deceased.")]
    EndCustomerDeceased = TransactionReasonCode.EndCustomerDeceased, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement of the transaction has failed.
    /// Encoded/decoded by serializers as &quot;ED05&quot;.
    /// </summary>
    [EnumMember(Value = "ED05")]
    [IsoId("_YtochNp-Ed-ak6NoX_4Aeg_-996872054")]
    [Description(@"Settlement of the transaction has failed.")]
    SettlementFailed = TransactionReasonCode.SettlementFailed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reason is provided as narrative information in the additional reason information.
    /// Encoded/decoded by serializers as &quot;NARR&quot;.
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("_Ytochdp-Ed-ak6NoX_4Aeg_-812033499")]
    [Description(
        @"Reason is provided as narrative information in the additional reason information."
    )]
    Narrative = TransactionReasonCode.Narrative, // same ordinal as derivation source for type conversions
}
