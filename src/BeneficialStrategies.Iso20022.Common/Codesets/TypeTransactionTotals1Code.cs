// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identification of the type of transactions which are included in the totals.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TUJ9PwEcEeCQm6a_G2yO_w_592182673")]
[Description(@"Identification of the type of transactions which are included in the totals.")]
[DerivedFrom(typeof(TypeTransactionTotalsCode))]
public enum TypeTransactionTotals1Code
{
    /// <summary>
    /// Debit transactions on the cardholder account.
    /// Encoded/decoded by serializers as &quot;DEBT&quot;.
    /// </summary>
    [EnumMember(Value = "DEBT")]
    [IsoId("_TUJ9QAEcEeCQm6a_G2yO_w_-1120595523")]
    [Description(@"Debit transactions on the cardholder account.")]
    Debit = TypeTransactionTotalsCode.Debit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reversal of debit transactions (cancellation).
    /// Encoded/decoded by serializers as &quot;DBTR&quot;.
    /// </summary>
    [EnumMember(Value = "DBTR")]
    [IsoId("_TUTHIAEcEeCQm6a_G2yO_w_-2003828810")]
    [Description(@"Reversal of debit transactions (cancellation).")]
    DebitReverse = TypeTransactionTotalsCode.DebitReverse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Credit transactions (refund, account, cash service, as defined in the transaction service type).
    /// Encoded/decoded by serializers as &quot;CRDT&quot;.
    /// </summary>
    [EnumMember(Value = "CRDT")]
    [IsoId("_TUTHIQEcEeCQm6a_G2yO_w_1152384112")]
    [Description(@"Credit transactions (refund, account, cash service, as defined in the transaction service type).")]
    Credit = TypeTransactionTotalsCode.Credit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reversal of credit transactions (cancellation).
    /// Encoded/decoded by serializers as &quot;CRDR&quot;.
    /// </summary>
    [EnumMember(Value = "CRDR")]
    [IsoId("_TUTHIgEcEeCQm6a_G2yO_w_-1205358011")]
    [Description(@"Reversal of credit transactions (cancellation).")]
    CreditReverse = TypeTransactionTotalsCode.CreditReverse, // same ordinal as derivation source for type conversions
    
}
