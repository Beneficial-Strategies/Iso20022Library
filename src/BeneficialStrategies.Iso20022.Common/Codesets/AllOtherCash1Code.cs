// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if remaining assets are transferred as cash.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_IzK98CYIEeWJkOUkQWu90g")]
[Description(@"Specifies if remaining assets are transferred as cash.")]
[DerivedFrom(typeof(AllOtherCashCode))]
public enum AllOtherCash1Code
{
    /// <summary>
    /// Remaining assets in a portfolio not listed for transfer should be liquidated and transferred as cash.
    /// Encoded/decoded by serializers as &quot;LIQU&quot;.
    /// </summary>
    [EnumMember(Value = "LIQU")]
    [IsoId("_Kyg_gSYIEeWJkOUkQWu90g")]
    [Description(@"Remaining assets in a portfolio not listed for transfer should be liquidated and transferred as cash.")]
    LiquidatedTransferAsCash = AllOtherCashCode.LiquidatedTransferAsCash, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Remaining assets in a portfolio not listed for transfer should not be liquidated and transferred as cash.
    /// Encoded/decoded by serializers as &quot;NLIQ&quot;.
    /// </summary>
    [EnumMember(Value = "NLIQ")]
    [IsoId("_K5qJUSYIEeWJkOUkQWu90g")]
    [Description(@"Remaining assets in a portfolio not listed for transfer should not be liquidated and transferred as cash.")]
    NotLiquidatedTransferAsCash = AllOtherCashCode.NotLiquidatedTransferAsCash, // same ordinal as derivation source for type conversions
    
}
