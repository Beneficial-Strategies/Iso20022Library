// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the item is used as collateral.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ObDuwCC-EeWPMvNwVtiMsA")]
[Description(@"Specifies whether the item is used as collateral.")]
[DerivedFrom(typeof(CollateralCode))]
public enum Collateral1Code
{
    /// <summary>
    /// Item is used as collateral.
    /// Encoded/decoded by serializers as &quot;COLL&quot;.
    /// </summary>
    [EnumMember(Value = "COLL")]
    [IsoId("_QHQx4SC-EeWPMvNwVtiMsA")]
    [Description(@"Item is used as collateral.")]
    Collateral = CollateralCode.Collateral, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Item is not used as collateral.
    /// Encoded/decoded by serializers as &quot;NCOL&quot;.
    /// </summary>
    [EnumMember(Value = "NCOL")]
    [IsoId("_QPdEkSC-EeWPMvNwVtiMsA")]
    [Description(@"Item is not used as collateral.")]
    NotCollateral = CollateralCode.NotCollateral, // same ordinal as derivation source for type conversions
    
}
