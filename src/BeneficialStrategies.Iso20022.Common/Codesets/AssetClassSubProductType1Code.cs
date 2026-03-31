// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product of type Grain Oil Seeds.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6aFcMAnyEeWnS-yHF1QhNQ")]
[Description(@"Defines the sub-product of type Grain Oil Seeds.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AssetClassSubProductType1Code>))]
#endif
public enum AssetClassSubProductType1Code
{
    /// <summary>
    /// Commodity of type grain oil seeds.
    /// Encoded/decoded by serializers as &quot;GROS&quot;.
    /// </summary>
    [EnumMember(Value = "GROS")]
    [IsoId("_LOvsMQnzEeWnS-yHF1QhNQ")]
    [Description(@"Commodity of type grain oil seeds.")]
    GrainOilSeeds = AssetClassSubProductTypeCode.GrainOilSeeds, // same ordinal as derivation source for type conversions
}
