// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the clearing account type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YZXcu9p-Ed-ak6NoX_4Aeg_-1340826137")]
[Description(@"Specifies the clearing account type.")]
[DerivedFrom(typeof(ClearingAccountTypeCode))]
public enum ClearingAccountType1Code
{
    /// <summary>
    /// Specifies that the account is used to register trades executed for either the clearing member or its subsidiaries.
    /// Encoded/decoded by serializers as &quot;HOUS&quot;.
    /// </summary>
    [EnumMember(Value = "HOUS")]
    [IsoId("_YZXcvNp-Ed-ak6NoX_4Aeg_-1776867324")]
    [Description(@"Specifies that the account is used to register trades executed for either the clearing member or its subsidiaries.")]
    House = ClearingAccountTypeCode.House, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Specifies that the account is used to register trades executed for the clearing member&apos;s customers.
    /// Encoded/decoded by serializers as &quot;CLIE&quot;.
    /// </summary>
    [EnumMember(Value = "CLIE")]
    [IsoId("_YZhNsNp-Ed-ak6NoX_4Aeg_-2094643985")]
    [Description(@"Specifies that the account is used to register trades executed for the clearing member's customers.")]
    Client = ClearingAccountTypeCode.Client, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Specifies that the account is used to register trades executed for liquidity providers (also known as market maker) activities.
    /// Encoded/decoded by serializers as &quot;LIPR&quot;.
    /// </summary>
    [EnumMember(Value = "LIPR")]
    [IsoId("_YZhNsdp-Ed-ak6NoX_4Aeg_2086484245")]
    [Description(@"Specifies that the account is used to register trades executed for liquidity providers (also known as market maker) activities.")]
    LiquidityProvider = ClearingAccountTypeCode.LiquidityProvider, // same ordinal as derivation source for type conversions
    
}
