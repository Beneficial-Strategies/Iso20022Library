// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Further sub product code list for commodity derivative Softs.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_4NUJgA2eEeW72qLtWESimw")]
[Description(@"Further sub product code list for commodity derivative Softs.")]
[DerivedFrom(typeof(AssetClassDetailedSubProductTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AssetClassDetailedSubProductType2Code>))]
#endif
public enum AssetClassDetailedSubProductType2Code
{
    /// <summary>
    /// Commodity attribute of type robusta coffee.
    /// Encoded/decoded by serializers as &quot;ROBU&quot;.
    /// </summary>
    [EnumMember(Value = "ROBU")]
    [IsoId("_PV51sQ2fEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type robusta coffee.")]
    RobustaCoffee = AssetClassDetailedSubProductTypeCode.RobustaCoffee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type cocoa.
    /// Encoded/decoded by serializers as &quot;CCOA&quot;.
    /// </summary>
    [EnumMember(Value = "CCOA")]
    [IsoId("_P_aswQ2fEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type cocoa.")]
    Cocoa = AssetClassDetailedSubProductTypeCode.Cocoa, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type raw sugar.
    /// Encoded/decoded by serializers as &quot;BRWN&quot;.
    /// </summary>
    [EnumMember(Value = "BRWN")]
    [IsoId("_RqOowQ2fEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type raw sugar.")]
    RawSugar = AssetClassDetailedSubProductTypeCode.RawSugar, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type white sugar.
    /// Encoded/decoded by serializers as &quot;WHSG&quot;.
    /// </summary>
    [EnumMember(Value = "WHSG")]
    [IsoId("_S_xfYQ2fEeW72qLtWESimw")]
    [Description(@"Commodity attribute of type white sugar.")]
    WhiteSugar = AssetClassDetailedSubProductTypeCode.WhiteSugar, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of other type.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_iQv5oQ2gEeW72qLtWESimw")]
    [Description(@"Commodity attribute of other type.")]
    Other = AssetClassDetailedSubProductTypeCode.Other, // same ordinal as derivation source for type conversions
}
