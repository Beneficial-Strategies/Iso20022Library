// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identification of the type of transactions which are included in the totals.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YoIbgCqPEeKu3rbsflh_TQ")]
[Description(@"Identification of the type of transactions which are included in the totals.")]
[DerivedFrom(typeof(TypeTransactionTotalsCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TypeTransactionTotals2Code>))]
#endif
public enum TypeTransactionTotals2Code
{
    /// <summary>
    /// Credit transactions (refund, account, cash service, as defined in the transaction service type).
    /// Encoded/decoded by serializers as &quot;CRDT&quot;.
    /// </summary>
    [EnumMember(Value = "CRDT")]
    [IsoId("_b5dCUSqPEeKu3rbsflh_TQ")]
    [Description(
        @"Credit transactions (refund, account, cash service, as defined in the transaction service type)."
    )]
    Credit = TypeTransactionTotalsCode.Credit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reversal of credit transactions (cancellation).
    /// Encoded/decoded by serializers as &quot;CRDR&quot;.
    /// </summary>
    [EnumMember(Value = "CRDR")]
    [IsoId("_cICQ4SqPEeKu3rbsflh_TQ")]
    [Description(@"Reversal of credit transactions (cancellation).")]
    CreditReverse = TypeTransactionTotalsCode.CreditReverse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Debit transactions on the cardholder account.
    /// Encoded/decoded by serializers as &quot;DEBT&quot;.
    /// </summary>
    [EnumMember(Value = "DEBT")]
    [IsoId("_cTpD8SqPEeKu3rbsflh_TQ")]
    [Description(@"Debit transactions on the cardholder account.")]
    Debit = TypeTransactionTotalsCode.Debit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reversal of debit transactions (cancellation).
    /// Encoded/decoded by serializers as &quot;DBTR&quot;.
    /// </summary>
    [EnumMember(Value = "DBTR")]
    [IsoId("_cgIn0SqPEeKu3rbsflh_TQ")]
    [Description(@"Reversal of debit transactions (cancellation).")]
    DebitReverse = TypeTransactionTotalsCode.DebitReverse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Declined transactions.
    /// Encoded/decoded by serializers as &quot;DECL&quot;.
    /// </summary>
    [EnumMember(Value = "DECL")]
    [IsoId("_csVQwSqPEeKu3rbsflh_TQ")]
    [Description(@"Declined transactions.")]
    Declined = TypeTransactionTotalsCode.Declined, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Failed transactions.
    /// Encoded/decoded by serializers as &quot;FAIL&quot;.
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_c539gSqPEeKu3rbsflh_TQ")]
    [Description(@"Failed transactions.")]
    Failed = TypeTransactionTotalsCode.Failed, // same ordinal as derivation source for type conversions
}
