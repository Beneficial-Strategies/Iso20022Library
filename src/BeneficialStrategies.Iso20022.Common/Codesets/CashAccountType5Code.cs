// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of cash account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_xujvECCyEeWJd9HF2tO7BA")]
[Description(@"Specifies the type of cash account.")]
[DerivedFrom(typeof(CashAccountTypeCode))]
public enum CashAccountType5Code
{
    /// <summary>
    /// Account is for the coverage of lending.
    /// Encoded/decoded by serializers as &quot;LEND&quot;.
    /// </summary>
    [EnumMember(Value = "LEND")]
    [IsoId("_2pYDQSCyEeWJd9HF2tO7BA")]
    [Description(@"Account is for the coverage of lending.")]
    Lending = CashAccountTypeCode.Lending, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account is for collateral.
    /// Encoded/decoded by serializers as &quot;COLL&quot;.
    /// </summary>
    [EnumMember(Value = "COLL")]
    [IsoId("_3W53oSCyEeWJd9HF2tO7BA")]
    [Description(@"Account is for collateral.")]
    Collateral = CashAccountTypeCode.Collateral, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account is for financial settlements.
    /// Encoded/decoded by serializers as &quot;SETT&quot;.
    /// </summary>
    [EnumMember(Value = "SETT")]
    [IsoId("_34FSESCyEeWJd9HF2tO7BA")]
    [Description(@"Account is for financial settlements.")]
    FinancialSettlement = CashAccountTypeCode.FinancialSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account is for margin returns.
    /// Encoded/decoded by serializers as &quot;MARR&quot;.
    /// </summary>
    [EnumMember(Value = "MARR")]
    [IsoId("__NxGMSCyEeWJd9HF2tO7BA")]
    [Description(@"Account is for margin returns.")]
    MarginReturn = CashAccountTypeCode.MarginReturn, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account is an segregated account.
    /// Encoded/decoded by serializers as &quot;SEGT&quot;.
    /// </summary>
    [EnumMember(Value = "SEGT")]
    [IsoId("__yXoESCyEeWJd9HF2tO7BA")]
    [Description(@"Account is an segregated account.")]
    Segregated = CashAccountTypeCode.Segregated, // same ordinal as derivation source for type conversions
}
