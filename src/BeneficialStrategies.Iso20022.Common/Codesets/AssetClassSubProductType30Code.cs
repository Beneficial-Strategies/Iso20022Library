// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product of type Weather.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ftdB4VrNEeWN79Bl6BUd3g")]
[Description(@"Defines the sub-product of type Weather.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
public enum AssetClassSubProductType30Code
{
    /// <summary>
    /// Commodity of type weather.
    /// Encoded/decoded by serializers as &quot;WTHR&quot;.
    /// </summary>
    [EnumMember(Value = "WTHR")]
    [IsoId("_f4vr41rNEeWN79Bl6BUd3g")]
    [Description(@"Commodity of type weather.")]
    Weather = AssetClassSubProductTypeCode.Weather, // same ordinal as derivation source for type conversions
}
