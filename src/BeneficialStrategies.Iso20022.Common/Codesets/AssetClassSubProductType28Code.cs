// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product of type Renewable Energy.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_sFQMYVrKEeWN79Bl6BUd3g")]
[Description(@"Defines the sub-product of type Renewable Energy.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AssetClassSubProductType28Code>))]
#endif
public enum AssetClassSubProductType28Code
{
    /// <summary>
    /// Commodity of type renewable energy.
    /// Encoded/decoded by serializers as &quot;RNNG&quot;.
    /// </summary>
    [EnumMember(Value = "RNNG")]
    [IsoId("_sQ1KRVrKEeWN79Bl6BUd3g")]
    [Description(@"Commodity of type renewable energy.")]
    RenewableEnergy = AssetClassSubProductTypeCode.RenewableEnergy, // same ordinal as derivation source for type conversions
}
