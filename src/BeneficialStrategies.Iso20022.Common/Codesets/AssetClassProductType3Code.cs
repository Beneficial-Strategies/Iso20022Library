// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Commodity derivative base product code list for Environmental.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VrcxEAnyEeWnS-yHF1QhNQ")]
[Description(@"Commodity derivative base product code list for Environmental.")]
[DerivedFrom(typeof(AssetClassProductTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AssetClassProductType3Code>))]
#endif
public enum AssetClassProductType3Code
{
    /// <summary>
    /// Commodity of type environmental.
    /// Encoded/decoded by serializers as &quot;ENVR&quot;.
    /// </summary>
    [EnumMember(Value = "ENVR")]
    [IsoId("_hLbbYQnyEeWnS-yHF1QhNQ")]
    [Description(@"Commodity of type environmental.")]
    Environmental = AssetClassProductTypeCode.Environmental, // same ordinal as derivation source for type conversions
}
