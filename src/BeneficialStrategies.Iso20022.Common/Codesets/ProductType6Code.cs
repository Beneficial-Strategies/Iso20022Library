// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the underlying type of product or financial instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_3dMpEDXvEemdWfjs3tykFQ")]
[Description(@"Specifies the underlying type of product or financial instrument.")]
[DerivedFrom(typeof(ProductTypeV2Code))]
public enum ProductType6Code
{
    /// <summary>
    /// The asset type is bond.
    /// Encoded/decoded by serializers as &quot;BOND&quot;.
    /// </summary>
    [EnumMember(Value = "BOND")]
    [IsoId("_5QytoTXvEemdWfjs3tykFQ")]
    [Description(@"The asset type is bond.")]
    Bond = ProductTypeV2Code.Bond, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The asset type is cash.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_5YreUTXvEemdWfjs3tykFQ")]
    [Description(@"The asset type is cash.")]
    Cash = ProductTypeV2Code.Cash, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other asset type.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_6Mv_kTXvEemdWfjs3tykFQ")]
    [Description(@"Other asset type.")]
    Other = ProductTypeV2Code.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies the nature or type of an equity.
    /// Encoded/decoded by serializers as &quot;EQUI&quot;.
    /// </summary>
    [EnumMember(Value = "EQUI")]
    [IsoId("_8fJgATXvEemdWfjs3tykFQ")]
    [Description(@"Identifies the nature or type of an equity.")]
    Equity = ProductTypeV2Code.Equity, // same ordinal as derivation source for type conversions
}
