// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Lending method applied to the securities financing contract.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__2_DY9ojEeC60axPepSq7g_1658762544")]
[Description(@"Lending method applied to the securities financing contract.")]
[Derivations(typeof(LendingTransactionMethod1Code))]
public enum LendingTransactionMethodCode
{
    /// <summary>
    /// Contract applies to a specific security only.
    /// Encoded/decoded by serializers as &quot;ODTR&quot;.
    /// </summary>
    [EnumMember(Value = "ODTR")]
    [IsoId("__2_DZNojEeC60axPepSq7g_-1747965958")]
    [Description(@"Contract applies to a specific security only.")]
    OnDemandTrade,
    
    /// <summary>
    /// Contract applies to a number of different securities within the same pool/fund.
    /// Encoded/decoded by serializers as &quot;EXTR&quot;.
    /// </summary>
    [EnumMember(Value = "EXTR")]
    [IsoId("__2_DZdojEeC60axPepSq7g_1202925115")]
    [Description(@"Contract applies to a number of different securities within the same pool/fund.")]
    ExclusiveTrade,
    
}
