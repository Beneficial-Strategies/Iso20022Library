// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the collateral is a pool collateral, delivery by value specific pool or not a pool.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_n7fkcd7FEeSaBeqd_btViQ")]
[Description(
    @"Specifies whether the collateral is a pool collateral, delivery by value specific pool or not a pool."
)]
[Derivations(typeof(CollateralPool1Code))]
public enum CollateralPoolCode
{
    /// <summary>
    /// Collateral is of pool type.
    /// Encoded/decoded by serializers as &quot;POOL&quot;.
    /// </summary>
    [EnumMember(Value = "POOL")]
    [IsoId("_xpEdAN7FEeSaBeqd_btViQ")]
    [Description(@"Collateral is of pool type.")]
    Pool,

    /// <summary>
    /// Collateral is not of pool type.
    /// Encoded/decoded by serializers as &quot;NOPL&quot;.
    /// </summary>
    [EnumMember(Value = "NOPL")]
    [IsoId("_yTBY8N7FEeSaBeqd_btViQ")]
    [Description(@"Collateral is not of pool type.")]
    NoPool,

    /// <summary>
    /// Transaction was settled using a delivery by value mechanism.
    /// Encoded/decoded by serializers as &quot;DBVP&quot;.
    /// </summary>
    [EnumMember(Value = "DBVP")]
    [IsoId("_zxVMIHvYEeWrWYBng3OpVw")]
    [Description(@"Transaction was settled using a delivery by value mechanism.")]
    DeliveryByValuePool,
}
