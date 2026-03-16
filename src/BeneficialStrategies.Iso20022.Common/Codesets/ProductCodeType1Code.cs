// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of product codification used to identify a product uniquely.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_rzY6gErMEeenp6hmNprBHg")]
[Description(@"Type of product codification used to identify a product uniquely.")]
[DerivedFrom(typeof(ProductCodeTypeCode))]
public enum ProductCodeType1Code
{
    /// <summary>
    /// European Article Number of type-13 also known as International Article Number
    /// Encoded/decoded by serializers as &quot;EA13&quot;.
    /// </summary>
    [EnumMember(Value = "EA13")]
    [IsoId("_tdo10UrMEeenp6hmNprBHg")]
    [Description(@"European Article Number of type-13 also known as International Article Number")]
    EuropeanArticleNumber13 = ProductCodeTypeCode.EuropeanArticleNumber13, // same ordinal as derivation source for type conversions

    /// <summary>
    /// European Article Number of type-8 also known as International Article Number
    /// Encoded/decoded by serializers as &quot;EAN8&quot;.
    /// </summary>
    [EnumMember(Value = "EAN8")]
    [IsoId("_tpm1QkrMEeenp6hmNprBHg")]
    [Description(@"European Article Number of type-8 also known as International Article Number")]
    EuropeanArticleNumber8 = ProductCodeTypeCode.EuropeanArticleNumber8, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Global Trade Item Number (GTIN) is an identifier for trade items.
    /// Encoded/decoded by serializers as &quot;GTIN&quot;.
    /// </summary>
    [EnumMember(Value = "GTIN")]
    [IsoId("_t1sJckrMEeenp6hmNprBHg")]
    [Description(@"Global Trade Item Number (GTIN) is an identifier for trade items.")]
    GlobalTradeItemNumber = ProductCodeTypeCode.GlobalTradeItemNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other type of product code classification.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_uJB8MkrMEeenp6hmNprBHg")]
    [Description(@"Other type of product code classification.")]
    Other = ProductCodeTypeCode.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price look-up codes, commonly called PLU codes, PLU numbers, PLUs, produce codes, or produce labels, are identification numbers affixed to produce in grocery stores and supermarkets
    /// Encoded/decoded by serializers as &quot;PLUP&quot;.
    /// </summary>
    [EnumMember(Value = "PLUP")]
    [IsoId("_uauJIkrMEeenp6hmNprBHg")]
    [Description(
        @"Price look-up codes, commonly called PLU codes, PLU numbers, PLUs, produce codes, or produce labels, are identification numbers affixed to produce in grocery stores and supermarkets"
    )]
    PriceLookUpCodes = ProductCodeTypeCode.PriceLookUpCodes, // same ordinal as derivation source for type conversions

    /// <summary>
    /// RSS 14 barcode (Reduce Space Symbology) encodes the full  EAN item identification in a symbol that can be omnidirectionally scanned by suitably configured point-of-sale laser scanners.
    /// Encoded/decoded by serializers as &quot;RS14&quot;.
    /// </summary>
    [EnumMember(Value = "RS14")]
    [IsoId("_uqTdQkrMEeenp6hmNprBHg")]
    [Description(
        @"RSS 14 barcode (Reduce Space Symbology) encodes the full  EAN item identification in a symbol that can be omnidirectionally scanned by suitably configured point-of-sale laser scanners."
    )]
    ReduceSpaceSymbology14 = ProductCodeTypeCode.ReduceSpaceSymbology14, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Uniform Product Code - A-type
    /// Encoded/decoded by serializers as &quot;UPCA&quot;.
    /// </summary>
    [EnumMember(Value = "UPCA")]
    [IsoId("_u1CGkkrMEeenp6hmNprBHg")]
    [Description(@"Uniform Product Code - A-type")]
    UniformProductCodeA = ProductCodeTypeCode.UniformProductCodeA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Uniform Product Code E-Type
    /// Encoded/decoded by serializers as &quot;UPCE&quot;.
    /// </summary>
    [EnumMember(Value = "UPCE")]
    [IsoId("_vCpEwkrMEeenp6hmNprBHg")]
    [Description(@"Uniform Product Code E-Type")]
    UniformProductCodeE = ProductCodeTypeCode.UniformProductCodeE, // same ordinal as derivation source for type conversions
}
