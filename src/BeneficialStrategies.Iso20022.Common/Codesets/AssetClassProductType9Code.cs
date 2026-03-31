// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Commodity derivative base product code list for Polypropylene.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YnMwgAnyEeWnS-yHF1QhNQ")]
[Description(@"Commodity derivative base product code list for Polypropylene.")]
[DerivedFrom(typeof(AssetClassProductTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AssetClassProductType9Code>))]
#endif
public enum AssetClassProductType9Code
{
    /// <summary>
    /// Commodity of type polypropylene.
    /// Encoded/decoded by serializers as &quot;POLY&quot;.
    /// </summary>
    [EnumMember(Value = "POLY")]
    [IsoId("_sc03IQnyEeWnS-yHF1QhNQ")]
    [Description(@"Commodity of type polypropylene.")]
    Polypropylene = AssetClassProductTypeCode.Polypropylene, // same ordinal as derivation source for type conversions
}
