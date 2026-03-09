// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if all assets are encashed and transferred as cash.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_7bsNUM4EEeiAhd-njDxLnA")]
[Description(@"Specifies if all assets are encashed and transferred as cash.")]
[Derivations(typeof(CashAll1Code))]
public enum CashAllCode
{
    /// <summary>
    /// All assets in a portfolio should be liquidated and transferred as cash.
    /// Encoded/decoded by serializers as &quot;LIQU&quot;.
    /// </summary>
    [EnumMember(Value = "LIQU")]
    [IsoId("_GH54Ys4FEeiAhd-njDxLnA")]
    [Description(@"All assets in a portfolio should be liquidated and transferred as cash.")]
    LiquidatedTransferAsCash,
    
    /// <summary>
    /// All assets in a portfolio should not be liquidated and transferred as cash.
    /// Encoded/decoded by serializers as &quot;NLIQ&quot;.
    /// </summary>
    [EnumMember(Value = "NLIQ")]
    [IsoId("_GH54Y84FEeiAhd-njDxLnA")]
    [Description(@"All assets in a portfolio should not be liquidated and transferred as cash.")]
    NotLiquidatedTransferAsCash,
    
}
