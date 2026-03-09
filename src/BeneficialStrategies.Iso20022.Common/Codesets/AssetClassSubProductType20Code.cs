// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product of type Dairy.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_nnsc8Vq_EeWN79Bl6BUd3g")]
[Description(@"Defines the sub-product of type Dairy.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductType20Code
{
    /// <summary>
    /// Commodity of type dairy.
    /// Encoded/decoded by serializers as &quot;DIRY&quot;.
    /// </summary>
    [EnumMember(Value = "DIRY")]
    [IsoId("_prJicVq_EeWN79Bl6BUd3g")]
    [Description(@"Commodity of type dairy.")]
    Dairy = AssetClassSubProductTypeCode.Dairy, // same ordinal as derivation source for type conversions
    
}
