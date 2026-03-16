// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if remaining assets are transferred as cash.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hzmK8CYHEeWJkOUkQWu90g")]
[Description(@"Specifies if remaining assets are transferred as cash.")]
[Derivations(typeof(AllOtherCash1Code))]
public enum AllOtherCashCode
{
    /// <summary>
    /// Remaining assets in a portfolio not listed for transfer should be liquidated and transferred as cash.
    /// Encoded/decoded by serializers as &quot;LIQU&quot;.
    /// </summary>
    [EnumMember(Value = "LIQU")]
    [IsoId("_up8yUCYHEeWJkOUkQWu90g")]
    [Description(
        @"Remaining assets in a portfolio not listed for transfer should be liquidated and transferred as cash."
    )]
    LiquidatedTransferAsCash,

    /// <summary>
    /// Remaining assets in a portfolio not listed for transfer should not be liquidated and transferred as cash.
    /// Encoded/decoded by serializers as &quot;NLIQ&quot;.
    /// </summary>
    [EnumMember(Value = "NLIQ")]
    [IsoId("_3ycA0CYHEeWJkOUkQWu90g")]
    [Description(
        @"Remaining assets in a portfolio not listed for transfer should not be liquidated and transferred as cash."
    )]
    NotLiquidatedTransferAsCash,
}
