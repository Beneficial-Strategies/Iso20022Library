// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the category of a product.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aLN02Np-Ed-ak6NoX_4Aeg_1399265867")]
[Description(@"Specifies the category of a product.")]
[DerivedFrom(typeof(ProductCategoryCode))]
public enum ProductCategory1Code
{
    /// <summary>
    /// Classification of goods as developed by the Customs Cooperation council.
    /// Encoded/decoded by serializers as &quot;HRTR&quot;.
    /// </summary>
    [EnumMember(Value = "HRTR")]
    [IsoId("_aLXl0Np-Ed-ak6NoX_4Aeg_1456527208")]
    [Description(@"Classification of goods as developed by the Customs Cooperation council.")]
    HarmonizedTariffCodeName = ProductCategoryCode.HarmonizedTariffCodeName, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Product identifier used by the retail industry.
    /// Encoded/decoded by serializers as &quot;QOTA&quot;.
    /// </summary>
    [EnumMember(Value = "QOTA")]
    [IsoId("_aLXl0dp-Ed-ak6NoX_4Aeg_1456527268")]
    [Description(@"Product identifier used by the retail industry.")]
    QuotaCategory = ProductCategoryCode.QuotaCategory, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Product Group Code.
    /// Encoded/decoded by serializers as &quot;PRGP&quot;.
    /// </summary>
    [EnumMember(Value = "PRGP")]
    [IsoId("_aLXl0tp-Ed-ak6NoX_4Aeg_1456527285")]
    [Description(@"Product Group Code.")]
    ProductGroup = ProductCategoryCode.ProductGroup, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Line of business code.
    /// Encoded/decoded by serializers as &quot;LOBU&quot;.
    /// </summary>
    [EnumMember(Value = "LOBU")]
    [IsoId("_aLXl09p-Ed-ak6NoX_4Aeg_1456527286")]
    [Description(@"Line of business code.")]
    LineOfBusiness = ProductCategoryCode.LineOfBusiness, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Code for gender.
    /// Encoded/decoded by serializers as &quot;GNDR&quot;.
    /// </summary>
    [EnumMember(Value = "GNDR")]
    [IsoId("_aLXl1Np-Ed-ak6NoX_4Aeg_1456527520")]
    [Description(@"Code for gender.")]
    Gender = ProductCategoryCode.Gender, // same ordinal as derivation source for type conversions
    
}
