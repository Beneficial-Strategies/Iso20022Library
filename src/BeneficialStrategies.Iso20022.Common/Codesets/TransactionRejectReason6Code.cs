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
[IsoId("_VxSAINp-Ed-ak6NoX_4Aeg_1027067779")]
[Description(
    @"Specifies the reason for a transaction to be rejected or returned by an instructed agent or somebody acting on behalf of an instructed agent."
)]
[DerivedFrom(typeof(TransactionReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TransactionRejectReason6Code>))]
#endif
public enum TransactionRejectReason6Code
{
    /// <summary>
    /// Format of the account number specified is not correct.
    /// Encoded/decoded by serializers as &quot;AC01&quot;.
    /// </summary>
    [EnumMember(Value = "AC01")]
    [IsoId("_VxSAIdp-Ed-ak6NoX_4Aeg_1027067810")]
    [Description(@"Format of the account number specified is not correct.")]
    IncorrectAccountNumber = TransactionReasonCode.IncorrectAccountNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account number specified has been closed on the Receiver&apos;s books.
    /// Encoded/decoded by serializers as &quot;AC04&quot;.
    /// </summary>
    [EnumMember(Value = "AC04")]
    [IsoId("_VxSAItp-Ed-ak6NoX_4Aeg_1027067811")]
    [Description(@"Account number specified has been closed on the Receiver's books.")]
    ClosedAccountNumber = TransactionReasonCode.ClosedAccountNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account specified is blocked, prohibiting posting of transactions against it.
    /// Encoded/decoded by serializers as &quot;AC06&quot;.
    /// </summary>
    [EnumMember(Value = "AC06")]
    [IsoId("_VxSAI9p-Ed-ak6NoX_4Aeg_1027067841")]
    [Description(@"Account specified is blocked, prohibiting posting of transactions against it.")]
    BlockedAccount = TransactionReasonCode.BlockedAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction forbidden on this type of account (formerly NoAgreement).
    /// Encoded/decoded by serializers as &quot;AG01&quot;.
    /// </summary>
    [EnumMember(Value = "AG01")]
    [IsoId("_VxSAJNp-Ed-ak6NoX_4Aeg_1027067842")]
    [Description(@"Transaction forbidden on this type of account (formerly NoAgreement).")]
    TransactionForbidden = TransactionReasonCode.TransactionForbidden, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bank Operation code specified in the message is not valid for receiver.
    /// Encoded/decoded by serializers as &quot;AG02&quot;.
    /// </summary>
    [EnumMember(Value = "AG02")]
    [IsoId("_VxSAJdp-Ed-ak6NoX_4Aeg_1027067871")]
    [Description(@"Bank Operation code specified in the message is not valid for receiver.")]
    InvalidBankOperationCode = TransactionReasonCode.InvalidBankOperationCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount of funds available to cover specified message amount is insufficient.
    /// Encoded/decoded by serializers as &quot;AM04&quot;.
    /// </summary>
    [EnumMember(Value = "AM04")]
    [IsoId("_VxSAJtp-Ed-ak6NoX_4Aeg_1027067872")]
    [Description(@"Amount of funds available to cover specified message amount is insufficient.")]
    InsufficientFunds = TransactionReasonCode.InsufficientFunds, // same ordinal as derivation source for type conversions

    /// <summary>
    /// This message appears to have been duplicated.
    /// Encoded/decoded by serializers as &quot;AM05&quot;.
    /// </summary>
    [EnumMember(Value = "AM05")]
    [IsoId("_VxSAJ9p-Ed-ak6NoX_4Aeg_1027067902")]
    [Description(@"This message appears to have been duplicated.")]
    Duplication = TransactionReasonCode.Duplication, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Mandate is cancelled or invalid.
    /// Encoded/decoded by serializers as &quot;MD01&quot;.
    /// </summary>
    [EnumMember(Value = "MD01")]
    [IsoId("_VxSAKNp-Ed-ak6NoX_4Aeg_1027068149")]
    [Description(@"Mandate is cancelled or invalid.")]
    NoMandate = TransactionReasonCode.NoMandate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Mandate related information data required by the scheme is missing.
    /// Encoded/decoded by serializers as &quot;MD02&quot;.
    /// </summary>
    [EnumMember(Value = "MD02")]
    [IsoId("_VxSAKdp-Ed-ak6NoX_4Aeg_1027068150")]
    [Description(@"Mandate related information data required by the scheme is missing.")]
    MissingMandatoryInformationInMandate =
        TransactionReasonCode.MissingMandatoryInformationInMandate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// File format incomplete or invalid.
    /// Encoded/decoded by serializers as &quot;MD03&quot;.
    /// </summary>
    [EnumMember(Value = "MD03")]
    [IsoId("_VxbxINp-Ed-ak6NoX_4Aeg_1027068180")]
    [Description(@"File format incomplete or invalid.")]
    InvalidFileFormatForOtherReasonThanGroupingIndicator =
        TransactionReasonCode.InvalidFileFormatForOtherReasonThanGroupingIndicator, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bank identifier code specified in the message has an incorrect format (formerly IncorrectFormatForRoutingCode).
    /// Encoded/decoded by serializers as &quot;RC01&quot;.
    /// </summary>
    [EnumMember(Value = "RC01")]
    [IsoId("_VxbxIdp-Ed-ak6NoX_4Aeg_1027068181")]
    [Description(
        @"Bank identifier code specified in the message has an incorrect format (formerly IncorrectFormatForRoutingCode)."
    )]
    BankIdentifierIncorrect = TransactionReasonCode.BankIdentifierIncorrect, // same ordinal as derivation source for type conversions

    /// <summary>
    /// End customer is deceased.
    /// Encoded/decoded by serializers as &quot;MD07&quot;.
    /// </summary>
    [EnumMember(Value = "MD07")]
    [IsoId("_VxbxItp-Ed-ak6NoX_4Aeg_1027068211")]
    [Description(@"End customer is deceased.")]
    EndCustomerDeceased = TransactionReasonCode.EndCustomerDeceased, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reason has not been specified by end customer.
    /// Encoded/decoded by serializers as &quot;MS02&quot;.
    /// </summary>
    [EnumMember(Value = "MS02")]
    [IsoId("_VxbxI9p-Ed-ak6NoX_4Aeg_1700958883")]
    [Description(@"Reason has not been specified by end customer.")]
    NotSpecifiedReasonCustomerGenerated = TransactionReasonCode.NotSpecifiedReasonCustomerGenerated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reason has not been specified by agent.
    /// Encoded/decoded by serializers as &quot;MS03&quot;.
    /// </summary>
    [EnumMember(Value = "MS03")]
    [IsoId("_VxbxJNp-Ed-ak6NoX_4Aeg_1027068212")]
    [Description(@"Reason has not been specified by agent.")]
    NotSpecifiedReasonAgentGenerated = TransactionReasonCode.NotSpecifiedReasonAgentGenerated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Associated message was received after agreed processing cut-off time.
    /// Encoded/decoded by serializers as &quot;TM01&quot;.
    /// </summary>
    [EnumMember(Value = "TM01")]
    [IsoId("_VxbxJdp-Ed-ak6NoX_4Aeg_1027068241")]
    [Description(@"Associated message was received after agreed processing cut-off time.")]
    CutOffTime = TransactionReasonCode.CutOffTime, // same ordinal as derivation source for type conversions
}
