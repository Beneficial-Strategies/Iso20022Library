// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Side taken by a party on an order.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__1DJtNojEeC60axPepSq7g_384259332")]
[Description(@"Side taken by a party on an order.")]
[DerivedFrom(typeof(ClearingSideCode))]
public enum ClearingSide1Code
{
    /// <summary>
    /// Clearing member is on the buying side.
    /// Encoded/decoded by serializers as &quot;BUYI&quot;.
    /// </summary>
    [EnumMember(Value = "BUYI")]
    [IsoId("__1DJtdojEeC60axPepSq7g_-1447578854")]
    [Description(@"Clearing member is on the buying side.")]
    Buy = ClearingSideCode.Buy, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Clearing member is on the selling side.
    /// Encoded/decoded by serializers as &quot;SELL&quot;.
    /// </summary>
    [EnumMember(Value = "SELL")]
    [IsoId("__1M6sNojEeC60axPepSq7g_-1458677631")]
    [Description(@"Clearing member is on the selling side.")]
    Sell = ClearingSideCode.Sell, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Clearing member is on the lending side.
    /// Encoded/decoded by serializers as &quot;LEND&quot;.
    /// </summary>
    [EnumMember(Value = "LEND")]
    [IsoId("__1M6sdojEeC60axPepSq7g_8471132")]
    [Description(@"Clearing member is on the lending side.")]
    Lend = ClearingSideCode.Lend, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Clearing member is on the borrowing side.
    /// Encoded/decoded by serializers as &quot;BORW&quot;.
    /// </summary>
    [EnumMember(Value = "BORW")]
    [IsoId("__1M6stojEeC60axPepSq7g_-407544559")]
    [Description(@"Clearing member is on the borrowing side.")]
    Borrow = ClearingSideCode.Borrow, // same ordinal as derivation source for type conversions
}
