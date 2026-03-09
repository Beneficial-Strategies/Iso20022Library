// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the transaction type used in the money market statistical reporting for the secured market.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_AaCp4JfsEeSfnc-VXAEapg")]
[Description(@"Specifies the transaction type used in the money market statistical reporting for the secured market.")]
[DerivedFrom(typeof(MoneyMarketTransactionTypeCode))]
public enum MoneyMarketTransactionType1Code
{
    /// <summary>
    /// Transaction is a borrowing.
    /// Encoded/decoded by serializers as &quot;BORR&quot;.
    /// </summary>
    [EnumMember(Value = "BORR")]
    [IsoId("_IwD5oZfsEeSfnc-VXAEapg")]
    [Description(@"Transaction is a borrowing.")]
    CashBorrowing = MoneyMarketTransactionTypeCode.CashBorrowing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is a lending.
    /// Encoded/decoded by serializers as &quot;LEND&quot;.
    /// </summary>
    [EnumMember(Value = "LEND")]
    [IsoId("_I4gD8ZfsEeSfnc-VXAEapg")]
    [Description(@"Transaction is a lending.")]
    CashLending = MoneyMarketTransactionTypeCode.CashLending, // same ordinal as derivation source for type conversions
    
}
