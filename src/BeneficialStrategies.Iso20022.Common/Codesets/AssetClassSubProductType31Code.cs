// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product of type Dry Freight.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Mjf7MVrdEeWN79Bl6BUd3g")]
[Description(@"Defines the sub-product of type Dry Freight.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductType31Code
{
    /// <summary>
    /// Commodity of type dry freight.
    /// Encoded/decoded by serializers as &quot;DRYF&quot;.
    /// </summary>
    [EnumMember(Value = "DRYF")]
    [IsoId("_MvTikVrdEeWN79Bl6BUd3g")]
    [Description(@"Commodity of type dry freight.")]
    Dry = AssetClassSubProductTypeCode.Dry, // same ordinal as derivation source for type conversions
}
