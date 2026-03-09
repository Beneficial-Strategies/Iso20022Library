// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of transactions to include in a batch transfer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KUq-g31DEeCF8NjrBemJWQ_-2092931546")]
[Description(@"Type of transactions to include in a batch transfer.")]
[DerivedFrom(typeof(BatchTransactionTypeCode))]
public enum BatchTransactionType1Code
{
    /// <summary>
    /// Debit and credit transactions.
    /// Encoded/decoded by serializers as &quot;DTCT&quot;.
    /// </summary>
    [EnumMember(Value = "DTCT")]
    [IsoId("_KUq-hH1DEeCF8NjrBemJWQ_-819708143")]
    [Description(@"Debit and credit transactions.")]
    DebitCredit = BatchTransactionTypeCode.DebitCredit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation of a previous transaction.
    /// Encoded/decoded by serializers as &quot;CNCL&quot;.
    /// </summary>
    [EnumMember(Value = "CNCL")]
    [IsoId("_KUq-hX1DEeCF8NjrBemJWQ_-538462037")]
    [Description(@"Cancellation of a previous transaction.")]
    Cancellation = BatchTransactionTypeCode.Cancellation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Failed transactions.
    /// Encoded/decoded by serializers as &quot;FAIL&quot;.
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_KUq-hn1DEeCF8NjrBemJWQ_-111331682")]
    [Description(@"Failed transactions.")]
    Failed = BatchTransactionTypeCode.Failed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Declined transactions.
    /// Encoded/decoded by serializers as &quot;DCLN&quot;.
    /// </summary>
    [EnumMember(Value = "DCLN")]
    [IsoId("_KUq-h31DEeCF8NjrBemJWQ_1581782246")]
    [Description(@"Declined transactions.")]
    Declined = BatchTransactionTypeCode.Declined, // same ordinal as derivation source for type conversions
    
}
