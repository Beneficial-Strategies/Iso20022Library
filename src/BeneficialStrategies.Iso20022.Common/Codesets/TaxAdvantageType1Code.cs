// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code for the form of tax advantage on the dividend.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8HZzAFf3EeOuDtoQo1qilA")]
[Description(@"Code for the form of tax advantage on the dividend.")]
[DerivedFrom(typeof(TaxAdvantageTypeCode))]
public enum TaxAdvantageType1Code
{
    /// <summary>
    /// Tax advantage type is: Concessional Goods and Services Tax.
    /// Encoded/decoded by serializers as &quot;CGST&quot;.
    /// </summary>
    [EnumMember(Value = "CGST")]
    [IsoId("_PeElYVf7EeOuDtoQo1qilA")]
    [Description(@"Tax advantage type is: Concessional Goods and Services Tax.")]
    ConcessionalGST = TaxAdvantageTypeCode.ConcessionalGST, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax advantage type is not applicable.
    /// Encoded/decoded by serializers as &quot;NOAP&quot;.
    /// </summary>
    [EnumMember(Value = "NOAP")]
    [IsoId("_PlNvMVf7EeOuDtoQo1qilA")]
    [Description(@"Tax advantage type is not applicable.")]
    NotApplicable = TaxAdvantageTypeCode.NotApplicable, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax advantage type is not available.
    /// Encoded/decoded by serializers as &quot;NOAV&quot;.
    /// </summary>
    [EnumMember(Value = "NOAV")]
    [IsoId("_PqROUVf7EeOuDtoQo1qilA")]
    [Description(@"Tax advantage type is not available.")]
    NotAvailable = TaxAdvantageTypeCode.NotAvailable, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other type of tax advantage type.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_PyJ_AVf7EeOuDtoQo1qilA")]
    [Description(@"Other type of tax advantage type.")]
    Other = TaxAdvantageTypeCode.Other, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax advantage type is: pooled development fund Rebta.
    /// Encoded/decoded by serializers as &quot;PDFR&quot;.
    /// </summary>
    [EnumMember(Value = "PDFR")]
    [IsoId("_P3qKEVf7EeOuDtoQo1qilA")]
    [Description(@"Tax advantage type is: pooled development fund Rebta.")]
    PooledDevelopmentFundRebta = TaxAdvantageTypeCode.PooledDevelopmentFundRebta, // same ordinal as derivation source for type conversions
    
}
