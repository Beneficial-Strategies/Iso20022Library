// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of product codification to identify a product uniquely.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_E_GcYErKEeenp6hmNprBHg")]
[Description(@"Type of product codification to identify a product uniquely.")]
[Derivations(typeof(ProductCodeType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ProductCodeTypeCode>))]
#endif
public enum ProductCodeTypeCode
{
    /// <summary>
    /// Uniform Product Code - A-type
    /// Encoded/decoded by serializers as &quot;UPCA&quot;.
    /// </summary>
    [EnumMember(Value = "UPCA")]
    [IsoId("_LTcIQErKEeenp6hmNprBHg")]
    [Description(@"Uniform Product Code - A-type")]
    UniformProductCodeA,

    /// <summary>
    /// Uniform Product Code E-Type
    /// Encoded/decoded by serializers as &quot;UPCE&quot;.
    /// </summary>
    [EnumMember(Value = "UPCE")]
    [IsoId("_0UlKYErKEeenp6hmNprBHg")]
    [Description(@"Uniform Product Code E-Type")]
    UniformProductCodeE,

    /// <summary>
    /// European Article Number of type-8 also known as International Article Number
    /// Encoded/decoded by serializers as &quot;EAN8&quot;.
    /// </summary>
    [EnumMember(Value = "EAN8")]
    [IsoId("_7c3bsErKEeenp6hmNprBHg")]
    [Description(@"European Article Number of type-8 also known as International Article Number")]
    EuropeanArticleNumber8,

    /// <summary>
    /// European Article Number of type-13 also known as International Article Number
    /// Encoded/decoded by serializers as &quot;EA13&quot;.
    /// </summary>
    [EnumMember(Value = "EA13")]
    [IsoId("_T8_ikErLEeenp6hmNprBHg")]
    [Description(@"European Article Number of type-13 also known as International Article Number")]
    EuropeanArticleNumber13,

    /// <summary>
    /// Price look-up codes, commonly called PLU codes, PLU numbers, PLUs, produce codes, or produce labels, are identification numbers affixed to produce in grocery stores and supermarkets
    /// Encoded/decoded by serializers as &quot;PLUP&quot;.
    /// </summary>
    [EnumMember(Value = "PLUP")]
    [IsoId("_0FX0QErLEeenp6hmNprBHg")]
    [Description(
        @"Price look-up codes, commonly called PLU codes, PLU numbers, PLUs, produce codes, or produce labels, are identification numbers affixed to produce in grocery stores and supermarkets"
    )]
    PriceLookUpCodes,

    /// <summary>
    /// Global Trade Item Number (GTIN) is an identifier for trade items.
    /// Encoded/decoded by serializers as &quot;GTIN&quot;.
    /// </summary>
    [EnumMember(Value = "GTIN")]
    [IsoId("_JBfB0ErMEeenp6hmNprBHg")]
    [Description(@"Global Trade Item Number (GTIN) is an identifier for trade items.")]
    GlobalTradeItemNumber,

    /// <summary>
    /// RSS 14 barcode (Reduce Space Symbology) encodes the full  EAN item identification in a symbol that can be omnidirectionally scanned by suitably configured point-of-sale laser scanners.
    /// Encoded/decoded by serializers as &quot;RS14&quot;.
    /// </summary>
    [EnumMember(Value = "RS14")]
    [IsoId("_aljVgErMEeenp6hmNprBHg")]
    [Description(
        @"RSS 14 barcode (Reduce Space Symbology) encodes the full  EAN item identification in a symbol that can be omnidirectionally scanned by suitably configured point-of-sale laser scanners."
    )]
    ReduceSpaceSymbology14,

    /// <summary>
    /// Other type of product code classification.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_mQAKcErMEeenp6hmNprBHg")]
    [Description(@"Other type of product code classification.")]
    Other,
}
