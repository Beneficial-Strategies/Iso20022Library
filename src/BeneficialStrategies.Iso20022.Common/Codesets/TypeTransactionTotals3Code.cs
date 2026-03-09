// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Additional attribute of the service type for totals.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_4IQQ0NxhEeioifFt1dhnJA")]
[Description(@"Additional attribute of the service type for totals.")]
[DerivedFrom(typeof(TypeTransactionTotalsCode))]
public enum TypeTransactionTotals3Code
{
    /// <summary>
    /// Credit transactions (refund, account, cash service, as defined in the transaction service type).
    /// Encoded/decoded by serializers as &quot;CRDT&quot;.
    /// </summary>
    [EnumMember(Value = "CRDT")]
    [IsoId("_56GB4dxhEeioifFt1dhnJA")]
    [Description(@"Credit transactions (refund, account, cash service, as defined in the transaction service type).")]
    Credit = TypeTransactionTotalsCode.Credit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reversal of credit transactions (cancellation).
    /// Encoded/decoded by serializers as &quot;CRDR&quot;.
    /// </summary>
    [EnumMember(Value = "CRDR")]
    [IsoId("_59X_YdxhEeioifFt1dhnJA")]
    [Description(@"Reversal of credit transactions (cancellation).")]
    CreditReverse = TypeTransactionTotalsCode.CreditReverse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Debit transactions on the cardholder account.
    /// Encoded/decoded by serializers as &quot;DEBT&quot;.
    /// </summary>
    [EnumMember(Value = "DEBT")]
    [IsoId("_6ApV0dxhEeioifFt1dhnJA")]
    [Description(@"Debit transactions on the cardholder account.")]
    Debit = TypeTransactionTotalsCode.Debit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reversal of debit transactions (cancellation).
    /// Encoded/decoded by serializers as &quot;DBTR&quot;.
    /// </summary>
    [EnumMember(Value = "DBTR")]
    [IsoId("_6EFEUdxhEeioifFt1dhnJA")]
    [Description(@"Reversal of debit transactions (cancellation).")]
    DebitReverse = TypeTransactionTotalsCode.DebitReverse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Declined transactions.
    /// Encoded/decoded by serializers as &quot;DECL&quot;.
    /// </summary>
    [EnumMember(Value = "DECL")]
    [IsoId("_6HIYUdxhEeioifFt1dhnJA")]
    [Description(@"Declined transactions.")]
    Declined = TypeTransactionTotalsCode.Declined, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Failed transactions.
    /// Encoded/decoded by serializers as &quot;FAIL&quot;.
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_6KQk0dxhEeioifFt1dhnJA")]
    [Description(@"Failed transactions.")]
    Failed = TypeTransactionTotalsCode.Failed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Outstanding Reservation transactions.
    /// Encoded/decoded by serializers as &quot;RESV&quot;.
    /// </summary>
    [EnumMember(Value = "RESV")]
    [IsoId("_6NjwcdxhEeioifFt1dhnJA")]
    [Description(@"Outstanding Reservation transactions.")]
    Reservation = TypeTransactionTotalsCode.Reservation, // same ordinal as derivation source for type conversions
    
}
