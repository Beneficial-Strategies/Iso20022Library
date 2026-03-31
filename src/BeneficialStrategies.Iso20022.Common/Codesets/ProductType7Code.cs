// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the underlying type of product or financial instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_xzn8ADXwEemdWfjs3tykFQ")]
[Description(@"Specifies the underlying type of product or financial instrument.")]
[DerivedFrom(typeof(ProductTypeV2Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ProductType7Code>))]
#endif
public enum ProductType7Code
{
    /// <summary>
    /// Asset type is sovereign.
    /// Encoded/decoded by serializers as &quot;SVGN&quot;.
    /// </summary>
    [EnumMember(Value = "SVGN")]
    [IsoId("_1dWbwTXwEemdWfjs3tykFQ")]
    [Description(@"Asset type is sovereign.")]
    Sovereign = ProductTypeV2Code.Sovereign, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies the nature or type of an equity.
    /// Encoded/decoded by serializers as &quot;EQUI&quot;.
    /// </summary>
    [EnumMember(Value = "EQUI")]
    [IsoId("_25u6MTXwEemdWfjs3tykFQ")]
    [Description(@"Identifies the nature or type of an equity.")]
    Equity = ProductTypeV2Code.Equity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other asset type.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_3aUewTXwEemdWfjs3tykFQ")]
    [Description(@"Other asset type.")]
    Other = ProductTypeV2Code.Other, // same ordinal as derivation source for type conversions
}
