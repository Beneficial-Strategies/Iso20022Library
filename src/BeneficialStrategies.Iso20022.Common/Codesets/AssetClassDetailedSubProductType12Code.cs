// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Further sub product code list for commodity derivative Wet.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_qOdIMVrdEeWN79Bl6BUd3g")]
[Description(@"Further sub product code list for commodity derivative Wet.")]
[DerivedFrom(typeof(AssetClassDetailedSubProductTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AssetClassDetailedSubProductType12Code>))]
#endif
public enum AssetClassDetailedSubProductType12Code
{
    /// <summary>
    /// Commodity attribute of type tanker.
    /// Encoded/decoded by serializers as &quot;TNKR&quot;.
    /// </summary>
    [EnumMember(Value = "TNKR")]
    [IsoId("_qaGXhVrdEeWN79Bl6BUd3g")]
    [Description(@"Commodity attribute of type tanker.")]
    Tanker = AssetClassDetailedSubProductTypeCode.Tanker, // same ordinal as derivation source for type conversions
}
