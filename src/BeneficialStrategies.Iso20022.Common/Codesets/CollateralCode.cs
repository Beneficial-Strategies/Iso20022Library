// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the item is used as collateral.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-IxzECC9EeWPMvNwVtiMsA")]
[Description(@"Specifies whether the item is used as collateral.")]
[Derivations(typeof(Collateral1Code))]
public enum CollateralCode
{
    /// <summary>
    /// Item is used as collateral.
    /// Encoded/decoded by serializers as &quot;COLL&quot;.
    /// </summary>
    [EnumMember(Value = "COLL")]
    [IsoId("_Ey4TkCC-EeWPMvNwVtiMsA")]
    [Description(@"Item is used as collateral.")]
    Collateral,

    /// <summary>
    /// Item is not used as collateral.
    /// Encoded/decoded by serializers as &quot;NCOL&quot;.
    /// </summary>
    [EnumMember(Value = "NCOL")]
    [IsoId("_JkxVQCC-EeWPMvNwVtiMsA")]
    [Description(@"Item is not used as collateral.")]
    NotCollateral,
}
