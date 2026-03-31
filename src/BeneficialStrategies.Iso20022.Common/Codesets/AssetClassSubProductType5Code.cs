// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product of type Grain.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_9NQHYAnyEeWnS-yHF1QhNQ")]
[Description(@"Defines the sub-product of type Grain.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AssetClassSubProductType5Code>))]
#endif
public enum AssetClassSubProductType5Code
{
    /// <summary>
    /// Commodity of type grain.
    /// Encoded/decoded by serializers as &quot;GRIN&quot;.
    /// </summary>
    [EnumMember(Value = "GRIN")]
    [IsoId("_5hvpgQnzEeWnS-yHF1QhNQ")]
    [Description(@"Commodity of type grain.")]
    Grain = AssetClassSubProductTypeCode.Grain, // same ordinal as derivation source for type conversions
}
