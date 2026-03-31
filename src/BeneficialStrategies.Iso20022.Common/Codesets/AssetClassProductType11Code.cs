// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Commodity derivative base product code list for Other C10.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Wl9_0A3oEeWc7_0KPiuk6w")]
[Description(@"Commodity derivative base product code list for Other C10.")]
[DerivedFrom(typeof(AssetClassProductTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AssetClassProductType11Code>))]
#endif
public enum AssetClassProductType11Code
{
    /// <summary>
    /// Commodity of other type C10.
    /// Encoded/decoded by serializers as &quot;OTHC&quot;.
    /// </summary>
    [EnumMember(Value = "OTHC")]
    [IsoId("_Xwy0MQ3oEeWc7_0KPiuk6w")]
    [Description(@"Commodity of other type C10.")]
    OtherC10 = AssetClassProductTypeCode.OtherC10, // same ordinal as derivation source for type conversions
}
