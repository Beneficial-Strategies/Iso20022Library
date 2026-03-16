// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of transactions to include in a batch transfer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KUq-iH1DEeCF8NjrBemJWQ_-1037208756")]
[Description(@"Type of transactions to include in a batch transfer.")]
[Derivations(typeof(BatchTransactionType1Code))]
public enum BatchTransactionTypeCode
{
    /// <summary>
    /// Debit and credit transactions.
    /// Encoded/decoded by serializers as &quot;DTCT&quot;.
    /// </summary>
    [EnumMember(Value = "DTCT")]
    [IsoId("_KU0vgH1DEeCF8NjrBemJWQ_-2001317413")]
    [Description(@"Debit and credit transactions.")]
    DebitCredit,

    /// <summary>
    /// Cancellation of a previous transaction.
    /// Encoded/decoded by serializers as &quot;CNCL&quot;.
    /// </summary>
    [EnumMember(Value = "CNCL")]
    [IsoId("_KU0vgX1DEeCF8NjrBemJWQ_-1823198741")]
    [Description(@"Cancellation of a previous transaction.")]
    Cancellation,

    /// <summary>
    /// Failed transactions.
    /// Encoded/decoded by serializers as &quot;FAIL&quot;.
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_KU0vgn1DEeCF8NjrBemJWQ_-2115156479")]
    [Description(@"Failed transactions.")]
    Failed,

    /// <summary>
    /// Declined transactions.
    /// Encoded/decoded by serializers as &quot;DCLN&quot;.
    /// </summary>
    [EnumMember(Value = "DCLN")]
    [IsoId("_KU0vg31DEeCF8NjrBemJWQ_1142799055")]
    [Description(@"Declined transactions.")]
    Declined,
}
