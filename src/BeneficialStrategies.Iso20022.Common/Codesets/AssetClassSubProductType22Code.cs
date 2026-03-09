// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product of type Livestock.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_jP1PYVrAEeWN79Bl6BUd3g")]
[Description(@"Defines the sub-product of type Livestock.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductType22Code
{
    /// <summary>
    /// Commodity of type livestock.
    /// Encoded/decoded by serializers as &quot;LSTK&quot;.
    /// </summary>
    [EnumMember(Value = "LSTK")]
    [IsoId("_kxU3UVrAEeWN79Bl6BUd3g")]
    [Description(@"Commodity of type livestock.")]
    Livestock = AssetClassSubProductTypeCode.Livestock, // same ordinal as derivation source for type conversions
    
}
