// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the underlying type of product or financial instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_2qJtcebCEeW1iL_FRZt8bg")]
[Description(@"Specifies the underlying type of product or financial instrument.")]
[DerivedFrom(typeof(ProductTypeV2Code))]
public enum ProductType4Code
{
    /// <summary>
    /// Identifies categories of instruments that are credits.
    /// Encoded/decoded by serializers as &quot;CRDT&quot;.
    /// </summary>
    [EnumMember(Value = "CRDT")]
    [IsoId("_3BXTkebCEeW1iL_FRZt8bg")]
    [Description(@"Identifies categories of instruments that are credits.")]
    Credit = ProductTypeV2Code.Credit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies categories of currency instruments.
    /// Encoded/decoded by serializers as &quot;CURR&quot;.
    /// </summary>
    [EnumMember(Value = "CURR")]
    [IsoId("_3BXTk-bCEeW1iL_FRZt8bg")]
    [Description(@"Identifies categories of currency instruments.")]
    Currency = ProductTypeV2Code.Currency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies the nature or type of an equity.
    /// Encoded/decoded by serializers as &quot;EQUI&quot;.
    /// </summary>
    [EnumMember(Value = "EQUI")]
    [IsoId("_3BXTlebCEeW1iL_FRZt8bg")]
    [Description(@"Identifies the nature or type of an equity.")]
    Equity = ProductTypeV2Code.Equity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies categories of instruments that are interest rates based.
    /// Encoded/decoded by serializers as &quot;INTR&quot;.
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("_3BXTl-bCEeW1iL_FRZt8bg")]
    [Description(@"Identifies categories of instruments that are interest rates based.")]
    InterestRate = ProductTypeV2Code.InterestRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifies categories of instruments that are commodities.
    /// Encoded/decoded by serializers as &quot;COMM&quot;.
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_3BXTmebCEeW1iL_FRZt8bg")]
    [Description(@"Identifies categories of instruments that are commodities.")]
    Commodity = ProductTypeV2Code.Commodity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other asset type.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_5Q8wkebCEeW1iL_FRZt8bg")]
    [Description(@"Other asset type.")]
    Other = ProductTypeV2Code.Other, // same ordinal as derivation source for type conversions
}
