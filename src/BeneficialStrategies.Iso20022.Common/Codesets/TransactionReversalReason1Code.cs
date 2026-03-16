// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for a transaction to be reversed by an instructed agent or somebody acting on behalf of an instructed agent.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YuFIdtp-Ed-ak6NoX_4Aeg_1201919260")]
[Description(
    @"Specifies the reason for a transaction to be reversed by an instructed agent or somebody acting on behalf of an instructed agent."
)]
[DerivedFrom(typeof(TransactionReasonCode))]
public enum TransactionReversalReason1Code
{
    /// <summary>
    /// Account number specified has been closed on the Receiver&apos;s books.
    /// Encoded/decoded by serializers as &quot;AC04&quot;.
    /// </summary>
    [EnumMember(Value = "AC04")]
    [IsoId("_YuFId9p-Ed-ak6NoX_4Aeg_1201920053")]
    [Description(@"Account number specified has been closed on the Receiver's books.")]
    ClosedAccountNumber = TransactionReasonCode.ClosedAccountNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// This message appears to have been duplicated.
    /// Encoded/decoded by serializers as &quot;AM05&quot;.
    /// </summary>
    [EnumMember(Value = "AM05")]
    [IsoId("_YuFIeNp-Ed-ak6NoX_4Aeg_1202840611")]
    [Description(@"This message appears to have been duplicated.")]
    Duplication = TransactionReasonCode.Duplication, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bank Operation code specified in the message is not valid for receiver.
    /// Encoded/decoded by serializers as &quot;AG02&quot;.
    /// </summary>
    [EnumMember(Value = "AG02")]
    [IsoId("_YuO5cNp-Ed-ak6NoX_4Aeg_1202842147")]
    [Description(@"Bank Operation code specified in the message is not valid for receiver.")]
    InvalidBankOperationCode = TransactionReasonCode.InvalidBankOperationCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Mandate is cancelled or invalid.
    /// Encoded/decoded by serializers as &quot;MD01&quot;.
    /// </summary>
    [EnumMember(Value = "MD01")]
    [IsoId("_YuO5cdp-Ed-ak6NoX_4Aeg_1204688750")]
    [Description(@"Mandate is cancelled or invalid.")]
    NoMandate = TransactionReasonCode.NoMandate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Creditor or creditor&apos;s agent should not have collected the direct debit.
    /// Encoded/decoded by serializers as &quot;MD05&quot;.
    /// </summary>
    [EnumMember(Value = "MD05")]
    [IsoId("_YuO5ctp-Ed-ak6NoX_4Aeg_1205611187")]
    [Description(@"Creditor or creditor's agent should not have collected the direct debit.")]
    CollectionNotDue = TransactionReasonCode.CollectionNotDue, // same ordinal as derivation source for type conversions
}
