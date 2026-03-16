// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product of type Diammonium Phosphate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VCgwEVr3EeWN79Bl6BUd3g")]
[Description(@"Defines the sub-product of type Diammonium Phosphate.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductType40Code
{
    /// <summary>
    /// Commodity of type diammonium phosphate.
    /// Encoded/decoded by serializers as &quot;DAPH&quot;.
    /// </summary>
    [EnumMember(Value = "DAPH")]
    [IsoId("_VOFt81r3EeWN79Bl6BUd3g")]
    [Description(@"Commodity of type diammonium phosphate.")]
    DiammoniumPhosphate = AssetClassSubProductTypeCode.DiammoniumPhosphate, // same ordinal as derivation source for type conversions
}
