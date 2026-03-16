// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product of type Potash.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bK2AQVr3EeWN79Bl6BUd3g")]
[Description(@"Defines the sub-product of type Potash.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductType41Code
{
    /// <summary>
    /// Commodity of type potash.
    /// Encoded/decoded by serializers as &quot;PTSH&quot;.
    /// </summary>
    [EnumMember(Value = "PTSH")]
    [IsoId("_bWeohVr3EeWN79Bl6BUd3g")]
    [Description(@"Commodity of type potash.")]
    Potash = AssetClassSubProductTypeCode.Potash, // same ordinal as derivation source for type conversions
}
