// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the transaction type used in the money market statistical reporting.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hxCgQJfrEeSfnc-VXAEapg")]
[Description(@"Specifies the transaction type used in the money market statistical reporting.")]
[Derivations(typeof(MoneyMarketTransactionType1Code))]
public enum MoneyMarketTransactionTypeCode
{
    /// <summary>
    /// Transaction is a borrowing.
    /// Encoded/decoded by serializers as &quot;BORR&quot;.
    /// </summary>
    [EnumMember(Value = "BORR")]
    [IsoId("_lmE4IJfrEeSfnc-VXAEapg")]
    [Description(@"Transaction is a borrowing.")]
    CashBorrowing,
    
    /// <summary>
    /// Transaction is a lending.
    /// Encoded/decoded by serializers as &quot;LEND&quot;.
    /// </summary>
    [EnumMember(Value = "LEND")]
    [IsoId("_n-_3UJfrEeSfnc-VXAEapg")]
    [Description(@"Transaction is a lending.")]
    CashLending,
    
}
