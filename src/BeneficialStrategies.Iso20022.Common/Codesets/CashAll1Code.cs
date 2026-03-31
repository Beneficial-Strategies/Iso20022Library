// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if all assets are encashed and transferred as cash.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_RAAqYM4FEeiAhd-njDxLnA")]
[Description(@"Specifies if all assets are encashed and transferred as cash.")]
[DerivedFrom(typeof(CashAllCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CashAll1Code>))]
#endif
public enum CashAll1Code
{
    /// <summary>
    /// All assets in a portfolio should be liquidated and transferred as cash.
    /// Encoded/decoded by serializers as &quot;LIQU&quot;.
    /// </summary>
    [EnumMember(Value = "LIQU")]
    [IsoId("_S1Ptsc4FEeiAhd-njDxLnA")]
    [Description(@"All assets in a portfolio should be liquidated and transferred as cash.")]
    LiquidatedTransferAsCash = CashAllCode.LiquidatedTransferAsCash, // same ordinal as derivation source for type conversions

    /// <summary>
    /// All assets in a portfolio should not be liquidated and transferred as cash.
    /// Encoded/decoded by serializers as &quot;NLIQ&quot;.
    /// </summary>
    [EnumMember(Value = "NLIQ")]
    [IsoId("_S7Dawc4FEeiAhd-njDxLnA")]
    [Description(@"All assets in a portfolio should not be liquidated and transferred as cash.")]
    NotLiquidatedTransferAsCash = CashAllCode.NotLiquidatedTransferAsCash, // same ordinal as derivation source for type conversions
}
