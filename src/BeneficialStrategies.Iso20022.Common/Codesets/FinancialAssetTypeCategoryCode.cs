// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Categorization of financial asset type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_m9ZG0PNBEeCuA5Tr22BnwA_-207567627")]
[Description(@"Categorization of financial asset type.")]
[Derivations(typeof(FinancialAssetTypeCategory1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<FinancialAssetTypeCategoryCode>))]
#endif
public enum FinancialAssetTypeCategoryCode
{
    /// <summary>
    /// Balance attributed to equities.
    /// Encoded/decoded by serializers as &quot;EQTY&quot;.
    /// </summary>
    [EnumMember(Value = "EQTY")]
    [IsoId("_m9ZG0fNBEeCuA5Tr22BnwA_1512048060")]
    [Description(@"Balance attributed to equities.")]
    Equities,

    /// <summary>
    /// Balance attributed to debt instruments.
    /// Encoded/decoded by serializers as &quot;DEBT&quot;.
    /// </summary>
    [EnumMember(Value = "DEBT")]
    [IsoId("_m9ZG0vNBEeCuA5Tr22BnwA_-1310716183")]
    [Description(@"Balance attributed to debt instruments.")]
    DebtInstruments,

    /// <summary>
    /// Balance attributed to entitlements.
    /// Encoded/decoded by serializers as &quot;ENTL&quot;.
    /// </summary>
    [EnumMember(Value = "ENTL")]
    [IsoId("_m9ZG0_NBEeCuA5Tr22BnwA_-492039069")]
    [Description(@"Balance attributed to entitlements.")]
    Entitlements,

    /// <summary>
    /// Balance attributed to derivatives.
    /// Encoded/decoded by serializers as &quot;DERV&quot;.
    /// </summary>
    [EnumMember(Value = "DERV")]
    [IsoId("_m9ZG1PNBEeCuA5Tr22BnwA_2127191488")]
    [Description(@"Balance attributed to derivatives.")]
    Derivatives,

    /// <summary>
    /// Balance attributed to money market instruments.
    /// Encoded/decoded by serializers as &quot;MMKT&quot;.
    /// </summary>
    [EnumMember(Value = "MMKT")]
    [IsoId("_m9ZG1fNBEeCuA5Tr22BnwA_-1923244113")]
    [Description(@"Balance attributed to money market instruments.")]
    MoneyMarket,

    /// <summary>
    /// Other financial asset type balance according to a different classification, which is not explictly defined.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_m9i30PNBEeCuA5Tr22BnwA_-878884426")]
    [Description(
        @"Other financial asset type balance according to a different classification, which is not explictly defined."
    )]
    Others,
}
