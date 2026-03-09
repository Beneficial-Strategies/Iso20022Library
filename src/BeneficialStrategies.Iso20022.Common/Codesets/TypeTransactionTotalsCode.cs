// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identification of the type of transactions which are included in the totals.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TVfZ-gEcEeCQm6a_G2yO_w_-334806911")]
[Description(@"Identification of the type of transactions which are included in the totals.")]
[Derivations(typeof(TypeTransactionTotals1Code),typeof(TypeTransactionTotals2Code),typeof(TypeTransactionTotals3Code))]
public enum TypeTransactionTotalsCode
{
    /// <summary>
    /// Debit transactions on the cardholder account.
    /// Encoded/decoded by serializers as &quot;DEBT&quot;.
    /// </summary>
    [EnumMember(Value = "DEBT")]
    [IsoId("_TVfZ-wEcEeCQm6a_G2yO_w_847668388")]
    [Description(@"Debit transactions on the cardholder account.")]
    Debit,
    
    /// <summary>
    /// Reversal of debit transactions (cancellation).
    /// Encoded/decoded by serializers as &quot;DBTR&quot;.
    /// </summary>
    [EnumMember(Value = "DBTR")]
    [IsoId("_TVfZ_AEcEeCQm6a_G2yO_w_-1805770177")]
    [Description(@"Reversal of debit transactions (cancellation).")]
    DebitReverse,
    
    /// <summary>
    /// Credit transactions (refund, account, cash service, as defined in the transaction service type).
    /// Encoded/decoded by serializers as &quot;CRDT&quot;.
    /// </summary>
    [EnumMember(Value = "CRDT")]
    [IsoId("_TVfZ_QEcEeCQm6a_G2yO_w_490339038")]
    [Description(@"Credit transactions (refund, account, cash service, as defined in the transaction service type).")]
    Credit,
    
    /// <summary>
    /// Reversal of credit transactions (cancellation).
    /// Encoded/decoded by serializers as &quot;CRDR&quot;.
    /// </summary>
    [EnumMember(Value = "CRDR")]
    [IsoId("_TVfZ_gEcEeCQm6a_G2yO_w_1638442145")]
    [Description(@"Reversal of credit transactions (cancellation).")]
    CreditReverse,
    
    /// <summary>
    /// Declined transactions.
    /// Encoded/decoded by serializers as &quot;DECL&quot;.
    /// </summary>
    [EnumMember(Value = "DECL")]
    [IsoId("_sP2PAb4pEeKkGaJ0UrThyA_1695729139")]
    [Description(@"Declined transactions.")]
    Declined,
    
    /// <summary>
    /// Failed transactions.
    /// Encoded/decoded by serializers as &quot;FAIL&quot;.
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_sP2PAr4pEeKkGaJ0UrThyA_1843086273")]
    [Description(@"Failed transactions.")]
    Failed,
    
    /// <summary>
    /// Outstanding Reservation transactions.
    /// Encoded/decoded by serializers as &quot;RESV&quot;.
    /// </summary>
    [EnumMember(Value = "RESV")]
    [IsoId("__Fr_kGpUEemFuJNacM8hZA")]
    [Description(@"Outstanding Reservation transactions.")]
    Reservation,
    
}
