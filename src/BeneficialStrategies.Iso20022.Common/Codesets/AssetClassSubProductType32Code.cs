// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product of type Wet Freight.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Q2ah4VrdEeWN79Bl6BUd3g")]
[Description(@"Defines the sub-product of type Wet Freight.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductType32Code
{
    /// <summary>
    /// Commodity of type wet freight.
    /// Encoded/decoded by serializers as &quot;WETF&quot;.
    /// </summary>
    [EnumMember(Value = "WETF")]
    [IsoId("_RB1uw1rdEeWN79Bl6BUd3g")]
    [Description(@"Commodity of type wet freight.")]
    Wet = AssetClassSubProductTypeCode.Wet, // same ordinal as derivation source for type conversions
}
