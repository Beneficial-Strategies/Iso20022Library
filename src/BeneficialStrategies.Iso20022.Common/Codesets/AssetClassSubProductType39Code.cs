// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product of type Ammonia.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_OX7HYVr3EeWN79Bl6BUd3g")]
[Description(@"Defines the sub-product of type Ammonia.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductType39Code
{
    /// <summary>
    /// Commodity of type ammonia.
    /// Encoded/decoded by serializers as &quot;AMMO&quot;.
    /// </summary>
    [EnumMember(Value = "AMMO")]
    [IsoId("_OjQNoVr3EeWN79Bl6BUd3g")]
    [Description(@"Commodity of type ammonia.")]
    Ammonia = AssetClassSubProductTypeCode.Ammonia, // same ordinal as derivation source for type conversions
    
}
