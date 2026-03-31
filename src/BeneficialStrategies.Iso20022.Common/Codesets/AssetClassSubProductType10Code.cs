// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product of type Emission.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_BJaa8AnzEeWnS-yHF1QhNQ")]
[Description(@"Defines the sub-product of type Emission.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AssetClassSubProductType10Code>))]
#endif
public enum AssetClassSubProductType10Code
{
    /// <summary>
    /// Commodity of type emission.
    /// Encoded/decoded by serializers as &quot;EMIS&quot;.
    /// </summary>
    [EnumMember(Value = "EMIS")]
    [IsoId("_XZ6MEQn0EeWnS-yHF1QhNQ")]
    [Description(@"Commodity of type emission.")]
    Emission = AssetClassSubProductTypeCode.Emission, // same ordinal as derivation source for type conversions
}
