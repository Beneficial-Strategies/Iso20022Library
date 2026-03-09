// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product of type Distillates.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hwjpcVrKEeWN79Bl6BUd3g")]
[Description(@"Defines the sub-product of type Distillates.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductType25Code
{
    /// <summary>
    /// Commodity of type distillates.
    /// Encoded/decoded by serializers as &quot;DIST&quot;.
    /// </summary>
    [EnumMember(Value = "DIST")]
    [IsoId("_h7wM2VrKEeWN79Bl6BUd3g")]
    [Description(@"Commodity of type distillates.")]
    Distillates = AssetClassSubProductTypeCode.Distillates, // same ordinal as derivation source for type conversions
    
}
