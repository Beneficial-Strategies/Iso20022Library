// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Commodity derivative base product code list for Inflation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Tl5sIVrLEeWN79Bl6BUd3g")]
[Description(@"Commodity derivative base product code list for Inflation.")]
[DerivedFrom(typeof(AssetClassProductTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AssetClassProductType12Code>))]
#endif
public enum AssetClassProductType12Code
{
    /// <summary>
    /// Commodity of type inflation.
    /// Encoded/decoded by serializers as &quot;INFL&quot;.
    /// </summary>
    [EnumMember(Value = "INFL")]
    [IsoId("_TxFBZ1rLEeWN79Bl6BUd3g")]
    [Description(@"Commodity of type inflation.")]
    Inflation = AssetClassProductTypeCode.Inflation, // same ordinal as derivation source for type conversions
}
