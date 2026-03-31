// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code for the form of tax advantage on the dividend.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8nnPAVf1EeOuDtoQo1qilA")]
[Description(@"Code for the form of tax advantage on the dividend.")]
[Derivations(typeof(TaxAdvantageType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TaxAdvantageTypeCode>))]
#endif
public enum TaxAdvantageTypeCode
{
    /// <summary>
    /// Tax advantage type is: Concessional Goods and Services Tax.
    /// Encoded/decoded by serializers as &quot;CGST&quot;.
    /// </summary>
    [EnumMember(Value = "CGST")]
    [IsoId("_Eovz4Ff2EeOuDtoQo1qilA")]
    [Description(@"Tax advantage type is: Concessional Goods and Services Tax.")]
    ConcessionalGST,

    /// <summary>
    /// Tax advantage type is not applicable.
    /// Encoded/decoded by serializers as &quot;NOAP&quot;.
    /// </summary>
    [EnumMember(Value = "NOAP")]
    [IsoId("_IRSn4Ff2EeOuDtoQo1qilA")]
    [Description(@"Tax advantage type is not applicable.")]
    NotApplicable,

    /// <summary>
    /// Tax advantage type is not available.
    /// Encoded/decoded by serializers as &quot;NOAV&quot;.
    /// </summary>
    [EnumMember(Value = "NOAV")]
    [IsoId("_LT6EUFf2EeOuDtoQo1qilA")]
    [Description(@"Tax advantage type is not available.")]
    NotAvailable,

    /// <summary>
    /// Other type of tax advantage type.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_0G6HUFf3EeOuDtoQo1qilA")]
    [Description(@"Other type of tax advantage type.")]
    Other,

    /// <summary>
    /// Tax advantage type is: pooled development fund Rebta.
    /// Encoded/decoded by serializers as &quot;PDFR&quot;.
    /// </summary>
    [EnumMember(Value = "PDFR")]
    [IsoId("_3b_z0Ff3EeOuDtoQo1qilA")]
    [Description(@"Tax advantage type is: pooled development fund Rebta.")]
    PooledDevelopmentFundRebta,
}
