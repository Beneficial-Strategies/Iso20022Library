// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product of type Softs.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_7HmpgAnyEeWnS-yHF1QhNQ")]
[Description(@"Defines the sub-product of type Softs.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AssetClassSubProductType2Code>))]
#endif
public enum AssetClassSubProductType2Code
{
    /// <summary>
    /// Commodity of type softs.
    /// Encoded/decoded by serializers as &quot;SOFT&quot;.
    /// </summary>
    [EnumMember(Value = "SOFT")]
    [IsoId("_MkTJ4QnzEeWnS-yHF1QhNQ")]
    [Description(@"Commodity of type softs.")]
    Softs = AssetClassSubProductTypeCode.Softs, // same ordinal as derivation source for type conversions
}
