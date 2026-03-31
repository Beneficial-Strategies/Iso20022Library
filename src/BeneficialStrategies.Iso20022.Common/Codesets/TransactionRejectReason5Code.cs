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
[IsoId("_Yt7-gtp-Ed-ak6NoX_4Aeg_-68983603")]
[Description(
    @"Specifies the reason for a transaction to be rejected or returned by an instructed agent or somebody acting on behalf of an instructed agent."
)]
[DerivedFrom(typeof(TransactionReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TransactionRejectReason5Code>))]
#endif
public enum TransactionRejectReason5Code
{
    /// <summary>
    /// Format of the account number specified is not correct.
    /// Encoded/decoded by serializers as &quot;AC01&quot;.
    /// </summary>
    [EnumMember(Value = "AC01")]
    [IsoId("_Yt7-g9p-Ed-ak6NoX_4Aeg_-68063242")]
    [Description(@"Format of the account number specified is not correct.")]
    IncorrectAccountNumber = TransactionReasonCode.IncorrectAccountNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account number specified has been closed on the Receiver&apos;s books.
    /// Encoded/decoded by serializers as &quot;AC04&quot;.
    /// </summary>
    [EnumMember(Value = "AC04")]
    [IsoId("_Yt7-hNp-Ed-ak6NoX_4Aeg_-68063199")]
    [Description(@"Account number specified has been closed on the Receiver's books.")]
    ClosedAccountNumber = TransactionReasonCode.ClosedAccountNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account specified is blocked, prohibiting posting of transactions against it.
    /// Encoded/decoded by serializers as &quot;AC06&quot;.
    /// </summary>
    [EnumMember(Value = "AC06")]
    [IsoId("_Yt7-hdp-Ed-ak6NoX_4Aeg_-68063139")]
    [Description(@"Account specified is blocked, prohibiting posting of transactions against it.")]
    BlockedAccount = TransactionReasonCode.BlockedAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction forbidden on this type of account (formerly NoAgreement).
    /// Encoded/decoded by serializers as &quot;AG01&quot;.
    /// </summary>
    [EnumMember(Value = "AG01")]
    [IsoId("_Yt7-htp-Ed-ak6NoX_4Aeg_-68063069")]
    [Description(@"Transaction forbidden on this type of account (formerly NoAgreement).")]
    TransactionForbidden = TransactionReasonCode.TransactionForbidden, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount of funds available to cover specified message amount is insufficient.
    /// Encoded/decoded by serializers as &quot;AM04&quot;.
    /// </summary>
    [EnumMember(Value = "AM04")]
    [IsoId("_Yt7-h9p-Ed-ak6NoX_4Aeg_-68063009")]
    [Description(@"Amount of funds available to cover specified message amount is insufficient.")]
    InsufficientFunds = TransactionReasonCode.InsufficientFunds, // same ordinal as derivation source for type conversions

    /// <summary>
    /// This message appears to have been duplicated.
    /// Encoded/decoded by serializers as &quot;AM05&quot;.
    /// </summary>
    [EnumMember(Value = "AM05")]
    [IsoId("_Yt7-iNp-Ed-ak6NoX_4Aeg_-68062967")]
    [Description(@"This message appears to have been duplicated.")]
    Duplication = TransactionReasonCode.Duplication, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specification of creditor&apos;s address, which is required for payment, is missing/not correct (formerly IncorrectCreditorAddress).
    /// Encoded/decoded by serializers as &quot;BE04&quot;.
    /// </summary>
    [EnumMember(Value = "BE04")]
    [IsoId("_YuFIcNp-Ed-ak6NoX_4Aeg_-68063104")]
    [Description(
        @"Specification of creditor's address, which is required for payment, is missing/not correct (formerly IncorrectCreditorAddress)."
    )]
    MissingCreditorAddress = TransactionReasonCode.MissingCreditorAddress, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Mandate is cancelled or invalid.
    /// Encoded/decoded by serializers as &quot;MD01&quot;.
    /// </summary>
    [EnumMember(Value = "MD01")]
    [IsoId("_YuFIcdp-Ed-ak6NoX_4Aeg_-68062672")]
    [Description(@"Mandate is cancelled or invalid.")]
    NoMandate = TransactionReasonCode.NoMandate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Return of funds requested by end customer.
    /// Encoded/decoded by serializers as &quot;MD06&quot;.
    /// </summary>
    [EnumMember(Value = "MD06")]
    [IsoId("_YuFIctp-Ed-ak6NoX_4Aeg_-68062595")]
    [Description(@"Return of funds requested by end customer.")]
    RefundRequestByEndCustomer = TransactionReasonCode.RefundRequestByEndCustomer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// End customer is deceased.
    /// Encoded/decoded by serializers as &quot;MD07&quot;.
    /// </summary>
    [EnumMember(Value = "MD07")]
    [IsoId("_YuFIc9p-Ed-ak6NoX_4Aeg_-68062252")]
    [Description(@"End customer is deceased.")]
    EndCustomerDeceased = TransactionReasonCode.EndCustomerDeceased, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reason has not been specified by end customer.
    /// Encoded/decoded by serializers as &quot;MS02&quot;.
    /// </summary>
    [EnumMember(Value = "MS02")]
    [IsoId("_YuFIdNp-Ed-ak6NoX_4Aeg_-68062637")]
    [Description(@"Reason has not been specified by end customer.")]
    NotSpecifiedReasonCustomerGenerated = TransactionReasonCode.NotSpecifiedReasonCustomerGenerated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reason has not been specified by agent.
    /// Encoded/decoded by serializers as &quot;MS03&quot;.
    /// </summary>
    [EnumMember(Value = "MS03")]
    [IsoId("_YuFIddp-Ed-ak6NoX_4Aeg_-68062209")]
    [Description(@"Reason has not been specified by agent.")]
    NotSpecifiedReasonAgentGenerated = TransactionReasonCode.NotSpecifiedReasonAgentGenerated, // same ordinal as derivation source for type conversions
}
