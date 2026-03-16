// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product of type Pulp.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_18yyEVryEeWN79Bl6BUd3g")]
[Description(@"Defines the sub-product of type Pulp.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductType37Code
{
    /// <summary>
    /// Commodity of type pulp.
    /// Encoded/decoded by serializers as &quot;PULP&quot;.
    /// </summary>
    [EnumMember(Value = "PULP")]
    [IsoId("_2IP0JVryEeWN79Bl6BUd3g")]
    [Description(@"Commodity of type pulp.")]
    Pulp = AssetClassSubProductTypeCode.Pulp, // same ordinal as derivation source for type conversions
}
