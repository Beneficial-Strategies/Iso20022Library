// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product of type Forestry.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_FlcDEVrAEeWN79Bl6BUd3g")]
[Description(@"Defines the sub-product of type Forestry.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductType21Code
{
    /// <summary>
    /// Commodity of type forestry.
    /// Encoded/decoded by serializers as &quot;FRST&quot;.
    /// </summary>
    [EnumMember(Value = "FRST")]
    [IsoId("_HNipUVrAEeWN79Bl6BUd3g")]
    [Description(@"Commodity of type forestry.")]
    Forestry = AssetClassSubProductTypeCode.Forestry, // same ordinal as derivation source for type conversions
}
