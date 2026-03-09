// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Side taken by a party on an order.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__1M6s9ojEeC60axPepSq7g_1756834553")]
[Description(@"Side taken by a party on an order.")]
[Derivations(typeof(ClearingSide1Code))]
public enum ClearingSideCode
{
    /// <summary>
    /// Clearing member is on the buying side.
    /// Encoded/decoded by serializers as &quot;BUYI&quot;.
    /// </summary>
    [EnumMember(Value = "BUYI")]
    [IsoId("__1M6tNojEeC60axPepSq7g_1642995487")]
    [Description(@"Clearing member is on the buying side.")]
    Buy,
    
    /// <summary>
    /// Clearing member is on the selling side.
    /// Encoded/decoded by serializers as &quot;SELL&quot;.
    /// </summary>
    [EnumMember(Value = "SELL")]
    [IsoId("__1M6tdojEeC60axPepSq7g_937880872")]
    [Description(@"Clearing member is on the selling side.")]
    Sell,
    
    /// <summary>
    /// Clearing member is on the lending side.
    /// Encoded/decoded by serializers as &quot;LEND&quot;.
    /// </summary>
    [EnumMember(Value = "LEND")]
    [IsoId("__1M6ttojEeC60axPepSq7g_-1133302535")]
    [Description(@"Clearing member is on the lending side.")]
    Lend,
    
    /// <summary>
    /// Clearing member is on the borrowing side.
    /// Encoded/decoded by serializers as &quot;BORW&quot;.
    /// </summary>
    [EnumMember(Value = "BORW")]
    [IsoId("__1WEoNojEeC60axPepSq7g_1986473736")]
    [Description(@"Clearing member is on the borrowing side.")]
    Borrow,
    
}
