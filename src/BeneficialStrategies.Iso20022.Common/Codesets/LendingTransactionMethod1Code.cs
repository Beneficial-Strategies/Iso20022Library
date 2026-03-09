// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Lending method applied to the securities financing contract.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__2_DYNojEeC60axPepSq7g_-126793566")]
[Description(@"Lending method applied to the securities financing contract.")]
[DerivedFrom(typeof(LendingTransactionMethodCode))]
public enum LendingTransactionMethod1Code
{
    /// <summary>
    /// Contract applies to a specific security only.
    /// Encoded/decoded by serializers as &quot;ODTR&quot;.
    /// </summary>
    [EnumMember(Value = "ODTR")]
    [IsoId("__2_DYdojEeC60axPepSq7g_-945747247")]
    [Description(@"Contract applies to a specific security only.")]
    OnDemandTrade = LendingTransactionMethodCode.OnDemandTrade, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Contract applies to a number of different securities within the same pool/fund.
    /// Encoded/decoded by serializers as &quot;EXTR&quot;.
    /// </summary>
    [EnumMember(Value = "EXTR")]
    [IsoId("__2_DYtojEeC60axPepSq7g_1548205403")]
    [Description(@"Contract applies to a number of different securities within the same pool/fund.")]
    ExclusiveTrade = LendingTransactionMethodCode.ExclusiveTrade, // same ordinal as derivation source for type conversions
    
}
